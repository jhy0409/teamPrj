using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teamProject.model;

namespace teamProject
{
    public partial class MainForm : Form
    {
        List<DrugOrder> lists = new List<DrugOrder>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_mainDrugComp_Click(object sender, EventArgs e)
        {
            new DrugCompInfo_Form().ShowDialog();
        }

        private void btn_mainDrugs_Click(object sender, EventArgs e)
        {
            new MainDrugs(lists).ShowDialog();
        }

        private void btn_main_order_Click(object sender, EventArgs e)
        {
            new DrugOrderForm(lists).ShowDialog();
        }
    }
}
