using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.IO;
using PowerWordGenerator.Model;

namespace PowerWordGenerator.DataAccess
{
    /// <summary>
    /// IWordDataContainerList用ファイル読み込み・書き出しクラス
    /// インスタンス及びそのメンバはDataContact専用の属性を付与しないとシリアライズされないことに注意
    /// </summary>
    class DataContractWordDataContainerListRepository : IWordDataContainerListRepository
    {
        private string _fileName;
        public DataContractWordDataContainerListRepository(string fileName)
        {
            _fileName = fileName;
        }

        public T Load<T>() where T : IWordDataContainerList
        {
            return DataContractSaveUtil.Load<T>(_fileName);
        }

        public void Save(IWordDataContainerList wordDataContainers)
        {
            DataContractSaveUtil.Save(_fileName, wordDataContainers);
        }

        public bool DataExists()
        {
            return File.Exists(_fileName);
        }
    }
}
