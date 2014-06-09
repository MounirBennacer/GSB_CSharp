using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GSB.App
{
    public partial class Dashboard : Form
    {
        private string _name;
        public Dashboard( string name)
        {
            InitializeComponent();
            _name = name;
            conName.Text = _name;
        }

        private void conName_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
