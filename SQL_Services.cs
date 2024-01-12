using System.Data;
using MySqlConnector;

namespace Shoppa
{
    internal class SQL_Services
    {
        private static MySqlConnection mySqlConnection;
        private MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
        private MySqlCommand mySqlCommand = new MySqlCommand();

        public void OpenDB(string sCon)
        {
            mySqlConnection = new MySqlConnection(sCon);
            mySqlConnection.Open();
        }

        public void CloseDB()
        {
            mySqlConnection.Close();
        }

        private void SetCommandText(string sSql)
        {
            mySqlCommand.Connection = mySqlConnection;
            mySqlCommand.CommandText = sSql;
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

        public string GetParameterValue(string parameterName)
        {
            if (mySqlCommand.Parameters.Contains(parameterName))
            {
                return mySqlCommand.Parameters[parameterName].Value.ToString();
            }

            return null;
        }

        public string ExecuteScalar(string sSql)
        {
            SetCommandText(sSql);
            object result = mySqlCommand.ExecuteScalar();
            return result != null ? result.ToString() : "";
        }

        public int ExecuteNonQuery(string sSql)
        {
            SetCommandText(sSql);
            return mySqlCommand.ExecuteNonQuery();
        }

        public DataTable ExecuteQueryTable(string sSql)
        {
            DataTable myDataTable = new DataTable();
            SetCommandText(sSql);
            myDataAdapter.SelectCommand = mySqlCommand;
            myDataAdapter.Fill(myDataTable);
            return myDataTable;
        }

        public void GetCartID()
        {
            string CartID = ExecuteScalar("SELECT OrderID FROM Orders WHERE OrdererAccountID = @AccountID AND StatusID = 0 LIMIT 1");
            if (CartID == "")
            {
                // Get new CartID
                int orderCount = int.Parse(ExecuteScalar("SELECT COUNT(*) FROM Orders"));
                CartID = "DH" + (orderCount + 1).ToString("D8");
                AddParamater("@CartID", CartID);
                ExecuteNonQuery("INSERT INTO Orders VALUES (@CartID, @AccountID, 0, NOW(), '0', NULL, NULL)");
            }
            AddParamater("@CartID", CartID);
        }

        public bool CheckExist(string Table, string Paramater, string filter = null)
        {
            string sSql = "Select COUNT(*) From " + Table + " Where " + Paramater + " = @" + Paramater + (filter != null ? " and " + filter : null);

            return int.Parse(ExecuteScalar(sSql)) != 0;
        }
    }
}
