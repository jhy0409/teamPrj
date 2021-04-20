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

        static string[] tel = { "010-3524-4767", "010-3733-2356", "010-3764-3362", "010-3763-2723", "010-3622-2263" };
        static string[] address = { "대구시 동구 신암4동 ", "서울시 동구 신암4동","광주시 동구 신암4동",
                "인천시 동구 신암4동", "부산시 동구 신암4동"};
        static string[] email = { "hong@naver.com", "lee@gmail.com", "park@daum.net", "choi@hanmail.net", "kim@gmail.com" };
        public DrugCompInfo_Form()
        {
            InitializeComponent();
            drugComp_dtGridView.DataSource = DataManager.Comps;
        }

        private void DrugCompInfo_Form_Load(object sender, EventArgs e)
        {
            string url = "http://apis.data.go.kr/1470000/DURPrdlstInfoService/getUsjntTabooInfoList"; // URL
            url += "?ServiceKey=" + "Kbg5ok99gLL7L7nQwR3uRoSjPEYTXU2TceiGRQ59%2F6CO%2BzLEl%2F2GcGh4L8BYBXfhtxbTbuUZmGTjb0%2BabDPX6w%3D%3D"; // Service Key
            XElement element = XElement.Load(url);
            foreach (var item in element.Descendants("item"))
            {
                string entpName = item.Element("ENTP_NAME").Value;
                string entpTel = tel[r.Next(0, 5)];

                string entpAddr = address[r.Next(0, 5)];
                string entpEmail = email[r.Next(email.Length)];

                entps.Add(new Entp(entpName, entpTel, entpAddr, entpEmail));
            }
            drugComp_dtGridView.DataSource = entps;
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



