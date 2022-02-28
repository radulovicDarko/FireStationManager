using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Vatrogasna_stanica.Models;

namespace Vatrogasna_stanica.Repos
{
    internal class RadnikRepo
    {
        private readonly OracleConnection con;
        private OracleDataAdapter oracleDataAdapter;
        private readonly RadnoMestoRepo radnoMestoRepo;
        private string command { get; set; }
        public RadnikRepo()
        {
            con = new OracleConnection(Constants.connectionString);
            radnoMestoRepo = new RadnoMestoRepo();
        }
     
        public List<Radnik> GetRadnici()
        {
            command = "SELECT * FROM Radnici";
           
            con.Open();

            oracleDataAdapter = new OracleDataAdapter(command, con);

            DataSet dataSet = new DataSet();
            oracleDataAdapter.Fill(dataSet);

            List<Radnik> radnici = new List<Radnik>();

            foreach (DataRow dr in dataSet.Tables[0].Rows)
            {
                radnici.Add(new Radnik {ime = Convert.ToString(dr["ime"]), prezime = Convert.ToString(dr["prezime"]), jmbg = Convert.ToString(dr["jmbg"]), adresa = Convert.ToString(dr["adresa"]), telefon = Convert.ToString(dr["telefon"]), sifraRadnogMesta = Convert.ToInt32(dr["sifraRadnogMesta"]), nazivRadnogMesta = Convert.ToString(dr["nazivRadnogMesta"]) });
            }

            con.Close();

            return radnici;
        }

        public bool InsertRadnik(Radnik r)
        {
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Radnici(jmbg, ime, prezime, adresa, telefon, sifraRadnogMesta, nazivRadnogMesta)" +
                "VALUES (:pjmbg, :pime, :pprezime, :padresa, :ptelefon, :psifraRadnogMesta, :pnazivRadnogMesta)";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(":pjmbg", OracleDbType.NVarchar2, 13, r.jmbg, ParameterDirection.Input);
            cmd.Parameters.Add(":pime", OracleDbType.NVarchar2, 15, r.ime, ParameterDirection.Input);
            cmd.Parameters.Add(":pprezime", OracleDbType.NVarchar2, 20, r.prezime, ParameterDirection.Input);
            cmd.Parameters.Add(":padresa", OracleDbType.NVarchar2, 30, r.adresa, ParameterDirection.Input);
            cmd.Parameters.Add(":ptelefon", OracleDbType.NVarchar2, 15, r.telefon, ParameterDirection.Input);
            cmd.Parameters.Add(":psifraRadnogMesta", OracleDbType.Int32, 2, radnoMestoRepo.GetRadnaMesta().Where(x => x.naziv == r.nazivRadnogMesta).FirstOrDefault().sifra, ParameterDirection.Input);
            cmd.Parameters.Add(":pnazivRadnogMesta", OracleDbType.NVarchar2, 20, "", ParameterDirection.Input);

            int count = cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            
            if ( count > 0)
                return true;
            return false;
        }

        public bool DeleteRadnik(string jmbgRadnika)
        {
            con.Open();
            command = "DELETE FROM Radnici WHERE jmbg = :pjmbgRadnika";
            OracleCommand cmd = new OracleCommand(command,con);
            

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(":pjmbgRadnika", OracleDbType.NVarchar2, 13, jmbgRadnika, ParameterDirection.Input);

            int count = cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            if (count > 0)
                return true;
            return false;
        }
        public bool UpdateRadnik(Radnik r, string jmbgRadnika)
        {
            con.Open();

            command = "UPDATE Radnici SET jmbg = :pjmbg, ime = :pime, prezime = :pprezime, adresa = :padresa, telefon = :ptelefon, sifraRadnogMesta = :psifraRadnogMesta WHERE jmbg = :pjmbgRadnika";
            OracleCommand cmd = new OracleCommand(command, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(":pjmbg", OracleDbType.NVarchar2, 13, r.jmbg, ParameterDirection.Input);
            cmd.Parameters.Add(":pime", OracleDbType.NVarchar2, 15, r.ime, ParameterDirection.Input);
            cmd.Parameters.Add(":pprezime", OracleDbType.NVarchar2, 20, r.prezime, ParameterDirection.Input);
            cmd.Parameters.Add(":padresa", OracleDbType.NVarchar2, 30, r.adresa, ParameterDirection.Input);
            cmd.Parameters.Add(":ptelefon", OracleDbType.NVarchar2, 15, r.telefon, ParameterDirection.Input);
            cmd.Parameters.Add(":psifraRadnogMesta", OracleDbType.Int32, 2, radnoMestoRepo.GetRadnaMesta().Where(x => x.naziv == r.nazivRadnogMesta).FirstOrDefault().sifra, ParameterDirection.Input);
            cmd.Parameters.Add(":pjmbgRadnika", OracleDbType.NVarchar2, 13, jmbgRadnika, ParameterDirection.Input);

            int count = cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            if (count > 0)
                return true;
            return false;
        }
    }
}
