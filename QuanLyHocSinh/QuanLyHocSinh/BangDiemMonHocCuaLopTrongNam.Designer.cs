﻿namespace QuanLyHocSinh
{
    partial class BangDiemMonHocCuaLopTrongNam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangDiemMonHocCuaLopTrongNam));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.panelPrint = new System.Windows.Forms.Panel();
            this.chartRatio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ButtonExportExcel = new Guna.UI2.WinForms.Guna2Button();
            this.labelNameOfGrid1 = new System.Windows.Forms.Label();
            this.panelClassifyYear = new System.Windows.Forms.Panel();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.LabelNameProject = new System.Windows.Forms.Label();
            this.comboBoxYear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBoxClass = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBoxSubject = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelClass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonPrint = new Guna.UI2.WinForms.Guna2Button();
            this.BtnHomeScreen = new System.Windows.Forms.Button();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRatio)).BeginInit();
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.Location = new System.Drawing.Point(492, 208);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(69, 18);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "Năm học";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubject.Location = new System.Drawing.Point(871, 159);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(67, 18);
            this.labelSubject.TabIndex = 12;
            this.labelSubject.Text = "Môn học";
            // 
            // panelPrint
            // 
            this.panelPrint.Controls.Add(this.dataGridView1);
            this.panelPrint.Controls.Add(this.chartRatio);
            this.panelPrint.Controls.Add(this.ButtonExportExcel);
            this.panelPrint.Controls.Add(this.labelNameOfGrid1);
            this.panelPrint.Controls.Add(this.panelClassifyYear);
            this.panelPrint.Location = new System.Drawing.Point(116, 295);
            this.panelPrint.Name = "panelPrint";
            this.panelPrint.Size = new System.Drawing.Size(1460, 632);
            this.panelPrint.TabIndex = 50;
            // 
            // chartRatio
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRatio.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRatio.Legends.Add(legend1);
            this.chartRatio.Location = new System.Drawing.Point(1107, 245);
            this.chartRatio.Name = "chartRatio";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRatio.Series.Add(series1);
            this.chartRatio.Size = new System.Drawing.Size(350, 314);
            this.chartRatio.TabIndex = 137;
            this.chartRatio.Text = "chart1";
            // 
            // ButtonExportExcel
            // 
            this.ButtonExportExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonExportExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonExportExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonExportExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExportExcel.ForeColor = System.Drawing.Color.White;
            this.ButtonExportExcel.Location = new System.Drawing.Point(893, 560);
            this.ButtonExportExcel.Name = "ButtonExportExcel";
            this.ButtonExportExcel.Size = new System.Drawing.Size(105, 55);
            this.ButtonExportExcel.TabIndex = 61;
            this.ButtonExportExcel.Text = "In bảng điểm";
            this.ButtonExportExcel.Click += new System.EventHandler(this.ButtonExportExcel_Click);
            // 
            // labelNameOfGrid1
            // 
            this.labelNameOfGrid1.AutoSize = true;
            this.labelNameOfGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameOfGrid1.Location = new System.Drawing.Point(532, 541);
            this.labelNameOfGrid1.Name = "labelNameOfGrid1";
            this.labelNameOfGrid1.Size = new System.Drawing.Size(46, 18);
            this.labelNameOfGrid1.TabIndex = 136;
            this.labelNameOfGrid1.Text = "label1";
            // 
            // panelClassifyYear
            // 
            this.panelClassifyYear.Location = new System.Drawing.Point(298, 3);
            this.panelClassifyYear.Name = "panelClassifyYear";
            this.panelClassifyYear.Size = new System.Drawing.Size(925, 236);
            this.panelClassifyYear.TabIndex = 112;
            // 
            // PanelTitle
            // 
            this.PanelTitle.Controls.Add(this.LabelNameProject);
            this.PanelTitle.Location = new System.Drawing.Point(393, 36);
            this.PanelTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(968, 86);
            this.PanelTitle.TabIndex = 54;
            // 
            // LabelNameProject
            // 
            this.LabelNameProject.AutoSize = true;
            this.LabelNameProject.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNameProject.Location = new System.Drawing.Point(102, 21);
            this.LabelNameProject.Name = "LabelNameProject";
            this.LabelNameProject.Size = new System.Drawing.Size(772, 46);
            this.LabelNameProject.TabIndex = 0;
            this.LabelNameProject.Text = "TỔNG KẾT ĐIỂM MÔN HỌC TRONG NĂM";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxYear.ForeColor = System.Drawing.Color.Black;
            this.comboBoxYear.ItemHeight = 25;
            this.comboBoxYear.Location = new System.Drawing.Point(582, 208);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(231, 31);
            this.comboBoxYear.TabIndex = 55;
            this.comboBoxYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxYear_SelectedIndexChanged);
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClass.ForeColor = System.Drawing.Color.Black;
            this.comboBoxClass.ItemHeight = 25;
            this.comboBoxClass.Location = new System.Drawing.Point(582, 151);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(231, 31);
            this.comboBoxClass.TabIndex = 57;
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSubject.DropDownHeight = 200;
            this.comboBoxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubject.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSubject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubject.ForeColor = System.Drawing.Color.Black;
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.IntegralHeight = false;
            this.comboBoxSubject.ItemHeight = 25;
            this.comboBoxSubject.Location = new System.Drawing.Point(970, 151);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(231, 31);
            this.comboBoxSubject.TabIndex = 58;
            // 
            // labelClass
            // 
            this.labelClass.BackColor = System.Drawing.Color.Transparent;
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(495, 157);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(28, 20);
            this.labelClass.TabIndex = 59;
            this.labelClass.Text = "Lớp";
            // 
            // buttonPrint
            // 
            this.buttonPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Location = new System.Drawing.Point(1024, 223);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(105, 55);
            this.buttonPrint.TabIndex = 60;
            this.buttonPrint.Text = "Xuất";
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // BtnHomeScreen
            // 
            this.BtnHomeScreen.BackColor = System.Drawing.SystemColors.Window;
            this.BtnHomeScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnHomeScreen.Image = ((System.Drawing.Image)(resources.GetObject("BtnHomeScreen.Image")));
            this.BtnHomeScreen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHomeScreen.Location = new System.Drawing.Point(116, 50);
            this.BtnHomeScreen.Name = "BtnHomeScreen";
            this.BtnHomeScreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnHomeScreen.Size = new System.Drawing.Size(146, 53);
            this.BtnHomeScreen.TabIndex = 61;
            this.BtnHomeScreen.Text = "Trang chủ";
            this.BtnHomeScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnHomeScreen.UseVisualStyleBackColor = false;
            this.BtnHomeScreen.Click += new System.EventHandler(this.BtnHomeScreen_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(17, 245);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1084, 273);
            this.dataGridView1.TabIndex = 138;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridView1.ThemeStyle.ReadOnly = true;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.Visible = false;
            // 
            // BangDiemMonHocCuaLopTrongNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1603, 935);
            this.Controls.Add(this.BtnHomeScreen);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.panelPrint);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelYear);
            this.Name = "BangDiemMonHocCuaLopTrongNam";
            this.Text = "XuatBangDiemMonHocCuaLopTrongNamHoc";
            this.panelPrint.ResumeLayout(false);
            this.panelPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRatio)).EndInit();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Panel panelPrint;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label LabelNameProject;
        private System.Windows.Forms.Panel panelClassifyYear;
        private System.Windows.Forms.Label labelNameOfGrid1;
        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox comboBoxYear;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxClass;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxSubject;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelClass;
        private Guna.UI2.WinForms.Guna2Button buttonPrint;
        private Guna.UI2.WinForms.Guna2Button ButtonExportExcel;
        private System.Windows.Forms.Button BtnHomeScreen;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRatio;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
    }
}