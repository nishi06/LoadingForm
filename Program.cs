using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadingForm
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //LicenseForm.exeを直接起動した場合は終了する。
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MessageBox.Show("このファイルは直接起動して使用するファイルではありません。", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
