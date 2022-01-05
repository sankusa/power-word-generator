using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace PowerWordGenerator.DataAccess
{
    /// <summary>
    /// インスタンスをDataContractSerializerでシリアライズし、ファイル書き出し・読み込みするクラス
    /// インスタンス及びそのメンバはDataContact専用の属性を付与しないとシリアライズされないことに注意
    /// </summary>
    public class DataContractSaveUtil
    {
        private const string FILEPATH_SUFFIX_TMP = "_TMP";

        public static T Load<T>(string filePath)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(T));
            XmlReader xr = XmlReader.Create(filePath);

            T obj = (T)serializer.ReadObject(xr);
            xr.Close();

            return obj;
        }

        public static void Save(string filePath, object obj)
        {
            string filePathTmp = filePath + FILEPATH_SUFFIX_TMP;

            DataContractSerializer serializer = new DataContractSerializer(obj.GetType());
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = Encoding.GetEncoding("Shift_JIS");
            XmlWriter xw = XmlWriter.Create(filePathTmp, settings);

            serializer.WriteObject(xw, obj);
            xw.Close();

            // ファイル置き換え
            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);

                // 旧ファイルの削除に失敗した場合は一時ファイルを削除
                } catch(IOException e)
                {
                    File.Delete(filePathTmp);
                    throw;
                }
                
            }
            File.Move(filePathTmp, filePath);
        }
    }
}
