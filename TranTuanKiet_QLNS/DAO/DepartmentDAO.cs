﻿using LanguageExt;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranTuanKiet_QLNS.DTO;

namespace TranTuanKiet_QLNS.DAO
{
    class DepartmentDAO : DbConnection
    {
        public List<DepartmentDTO> ReadAreaList()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("selectDepartment", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            List<DepartmentDTO> lstCus = new List<DepartmentDTO>();

            while (reader.Read())
            {
                DepartmentDTO cus = new DepartmentDTO();
                cus.ID = reader["ID"].ToString();
                cus.NAME = reader["NAME"].ToString();
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }
        public DepartmentDTO ReadArea(int id)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                "selectDepartment where ID=" + id.ToString(), conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DepartmentDTO area = new DepartmentDTO();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows && reader.Read())
            {
                area.ID = reader["ID"].ToString();
                area.NAME = reader["NAME"].ToString();
            }
            conn.Close();
            return area;
        }
    }
}
