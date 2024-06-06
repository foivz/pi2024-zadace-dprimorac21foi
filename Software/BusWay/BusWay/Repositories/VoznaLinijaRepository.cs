using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusWay.Models;
using DBLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BusWay.Repositories
{
    public class VoznaLinijaRepository
    {
        public static VoznaLinija GetVoznaLinija(int id)
        {
            VoznaLinija voznaLinija = null;
            string sql = $"SELECT * FROM VoznaLinija WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                voznaLinija = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return voznaLinija;
        }

        public static List<VoznaLinija> GetVozneLinije()
        {
            List<VoznaLinija> vozneLinije = new List<VoznaLinija>();

            string sql = $"SELECT * FROM VozneLinije";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                VoznaLinija vozLinija = CreateObject(reader);
                vozneLinije.Add(vozLinija);
            }
            reader.Close();
            DB.CloseConnection();
            return vozneLinije;

        }

        public static VoznaLinija CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string odrediste = reader["Odrediste"].ToString();
            string polaziste = reader["Polaziste"].ToString();
            string vrijemePolaska = reader["VrijemePolaska"].ToString();
            string vrijemeDolaska = reader["VrijemeDolaska"].ToString();

            var voznalinija = new VoznaLinija
            {
                Id = id,
                Odrediste = odrediste,
                Polaziste = polaziste,
                VrijemePolaska = vrijemePolaska,
                VrijemeDolaska = vrijemeDolaska
            };
            return voznalinija;
            
        }

        public static void KreirajVoznuLiniju (VoznaLinija linija)
        {
            string sql = $"INSERT INTO VozneLinije (Id, Odrediste, Polaziste, VrijemePolaska, VrijemeDolaska) VALUES ({linija.Id}, '{linija.Odrediste}', '{linija.Polaziste}', '{linija.VrijemePolaska}', '{linija.VrijemePolaska}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void ObrisiVoznuLiniju(VoznaLinija linija)
        {
            string sql = $"DELETE FROM VozneLinije WHERE Id = {linija.Id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

        }

        public static List<VoznaLinija> GetVoznaLinijaPolaziste(string polaziste)
        {
            List<VoznaLinija> vozneLinijePolaziste = new List<VoznaLinija>();

            string sql = $"SELECT * FROM VozneLinije WHERE Polaziste = '{polaziste}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                VoznaLinija vozLinija = CreateObject(reader);
                vozneLinijePolaziste.Add(vozLinija);
            }
            reader.Close();
            DB.CloseConnection();
            return vozneLinijePolaziste;
        }

        public static void AzurirajVoznuLiniju(VoznaLinija linija)
        {
            int id = linija.Id;
            string odrediste = linija.Odrediste;
            string polaziste = linija.Polaziste;
            string vrijemePolaska = linija.VrijemePolaska;
            string vrijemDolaska = linija.VrijemeDolaska;

            string sql = $"UPDATE VozneLinije SET Odrediste = '{odrediste}', Polaziste = '{polaziste}', " +
                $"VrijemePolaska = '{vrijemePolaska}', VrijemeDolaska = '{vrijemDolaska}' WHERE Id={id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static List<string> GetUniquePolazista()
        {
            List<string> uniquePolazista = new List<string>();

            string sql = $"SELECT DISTINCT Polaziste FROM VozneLinije";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                string polaziste = reader["Polaziste"].ToString();
                uniquePolazista.Add(polaziste);
            }
            reader.Close();
            DB.CloseConnection();
            return uniquePolazista;
        }
    }
}
