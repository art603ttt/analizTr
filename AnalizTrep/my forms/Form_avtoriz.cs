﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizTrep
{
    public partial class Form_avtoriz :MetroFramework.Forms.MetroForm
    {
        public Form_avtoriz()
        {
            InitializeComponent();
        }
        Form1 f_help;
        public Form_avtoriz(Form1 f)
        {
            f_help = f;
            InitializeComponent();
        }
    }
}
