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
            SwissTransport.Transport _trans = new SwissTransport.Transport();
            dgvVerbindungen.DataSource = _trans.GetConnections(txtStandort.Text, txtEndstation.Text).ConnectionList;


        }

        private void txtStandort_TextChanged(object sender, EventArgs e)
        {
            SwissTransport.Transport _trans = new SwissTransport.Transport();
            _trans.GetStations(txtStandort.Text);

        }

        private void txtEndstation_TextChanged(object sender, EventArgs e)
        {
            SwissTransport.Transport _trans = new SwissTransport.Transport();
            _trans.GetStations(txtEndstation.Text);
        }

    }
}
