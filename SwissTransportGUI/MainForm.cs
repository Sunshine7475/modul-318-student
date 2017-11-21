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
using System.Globalization;

namespace SwissTransportGUI
{
    public partial class MainForm : Form
    {
        Transport _trans = new Transport();
        DataTable _dtConnections = new DataTable();

        public MainForm()
        {
           InitializeComponent();           
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            _dtConnections = new DataTable();

            if (tcVerbindungen.SelectedIndex == 0)
            {
                _dtConnections.Columns.Add("Abfahrtszeit");
                _dtConnections.Columns.Add("Abfahrtsort");
                _dtConnections.Columns.Add("Zielort");
                _dtConnections.Columns.Add("Ankunftszeit");
                _dtConnections.Columns.Add("Dauer");

                Connections _stb = _trans.GetConnections(cbStandort.Text, cbEndstation.Text);
           
                foreach (Connection _station in _stb.ConnectionList)
                {
                    _dtConnections.Rows.Add(Convert.ToDateTime(_station.From.Departure), _station.From.Station.Name, _station.To.Station.Name,
                       Convert.ToDateTime(_station.To.Arrival), replaceString(_station.Duration));
                }
           
                dgvVerbindungen.DataSource = _dtConnections;
             
            }

            else
            {
                _dtConnections.Columns.Add("Abfahrtszeit");
                _dtConnections.Columns.Add("Abfahrtsort");
                _dtConnections.Columns.Add("Zielort");

                Stations _station = _trans.GetStations(cbOrt.Text);
                string _id = _station.StationList[0].Id;
                StationBoardRoot _stb = _trans.GetStationBoard(cbOrt.Text, _id);

                foreach (StationBoard _stbo in _stb.Entries)
                {
                    _dtConnections.Rows.Add(_stbo.Stop.Departure,cbOrt.Text, _stbo.To);
                }
                
                dgvVerbindungen.DataSource = _dtConnections;
            }

           
        }


        private string replaceString(string anfang)
        {
            string _resultat = anfang.Replace("00d", "");
            return _resultat;
        }

        private void cbStandort_DropDown(object sender, EventArgs e)
        {
            SearchAndFillComboBox(cbStandort);
        }

        private void cbEndstation_DropDown(Object sender, EventArgs e)
        {
            SearchAndFillComboBox(cbEndstation);
        }


        private void SearchAndFillComboBox(ComboBox _cbo)
        {
            _cbo.Items.Clear();

            string searchCrit = _cbo.Text + ",";

            Stations stations = _trans.GetStations(searchCrit);

            for (int i = 0; i < stations.StationList.Count; i++)
            {
                Station station = stations.StationList[i];
                string stationName = station.Name;
                _cbo.Items.Add(stationName);
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cbStandort;
            btnSuchen.Enabled = false;

        }

        private void tcVerbindungen_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dtConnections.Columns.Clear();
            dgvVerbindungen.DataSource = null;
            if (tcVerbindungen.SelectedIndex == 0)
            {
                this.ActiveControl = cbStandort;
            }
            else
            {
                this.ActiveControl = cbOrt;
            }
        }

        private void cbEndstation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbStandort != null && cbEndstation != null)
            {
                btnSuchen.Enabled = true;

            }
        }

        private void cbOrt_DropDown(object sender, EventArgs e)
        {
            SearchAndFillComboBox(cbEndstation);
        }

        private void cbOrt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbOrt != null)
            {
                btnSuchen.Enabled = true;

            }
        }
    }
}