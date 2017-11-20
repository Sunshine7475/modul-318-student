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
            this.btnSuchen = new System.Windows.Forms.Button();
            this.lStandort = new System.Windows.Forms.Label();
            this.lEndstation = new System.Windows.Forms.Label();
            this.dgvVerbindungen = new System.Windows.Forms.DataGridView();
            this.gbEingabe = new System.Windows.Forms.GroupBox();
            this.cbEndstation = new System.Windows.Forms.ComboBox();
            this.cbStandort = new System.Windows.Forms.ComboBox();
            this.txtZeitpunkt = new System.Windows.Forms.TextBox();
            this.dtpZeitpunkt = new System.Windows.Forms.DateTimePicker();
            this.lZeitpunkt = new System.Windows.Forms.Label();
            this.tcVerbindungen = new System.Windows.Forms.TabControl();
            this.tbVerbindungSuchen = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lVerbindungen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerbindungen)).BeginInit();
            this.gbEingabe.SuspendLayout();
            this.tcVerbindungen.SuspendLayout();
            this.tbVerbindungSuchen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSuchen
            // 
            this.btnSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuchen.Location = new System.Drawing.Point(716, 598);
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
            this.lStandort.Location = new System.Drawing.Point(32, 58);
            this.lStandort.Name = "lStandort";
            this.lStandort.Size = new System.Drawing.Size(71, 20);
            this.lStandort.TabIndex = 2;
            this.lStandort.Text = "Standort";
            // 
            // lEndstation
            // 
            this.lEndstation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lEndstation.AutoSize = true;
            this.lEndstation.Location = new System.Drawing.Point(32, 107);
            this.lEndstation.Name = "lEndstation";
            this.lEndstation.Size = new System.Drawing.Size(86, 20);
            this.lEndstation.TabIndex = 4;
            this.lEndstation.Text = "Endstation";
            // 
            // dgvVerbindungen
            // 
            this.dgvVerbindungen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVerbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerbindungen.Location = new System.Drawing.Point(24, 409);
            this.dgvVerbindungen.Name = "dgvVerbindungen";
            this.dgvVerbindungen.RowTemplate.Height = 28;
            this.dgvVerbindungen.Size = new System.Drawing.Size(764, 150);
            this.dgvVerbindungen.TabIndex = 10;
            this.dgvVerbindungen.TabStop = false;
            // 
            // gbEingabe
            // 
            this.gbEingabe.Controls.Add(this.cbEndstation);
            this.gbEingabe.Controls.Add(this.cbStandort);
            this.gbEingabe.Controls.Add(this.txtZeitpunkt);
            this.gbEingabe.Controls.Add(this.dtpZeitpunkt);
            this.gbEingabe.Controls.Add(this.lZeitpunkt);
            this.gbEingabe.Controls.Add(this.lStandort);
            this.gbEingabe.Controls.Add(this.lEndstation);
            this.gbEingabe.Location = new System.Drawing.Point(18, 16);
            this.gbEingabe.Name = "gbEingabe";
            this.gbEingabe.Size = new System.Drawing.Size(550, 225);
            this.gbEingabe.TabIndex = 11;
            this.gbEingabe.TabStop = false;
            this.gbEingabe.Text = "Verbindung suchen";
            // 
            // cbEndstation
            // 
            this.cbEndstation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbEndstation.FormattingEnabled = true;
            this.cbEndstation.Location = new System.Drawing.Point(150, 99);
            this.cbEndstation.Name = "cbEndstation";
            this.cbEndstation.Size = new System.Drawing.Size(307, 28);
            this.cbEndstation.TabIndex = 2;
            this.cbEndstation.SelectedIndexChanged += new System.EventHandler(this.cbEndstation_SelectedIndexChanged);
            // 
            // cbStandort
            // 
            this.cbStandort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbStandort.FormattingEnabled = true;
            this.cbStandort.Location = new System.Drawing.Point(150, 50);
            this.cbStandort.Name = "cbStandort";
            this.cbStandort.Size = new System.Drawing.Size(307, 28);
            this.cbStandort.TabIndex = 0;
            this.cbStandort.SelectedIndexChanged += new System.EventHandler(this.cbStandort_SelectedIndexChanged);
            // 
            // txtZeitpunkt
            // 
            this.txtZeitpunkt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZeitpunkt.Location = new System.Drawing.Point(425, 150);
            this.txtZeitpunkt.Name = "txtZeitpunkt";
            this.txtZeitpunkt.Size = new System.Drawing.Size(100, 26);
            this.txtZeitpunkt.TabIndex = 9;
            // 
            // dtpZeitpunkt
            // 
            this.dtpZeitpunkt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpZeitpunkt.Location = new System.Drawing.Point(150, 150);
            this.dtpZeitpunkt.Name = "dtpZeitpunkt";
            this.dtpZeitpunkt.Size = new System.Drawing.Size(269, 26);
            this.dtpZeitpunkt.TabIndex = 8;
            // 
            // lZeitpunkt
            // 
            this.lZeitpunkt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lZeitpunkt.AutoSize = true;
            this.lZeitpunkt.Location = new System.Drawing.Point(32, 150);
            this.lZeitpunkt.Name = "lZeitpunkt";
            this.lZeitpunkt.Size = new System.Drawing.Size(76, 20);
            this.lZeitpunkt.TabIndex = 10;
            this.lZeitpunkt.Text = "Zeitpunkt";
            // 
            // tcVerbindungen
            // 
            this.tcVerbindungen.Controls.Add(this.tbVerbindungSuchen);
            this.tcVerbindungen.Controls.Add(this.tabPage2);
            this.tcVerbindungen.Location = new System.Drawing.Point(24, 26);
            this.tcVerbindungen.Name = "tcVerbindungen";
            this.tcVerbindungen.SelectedIndex = 0;
            this.tcVerbindungen.Size = new System.Drawing.Size(618, 291);
            this.tcVerbindungen.TabIndex = 12;
            // 
            // tbVerbindungSuchen
            // 
            this.tbVerbindungSuchen.Controls.Add(this.gbEingabe);
            this.tbVerbindungSuchen.Location = new System.Drawing.Point(4, 29);
            this.tbVerbindungSuchen.Name = "tbVerbindungSuchen";
            this.tbVerbindungSuchen.Padding = new System.Windows.Forms.Padding(3);
            this.tbVerbindungSuchen.Size = new System.Drawing.Size(610, 258);
            this.tbVerbindungSuchen.TabIndex = 0;
            this.tbVerbindungSuchen.Text = "Verbindung suchen";
            this.tbVerbindungSuchen.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(610, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abfahrtstafel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lVerbindungen
            // 
            this.lVerbindungen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lVerbindungen.AutoSize = true;
            this.lVerbindungen.Enabled = false;
            this.lVerbindungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVerbindungen.Location = new System.Drawing.Point(23, 367);
            this.lVerbindungen.Name = "lVerbindungen";
            this.lVerbindungen.Size = new System.Drawing.Size(141, 25);
            this.lVerbindungen.TabIndex = 13;
            this.lVerbindungen.Text = "Verbindungen:";
            this.lVerbindungen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 669);
            this.Controls.Add(this.lVerbindungen);
            this.Controls.Add(this.tcVerbindungen);
            this.Controls.Add(this.dgvVerbindungen);
            this.Controls.Add(this.btnSuchen);
            this.Name = "MainForm";
            this.Text = "SwissTransport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerbindungen)).EndInit();
            this.gbEingabe.ResumeLayout(false);
            this.gbEingabe.PerformLayout();
            this.tcVerbindungen.ResumeLayout(false);
            this.tbVerbindungSuchen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.Label lStandort;
        private System.Windows.Forms.Label lEndstation;
        private System.Windows.Forms.DataGridView dgvVerbindungen;
        private System.Windows.Forms.GroupBox gbEingabe;
        private System.Windows.Forms.TextBox txtZeitpunkt;
        private System.Windows.Forms.DateTimePicker dtpZeitpunkt;
        private System.Windows.Forms.Label lZeitpunkt;
        private System.Windows.Forms.ComboBox cbStandort;
        private System.Windows.Forms.ComboBox cbEndstation;
        private System.Windows.Forms.TabControl tcVerbindungen;
        private System.Windows.Forms.TabPage tbVerbindungSuchen;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lVerbindungen;
    }
}

