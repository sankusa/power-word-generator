using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace PowerWordGenerator.Model
{
    [DataContract]
    public class WordDataContainer : IWordDataContainer
    {
        [DataMember(Order = 0)] private string _categoryName = "";
        public string CategoryName => _categoryName;

        [DataMember(Order = 1)] private List<string> _materialWords = new List<string>();

        public IReadOnlyList<string> MaterialWords => _materialWords;

        [DataMember(Order = 2)] private List<string> _favoriteWords = new List<string>();

        public IReadOnlyList<string> FavoriteWords => _favoriteWords;

        private Random _random = new Random();

        public WordDataContainer(string categoryName)
        {
            _categoryName = categoryName;
        }

        [OnDeserializing]
        private void OnDeserializing(StreamingContext sc)
        {
            _random = new Random();
        }

        public string GetRandomMaterialWord()
        {
            return _materialWords[_random.Next(0, _materialWords.Count)];
        }

        public void AddMaterialWord(string word)
        {
            _materialWords.Add(word);
        }

        public void RemoveMaterialWord(string word)
        {
            _materialWords.Remove(word);
        }

        public bool MaterialWordExists(string word)
        {
            return _materialWords.Exists(x => x == word);
        }

        public void AddFavoriteWord(string word)
        {
            _favoriteWords.Add(word);
        }

        public void RemoveFavoriteWord(string word)
        {
            _favoriteWords.Remove(word);
        }

        public bool FavoriteWordExists(string word)
        {
            return _favoriteWords.Exists(x => x == word);
        }
    }
}
