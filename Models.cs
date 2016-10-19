using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Projet_Quizz
{
    class Models
    {

        MySqlConnection BDDConnection;
        MySqlCommand SqlToSend;
        MySqlDataReader ReadBdd;
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
                }
                catch (Exception ex) { /*return ex.Message;*/ }
            }
        }

//===============================================================================================================================================//
//==============================================================================================================================================//

        /// <summary>
        /// Cette methode envoie une commande Sql à la base et nous retourne le résultat de la commande dans une liste.
        /// !!!!! Ne pas Metre de " ' ou ` !!!!!
        /// La bonne syntaxe est : SELECT Prenom, id FROM table
        /// </summary>
        /// <param name="Sql">La commande sql</param>
        /// <returns>Retourne une liste qvec le resultat de la requette</returns>
        public List<string> ReadDataBase(string Sql)
        {            
            List<string> lst = new List<string>();//Création de la liste qui sera renvoyer
            List<string> Entete = new List<string>();//Création de la liste qui contien tout les éléments que la commande sql va renvoyer

            char[] Delimiteurs = { ' ', ',' };//Tableau de delimiteur
            string[] Mots = Sql.Split(Delimiteurs);//Tableau avec la commande sql

            //Création de la liste qui contien uniquement le nom de la colonne
            foreach (string Col in Mots)
            {
                if (Col != "" && Col != "from" && Col != "FROM"
                    && Col != "SELECT" && Col != "select")
                {
                    Entete.Add(Col);
                }
                else if (Col == "FROM" || Col == "from")
                {
                    break;
                }
            }

            if (Sql != "" && Sql != null)
            {
                SqlToSend = BDDConnection.CreateCommand();
                SqlToSend.CommandText = Sql;
                ReadBdd = SqlToSend.ExecuteReader();

                while (ReadBdd.Read())
                {
                    foreach (string elem in Entete)
                    {
                        lst.Add(ReadBdd[elem].ToString());
                    }
                }
            }
            return lst;
        }

//==============================================================================================================================//
//=============================================================================================================================//

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Sql"></param>
        /// Veuillez écrire la requetes dans se style : INSERT INTO projets(NomProjet,idProjet) VALUES(@Prenom,@1)
        /// !!!!!!ATTENTION A NE PAS METTRE D'ESPACE APRES LES VIRGULES!!!!!!
        public void WriteDataBase(string Sql, List<string> ListValeurs)
        {
            string Entete;//Création du string qui contien tout les éléments valeur variable (@Elem1) que la commande sql va envoyer
            List<string> Values = new List<string>();

            char[] Delimiteurs = { ' ' };//Tableau de delimiteur
            string[] Mots = Sql.Split(Delimiteurs);//Tableau avec la commande sql

            Entete = Mots[3];

            char[] Delimiteurs2 = { '(', ')', ',' };
            string[] Vals = Entete.Split(Delimiteurs2);

            //Création de la liste qui contien uniquement le nom des valeurs variables
            foreach (string col in Vals)
            {
                if (col.StartsWith("@"))
                {
                    Values.Add(col);
                }
            }

            if (Sql != "" && Sql != null)
            {
                SqlToSend = BDDConnection.CreateCommand();
                SqlToSend.CommandText = Sql;
                for (int i = 0; i < Values.Count(); i++)
                {
                    SqlToSend.Parameters.AddWithValue(Values[i], ListValeurs[i]);
                }
                SqlToSend.ExecuteNonQuery();
            }
        }
    }
}
