using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoppa
{
    internal class SQL_Services
    {
        private static SqlConnection mySqlConnection;
        private SqlDataAdapter myDataAdapter = new SqlDataAdapter();
        private SqlCommand mySqlCommand = new SqlCommand();
        
        private void DisplayError(SqlException ex)
        {
            string sSql = "SELECT * FROM Errors WHERE Number = " + ex.Number;
            DataTable dtError = ExecuteQueryTable(sSql);
            if (dtError.Rows.Count > 0)
            {
                MessageBox.Show(dtError.Rows[0][1].ToString().Trim(), "Lỗi: " + ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(ex.Message, "Lỗi: " + ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        public void OpenDB(string sCon)
        {
            try
            {
                mySqlConnection = new SqlConnection(sCon);
                mySqlConnection.Open();
            }
            catch (SqlException ex)
            {
                DisplayError(ex);
            }
        }
        
        public void CloseDB()
        {
            try
            {
                mySqlConnection.Close();
            }
            catch (SqlException ex)
            {
                DisplayError(ex);
            }
        }

        public void AddParamater(string parameterName, string parameterValue)
        {
            if (mySqlCommand.Parameters.Contains(parameterName))
            {
                mySqlCommand.Parameters[parameterName].Value = parameterValue;
            }
            else
            {
                mySqlCommand.Parameters.AddWithValue(parameterName, parameterValue);
            }
        }

        public string ExecuteScalar(string sSql)
        {
            SetCommandText(sSql);
            return mySqlCommand.ExecuteScalar().ToString();
        }

        public int ExecuteNonQuery(string sSql)
        {
            SetCommandText(sSql);
            return mySqlCommand.ExecuteNonQuery();
        }

        public DataTable ExecuteQueryTable(string sSql)
        {
            DataTable myDataTable = new DataTable();
            try
            {
                SetCommandText(sSql);
                myDataAdapter.SelectCommand = mySqlCommand;
                myDataAdapter.Fill(myDataTable);
            }
            catch (SqlException ex)
            {
                DisplayError(ex);
                return null;
            }
            return myDataTable;
        }

        public bool CheckExist(string Table, string Paramater)
        {
            string sSql = "Select COUNT(*) From " + Table + " Where " + Paramater + " = @" + Paramater;

            return int.Parse(ExecuteScalar(sSql)) != 0;
        }

        public void SetCommandText(string sSql)
        {
            mySqlCommand.Connection = mySqlConnection;
            mySqlCommand.CommandText = sSql;
        }
    }
}
