using BusWay.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusWay.Repositories
{
    public class VoznaLinijaRepozitorij
    {
        public static List<VoznaLinija> GetVozneLinije(DateTime datum)
        {
            List<VoznaLinija> vozneLinije = new List<VoznaLinija>();

            string formattedDate = datum.ToString("yyyy-MM-dd");
            string sql = $"SELECT * FROM VoznaLinija WHERE Datum = '{formattedDate}'";
            Console.WriteLine(formattedDate);
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                VoznaLinija voznaLinija = CreateObject(reader);
                vozneLinije.Add(voznaLinija);
            }
            reader.Close();
            DB.CloseConnection();
            return vozneLinije;
        }

        public static void AddVoznaLinija(VoznaLinija voznaLinija)
        {
            string imeLinije = voznaLinija.ImeLinije.Replace("'", "''");
            string polaziste = voznaLinija.Polaziste.Replace("'", "''");
            string dolaziste = voznaLinija.Dolaziste.Replace("'", "''");
            string datum = voznaLinija.Datum.ToString("yyyy-MM-dd");

            string sql = $"INSERT INTO VoznaLinija (ImeLinije, Polaziste, Dolaziste, Datum) " +
                         $"VALUES ('{imeLinije}', '{polaziste}', '{dolaziste}', '{datum}'); " +
                         "SELECT CAST(scope_identity() AS int);";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void DeleteVoznaLinija(VoznaLinija voznaLinija)
        {
            string sql = $"DELETE FROM VoznaLinija WHERE Id = {voznaLinija.Id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateVoznaLinija(VoznaLinija novaVoznaLinija)
        {
            string imeLinije = novaVoznaLinija.ImeLinije.Replace("'", "''");
            string polaziste = novaVoznaLinija.Polaziste.Replace("'", "''");
            string dolaziste = novaVoznaLinija.Dolaziste.Replace("'", "''");
            string datum = novaVoznaLinija.Datum.ToString("yyyy-MM-dd");

            string sql = $"UPDATE VoznaLinija SET ImeLinije = '{imeLinije}', " +
                         $"Polaziste = '{polaziste}', Dolaziste = '{dolaziste}', " +
                         $"Datum = '{datum}' WHERE Id = {novaVoznaLinija.Id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }




        private static VoznaLinija CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string imeLinije = reader["ImeLinije"].ToString();
            string polaziste = reader["Polaziste"].ToString();
            string dolaziste = reader["Dolaziste"].ToString();
            DateTime datum = (DateTime)reader["Datum"];

            var voznaLinija = new VoznaLinija
            {
                Id = id,
                ImeLinije = imeLinije,
                Polaziste = polaziste,
                Dolaziste = dolaziste,
                Datum = datum
            };
            return voznaLinija;
        }
    }
}
