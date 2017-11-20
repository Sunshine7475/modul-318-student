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
        Transport _trans = new Transport();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            
            dgvVerbindungen.DataSource = _trans.GetConnections(cbStandort.Text, cbEndstation.Text).ConnectionList;
         

        }


        private void cbStandort_SelectedIndexChanged(object sender, EventArgs e)
        {
            _trans.GetStations(cbStandort.Text);
        }

        private void cbEndstation_SelectedIndexChanged(object sender, EventArgs e)
        {
            _trans.GetStations(cbEndstation.Text);
        }
    }
}
