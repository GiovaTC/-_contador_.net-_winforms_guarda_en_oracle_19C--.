// Form1.cs
using System;
using System.Windows.Forms;

namespace ContadorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnStart.Click += BtnStart_Click;
            btnStop.Click += BtnStop_Click;
            btnReset.Click += BtnReset_Click;
            btnSaveOnce.Click += BtnSaveOnce_Click;
            chkAutoSave.CheckedChanged += ChkAutoSave_CheckedChanged;
            lblStatus.Text = "Listo";
            UpdateLabel();
        }

        private void BtnStart_Click(object sender, EventArgs e) { }
        private void BtnStop_Click(object sender, EventArgs e) { }
        private void BtnReset_Click(object sender, EventArgs e) { }
        private void BtnSaveOnce_Click(object sender, EventArgs e) { }
        private void ChkAutoSave_CheckedChanged(object sender, EventArgs e) { }
        private void UpdateLabel() { }
    }
}

