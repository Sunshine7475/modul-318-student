namespace SwissTransportGUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtStandort = new System.Windows.Forms.TextBox();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.lStandort = new System.Windows.Forms.Label();
            this.lEndstation = new System.Windows.Forms.Label();
            this.txtEndstation = new System.Windows.Forms.TextBox();
            this.dgvVerbindungen = new System.Windows.Forms.DataGridView();
            this.gbEingabe = new System.Windows.Forms.GroupBox();
            this.txtZeitpunkt = new System.Windows.Forms.TextBox();
            this.dtpZeitpunkt = new System.Windows.Forms.DateTimePicker();
            this.lZeitpunkt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerbindungen)).BeginInit();
            this.gbEingabe.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStandort
            // 
            this.txtStandort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStandort.Location = new System.Drawing.Point(150, 44);
            this.txtStandort.Name = "txtStandort";
            this.txtStandort.Size = new System.Drawing.Size(307, 26);
            this.txtStandort.TabIndex = 0;
            this.txtStandort.TextChanged += new System.EventHandler(this.txtStandort_TextChanged);
            // 
            // btnSuchen
            // 
            this.btnSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuchen.Location = new System.Drawing.Point(445, 496);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(98, 42);
            this.btnSuchen.TabIndex = 4;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // lStandort
            // 
            this.lStandort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lStandort.AutoSize = true;
            this.lStandort.Location = new System.Drawing.Point(32, 50);
            this.lStandort.Name = "lStandort";
            this.lStandort.Size = new System.Drawing.Size(71, 20);
            this.lStandort.TabIndex = 2;
            this.lStandort.Text = "Standort";
            // 
            // lEndstation
            // 
            this.lEndstation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lEndstation.AutoSize = true;
            this.lEndstation.Location = new System.Drawing.Point(32, 99);
            this.lEndstation.Name = "lEndstation";
            this.lEndstation.Size = new System.Drawing.Size(86, 20);
            this.lEndstation.TabIndex = 4;
            this.lEndstation.Text = "Endstation";
            // 
            // txtEndstation
            // 
            this.txtEndstation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndstation.Location = new System.Drawing.Point(150, 93);
            this.txtEndstation.Name = "txtEndstation";
            this.txtEndstation.Size = new System.Drawing.Size(307, 26);
            this.txtEndstation.TabIndex = 1;
            this.txtEndstation.TextChanged += new System.EventHandler(this.txtEndstation_TextChanged);
            // 
            // dgvVerbindungen
            // 
            this.dgvVerbindungen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVerbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerbindungen.Location = new System.Drawing.Point(84, 289);
            this.dgvVerbindungen.Name = "dgvVerbindungen";
            this.dgvVerbindungen.RowTemplate.Height = 28;
            this.dgvVerbindungen.Size = new System.Drawing.Size(320, 150);
            this.dgvVerbindungen.TabIndex = 10;
            this.dgvVerbindungen.TabStop = false;
            // 
            // gbEingabe
            // 
            this.gbEingabe.Controls.Add(this.txtZeitpunkt);
            this.gbEingabe.Controls.Add(this.dtpZeitpunkt);
            this.gbEingabe.Controls.Add(this.lZeitpunkt);
            this.gbEingabe.Controls.Add(this.txtStandort);
            this.gbEingabe.Controls.Add(this.lStandort);
            this.gbEingabe.Controls.Add(this.txtEndstation);
            this.gbEingabe.Controls.Add(this.lEndstation);
            this.gbEingabe.Location = new System.Drawing.Point(29, 23);
            this.gbEingabe.Name = "gbEingabe";
            this.gbEingabe.Size = new System.Drawing.Size(500, 210);
            this.gbEingabe.TabIndex = 11;
            this.gbEingabe.TabStop = false;
            this.gbEingabe.Text = "Verbindung suchen";
            // 
            // txtZeitpunkt
            // 
            this.txtZeitpunkt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZeitpunkt.Location = new System.Drawing.Point(362, 142);
            this.txtZeitpunkt.Name = "txtZeitpunkt";
            this.txtZeitpunkt.Size = new System.Drawing.Size(95, 26);
            this.txtZeitpunkt.TabIndex = 9;
            // 
            // dtpZeitpunkt
            // 
            this.dtpZeitpunkt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpZeitpunkt.Location = new System.Drawing.Point(150, 142);
            this.dtpZeitpunkt.Name = "dtpZeitpunkt";
            this.dtpZeitpunkt.Size = new System.Drawing.Size(202, 26);
            this.dtpZeitpunkt.TabIndex = 8;
            // 
            // lZeitpunkt
            // 
            this.lZeitpunkt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lZeitpunkt.AutoSize = true;
            this.lZeitpunkt.Location = new System.Drawing.Point(32, 142);
            this.lZeitpunkt.Name = "lZeitpunkt";
            this.lZeitpunkt.Size = new System.Drawing.Size(76, 20);
            this.lZeitpunkt.TabIndex = 10;
            this.lZeitpunkt.Text = "Zeitpunkt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 567);
            this.Controls.Add(this.gbEingabe);
            this.Controls.Add(this.dgvVerbindungen);
            this.Controls.Add(this.btnSuchen);
            this.Name = "MainForm";
            this.Text = "SwissTransport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerbindungen)).EndInit();
            this.gbEingabe.ResumeLayout(false);
            this.gbEingabe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtStandort;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.Label lStandort;
        private System.Windows.Forms.Label lEndstation;
        private System.Windows.Forms.TextBox txtEndstation;
        private System.Windows.Forms.DataGridView dgvVerbindungen;
        private System.Windows.Forms.GroupBox gbEingabe;
        private System.Windows.Forms.TextBox txtZeitpunkt;
        private System.Windows.Forms.DateTimePicker dtpZeitpunkt;
        private System.Windows.Forms.Label lZeitpunkt;
    }
}

