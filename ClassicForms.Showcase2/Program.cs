﻿using ClassicForms.Showcase2.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicForms.Showcase2
{
    public class Program
    {
        public static void Main()
        {
            Settings.UseNameForInputPlaceholders = true;

            var x = new frmMainPage();
            x.Show();
        }
    }
}
