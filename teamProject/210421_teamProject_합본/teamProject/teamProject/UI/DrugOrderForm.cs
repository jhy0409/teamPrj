﻿using System;
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
                    drugOrder_dtGridView.Rows.Add(item.drug.MedName, item.entp.entpName, item.count);
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

            foreach (var item in orders)
            {
                foreach (var item2 in DataManager.drugs)
                {
                    if(item.drug == item2)
                    {
                        item2.Stock += item.count;
                    }
                }
            }
            DataManager.Save();
            MessageBox.Show("주문 완료!!", "주문 완료");
            Close();
        }

        private void drugOrder_dtGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = drugOrder_dtGridView.CurrentCell.RowIndex;
            DrugOrder drugorder = orders[n];
            productName_txtBox.Text = drugorder.drug.MedName;
            ProductCnt_txtBox.Text = drugorder.count.ToString();
        }

        private void btn_DrugCntEdit_Click(object sender, EventArgs e)
        {
            drugOrder_dtGridView.Rows.Clear();
            DrugOrder temp = orders[n];
            temp.drug.MedName = productName_txtBox.Text;
            temp.count = int.Parse(ProductCnt_txtBox.Text);

            try
            {
                foreach (var item in orders)
                {
                    drugOrder_dtGridView.Rows.Add(item.drug.MedName, item.entp.entpName, item.count);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("추가 불가");
            }
        }
    }
}

