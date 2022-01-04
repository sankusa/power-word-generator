using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerWordGenerator.Model
{
    public interface IWordDataContainerList
    {
        IReadOnlyList<IWordDataContainer> WordDataContainers { get; }
        IWordDataContainer FindByCategoryName(string categoryName);
        bool CategoryExists(string categoryName);
        void AddCategory(string categoryName);
        void RemoveCategory(string categoryName);
    }
}
