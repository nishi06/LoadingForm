using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadingForm
{
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
        }

        internal static Boolean _isNormal = false; //LoadingForm.exeを直接起動したかどうか

        /// <summary>
        /// LicenseForm.exeを直接起動したかどうかを設定します。
        /// </summary>
        public Boolean isNormal
        {
            set { _isNormal = value; }
            get { return _isNormal; }
        }
    }
}
