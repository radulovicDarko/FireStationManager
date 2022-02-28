using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using Vatrogasna_stanica.Models;


namespace Vatrogasna_stanica.Repos
{
    class VoziloRepo
    {
        private readonly OracleConnection con;
        private OracleDataAdapter oracleDataAdapter;
        private string command { get; set; }

        public VoziloRepo()
        {
            con = new OracleConnection(Constants.connectionString);
        }

        public List<Vozilo> GetVozila()
        {
            OracleConnection con = new OracleConnection(Constants.connectionString);

            command = "SELECT * FROM Vozila";

            con.Open();

            oracleDataAdapter = new OracleDataAdapter(command, con);

            DataSet dataSet = new DataSet();
            oracleDataAdapter.Fill(dataSet);

            List<Vozilo> vozila = new List<Vozilo>();

            foreach (DataRow dr in dataSet.Tables[0].Rows)
            {
                vozila.Add(new Vozilo { registarskiBroj = Convert.ToString(dr["registarskiBroj"]), marka = Convert.ToString(dr["marka"]), tipVozila = Convert.ToString(dr["tipVozila"]) });
            }

            con.Close();

            return vozila;
        }

        public bool InsertVozilo(Vozilo v)
        {
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Vozila(registarskiBroj, marka, tipVozila)" +
                "VALUES (:pregistarskiBroj, :pmarka, :ptipVozila)";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(":pregistarskiBroj", OracleDbType.NVarchar2, 7, v.registarskiBroj, ParameterDirection.Input);
            cmd.Parameters.Add(":pmarka", OracleDbType.NVarchar2, 15, v.marka, ParameterDirection.Input);
            cmd.Parameters.Add(":ptipVozila", OracleDbType.NVarchar2, 20, v.tipVozila, ParameterDirection.Input);

            int count = cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            if (count > 0)
                return true;
            return false;
        }

        public bool DeleteVozilo(string registarskiBrojVozila)
        {
            con.Open();
            command = "DELETE FROM Vozila WHERE registarskiBroj = :pregistarskiBrojVozila";
            OracleCommand cmd = new OracleCommand(command, con);


            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(":registarskiBrojVozila", OracleDbType.NVarchar2, 7, registarskiBrojVozila, ParameterDirection.Input);

            int count = cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            if (count > 0)
                return true;
            return false;
        }
        public bool UpdateVozilo(Vozilo v, string registarskiBrojVozila)
        {
            con.Open();

            command = "UPDATE Vozila SET registarskiBroj = :pregistarskiBrojVozila, marka = :pmarka, tipVozila = :ptipVozila WHERE registarskiBroj = :pregistarskiBrojVozilaa";
            OracleCommand cmd = new OracleCommand(command, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(":pregistarskiBrojVozila", OracleDbType.NVarchar2, 13, v.registarskiBroj, ParameterDirection.Input);
            cmd.Parameters.Add(":pmarka", OracleDbType.NVarchar2, 15, v.marka, ParameterDirection.Input);
            cmd.Parameters.Add(":ptipVozila", OracleDbType.NVarchar2, 20, v.tipVozila, ParameterDirection.Input);
            cmd.Parameters.Add(":pregistarskiBrojVozilaa", OracleDbType.NVarchar2, 20, registarskiBrojVozila, ParameterDirection.Input);

            int count = cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            if (count > 0)
                return true;
            return false;
        }
    }
}
