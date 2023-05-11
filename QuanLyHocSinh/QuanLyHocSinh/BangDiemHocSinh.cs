﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using QuanLyHocSinh.Model;

namespace QuanLyHocSinh
{
    public partial class BangDiemHocSinh : Form
    {
        public BangDiemHocSinh()
        {

            InitializeComponent();
            panelDNH.Hide();
            PanelDHK.Hide();
            dataGridView1.Hide();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        void TraCuuDiemHocKy()
        {
            dataEntities dtb = new dataEntities();
            var result = from c in dtb.DIEMs
                         where c.MaHocSinh == textBox1.Text && c.HocKy == HocKyCbb.Text && c.NamHoc == NamHocCbb.Text
                         select new { c.MaMonHoc, c.MONHOC.TenMonHoc, c.DiemTX, c.DiemGK, c.DiemCK, c.DiemTB };
            //Nhap sai
            if (result.Count() == 0) MessageBox.Show("Mã số học sinh không tồn tại","Error",MessageBoxButtons.OK);
            else
            {
                dataGridView1.DataSource = result.ToList();
                //Ho Ten
                var HoTen = from h in dtb.HOCSINHs
                            where h.MaHocSinh == textBox1.Text
                            select h.HoTen;

                HoTenTextBox.Text = HoTen.First();
                //LOP
                var Lop = from src in dtb.CTLOPs
                          join cls in dtb.DIEMs on src.MaHocSinh equals cls.MaHocSinh
                          join l in dtb.LOPs on src.MaLop equals l.MaLop
                          where src.MaHocSinh == textBox1.Text && cls.HocKy == HocKyCbb.Text && NamHocCbb.Text == cls.NamHoc
                          select l.TenLop;
                LopTextBox.Text = Lop.First();
                //Diem trung binh ca hoc ky
                var DTBHK = result.Sum(row => row.DiemTB) / 13;
                DTBHK = Math.Round((double)DTBHK, 2);
                DTBHKTextBox.Text = DTBHK.ToString();
                //XepLoai
                if (DTBHK >= 8) XepLoaiTextBox.Text = "Giỏi";
                else if (DTBHK >= 6.5) XepLoaiTextBox.Text = "Khá";
                else if (DTBHK >= 5) XepLoaiTextBox.Text = "Trung Bình";
                else if (DTBHK >= 3.5) XepLoaiTextBox.Text = "Yếu";
                else XepLoaiTextBox.Text = "Kém";
                PanelDHK.Show();
                dataGridView1.Show();
            }
        }
        void TraCuuDiemNamHoc()
        {

        }
        private void TraCuuButton_Click(object sender, EventArgs e)
        {
            TraCuuDiemHocKy();
        }

        private void TraCuuNHButton_Click(object sender, EventArgs e)
        {
            TraCuuDiemNamHoc();
        }
    }
}