﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.UI
{
    public partial class ErrorForm : Form
    {
        public ErrorForm(string label)
        {
            InitializeComponent();
            label_error.Text = label;
        }

        
    }
}
