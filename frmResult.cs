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
    public partial class frmResult : Form
    {
        public frmResult(int True,int False)
        {
            InitializeComponent();
            _False = False;
            _True = True;
            _Total = _True + _False;
        }
        private int _True;
        private int _False;
        private int _Total;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmResult_Load(object sender, EventArgs e)
        {

            lblTrue.Text= _True.ToString();
            lblTotal.Text= _Total.ToString();
            if (_Total > 0)
            {
                lblAccuracy.Text = (((float)_True / (float)_Total) * 100).ToString();
                if (_True > _False)
                {
                    lblAccuracy.ForeColor = Color.LightGreen;
                }
                else
                { lblAccuracy.ForeColor = Color.Red; }
            }
            else
            {
                lblTrue.Text = "0";
                lblTotal.Text = "0";
                lblAccuracy.Text = "0";
            }
        }
    }
}
