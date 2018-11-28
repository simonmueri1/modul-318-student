namespace SwissTransportApp
{
    partial class Form1
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
            this.lblStartStation = new System.Windows.Forms.Label();
            this.lblEndStation = new System.Windows.Forms.Label();
            this.cmbStartStation = new System.Windows.Forms.ComboBox();
            this.cmbEndStation = new System.Windows.Forms.ComboBox();
            this.btnConnections = new System.Windows.Forms.Button();
            this.btnDeparture = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.rdbDeparture = new System.Windows.Forms.RadioButton();
            this.rdbArrival = new System.Windows.Forms.RadioButton();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.grbResult = new System.Windows.Forms.GroupBox();
            this.lsbResult = new System.Windows.Forms.ListBox();
            this.grbSearch.SuspendLayout();
            this.grbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStartStation
            // 
            this.lblStartStation.AutoSize = true;
            this.lblStartStation.Location = new System.Drawing.Point(16, 44);
            this.lblStartStation.Name = "lblStartStation";
            this.lblStartStation.Size = new System.Drawing.Size(80, 17);
            this.lblStartStation.TabIndex = 0;
            this.lblStartStation.Text = "Startstation";
            // 
            // lblEndStation
            // 
            this.lblEndStation.AutoSize = true;
            this.lblEndStation.Location = new System.Drawing.Point(295, 44);
            this.lblEndStation.Name = "lblEndStation";
            this.lblEndStation.Size = new System.Drawing.Size(75, 17);
            this.lblEndStation.TabIndex = 1;
            this.lblEndStation.Text = "Endstation";
            // 
            // cmbStartStation
            // 
            this.cmbStartStation.FormattingEnabled = true;
            this.cmbStartStation.Location = new System.Drawing.Point(19, 79);
            this.cmbStartStation.Name = "cmbStartStation";
            this.cmbStartStation.Size = new System.Drawing.Size(149, 24);
            this.cmbStartStation.TabIndex = 2;
            this.cmbStartStation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStartStation_KeyPress);
            // 
            // cmbEndStation
            // 
            this.cmbEndStation.FormattingEnabled = true;
            this.cmbEndStation.Location = new System.Drawing.Point(298, 79);
            this.cmbEndStation.Name = "cmbEndStation";
            this.cmbEndStation.Size = new System.Drawing.Size(139, 24);
            this.cmbEndStation.TabIndex = 3;
            // 
            // btnConnections
            // 
            this.btnConnections.Location = new System.Drawing.Point(570, 44);
            this.btnConnections.Name = "btnConnections";
            this.btnConnections.Size = new System.Drawing.Size(114, 40);
            this.btnConnections.TabIndex = 4;
            this.btnConnections.Text = "Verbindungen";
            this.btnConnections.UseVisualStyleBackColor = true;
            // 
            // btnDeparture
            // 
            this.btnDeparture.Location = new System.Drawing.Point(570, 118);
            this.btnDeparture.Name = "btnDeparture";
            this.btnDeparture.Size = new System.Drawing.Size(114, 42);
            this.btnDeparture.TabIndex = 5;
            this.btnDeparture.Text = "Abfahrtstabelle";
            this.btnDeparture.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(298, 172);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(121, 24);
            this.cmbTime.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(16, 143);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(295, 143);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 17);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Time:";
            // 
            // rdbDeparture
            // 
            this.rdbDeparture.AutoSize = true;
            this.rdbDeparture.Location = new System.Drawing.Point(467, 143);
            this.rdbDeparture.Name = "rdbDeparture";
            this.rdbDeparture.Size = new System.Drawing.Size(75, 21);
            this.rdbDeparture.TabIndex = 10;
            this.rdbDeparture.TabStop = true;
            this.rdbDeparture.Text = "Abfahrt";
            this.rdbDeparture.UseVisualStyleBackColor = true;
            // 
            // rdbArrival
            // 
            this.rdbArrival.AutoSize = true;
            this.rdbArrival.Location = new System.Drawing.Point(467, 177);
            this.rdbArrival.Name = "rdbArrival";
            this.rdbArrival.Size = new System.Drawing.Size(77, 21);
            this.rdbArrival.TabIndex = 11;
            this.rdbArrival.TabStop = true;
            this.rdbArrival.Text = "Ankunft";
            this.rdbArrival.UseVisualStyleBackColor = true;
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.dateTimePicker1);
            this.grbSearch.Controls.Add(this.btnConnections);
            this.grbSearch.Controls.Add(this.btnDeparture);
            this.grbSearch.Controls.Add(this.rdbDeparture);
            this.grbSearch.Controls.Add(this.rdbArrival);
            this.grbSearch.Controls.Add(this.lblDate);
            this.grbSearch.Controls.Add(this.cmbStartStation);
            this.grbSearch.Controls.Add(this.cmbTime);
            this.grbSearch.Controls.Add(this.lblTime);
            this.grbSearch.Controls.Add(this.lblStartStation);
            this.grbSearch.Controls.Add(this.cmbEndStation);
            this.grbSearch.Controls.Add(this.lblEndStation);
            this.grbSearch.Location = new System.Drawing.Point(39, 12);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(719, 220);
            this.grbSearch.TabIndex = 12;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Eingaben";
            // 
            // grbResult
            // 
            this.grbResult.Controls.Add(this.lsbResult);
            this.grbResult.Location = new System.Drawing.Point(39, 255);
            this.grbResult.Name = "grbResult";
            this.grbResult.Size = new System.Drawing.Size(719, 252);
            this.grbResult.TabIndex = 13;
            this.grbResult.TabStop = false;
            this.grbResult.Text = "Ergebnisse";
            // 
            // lsbResult
            // 
            this.lsbResult.FormattingEnabled = true;
            this.lsbResult.ItemHeight = 16;
            this.lsbResult.Location = new System.Drawing.Point(19, 38);
            this.lsbResult.Name = "lsbResult";
            this.lsbResult.Size = new System.Drawing.Size(665, 196);
            this.lsbResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.grbResult);
            this.Controls.Add(this.grbSearch);
            this.Name = "Form1";
            this.Text = "ÖV-App";
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.grbResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStartStation;
        private System.Windows.Forms.Label lblEndStation;
        private System.Windows.Forms.ComboBox cmbStartStation;
        private System.Windows.Forms.ComboBox cmbEndStation;
        private System.Windows.Forms.Button btnConnections;
        private System.Windows.Forms.Button btnDeparture;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.RadioButton rdbDeparture;
        private System.Windows.Forms.RadioButton rdbArrival;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.GroupBox grbResult;
        private System.Windows.Forms.ListBox lsbResult;
    }
}

