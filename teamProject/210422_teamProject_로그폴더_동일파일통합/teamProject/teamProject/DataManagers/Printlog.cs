﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teamProject.DataManagers
{
    class Printlog
    {
        public static Printlog prl;

        public static void printLog(string contents, string date)
        {
            DirectoryInfo di = new DirectoryInfo("History");
            if (!di.Exists)
            {
                di.Create();
            }

            using (StreamWriter writer = new StreamWriter(@"History\" + date + ".txt", true))
            {
                writer.WriteLine($"[ {date} ]\t{contents}");
            }
        }

        public static Printlog getInst()
        {
            if (prl == null)
            {
                prl = new Printlog();
            }
            return prl;
        }

    }
}
