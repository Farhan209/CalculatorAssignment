using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWinForm
{
    class DatabaseConnection
    {

        public static void insertData(int firstNum, int secondNum, string arithmetic, int outputR)
        {
            string connectionString = @"Server=FARHAN\SQLEXPRESS;Database=CalculatorApp;User ID=sa;Password=Dmc208209";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand insertValues = new SqlCommand("Insert into Results(first_number, second_number, arithmetic, result) values(@firstValue, @secondValue, @operatorA, @outputRes)", connection);
                insertValues.Parameters.AddWithValue("@firstValue", firstNum);
                insertValues.Parameters.AddWithValue("@secondValue", secondNum);
                insertValues.Parameters.AddWithValue("@operatorA", arithmetic);
                insertValues.Parameters.AddWithValue("@outputRes", outputR);
                connection.Open();
                insertValues.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
