﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    class Program
    {
        public static void Main()
        {
            Application.EnableVisualStyles();

            var x = new frmTest();
            
            Application.Run(x);
        }
    }
}
