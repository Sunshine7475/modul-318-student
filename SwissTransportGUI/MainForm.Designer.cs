﻿namespace SwissTransportGUI
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
            this.txtZeitpunkt = new System.Windows.Forms.TextBox();
            this.cbStandort = new System.Windows.Forms.ComboBox();
            this.dtpZeitpunkt = new System.Windows.Forms.DateTimePicker();
            this.lZeitpunkt = new System.Windows.Forms.Label();
            this.tcVerbindungen = new System.Windows.Forms.TabControl();
            this.tpVerbindungSuchen = new System.Windows.Forms.TabPage();
            this.tpAbfahtstafel = new System.Windows.Forms.TabPage();
            this.gbAbfahrtstafel = new System.Windows.Forms.GroupBox();
            this.txtZeitpunktAb = new System.Windows.Forms.TextBox();
            this.dtpZeitpunktAb = new System.Windows.Forms.DateTimePicker();
            this.lZeitpunktAb = new System.Windows.Forms.Label();
            this.cbOrt = new System.Windows.Forms.ComboBox();
            this.lOrt = new System.Windows.Forms.Label();
            this.lVerbindungen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerbindungen)).BeginInit();
            this.gbEingabe.SuspendLayout();
            this.tcVerbindungen.SuspendLayout();
            this.tpVerbindungSuchen.SuspendLayout();
            this.tpAbfahtstafel.SuspendLayout();
            this.gbAbfahrtstafel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSuchen
            // 
            this.btnSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuchen.Location = new System.Drawing.Point(1071, 776);
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
            this.dgvVerbindungen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVerbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerbindungen.Location = new System.Drawing.Point(24, 448);
            this.dgvVerbindungen.Name = "dgvVerbindungen";
            this.dgvVerbindungen.RowTemplate.Height = 28;
            this.dgvVerbindungen.Size = new System.Drawing.Size(1145, 256);
            this.dgvVerbindungen.TabIndex = 10;
            this.dgvVerbindungen.TabStop = false;
            // 
            // gbEingabe
            // 
            this.gbEingabe.Controls.Add(this.cbEndstation);
            this.gbEingabe.Controls.Add(this.txtZeitpunkt);
            this.gbEingabe.Controls.Add(this.cbStandort);
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
            this.cbEndstation.DropDown += new System.EventHandler(this.cbEndstation_DropDown);
            this.cbEndstation.TextChanged += new System.EventHandler(this.cbEndstation_TextChanged);
            this.cbEndstation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbEndstation_KeyPress);
            // 
            // txtZeitpunkt
            // 
            this.txtZeitpunkt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZeitpunkt.Location = new System.Drawing.Point(428, 150);
            this.txtZeitpunkt.Name = "txtZeitpunkt";
            this.txtZeitpunkt.Size = new System.Drawing.Size(100, 26);
            this.txtZeitpunkt.TabIndex = 9;
            this.txtZeitpunkt.Text = "12:00";
            // 
            // cbStandort
            // 
            this.cbStandort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbStandort.FormattingEnabled = true;
            this.cbStandort.Location = new System.Drawing.Point(150, 55);
            this.cbStandort.Name = "cbStandort";
            this.cbStandort.Size = new System.Drawing.Size(307, 28);
            this.cbStandort.TabIndex = 0;
            this.cbStandort.DropDown += new System.EventHandler(this.cbStandort_DropDown);
            this.cbStandort.TextChanged += new System.EventHandler(this.cbStandort_TextChanged);
            // 
            // dtpZeitpunkt
            // 
            this.dtpZeitpunkt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpZeitpunkt.Location = new System.Drawing.Point(150, 150);
            this.dtpZeitpunkt.Name = "dtpZeitpunkt";
            this.dtpZeitpunkt.Size = new System.Drawing.Size(272, 26);
            this.dtpZeitpunkt.TabIndex = 8;
            this.dtpZeitpunkt.Value = new System.DateTime(2017, 11, 20, 11, 30, 24, 0);
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
            this.tcVerbindungen.Controls.Add(this.tpVerbindungSuchen);
            this.tcVerbindungen.Controls.Add(this.tpAbfahtstafel);
            this.tcVerbindungen.Location = new System.Drawing.Point(24, 26);
            this.tcVerbindungen.Name = "tcVerbindungen";
            this.tcVerbindungen.SelectedIndex = 0;
            this.tcVerbindungen.Size = new System.Drawing.Size(618, 291);
            this.tcVerbindungen.TabIndex = 12;
            this.tcVerbindungen.SelectedIndexChanged += new System.EventHandler(this.tcVerbindungen_SelectedIndexChanged);
            // 
            // tpVerbindungSuchen
            // 
            this.tpVerbindungSuchen.Controls.Add(this.gbEingabe);
            this.tpVerbindungSuchen.Location = new System.Drawing.Point(4, 29);
            this.tpVerbindungSuchen.Name = "tpVerbindungSuchen";
            this.tpVerbindungSuchen.Padding = new System.Windows.Forms.Padding(3);
            this.tpVerbindungSuchen.Size = new System.Drawing.Size(610, 258);
            this.tpVerbindungSuchen.TabIndex = 0;
            this.tpVerbindungSuchen.Text = "Verbindung suchen";
            this.tpVerbindungSuchen.UseVisualStyleBackColor = true;
            // 
            // tpAbfahtstafel
            // 
            this.tpAbfahtstafel.Controls.Add(this.gbAbfahrtstafel);
            this.tpAbfahtstafel.Location = new System.Drawing.Point(4, 29);
            this.tpAbfahtstafel.Name = "tpAbfahtstafel";
            this.tpAbfahtstafel.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbfahtstafel.Size = new System.Drawing.Size(610, 258);
            this.tpAbfahtstafel.TabIndex = 1;
            this.tpAbfahtstafel.Text = "Abfahrtstafel";
            this.tpAbfahtstafel.UseVisualStyleBackColor = true;
            // 
            // gbAbfahrtstafel
            // 
            this.gbAbfahrtstafel.Controls.Add(this.txtZeitpunktAb);
            this.gbAbfahrtstafel.Controls.Add(this.dtpZeitpunktAb);
            this.gbAbfahrtstafel.Controls.Add(this.lZeitpunktAb);
            this.gbAbfahrtstafel.Controls.Add(this.cbOrt);
            this.gbAbfahrtstafel.Controls.Add(this.lOrt);
            this.gbAbfahrtstafel.Location = new System.Drawing.Point(56, 30);
            this.gbAbfahrtstafel.Name = "gbAbfahrtstafel";
            this.gbAbfahrtstafel.Size = new System.Drawing.Size(528, 190);
            this.gbAbfahrtstafel.TabIndex = 1;
            this.gbAbfahrtstafel.TabStop = false;
            this.gbAbfahrtstafel.Text = "Abfahrtstafel";
            // 
            // txtZeitpunktAb
            // 
            this.txtZeitpunktAb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZeitpunktAb.Location = new System.Drawing.Point(412, 99);
            this.txtZeitpunktAb.Name = "txtZeitpunktAb";
            this.txtZeitpunktAb.Size = new System.Drawing.Size(72, 26);
            this.txtZeitpunktAb.TabIndex = 12;
            this.txtZeitpunktAb.Text = "12:00";
            // 
            // dtpZeitpunktAb
            // 
            this.dtpZeitpunktAb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpZeitpunktAb.Location = new System.Drawing.Point(134, 99);
            this.dtpZeitpunktAb.Name = "dtpZeitpunktAb";
            this.dtpZeitpunktAb.Size = new System.Drawing.Size(272, 26);
            this.dtpZeitpunktAb.TabIndex = 11;
            // 
            // lZeitpunktAb
            // 
            this.lZeitpunktAb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lZeitpunktAb.AutoSize = true;
            this.lZeitpunktAb.Location = new System.Drawing.Point(16, 99);
            this.lZeitpunktAb.Name = "lZeitpunktAb";
            this.lZeitpunktAb.Size = new System.Drawing.Size(76, 20);
            this.lZeitpunktAb.TabIndex = 13;
            this.lZeitpunktAb.Text = "Zeitpunkt";
            // 
            // cbOrt
            // 
            this.cbOrt.FormattingEnabled = true;
            this.cbOrt.Location = new System.Drawing.Point(134, 55);
            this.cbOrt.Name = "cbOrt";
            this.cbOrt.Size = new System.Drawing.Size(239, 28);
            this.cbOrt.TabIndex = 1;
            this.cbOrt.DropDown += new System.EventHandler(this.cbOrt_DropDown);
            this.cbOrt.TextChanged += new System.EventHandler(this.cbOrt_TextChanged);
            this.cbOrt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbOrt_KeyPress);
            // 
            // lOrt
            // 
            this.lOrt.Location = new System.Drawing.Point(50, 60);
            this.lOrt.Name = "lOrt";
            this.lOrt.Size = new System.Drawing.Size(100, 23);
            this.lOrt.TabIndex = 0;
            this.lOrt.Text = "Ort";
            // 
            // lVerbindungen
            // 
            this.lVerbindungen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lVerbindungen.AutoSize = true;
            this.lVerbindungen.Enabled = false;
            this.lVerbindungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVerbindungen.Location = new System.Drawing.Point(23, 406);
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
            this.ClientSize = new System.Drawing.Size(1201, 847);
            this.Controls.Add(this.lVerbindungen);
            this.Controls.Add(this.tcVerbindungen);
            this.Controls.Add(this.dgvVerbindungen);
            this.Controls.Add(this.btnSuchen);
            this.Name = "MainForm";
            this.Text = "SwissTransport";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerbindungen)).EndInit();
            this.gbEingabe.ResumeLayout(false);
            this.gbEingabe.PerformLayout();
            this.tcVerbindungen.ResumeLayout(false);
            this.tpVerbindungSuchen.ResumeLayout(false);
            this.tpAbfahtstafel.ResumeLayout(false);
            this.gbAbfahrtstafel.ResumeLayout(false);
            this.gbAbfahrtstafel.PerformLayout();
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
        private System.Windows.Forms.TabPage tpVerbindungSuchen;
        private System.Windows.Forms.TabPage tpAbfahtstafel;
        private System.Windows.Forms.Label lVerbindungen;
        private System.Windows.Forms.GroupBox gbAbfahrtstafel;
        private System.Windows.Forms.TextBox txtZeitpunktAb;
        private System.Windows.Forms.DateTimePicker dtpZeitpunktAb;
        private System.Windows.Forms.Label lZeitpunktAb;
        private System.Windows.Forms.ComboBox cbOrt;
        private System.Windows.Forms.Label lOrt;
    }
}

