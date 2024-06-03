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
    public class KorisnikRepozitorij
    {
        public static Korisnik GetKorisnik(string korisnickoIme)
        {
            Korisnik korisnik = null;
            string sql = $"SELECT * FROM Korisnik WHERE KorisnickoIme = '{korisnickoIme}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                korisnik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return korisnik;
        }

        public static List<Korisnik> GetKorisnici()
        {
            List<Korisnik> korisnici = new List<Korisnik>();
            string sql = "SELECT * FROM Korisnik";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Korisnik korisnik = CreateObject(reader);
                korisnici.Add(korisnik);
            }
            reader.Close();
            DB.CloseConnection();
            return korisnici;
        }

        private static Korisnik CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string korisnickoIme = reader["KorisnickoIme"].ToString();
            string lozinka = reader["Lozinka"].ToString();
            var korisnik = new Korisnik
            {
                Id = id,
                KorisnickoIme = korisnickoIme,
                Lozinka = lozinka,
            };
            return korisnik;
        }
    }
}
