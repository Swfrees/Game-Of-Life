﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOLStartUpTemplate1
{
    public partial class Randomizer : Form
    {
        public Randomizer()
        {
            InitializeComponent();
        }

        public int randomizerNumber
        {
            get
            {
                return (int)numericUpDownRandom.Value;
            }

            set
            {
                numericUpDownRandom.Value = value;
            }
        }

    }
}
