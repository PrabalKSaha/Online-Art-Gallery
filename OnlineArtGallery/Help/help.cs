﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace art2
{
    public partial class help : UserControl
    {
        public help()
        {
            InitializeComponent();
        }

        private void help_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Software Engineering Project\n \n \n \n Cuet Art gallery\n \n Nur-A-Alam Shiddiki \n\n Sakiul Kawser \n \n Prabal Krishna Saha  \n \n data source: E:\\Works\\visc#\\art2\\LIB.accdb";
        }
    }
}
