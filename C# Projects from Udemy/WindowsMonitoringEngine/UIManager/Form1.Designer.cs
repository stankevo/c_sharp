namespace UIManager
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMonitor = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataCollectedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new UIManager.DataSet1();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpuValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTakenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelStart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.dataCollectedTableAdapter = new UIManager.DataSet1TableAdapters.DataCollectedTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCollectedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMonitor);
            this.tabControl1.Controls.Add(this.tabLogs);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(971, 618);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMonitor
            // 
            this.tabMonitor.Controls.Add(this.label5);
            this.tabMonitor.Controls.Add(this.chart2);
            this.tabMonitor.Controls.Add(this.chart1);
            this.tabMonitor.Controls.Add(this.label4);
            this.tabMonitor.Controls.Add(this.label3);
            this.tabMonitor.Controls.Add(this.dataGridView1);
            this.tabMonitor.Controls.Add(this.buttonStart);
            this.tabMonitor.Controls.Add(this.labelStart);
            this.tabMonitor.Controls.Add(this.label1);
            this.tabMonitor.Location = new System.Drawing.Point(4, 22);
            this.tabMonitor.Name = "tabMonitor";
            this.tabMonitor.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonitor.Size = new System.Drawing.Size(963, 592);
            this.tabMonitor.TabIndex = 0;
            this.tabMonitor.Text = " Monitor";
            this.tabMonitor.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Memory Chart:  ";
            // 
            // chart2
            // 
            chartArea3.AxisX.MajorGrid.LineWidth = 0;
            chartArea3.AxisY.MajorGrid.LineWidth = 0;
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            this.chart2.DataSource = this.dataCollectedBindingSource;
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(463, 284);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.XValueMember = "DateTaken";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.YValueMembers = "MemValue";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(497, 300);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "chart2";
            // 
            // dataCollectedBindingSource
            // 
            this.dataCollectedBindingSource.DataMember = "DataCollected";
            this.dataCollectedBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart1
            // 
            chartArea4.AxisX.MajorGrid.LineWidth = 0;
            chartArea4.AxisY.MajorGrid.LineWidth = 0;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.DataSource = this.dataCollectedBindingSource;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(463, 41);
            this.chart1.Name = "chart1";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.XValueMember = "DateTaken";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series4.YValueMembers = "CpuValue";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(497, 209);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPU Chart:  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Recorded data:  ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.cpuValueDataGridViewTextBoxColumn,
            this.memValueDataGridViewTextBoxColumn,
            this.dateTakenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataCollectedBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 509);
            this.dataGridView1.TabIndex = 3;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpuValueDataGridViewTextBoxColumn
            // 
            this.cpuValueDataGridViewTextBoxColumn.DataPropertyName = "CpuValue";
            this.cpuValueDataGridViewTextBoxColumn.HeaderText = "CpuValue";
            this.cpuValueDataGridViewTextBoxColumn.Name = "cpuValueDataGridViewTextBoxColumn";
            // 
            // memValueDataGridViewTextBoxColumn
            // 
            this.memValueDataGridViewTextBoxColumn.DataPropertyName = "MemValue";
            this.memValueDataGridViewTextBoxColumn.HeaderText = "MemValue";
            this.memValueDataGridViewTextBoxColumn.Name = "memValueDataGridViewTextBoxColumn";
            // 
            // dateTakenDataGridViewTextBoxColumn
            // 
            this.dateTakenDataGridViewTextBoxColumn.DataPropertyName = "DateTaken";
            this.dateTakenDataGridViewTextBoxColumn.HeaderText = "DateTaken";
            this.dateTakenDataGridViewTextBoxColumn.Name = "dateTakenDataGridViewTextBoxColumn";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(179, 20);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(112, 25);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(47, 13);
            this.labelStart.TabIndex = 1;
            this.labelStart.Text = "Stopped";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service status:  ";
            // 
            // tabLogs
            // 
            this.tabLogs.Location = new System.Drawing.Point(4, 22);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogs.Size = new System.Drawing.Size(963, 592);
            this.tabLogs.TabIndex = 1;
            this.tabLogs.Text = "Logs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // dataCollectedTableAdapter
            // 
            this.dataCollectedTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(971, 618);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UI Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMonitor.ResumeLayout(false);
            this.tabMonitor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCollectedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMonitor;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataCollectedBindingSource;
        private DataSet1TableAdapters.DataCollectedTableAdapter dataCollectedTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpuValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTakenDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label5;
    }
}

