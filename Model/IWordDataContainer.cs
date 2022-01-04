using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerWordGenerator.Model
{
    public interface IWordDataContainer
    {
        string CategoryName { get; }
        IReadOnlyList<string> MaterialWords { get; }
        IReadOnlyList<string> FavoriteWords { get; }
        string GetRandomMaterialWord();
        void AddMaterialWord(string word);
        void RemoveMaterialWord(string word);
        bool MaterialWordExists(string word);
        void AddFavoriteWord(string word);
        void RemoveFavoriteWord(string word);
        bool FavoriteWordExists(string word);
    }
}
