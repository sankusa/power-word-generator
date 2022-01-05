using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PowerWordGenerator.Model;
using PowerWordGenerator.DataAccess;
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
            // インスタンス生成、依存性注入
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

            // フォームの表示
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(_mainViewModel));
        }
    }
}
