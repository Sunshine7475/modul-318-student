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
            //DataTAble erstellen
            DataTable dtConnections = new DataTable();
            dtConnections.Columns.Add("Abfahrtszeit");
            dtConnections.Columns.Add("AbfahrtsOrt");
            dtConnections.Columns.Add("Zielort");
            dtConnections.Columns.Add("Zielzeit");

            //Verbindungen auslesen
            Connections stb = _trans.GetConnections(cbStandort.Text, cbEndstation.Text);

            //Verbindungen in DataTAble speichern
            foreach (Connection station in stb.ConnectionList)
            {
                dtConnections.Rows.Add(ConvertDateToTime(station.From.Departure), station.From.Station.Name, station.To.Station.Name,
                   ConvertDateToTime(station.To.Arrival));
            }

            //DatatAble in DataGrdid hinzufühen
            dgvVerbindungen.DataSource = dtConnections;

            //dgvVerbindungen.DataSource = _trans.GetConnections(cbStandort.Text, cbEndstation.Text).ConnectionList;
            // dgvVerbindungen.DataSource = _trans.GetStationBoard(cbOrt.Text, "");

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
            Transport t = new Transport();

            string searchCrit = _cbo.Text + ",";

            Stations stations = t.GetStations(searchCrit);

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

        }
    }
}