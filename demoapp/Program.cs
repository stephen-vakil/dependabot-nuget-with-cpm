// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;

var con = new SqlConnection("Server=localhost;Database=master;User Id=sa;Password=your_password;");
con.Open();

