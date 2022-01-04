using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PowerWordGenerator.Model;
using PowerWordGenerator.Infrastructure;
using PowerWordGenerator.ViewModel;
using PowerWordGenerator.View;

namespace PowerWordGenerator
{
    static class Program
    {

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            IWordDataContainerList _wordDataContainers;
            DataContractWordDataContainerListRepository _wordDataContainerListRepository = new DataContractWordDataContainerListRepository(Const.FILE_NAME_SAVE);

            if (!_wordDataContainerListRepository.DataExists())
            {
                _wordDataContainers = new WordDataContainerList();
                _wordDataContainers.AddCategory(Const.CATEGORY_NAME_DEFAULT);
                _wordDataContainerListRepository.Save(_wordDataContainers);
            } else
            {
                _wordDataContainers = _wordDataContainerListRepository.Load<WordDataContainerList>();
            }

            MainViewModel _mainViewModel = new MainViewModel(_wordDataContainers, _wordDataContainerListRepository);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(_mainViewModel));

            _wordDataContainerListRepository.Save(_wordDataContainers);
        }
    }
}
