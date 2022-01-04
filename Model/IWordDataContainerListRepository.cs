using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerWordGenerator.Model
{
    public interface IWordDataContainerListRepository
    {
        void Save(IWordDataContainerList wordDataContainers);
        T Load<T>() where T : IWordDataContainerList;

        bool DataExists();
    }
}
