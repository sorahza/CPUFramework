﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUFramework
{
    public class SQLUtility
    {
        public static string ConnectionString = "";
        public static DataTable GetDataTable(string sqlstatement)   // take sql statement and return a data table
        {
            Debug.Print(sqlstatement);
            DataTable dt = new();
            SqlConnection conn = new();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            //DisplayMessage("connection ", conn.State.ToString());
            var cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sqlstatement;
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;

        }
    }
}
//note
