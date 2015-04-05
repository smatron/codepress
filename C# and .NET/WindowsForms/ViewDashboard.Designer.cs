namespace CodePress
{
    partial class ViewDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.UserListbox = new System.Windows.Forms.ListBox();
            this.UserTable = new System.Windows.Forms.DataGridView();
            this.UserLineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.UserPieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.UserMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserLineChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPieChart)).BeginInit();
            this.UserMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserListbox
            // 
            this.UserListbox.FormattingEnabled = true;
            this.UserListbox.Location = new System.Drawing.Point(12, 33);
            this.UserListbox.Name = "UserListbox";
            this.UserListbox.Size = new System.Drawing.Size(166, 433);
            this.UserListbox.TabIndex = 0;
            // 
            // UserTable
            // 
            this.UserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserTable.Location = new System.Drawing.Point(184, 279);
            this.UserTable.Name = "UserTable";
            this.UserTable.Size = new System.Drawing.Size(644, 213);
            this.UserTable.TabIndex = 1;
            // 
            // UserLineChart
            // 
            chartArea1.Name = "ChartArea1";
            this.UserLineChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.UserLineChart.Legends.Add(legend1);
            this.UserLineChart.Location = new System.Drawing.Point(184, 33);
            this.UserLineChart.Name = "UserLineChart";
            this.UserLineChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.UserLineChart.Series.Add(series1);
            this.UserLineChart.Size = new System.Drawing.Size(319, 240);
            this.UserLineChart.TabIndex = 2;
            this.UserLineChart.Text = "chart1";
            // 
            // UserPieChart
            // 
            chartArea2.Name = "ChartArea1";
            this.UserPieChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.UserPieChart.Legends.Add(legend2);
            this.UserPieChart.Location = new System.Drawing.Point(509, 33);
            this.UserPieChart.Name = "UserPieChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.UserPieChart.Series.Add(series2);
            this.UserPieChart.Size = new System.Drawing.Size(319, 240);
            this.UserPieChart.TabIndex = 3;
            this.UserPieChart.Text = "chart2";
            // 
            // UserMenuStrip
            // 
            this.UserMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.UserMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.UserMenuStrip.Name = "UserMenuStrip";
            this.UserMenuStrip.Size = new System.Drawing.Size(839, 24);
            this.UserMenuStrip.TabIndex = 6;
            this.UserMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(13, 469);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(165, 23);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ViewDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 502);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.UserPieChart);
            this.Controls.Add(this.UserLineChart);
            this.Controls.Add(this.UserTable);
            this.Controls.Add(this.UserListbox);
            this.Controls.Add(this.UserMenuStrip);
            this.MainMenuStrip = this.UserMenuStrip;
            this.Name = "ViewDashboard";
            this.Text = "ViewDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.UserTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserLineChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPieChart)).EndInit();
            this.UserMenuStrip.ResumeLayout(false);
            this.UserMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UserListbox;
        private System.Windows.Forms.DataGridView UserTable;
        private System.Windows.Forms.DataVisualization.Charting.Chart UserLineChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart UserPieChart;
        private System.Windows.Forms.MenuStrip UserMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button UpdateButton;
    }
}