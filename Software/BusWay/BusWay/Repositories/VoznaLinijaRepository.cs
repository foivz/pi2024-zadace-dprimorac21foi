using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusWay.Models;
using DBLayer;

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

        public static List<VoznaLinija> GetVoznaLinija()
        {
            List<VoznaLinija> vozneLinije = new List<VoznaLinija>();

            string sql = "SELECT * FROM VoznaLinija";
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

        private static VoznaLinija CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string odrediste = reader["Odrediste"].ToString();
            string polaziste = reader["Polaziste"].ToString();
            DateTime vrijemePolaska = DateTime.Parse(reader["VrijemePolaska"].ToString());
            DateTime vrijemeDolaska = DateTime.Parse(reader["VrijemeDolaska"].ToString());

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

    }
}
