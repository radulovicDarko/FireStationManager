using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using Vatrogasna_stanica.Models;

namespace Vatrogasna_stanica.Repos
{
    internal class DogadjajRepo
    {
        private readonly OracleConnection con;
        private OracleDataAdapter oracleDataAdapter;
        private string command { get; set; }

        public DogadjajRepo()
        {
            con = new OracleConnection(Constants.connectionString);
            oracleDataAdapter = new OracleDataAdapter();
        }
        public List<Dogadjaj> GetDogadjaji()
        {
            OracleConnection con = new OracleConnection(Constants.connectionString);

            command = "SELECT * FROM Dogadjaji";

            con.Open();

            oracleDataAdapter = new OracleDataAdapter(command, con);

            DataSet dataSet = new DataSet();
            oracleDataAdapter.Fill(dataSet);

            List<Dogadjaj> dogadjaji = new List<Dogadjaj>();

            foreach (DataRow dr in dataSet.Tables[0].Rows)
            {
                dogadjaji.Add(new Dogadjaj { sifra = Convert.ToInt32(dr["sifra"]), opis = Convert.ToString(dr["opis"]), mesto = Convert.ToString(dr["mesto"]), adresa = Convert.ToString(dr["adresa"]), velicina = Convert.ToString(dr["velicina"]), ugrozenostLjudiDogadjaja = Convert.ToString(dr["ugrozenostLjudiDogadjaja"]) });
            }

            con.Close();

            return dogadjaji;
        }

        public bool InsertDogadjaj(Dogadjaj d)
        {
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Dogadjaji(sifra, opis, mesto, adresa, velicina, ugrozenostLjudiDogadjaja)" +
                "VALUES (:psifra, :popis, :pmesto, :padresa, :pvelicina, :pugrozenost)";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(":psifra", OracleDbType.Int32, 3, d.sifra, ParameterDirection.Input);
            cmd.Parameters.Add(":popis", OracleDbType.NVarchar2, 100, d.opis, ParameterDirection.Input);
            cmd.Parameters.Add(":pmesto", OracleDbType.NVarchar2, 25, d.mesto, ParameterDirection.Input);
            cmd.Parameters.Add(":padresa", OracleDbType.NVarchar2, 30, d.adresa, ParameterDirection.Input);
            cmd.Parameters.Add(":pvelicina", OracleDbType.NVarchar2, 15, d.velicina, ParameterDirection.Input);
            cmd.Parameters.Add(":pugrozenost", OracleDbType.NVarchar2, 40, d.ugrozenostLjudiDogadjaja, ParameterDirection.Input);

            int count = cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            if (count > 0)
                return true;
            return false;
        }

        public bool DeleteDogadjaj(int sifra)
        {
            con.Open();
            command = "DELETE FROM Dogadjaji WHERE sifra = :psifraDogadjaja";
            OracleCommand cmd = new OracleCommand(command, con);


            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(":psifraDogadjaja", OracleDbType.Int32, 3, sifra, ParameterDirection.Input);

            int count = cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            if (count > 0)
                return true;
            return false;
        }
        public bool UpdateDogadjaj(Dogadjaj d, string sifra)
        {
            con.Open();

            command = "UPDATE Dogadjaji SET sifra = :psifra, opis = :popis, mesto = :pmesto, adresa = :padresa, velicina = :pvelicina, ugrozenostLjudiDogadjaja = :pugrozenost WHERE sifra = :psifraDogadjaja";
            OracleCommand cmd = new OracleCommand(command, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(":psifra", OracleDbType.Int32, 3, d.sifra, ParameterDirection.Input);
            cmd.Parameters.Add(":popis", OracleDbType.NVarchar2, 100, d.opis, ParameterDirection.Input);
            cmd.Parameters.Add(":pmesto", OracleDbType.NVarchar2, 25, d.mesto, ParameterDirection.Input);
            cmd.Parameters.Add(":padresa", OracleDbType.NVarchar2, 30, d.adresa, ParameterDirection.Input);
            cmd.Parameters.Add(":pvelicina", OracleDbType.NVarchar2, 15, d.velicina, ParameterDirection.Input);
            cmd.Parameters.Add(":pugrozenost", OracleDbType.NVarchar2, 40, d.ugrozenostLjudiDogadjaja, ParameterDirection.Input);
            cmd.Parameters.Add(":psifraDogadjaja", OracleDbType.Int32, 3, sifra, ParameterDirection.Input);

            int count = cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            if (count > 0)
                return true;
            return false;
        }
    }
}
