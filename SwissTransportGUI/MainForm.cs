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
            cbStandort.Items.Add("Luzern");
            cbEndstation.Items.Add("Luzern");
            cbOrt.Items.Add("Luzern");
            
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        private void MoveCursor()
        {
            // Set the Current cursor, move the cursor's Position,
            // and set its clipping rectangle to the form. 

            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }
    }
}
