using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;
using System.Data;

namespace Projet_Quizz
{
    class Models
    {

        private string _IpBdd = "10.134.180.111";
        private string _User = "Quizz";
        private string _Password = "SuperC101";
        private string _DataBase = "Quizz";

        private string _status = "";       

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        MySqlConnection BDDConnection;
        MySqlCommand SqlToSend;
        MySqlDataReader ReadBdd;
//===============================================================================================================================================//
//==============================================================================================================================================// 
        /// <summary>
        /// Cette methode ouvre la connection à la base de données en utilisant les paramètres suivants :
        /// </summary>
        /// <param name="IpAdress">Adresse du serveur</param>
        /// <param name="DataBaseName">Nom de la base de données</param>
        /// <param name="UserName">Utilisateur pouvant se connecter à la base</param>
        /// <param name="Password">Mot de passe de l'utilisateur</param>
        public void StartConnectionWithBDD(string IpAdress, string DataBaseName, string UserName, string Password)
        {
            if (IpAdress != "" && DataBaseName != "" && UserName != "")
            {
                string ConnectionAdress = "SERVER=" + IpAdress + "; DATABASE=" + DataBaseName + "; UID=" + UserName + "; PASSWORD=" + Password;
                BDDConnection = new MySqlConnection(ConnectionAdress);

                try
                {
                    //Overture de la connection
                    BDDConnection.Open();
                    this.Status = "Connecter";
                    
                }
                catch (Exception) 
                {
                    this.Status = "Error";
                }
            }
        }
//===============================================================================================================================================//
//==============================================================================================================================================//        

        public void WirteAnswersInDataBase(string SqlParam, List<List<object>> values)
        {
            this.StartConnectionWithBDD(this._IpBdd,this._DataBase,this._User,this._Password);
            SqlToSend = BDDConnection.CreateCommand();

            for (int i = 0; i < values.Count; i++)
            {
                SqlToSend.CommandText = SqlParam + " (@name" + i + ", @isTrue" + i + ", @idQuestion" + i + ")";
                SqlToSend.Parameters.AddWithValue("@name"+i, values[i][0]);
                SqlToSend.Parameters.AddWithValue("@isTrue" + i, values[i][1]);
                SqlToSend.Parameters.AddWithValue("@idQuestion" + i, values[i][2]);
                SqlToSend.ExecuteNonQuery();
            }
            
            BDDConnection.Close();
        }

        public int WriteQuestionInDataBase(string SqlParam, List<object> values)
        {
            this.StartConnectionWithBDD(this._IpBdd, this._DataBase, this._User, this._Password);
            SqlToSend = BDDConnection.CreateCommand();

            for (int i = 0; i < values.Count; i++)
            {
                SqlToSend.CommandText = SqlParam+" (@name"+i+")";
                SqlToSend.Parameters.AddWithValue("@name"+i, values[i]);
                SqlToSend.ExecuteNonQuery();
            }

            long a = SqlToSend.LastInsertedId;

            BDDConnection.Close();

            return (int)a;
        }
//===============================================================================================================================================//
//==============================================================================================================================================// 
        public List<List<object>> ReadAnswersInDataBase(string sql)
        {
            List<List<object>> e = new List<List<object>>();

            this.StartConnectionWithBDD(this._IpBdd, this._DataBase, this._User, this._Password);

            SqlToSend = new MySqlCommand(sql, BDDConnection);
            //
            SqlToSend.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, BDDConnection);
            sda.Fill(dt);

            //byte[] bits = new byte[0];

            foreach (DataRow item in dt.Rows)
            {
                List<object> heu = new List<object>();
                foreach (object item2 in item.ItemArray)
                {
                    heu.Add(item2);
                }
                e.Add(heu);
            }

            //bits = (byte[])dt.Rows[6][0];

            //MemoryStream ms = new MemoryStream(bits,23,bits.Length - 23);

            //Image a = Bitmap.FromStream(ms);
            //e.Add(bits);

            return e;
        }
//===============================================================================================================================================//
//==============================================================================================================================================// 
        public List<List<string>> GetTextData(string query)
        {
            this.StartConnectionWithBDD(this._IpBdd, this._DataBase, this._User, this._Password);

            List<List<string>> listUserScore = new List<List<string>>();

            if(query != "" && query != null)
            {
                SqlToSend = BDDConnection.CreateCommand();
                SqlToSend.CommandText = query;
                ReadBdd = SqlToSend.ExecuteReader();

                while (ReadBdd.Read())
                {
                    List<string> a = new List<string>();                    

                    for (int i = 0; i < ReadBdd.FieldCount/*compte les colones (les champs)*/; i++)
                    {
                        a.Add(ReadBdd[i].ToString());
                    }
                    listUserScore.Add(a);
                }
            }
            BDDConnection.Close();

            return listUserScore;
            
        }


    }
}
