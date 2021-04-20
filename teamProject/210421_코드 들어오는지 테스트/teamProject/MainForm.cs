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
                MessageBox.Show($"{(i+1)} i값이 3번 뜬다");
            }
        }

        private void btn_mainDrugs_Click(object sender, EventArgs e)
        {
        }
    }
}
