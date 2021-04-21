using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teamProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void btn_mainDrugComp_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                MessageBox.Show($"{(i + 1)} i값이 3번 뜬다");
            }
            /* 8:54 AM 별 의미없는 주석.. 코드가 다 들어오는지 보자 */
        }

        private void btn_mainDrugs_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                MessageBox.Show("눈치게임 " + (i+1) + "!");
            }
        }
    }
}
