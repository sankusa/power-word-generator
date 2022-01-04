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

namespace PowerWordGenerator.Infrastructure
{
    class DataContractWordDataContainerListRepository : IWordDataContainerListRepository
    {
        private string _fileName;
        public DataContractWordDataContainerListRepository(string fileName)
        {
            _fileName = fileName;
        }

        public WordDataContainerList Load()
        {
            return DataContractSaveUtil.Load<WordDataContainerList>(_fileName);
        }

        public void Save(WordDataContainerList wordDataContainers)
        {
            DataContractSaveUtil.Save(_fileName, wordDataContainers);
        }

        public bool DataExists()
        {
            return File.Exists(_fileName);
        }
    }
}
