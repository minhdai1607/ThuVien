using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace AnLibrary.EntityFramework
{
    class common
    {
        public string sql = "Data Source=.\\SQLEXPRESS;Initial Catalog=AnLibrary;Integrated Security=True;TrustServerCertificate=True;";
        public DataTable getdata(string query)
        {
            SqlConnection conn = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            var table = new DataTable();
            table.Load(cmd.ExecuteReader());
            return table;
        }
        //check SDT
        public const string motif = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
        public bool IsPhoneNbr(string number)
        {
            if (number != null)
                return Regex.IsMatch(number, motif);
            else return false;
        }

        public static void InsertBook(int book_code, int supplier_code,int type_code, string name, int quantity, int price)
        {
            using (SqlConnection cnn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=AnLibrary;Integrated Security=True;TrustServerCertificate=True;"))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    // chọn kiểu command type là storedProcedure, mình đã viết stored lưu trong DB trước đó.
                    cmd.CommandType = CommandType.StoredProcedure;
                    // gọi tên procedure ra sài
                    cmd.CommandText = "";
                    //Gán kiểu dữ liệu và tên phải chính xác mới quăng lên SQL được
                    cmd.Parameters.AddWithValue("@bill_id", book_code);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@price", price);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
