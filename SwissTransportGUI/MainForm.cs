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

        /// <summary>
        /// Beim Clicken auf Suchen werden eintweder die Verbindungen zwischen zwei Orten gesucht
        /// oder eine Abfahrtstafel für einen Ort erstellt und in einer DataGridView ausgebeben.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuchen_Click(object sender, EventArgs e)
        {
            try
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
                           Convert.ToDateTime(_station.To.Arrival), ReplaceString(_station.Duration));
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
                        _dtConnections.Rows.Add(_stbo.Stop.Departure, cbOrt.Text, _stbo.To);
                    }

                    dgvVerbindungen.DataSource = _dtConnections;
                }
            }
            catch
            {
                MessageBox.Show("Es konnten keine Verbindungen gefunden werden.");
            }           
        }

        /// <summary>
        /// Erstetzt bei einem mitgegeben String "00d" durch nichts (schneidet es weg) und gibt den veränderten String zurück.
        /// </summary>
        /// <param name="anfang"></param>
        /// <returns></returns>
        private string ReplaceString(string _anfang)
        {
            string _resultat = _anfang.Replace("00d", "");
            return _resultat;
        }

        /// <summary>
        /// Findet Vorschlage zu den Stationsnamen.
        /// </summary>
        /// <param name="_cbo"></param>
        private void SearchAndFillComboBox(ComboBox _cbo)
        {
            try
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
            catch
            {
                MessageBox.Show("Es konnten keine Vorschläge zu Stationen gefunden werden.");
            }

        }

        /// <summary>
        /// Beim Laden des Fensters wird der Courser in des Feld von Standort gesetzt und den Suchen Button deaktiviert.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cbStandort;
            btnSuchen.Enabled = false;

        }

        /// <summary>
        /// Wenn der Tab gewechselt wird wird die DataGridView gelehrt und der Coursor entweder ins Feld Standort oder Ort gesetzt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Vorschläge von Haltestellen für Standort beim drücken von Dropdown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbStandort_DropDown(object sender, EventArgs e)
        {
            SearchAndFillComboBox(cbStandort);
        }

        /// <summary>
        /// Wenn der Text in Standort geändet wird wird auch die DatagridView geleert.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbStandort_TextChanged(object sender, EventArgs e)
        {
            _dtConnections.Columns.Clear();
            dgvVerbindungen.DataSource = null;
        }

        /// <summary>
        /// Vorschläge von Haltestellen für Entstation beim drücken von Dropdown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbEndstation_DropDown(Object sender, EventArgs e)
        {
            SearchAndFillComboBox(cbEndstation);
        }

        /// <summary>
        /// Wenn der Text in Endstation geändet wird wird auch die DatagridView geleert.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbEndstation_TextChanged(object sender, EventArgs e)
        {
            _dtConnections.Columns.Clear();
            dgvVerbindungen.DataSource = null;
        }

        /// <summary>
        /// Wenn in Ort auf der Tastatur etwas gedrückt wird wird überprüft ob Inhalt nicht leer ist falls der Fall Suchen Button aktiviert. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbEndstation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbStandort != null && cbEndstation != null)
            {
                btnSuchen.Enabled = true;

            }
        }

        /// <summary>
        /// Vorschläge von Haltestellen für Ort beim drücken von Dropdown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbOrt_DropDown(object sender, EventArgs e)
        {
            SearchAndFillComboBox(cbEndstation);
        }

        /// <summary>
        /// Wenn der Text in Ort geändet wird wird auch die DatagridView geleert.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbOrt_TextChanged(object sender, EventArgs e)
        {
            _dtConnections.Columns.Clear();
            dgvVerbindungen.DataSource = null;
        }

        /// <summary>
        /// Wenn in Ort auf der Tastatur etwas gedrückt wird wird überprüft ob Inhalt nicht leer ist falls der Fall Suchen Button aktiviert. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbOrt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbOrt != null)
            {
                btnSuchen.Enabled = true;

            }
        }


       

    }
}