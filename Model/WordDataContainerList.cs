using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace PowerWordGenerator.Model
{
    /// <summary>
    /// 単語情報コンテナリストクラス
    /// </summary>
    [DataContract]
    [KnownType(typeof(WordDataContainer))]
    public class WordDataContainerList : IWordDataContainerList
    {
        [DataMember(Order = 0)] private List<IWordDataContainer> _wordDataContainers = new List<IWordDataContainer>();
        public IReadOnlyList<IWordDataContainer> WordDataContainers => _wordDataContainers;

        public IWordDataContainer FindByCategoryName(string categoryName)
        {
            return _wordDataContainers.Find(x => x.CategoryName == categoryName);
        }

        public bool CategoryExists(string categoryName)
        {
            return _wordDataContainers.Exists(x => x.CategoryName == categoryName);
        }

        public void AddCategory(string categoryName)
        {
            _wordDataContainers.Add(new WordDataContainer(categoryName));
        }

        public void RemoveCategory(string categoryName)
        {
            _wordDataContainers.Remove(_wordDataContainers.Find(x => x.CategoryName == categoryName));
        }
    }
}
