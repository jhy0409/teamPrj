﻿using System;
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
    public partial class MainDrugs : Form
    {
        public MainDrugs()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string url = "http://apis.data.go.kr/1470000/DURPrdlstInfoService";
            XElement xElement = XElement.Load(url);
            var xmlQuery = from item in xElement.Descendants("data")
                           select item;

            foreach(var item in xmlQuery)
            {
                
            }

        }
    }
}
