using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HASAKI
{
    class KetNoi
    {
        private string strCon = @"Data Source =DESKTOP-KSMPI06;Initial Catalog=QUANLYBANHANGHASAKI;Integrated Security=True";
        public SqlConnection GetConnect()
        {
            SqlConnection sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            return sqlCon;
        }
        public int EXECUTENONQUERY(string query)
        {
            int data = 0;
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlCon);
          data = cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            return data;
        }
        public DataTable LOGIN()
        {
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from USERS", GetConnect());
            adapter.Fill(data);
            return data;
        }
        public DataTable Executequery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataAdapter laydulieu = new SqlDataAdapter(cmd);
                laydulieu.Fill(data);
                sqlCon.Close();
            }
            return data;
        }
        public DataTable NHANVIEN()
        {
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from NHANVIEN", GetConnect());
            adapter.Fill(data);
            return data;
        }
        public DataTable ThongTinSP()
        {
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from MATHANG", GetConnect());
            adapter.Fill(data);
            return data;
        }
        public DataTable ThongTinKH()
        {
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from KHACHHANG", GetConnect());
            adapter.Fill(data);
            return data;
        }
        public DataTable LOGINN()
        {
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from USERS", GetConnect()); //LOGIN
            adapter.Fill(data);
            return data;
        }
        public DataTable hoadon()
        {
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from HOADON", GetConnect());
            adapter.Fill(data);
            return data;

        }
        public DataTable NCC()
        {
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from NHACUNGCAP", GetConnect());
            adapter.Fill(data);
            return data;
        }
    }
}
