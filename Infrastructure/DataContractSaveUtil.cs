using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace PowerWordGenerator.Infrastructure
{
    public class DataContractSaveUtil
    {
        private const string FILENAME_SUFFIX_TMP = "_TMP";

        public static T Load<T>(string fileName)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(T));
            XmlReader xr = XmlReader.Create(fileName);

            T obj = (T)serializer.ReadObject(xr);
            xr.Close();

            return obj;
        }

        public static void Save<T>(string fileName, T obj)
        {
            string fileNameTmp = fileName + FILENAME_SUFFIX_TMP;

            DataContractSerializer serializer = new DataContractSerializer(typeof(T));
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = Encoding.GetEncoding("Shift_JIS");
            XmlWriter xw = XmlWriter.Create(fileNameTmp, settings);

            serializer.WriteObject(xw, obj);
            xw.Close();

            // ファイル置き換え
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            File.Move(fileNameTmp, fileName);
        }
    }
}
