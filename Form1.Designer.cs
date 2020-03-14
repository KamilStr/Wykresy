namespace KolejneWykresy
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.klasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOBlasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wLASToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dane2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dane3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dane4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dane5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dane6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dane7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dane8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dane9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dane10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dane11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dane12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.AxisX.ScrollBar.BackColor = System.Drawing.Color.Black;
            chartArea2.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.IsReversed = true;
            chartArea2.AxisY.ScrollBar.BackColor = System.Drawing.Color.Black;
            chartArea2.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.ScrollBar.IsPositionedInside = false;
            chartArea2.AxisY2.ScrollBar.BackColor = System.Drawing.Color.Black;
            chartArea2.AxisY2.ScrollBar.ButtonColor = System.Drawing.Color.Silver;
            chartArea2.CursorY.IsUserSelectionEnabled = true;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Right;
            this.chart1.Location = new System.Drawing.Point(113, 0);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(434, 512);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // klasToolStripMenuItem
            // 
            this.klasToolStripMenuItem.Name = "klasToolStripMenuItem";
            this.klasToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // sOBlasToolStripMenuItem
            // 
            this.sOBlasToolStripMenuItem.Name = "sOBlasToolStripMenuItem";
            this.sOBlasToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // wLASToolStripMenuItem1
            // 
            this.wLASToolStripMenuItem1.Name = "wLASToolStripMenuItem1";
            this.wLASToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Enabled = false;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(12, 208);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(98, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.dane2ToolStripMenuItem,
            this.dane3ToolStripMenuItem,
            this.dane4ToolStripMenuItem,
            this.dane5ToolStripMenuItem,
            this.dane6ToolStripMenuItem,
            this.dane7ToolStripMenuItem,
            this.dane8ToolStripMenuItem,
            this.dane9ToolStripMenuItem,
            this.dane10ToolStripMenuItem,
            this.dane11ToolStripMenuItem,
            this.dane12ToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.dataToolStripMenuItem.Text = "Wybierz dane";
            this.dataToolStripMenuItem.Click += new System.EventHandler(this.dataToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.testToolStripMenuItem.Text = "dane1";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // dane2ToolStripMenuItem
            // 
            this.dane2ToolStripMenuItem.Name = "dane2ToolStripMenuItem";
            this.dane2ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.dane2ToolStripMenuItem.Text = "dane2";
            this.dane2ToolStripMenuItem.Click += new System.EventHandler(this.dane2ToolStripMenuItem_Click);
            // 
            // dane3ToolStripMenuItem
            // 
            this.dane3ToolStripMenuItem.Name = "dane3ToolStripMenuItem";
            this.dane3ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.dane3ToolStripMenuItem.Text = "dane3";
            this.dane3ToolStripMenuItem.Click += new System.EventHandler(this.dane3ToolStripMenuItem_Click);
            // 
            // dane4ToolStripMenuItem
            // 
            this.dane4ToolStripMenuItem.Name = "dane4ToolStripMenuItem";
            this.dane4ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.dane4ToolStripMenuItem.Text = "dane4";
            this.dane4ToolStripMenuItem.Click += new System.EventHandler(this.dane4ToolStripMenuItem_Click);
            // 
            // dane5ToolStripMenuItem
            // 
            this.dane5ToolStripMenuItem.Name = "dane5ToolStripMenuItem";
            this.dane5ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.dane5ToolStripMenuItem.Text = "dane5";
            this.dane5ToolStripMenuItem.Click += new System.EventHandler(this.dane5ToolStripMenuItem_Click);
            // 
            // dane6ToolStripMenuItem
            // 
            this.dane6ToolStripMenuItem.Name = "dane6ToolStripMenuItem";
            this.dane6ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.dane6ToolStripMenuItem.Text = "dane6";
            this.dane6ToolStripMenuItem.Click += new System.EventHandler(this.dane6ToolStripMenuItem_Click);
            // 
            // dane7ToolStripMenuItem
            // 
            this.dane7ToolStripMenuItem.Name = "dane7ToolStripMenuItem";
            this.dane7ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.dane7ToolStripMenuItem.Text = "dane7";
            this.dane7ToolStripMenuItem.Click += new System.EventHandler(this.dane7ToolStripMenuItem_Click);
            // 
            // dane8ToolStripMenuItem
            // 
            this.dane8ToolStripMenuItem.Name = "dane8ToolStripMenuItem";
            this.dane8ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.dane8ToolStripMenuItem.Text = "dane8";
            this.dane8ToolStripMenuItem.Click += new System.EventHandler(this.dane8ToolStripMenuItem_Click);
            // 
            // dane9ToolStripMenuItem
            // 
            this.dane9ToolStripMenuItem.Name = "dane9ToolStripMenuItem";
            this.dane9ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.dane9ToolStripMenuItem.Text = "dane9";
            this.dane9ToolStripMenuItem.Click += new System.EventHandler(this.dane9ToolStripMenuItem_Click);
            // 
            // dane10ToolStripMenuItem
            // 
            this.dane10ToolStripMenuItem.Name = "dane10ToolStripMenuItem";
            this.dane10ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.dane10ToolStripMenuItem.Text = "dane10";
            this.dane10ToolStripMenuItem.Click += new System.EventHandler(this.dane10ToolStripMenuItem_Click);
            // 
            // dane11ToolStripMenuItem
            // 
            this.dane11ToolStripMenuItem.Name = "dane11ToolStripMenuItem";
            this.dane11ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.dane11ToolStripMenuItem.Text = "dane11";
            this.dane11ToolStripMenuItem.Click += new System.EventHandler(this.dane11ToolStripMenuItem_Click);
            // 
            // dane12ToolStripMenuItem
            // 
            this.dane12ToolStripMenuItem.Name = "dane12ToolStripMenuItem";
            this.dane12ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.dane12ToolStripMenuItem.Text = "dane12";
            this.dane12ToolStripMenuItem.Click += new System.EventHandler(this.dane12ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dane:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(16, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Przełącz skalę";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aktualna skala:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 63);
            this.button2.TabIndex = 8;
            this.button2.Text = "Wybierz plik";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 512);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Rysowacz wykresów";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem klasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOBlasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wLASToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dane2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dane3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dane4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dane5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dane6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dane7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dane8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dane9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dane10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dane11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dane12ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

