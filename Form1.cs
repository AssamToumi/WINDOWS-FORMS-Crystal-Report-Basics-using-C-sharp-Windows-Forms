﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crystal_Reports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CrystalReports.crptHelloWorld crpt = new CrystalReports.crptHelloWorld();
            crvViewer.ReportSource = null;
            crvViewer.ReportSource = crpt; 

        }
    }
}
