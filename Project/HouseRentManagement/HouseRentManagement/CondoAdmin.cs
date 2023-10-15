﻿using System;
using System.Configuration;
using System.Data.SqlClient;

namespace HouseRentManagement
{
    public partial class CondoAdmin : DevExpress.XtraEditors.XtraForm
    {
        private VehicleCard vehicleCard;
        public CondoAdmin()
        {
            InitializeComponent();
            bindData1();
            bindData2();
        }
        private ChildFormManager formManager = new ChildFormManager();

        private void bindData1()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                string query = @"SELECT DANHSACHNHANKHAU.MaCanHo, TANG.Tang, CHUSOHUU.TenChuSoHuu, NGUOITHUE.TenNguoiThue, DANHSACHNHANKHAU.QuanHeVoiChuThue, LOAICANHO.TenLoai, LOAICANHO.DienTich, THECUDAN.MaTheCuDan, XE.TenXe
    FROM CANHO
    INNER JOIN TANG ON CANHO.MaTang = TANG.MaTang
    INNER JOIN CHUSOHUU ON CANHO.MaChuSoHuu = CHUSOHUU.MaChuSoHuu
    INNER JOIN DANHSACHNHANKHAU ON CANHO.MaCanHo = DANHSACHNHANKHAU.MaCanHo
    INNER JOIN NGUOITHUE ON DANHSACHNHANKHAU.MaNguoiThue = NGUOITHUE.MaNguoiThue
    INNER JOIN THECUDAN ON DANHSACHNHANKHAU.MaNguoiThue = THECUDAN.MaNguoiThue
    LEFT JOIN THEXE ON THEXE.MaTheCuDan = THECUDAN.MaTheCuDan
    LEFT JOIN XE ON XE.MaTheXe = THEXE.MaTheXe
    INNER JOIN LOAICANHO ON CANHO.MaLoai = LOAICANHO.MaLoai;";
                // Thêm điều kiện WHERE nếu cần thiết
                // query += " WHERE ...";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dgvPopulation.Rows.Clear();

                        while (reader.Read())
                        {
                            int index = dgvPopulation.Rows.Add();

                            dgvPopulation.Rows[index].Cells[0].Value = reader["MaCanHo"];
                            dgvPopulation.Rows[index].Cells[1].Value = reader["Tang"];
                            dgvPopulation.Rows[index].Cells[4].Value = reader["TenChuSoHuu"];
                            dgvPopulation.Rows[index].Cells[5].Value = reader["TenNguoiThue"];
                            dgvPopulation.Rows[index].Cells[8].Value = reader["QuanHeVoiChuThue"];
                            dgvPopulation.Rows[index].Cells[3].Value = reader["TenLoai"];
                            dgvPopulation.Rows[index].Cells[6].Value = reader["MaTheCuDan"];
                            dgvPopulation.Rows[index].Cells[7].Value = reader["TenXe"];
                            dgvPopulation.Rows[index].Cells[2].Value = reader["DienTich"];
                        }
                    }
                }
            }
        }
        private void bindData2()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                string query = @"SELECT CANHO.MaCanHo, TANG.Tang, CHUSOHUU.TenChuSoHuu, LOAICANHO.TenLoai, CANHO.TinhTrang, LOAICANHO.DienTich
                    FROM CANHO
                    INNER JOIN TANG ON CANHO.MaTang = TANG.MaTang
                    INNER JOIN CHUSOHUU ON CANHO.MaChuSoHuu = CHUSOHUU.MaChuSoHuu
                    INNER JOIN LOAICANHO ON CANHO.MaLoai = LOAICANHO.MaLoai;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dgvCondo.Rows.Clear();

                        while (reader.Read())
                        {
                            int index = dgvCondo.Rows.Add();

                            dgvCondo.Rows[index].Cells[0].Value = reader["MaCanHo"];
                            dgvCondo.Rows[index].Cells[1].Value = reader["Tang"];
                            dgvCondo.Rows[index].Cells[4].Value = reader["TenChuSoHuu"];
                            dgvCondo.Rows[index].Cells[5].Value = reader["TinhTrang"];
                            dgvCondo.Rows[index].Cells[3].Value = reader["TenLoai"];
                            dgvCondo.Rows[index].Cells[2].Value = reader["DienTich"];
                        }
                    }
                }
            }
        }
        private string connString = ConfigurationManager.ConnectionStrings["Model_QLCHCC"].ConnectionString;


        private void tsbCondo_Click(object sender, EventArgs e)
        {
            dgvPopulation.Visible = true;
            txtSearchPopulation.Visible = true;
            dgvCondo.Visible = false;
            txtSearchCondo.Visible = false;
            btnClose1.Visible = true;
        }
        private void ShowVehicleCard()
        {
            if (formManager.CurrentChildForm is VehicleCard)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            VehicleCard vc = new VehicleCard();
            formManager.ShowChildForm(pnlContainer, vc);
        }

        private void tsbVehicleCard_Click(object sender, EventArgs e)
        {
            ShowVehicleCard();
            dgvPopulation.Visible = false;
            txtSearchPopulation.Visible = false;
            dgvCondo.Visible = false;
            txtSearchCondo.Visible = false;
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            dgvPopulation.Visible = false;
            txtSearchPopulation.Visible = false;
            dgvCondo.Visible = true;
            txtSearchCondo.Visible = true;
            btnClose1.Visible = false;
        }
    }
}