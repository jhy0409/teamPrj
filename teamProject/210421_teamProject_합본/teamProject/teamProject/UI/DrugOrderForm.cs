using System;
using System.Collections.Generic;
using System.Windows.Forms;
using teamProject.model;

namespace teamProject
{
    partial class DrugOrderForm : Form
    {
        public static List<DrugOrder> orders = new List<DrugOrder>();
        int n;
        public DrugOrderForm()
        {
            InitializeComponent();


        }

        private void DrugOrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in orders)
                {
                    drugOrder_dtGridView.Rows.Add(item.Drug.MedName, item.Entp.entpName, item.Count);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("추가 불가");
            }

        }

        private void btn_DrugOrder_Click(object sender, EventArgs e)
        {
            foreach (var item in orders)
            {
                new UI.EmailForm(item).ShowDialog();
            }
        }

        private void drugOrder_dtGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = drugOrder_dtGridView.CurrentCell.RowIndex;
            DrugOrder drugorder = orders[n];
            productName_txtBox.Text = drugorder.Drug.MedName;
            ProductCnt_txtBox.Text = drugorder.Count.ToString();
        }

        private void btn_DrugCntEdit_Click(object sender, EventArgs e)
        {
            drugOrder_dtGridView.Rows.Clear();
            /*Entp temp = drugComp_dtGridView.CurrentRow.DataBoundItem as Entp;
            compName_txtBox.Text = temp.entpName;
            compTel_txtBox.Text = temp.entpTel;
            compAddr_txtBox.Text = temp.entpAddr;
            compEmail_txtBox.Text = temp.entpEmail;*/

            DrugOrder temp = orders[n];
            temp.Drug.MedName = productName_txtBox.Text;
            temp.Count = int.Parse(ProductCnt_txtBox.Text);

            try
            {
                foreach (var item in orders)
                {
                    drugOrder_dtGridView.Rows.Add(item.Drug.MedName, item.Entp.entpName, item.Count);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("추가 불가");
            }
        }
    }
}

