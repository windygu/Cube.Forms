﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cube.Forms.Demo
{
    public partial class MainForm : Cube.Forms.WidgetForm
    {
        public MainForm()
        {
            InitializeComponent();
            CloseButton.Click += (s, e) => Close();
        }
    }
}
