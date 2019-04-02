namespace FinishLine
{
    partial class MainView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newTournamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBxRaceParameters = new System.Windows.Forms.GroupBox();
            this.nmrNumWinners = new System.Windows.Forms.NumericUpDown();
            this.nmrNumLaps = new System.Windows.Forms.NumericUpDown();
            this.nmrLapDistance = new System.Windows.Forms.NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.btnStartRace = new System.Windows.Forms.Button();
            this.lblWinners = new System.Windows.Forms.Label();
            this.lblLaps = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.grpBxRaceControl = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnDisq = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnSplitTime = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpBxRaceParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumWinners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumLaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLapDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.grpBxRaceControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTournamentToolStripMenuItem,
            this.runnersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newTournamentToolStripMenuItem
            // 
            this.newTournamentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitAppToolStripMenuItem});
            this.newTournamentToolStripMenuItem.Name = "newTournamentToolStripMenuItem";
            this.newTournamentToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.newTournamentToolStripMenuItem.Text = "New tournament";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.createToolStripMenuItem.Text = "New Event";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.saveToolStripMenuItem.Text = "Save race";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.loadToolStripMenuItem.Text = "Load race";
            // 
            // exitAppToolStripMenuItem
            // 
            this.exitAppToolStripMenuItem.Name = "exitAppToolStripMenuItem";
            this.exitAppToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exitAppToolStripMenuItem.Text = "Exit app";
            this.exitAppToolStripMenuItem.Click += new System.EventHandler(this.exitAppToolStripMenuItem_Click);
            // 
            // runnersToolStripMenuItem
            // 
            this.runnersToolStripMenuItem.Name = "runnersToolStripMenuItem";
            this.runnersToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.runnersToolStripMenuItem.Text = "Runners";
            this.runnersToolStripMenuItem.Click += new System.EventHandler(this.runnersToolStripMenuItem_Click);
            // 
            // grpBxRaceParameters
            // 
            this.grpBxRaceParameters.Controls.Add(this.nmrNumWinners);
            this.grpBxRaceParameters.Controls.Add(this.nmrNumLaps);
            this.grpBxRaceParameters.Controls.Add(this.nmrLapDistance);
            this.grpBxRaceParameters.Controls.Add(this.lblTime);
            this.grpBxRaceParameters.Controls.Add(this.lblStartTime);
            this.grpBxRaceParameters.Controls.Add(this.btnStartRace);
            this.grpBxRaceParameters.Controls.Add(this.lblWinners);
            this.grpBxRaceParameters.Controls.Add(this.lblLaps);
            this.grpBxRaceParameters.Controls.Add(this.lblDistance);
            this.grpBxRaceParameters.Location = new System.Drawing.Point(13, 28);
            this.grpBxRaceParameters.Name = "grpBxRaceParameters";
            this.grpBxRaceParameters.Size = new System.Drawing.Size(238, 300);
            this.grpBxRaceParameters.TabIndex = 2;
            this.grpBxRaceParameters.TabStop = false;
            this.grpBxRaceParameters.Text = "Race parameters:";
            this.grpBxRaceParameters.Visible = false;
            // 
            // nmrNumWinners
            // 
            this.nmrNumWinners.Location = new System.Drawing.Point(132, 122);
            this.nmrNumWinners.Name = "nmrNumWinners";
            this.nmrNumWinners.Size = new System.Drawing.Size(102, 20);
            this.nmrNumWinners.TabIndex = 11;
            // 
            // nmrNumLaps
            // 
            this.nmrNumLaps.Location = new System.Drawing.Point(132, 92);
            this.nmrNumLaps.Name = "nmrNumLaps";
            this.nmrNumLaps.Size = new System.Drawing.Size(102, 20);
            this.nmrNumLaps.TabIndex = 10;
            // 
            // nmrLapDistance
            // 
            this.nmrLapDistance.DecimalPlaces = 2;
            this.nmrLapDistance.Location = new System.Drawing.Point(132, 62);
            this.nmrLapDistance.Name = "nmrLapDistance";
            this.nmrLapDistance.Size = new System.Drawing.Size(102, 20);
            this.nmrLapDistance.TabIndex = 9;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(129, 203);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(65, 13);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Starting time";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(6, 203);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(72, 13);
            this.lblStartTime.TabIndex = 7;
            this.lblStartTime.Text = "Starting Time:";
            // 
            // btnStartRace
            // 
            this.btnStartRace.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStartRace.Location = new System.Drawing.Point(132, 159);
            this.btnStartRace.Name = "btnStartRace";
            this.btnStartRace.Size = new System.Drawing.Size(100, 23);
            this.btnStartRace.TabIndex = 6;
            this.btnStartRace.Text = "Start race";
            this.btnStartRace.UseVisualStyleBackColor = true;
            this.btnStartRace.Click += new System.EventHandler(this.btnStartRace_Click);
            // 
            // lblWinners
            // 
            this.lblWinners.AutoSize = true;
            this.lblWinners.Location = new System.Drawing.Point(6, 124);
            this.lblWinners.Name = "lblWinners";
            this.lblWinners.Size = new System.Drawing.Size(101, 13);
            this.lblWinners.TabIndex = 4;
            this.lblWinners.Text = "Number of Winners:";
            // 
            // lblLaps
            // 
            this.lblLaps.AutoSize = true;
            this.lblLaps.Location = new System.Drawing.Point(6, 94);
            this.lblLaps.Name = "lblLaps";
            this.lblLaps.Size = new System.Drawing.Size(85, 13);
            this.lblLaps.TabIndex = 2;
            this.lblLaps.Text = "Number of Laps:";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(6, 64);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(97, 13);
            this.lblDistance.TabIndex = 0;
            this.lblDistance.Text = "Lap Distance (Km):";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(258, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 300);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(258, 349);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(714, 300);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.Visible = false;
            // 
            // grpBxRaceControl
            // 
            this.grpBxRaceControl.Controls.Add(this.label2);
            this.grpBxRaceControl.Controls.Add(this.textBox5);
            this.grpBxRaceControl.Controls.Add(this.btnDisq);
            this.grpBxRaceControl.Controls.Add(this.label1);
            this.grpBxRaceControl.Controls.Add(this.textBox4);
            this.grpBxRaceControl.Controls.Add(this.btnSplitTime);
            this.grpBxRaceControl.Location = new System.Drawing.Point(12, 349);
            this.grpBxRaceControl.Name = "grpBxRaceControl";
            this.grpBxRaceControl.Size = new System.Drawing.Size(240, 300);
            this.grpBxRaceControl.TabIndex = 8;
            this.grpBxRaceControl.TabStop = false;
            this.grpBxRaceControl.Text = "Race Control";
            this.grpBxRaceControl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resigned/Disqalified!";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(131, 220);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 5;
            // 
            // btnDisq
            // 
            this.btnDisq.Location = new System.Drawing.Point(131, 246);
            this.btnDisq.Name = "btnDisq";
            this.btnDisq.Size = new System.Drawing.Size(100, 23);
            this.btnDisq.TabIndex = 4;
            this.btnDisq.Text = "Disqualified";
            this.btnDisq.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Runner number";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(133, 78);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 2;
            // 
            // btnSplitTime
            // 
            this.btnSplitTime.Location = new System.Drawing.Point(133, 104);
            this.btnSplitTime.Name = "btnSplitTime";
            this.btnSplitTime.Size = new System.Drawing.Size(100, 23);
            this.btnSplitTime.TabIndex = 1;
            this.btnSplitTime.Text = "Split time";
            this.btnSplitTime.UseVisualStyleBackColor = true;
            this.btnSplitTime.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.grpBxRaceControl);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpBxRaceParameters);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "MainView";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBxRaceParameters.ResumeLayout(false);
            this.grpBxRaceParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumWinners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumLaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLapDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.grpBxRaceControl.ResumeLayout(false);
            this.grpBxRaceControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newTournamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runnersToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBxRaceParameters;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblLaps;
        private System.Windows.Forms.Button btnStartRace;
        private System.Windows.Forms.Label lblWinners;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.GroupBox grpBxRaceControl;
        private System.Windows.Forms.Button btnSplitTime;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnDisq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.NumericUpDown nmrNumWinners;
        private System.Windows.Forms.NumericUpDown nmrNumLaps;
        private System.Windows.Forms.NumericUpDown nmrLapDistance;
    }
}

