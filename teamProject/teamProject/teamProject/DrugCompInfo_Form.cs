using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
           
                entps.Add(new Entp(entpName, entpTel, entpAddr,entpEmail));
            }
            drugComp_dtGridView.DataSource = entps;
        }

        private void drugComp_dtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

