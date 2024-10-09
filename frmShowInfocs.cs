using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace برنامج_اختبار_في_القرآن_الكريم
{
    public partial class frmShowInfocs : Form
    {
        public frmShowInfocs(string Info)
        {
            InitializeComponent();
            _Info = Info;
        }
        string _Info = "";
        private void frmShowInfocs_Load(object sender, EventArgs e)
        {
            lblInfo.Text = _Info;
        }
    }
}
