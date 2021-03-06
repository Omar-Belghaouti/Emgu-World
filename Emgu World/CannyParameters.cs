﻿using System;
using MetroFramework.Forms;

namespace Emgu_World
{
    public partial class CannyParameters : MetroForm
    {
        Menu _menu;
        public CannyParameters()
        {
            InitializeComponent();
        }

        public CannyParameters(Menu menu)
        {
            InitializeComponent();
            _menu = menu;
        }

        private void CannyParameters_Load(object sender, EventArgs e)
        {
            metroTrackBar1.Value = (int) _menu.GetThresh();
            metroTrackBar2.Value = (int) _menu.GetThreshLink();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            _menu.SetThreshParameters(metroTrackBar1.Value, metroTrackBar2.Value);
            _menu.ApplyCanny(_menu.GetThresh(), _menu.GetThreshLink());
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
