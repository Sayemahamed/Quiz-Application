using System;
using System.Data.SQLite;

namespace QuizApp
{
    internal class DataBase
    {
        private SQLiteConnection connection = new SQLiteConnection("Data Source = Data.db");
        private String ReadQuestion = "SELECT * FROM Question;";
        private string ReadOptions = "SELECT * FROM Options;";
        public void openConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open) connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open) connection.Close();
        }
        public string[] Options(int ID)
        {
            string[] options = new string[4];
            SQLiteCommand cmd = new SQLiteCommand(ReadOptions, connection);
            SQLiteDataReader result = cmd.ExecuteReader();
            while (result.Read())
            {
                if (Convert.ToInt32(result[0].ToString()) == ID)
                {
                    options[0] = result[1].ToString();
                    options[1] = result[2].ToString();
                    options[2] = result[3].ToString();
                    options[3] = result[4].ToString();
                    break;
                }
            }
            return options;
        }
        public string[] Question(int ID)
        {
            string[] ans = new string[2];
            SQLiteCommand cmd = new SQLiteCommand(ReadQuestion, connection);
            SQLiteDataReader result = cmd.ExecuteReader();
            while (result.Read())
            {
                if (Convert.ToInt32(result[0].ToString()) == ID)
                {
                    ans[0] = result[1].ToString();
                    ans[1] = result[2].ToString(); break;
                }
            }
            return ans;
        }
    }
}
