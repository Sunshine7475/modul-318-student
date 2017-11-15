using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SwissTransportGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            Transport _trans = new Transport();
            dgvVerbindungen.DataSource = _trans.GetConnections(txtStandort.Text, txtEndstation.Text).ConnectionList;


        }

    }
}
