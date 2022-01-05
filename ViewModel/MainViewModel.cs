using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerWordGenerator.Model;

namespace PowerWordGenerator.ViewModel
{
    /// <summary>
    /// MainViewに表示用データとModelの操作メソッドを提供する
    /// </summary>
    public class MainViewModel
    {
        private IWordDataContainerList _wordDataContainers;
        private IWordDataContainerListRepository _wordDataContainerListRepository;

        private string _activeCategoryName;
        public string ActiveCategoryName
        {
            get => _activeCategoryName;
            set
            {
                if(_activeCategoryName != value)
                {
                    _activeCategoryName = value;
                    OnActiveCategoryNameChanged?.Invoke(_activeCategoryName);
                }
            }
        }

        private IWordDataContainer ActiveWordDataContainer => _wordDataContainers.FindByCategoryName(_activeCategoryName);

        public IReadOnlyList<string> MaterialWords => _wordDataContainers.FindByCategoryName(_activeCategoryName).MaterialWords;
        public IReadOnlyList<string> FavoriteWords => _wordDataContainers.FindByCategoryName(_activeCategoryName).FavoriteWords;

        public event Action<string> OnActiveCategoryNameChanged;
        public event Action OnCategorizedContentChanged;


        public MainViewModel(IWordDataContainerList wordDataContainers, IWordDataContainerListRepository wordDataContainerListRepository)
        {
            _wordDataContainers = wordDataContainers;
            _activeCategoryName = wordDataContainers.WordDataContainers[0].CategoryName;

            _wordDataContainerListRepository = wordDataContainerListRepository;
        }

        public IReadOnlyList<string> CategoryNames => _wordDataContainers.WordDataContainers.Select(x => x.CategoryName).ToList();
        public int CategoryCount => _wordDataContainers.WordDataContainers.Count;

        public bool CategoryExists(string categoryName)
        {
            return _wordDataContainers.CategoryExists(categoryName);
        }

        public IWordDataContainer FindDataContainer(string categoryName)
        {
            return _wordDataContainers.FindByCategoryName(categoryName);
        }

        public void AddCategory(string categoryName)
        {
            _wordDataContainers.AddCategory(categoryName);
            ActiveCategoryName = categoryName;
        }

        public void RemoveCategory(string categoryName)
        {
            _wordDataContainers.RemoveCategory(categoryName);
            ActiveCategoryName = _wordDataContainers.WordDataContainers[0].CategoryName;
        }

        public bool MaterialWordExists(string word)
        {
            return ActiveWordDataContainer.MaterialWordExists(word);
        }

        public void AddMaterialWord(string word)
        {
            ActiveWordDataContainer.AddMaterialWord(word);
            OnCategorizedContentChanged?.Invoke();
        }

        public void RemoveMaterialWord(string word)
        {
            ActiveWordDataContainer.RemoveMaterialWord(word);
            OnCategorizedContentChanged?.Invoke();
        }

        public bool FavoriteWordExists(string word)
        {
            return ActiveWordDataContainer.FavoriteWordExists(word);
        }

        public void AddFavoriteWord(string word)
        {
            ActiveWordDataContainer.AddFavoriteWord(word);
            OnCategorizedContentChanged?.Invoke();
        }

        public void RemoveFavoriteWord(string word)
        {
            ActiveWordDataContainer.RemoveFavoriteWord(word);
            OnCategorizedContentChanged?.Invoke();
        }

        public string GenerateWord(int materialCount)
        {
            string result = "";
            for (int i = 0; i < materialCount; i++)
            {
                result += ActiveWordDataContainer.GetRandomMaterialWord();
            }
            return result;
        }

        public void Save()
        {
            _wordDataContainerListRepository.Save(_wordDataContainers);
        }
    }
}
