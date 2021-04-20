using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace teamProject
{
    public partial class DrugCompInfo_Form : Form
    {
        Random r = new Random();
        List<Entp> entps = new List<Entp>();

        
        public DrugCompInfo_Form()
        {
            InitializeComponent();
            drugComp_dtGridView.DataSource = DataManager.Comps;
        }



        private void btn_DrugComp_Search_Click(object sender, EventArgs e)
        {
            List<Entp> tempComps = new List<Entp>();
            drugComp_dtGridView.DataSource = null;
            if (searchName.Text.Trim() == "")
            {
                MessageBox.Show("제약회사 이름을 입력해 주세요!");
                //함수 종료
                return;
            }
            try
            {
                for (int i = 0; i < DataManager.Comps.Count; i++)
                {
                    if (DataManager.Comps[i].entpName == searchName.Text)
                    {
                        tempComps.Add(DataManager.Comps[i]);
                        //drugComp_dtGridView.DataSource = DataManager.Comps[0].entpName;
                        //drugComp_dtGridView.DataSource = DataManager.Comps[0].entpTel;
                        //drugComp_dtGridView.DataSource = DataManager.Comps[0].entpAddr;
                        //drugComp_dtGridView.DataSource = DataManager.Comps[0].entpEmail;


                    }
                }
                drugComp_dtGridView.DataSource = tempComps;
               
            }

            catch (Exception ex)
            {
                MessageBox.Show("조회 안됨");
                MessageBox.Show(ex.Message);


            }

        }

        private void drugComp_dtGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                Entp temp = drugComp_dtGridView.CurrentRow.DataBoundItem as Entp;

                searchName.Text = temp.entpName.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                //writeLog(ex.Message);
                //writeLog(ex.StackTrace);

            }
        }

        private void drugComp_dtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



