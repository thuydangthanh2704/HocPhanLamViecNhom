using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace KhaiBaoYTe
{
    static class KetNoi
    {
        static SqlConnection conn;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static public void moKetNoi()
        {
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["kn"].ConnectionString.ToString();
            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Ket noi that bai");
            }

        }
        static public void dongKetNoi()
        {
            try
            {
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Dong ket noi that bai");
            }
        }
        static public DataTable getData(string sql)
        {
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        static public object execScalar(string sql)
        {
            object data = 0;
            {
                KetNoi.moKetNoi();
                cmd = new SqlCommand(sql, conn);
                data = cmd.ExecuteScalar();
                KetNoi.dongKetNoi();
            }
            return data;
        }
        static public SqlDataReader HienThii(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dataR = cmd.ExecuteReader();
            return dataR;
        }

        static public bool check(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dataR = cmd.ExecuteReader();
            return dataR.Read();
        }
        static public void updateData(string sql, object[] value, string[] name, int slthamso)
        {
            cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Clear();
            for (int i = 0; i < slthamso; i++)
                cmd.Parameters.AddWithValue(name[i], value[i]);

            cmd.ExecuteNonQuery();
        }
    }
}