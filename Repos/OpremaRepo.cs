using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using Vatrogasna_stanica.Models;

namespace Vatrogasna_stanica.Repos
{
    internal class OpremaRepo
    {
        private OracleConnection con;
        private OracleDataAdapter oracleDataAdapter;
        private readonly TipOpremeRepo tipOpremeRepo;
        private string command { get; set; }

        public OpremaRepo()
        {
            con = new OracleConnection(Constants.connectionString);
            tipOpremeRepo = new TipOpremeRepo();
        }
        public List<Oprema> GetOprema()
        {

            command = "SELECT * FROM Oprema";

            con.Open();

            oracleDataAdapter = new OracleDataAdapter(command, con);

            DataSet dataSet = new DataSet();
            oracleDataAdapter.Fill(dataSet);

            List<Oprema> oprema = new List<Oprema>();

            foreach (DataRow dr in dataSet.Tables[0].Rows)
            {
                oprema.Add(new Oprema { fabrickiBroj = Convert.ToString(dr["fabrickiBroj"]), masa = Convert.ToInt32(dr["masa"]), datumProizvodnje = Convert.ToDateTime(dr["datumProizvodnje"]), nazivProizvodjaca = Convert.ToString(dr["nazivProizvodjaca"]), sifraOpreme = Convert.ToInt32(dr["sifraOpreme"]) });
            }

            con.Close();

            return oprema;
        }

        public bool InsertOprema(Oprema o)
        {
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Oprema(fabrickiBroj, masa, datumProizvodnje, nazivProizvodjaca, sifraOpreme)" +
                "VALUES (:pfabrickiBroj, :pmasa, :pdatumProizvodnje, :pnazivProizvodjaca, :psifraOpreme)";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(":pfabrickiBroj", OracleDbType.NVarchar2, 10, o.fabrickiBroj, ParameterDirection.Input);
            cmd.Parameters.Add(":pmasa", OracleDbType.Int32, 5, o.masa, ParameterDirection.Input);
            cmd.Parameters.Add(":pdatumProizvodnje", OracleDbType.Date, o.datumProizvodnje, ParameterDirection.Input);
            cmd.Parameters.Add(":pnazivProizvodjaca", OracleDbType.NVarchar2, 20, o.nazivProizvodjaca, ParameterDirection.Input);
            cmd.Parameters.Add(":psifraOpreme", OracleDbType.Int32, 3, o.sifraOpreme, ParameterDirection.Input);

            int count = cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            if (count > 0)
                return true;
            return false;
        }

        public bool DeleteOprema(string fabrickiBrojOpreme)
        {
            con.Open();
            command = "DELETE FROM Oprema WHERE fabrickiBroj = :pfabrickiBroj";
            OracleCommand cmd = new OracleCommand(command, con);


            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(":pfabrickiBroj", OracleDbType.NVarchar2, 10, fabrickiBrojOpreme, ParameterDirection.Input);

            int count = cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            if (count > 0)
                return true;
            return false;
        }
        public bool UpdateOprema(Oprema o, string fabrickiBrojOpreme)
        {
            con.Open();

            command = "UPDATE Oprema SET fabrickiBroj = :pfabrickiBroj, masa = :pmasa, datumProizvodnje = :pdatumProizvodnje, nazivProizvodjaca = :pnazivProizvodjaca, sifraOpreme = :psifraOpreme WHERE fabrickiBroj = :pfabrickiBrojOpreme";
            OracleCommand cmd = new OracleCommand(command, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(":pfabrickiBroj", OracleDbType.NVarchar2, 10, o.fabrickiBroj, ParameterDirection.Input);
            cmd.Parameters.Add(":pmasa", OracleDbType.Int32, 5, o.masa, ParameterDirection.Input);
            cmd.Parameters.Add(":pdatumProizvodnje", OracleDbType.Date, o.datumProizvodnje, ParameterDirection.Input);
            cmd.Parameters.Add(":pnazivProizvodjaca", OracleDbType.NVarchar2, 20, o.nazivProizvodjaca, ParameterDirection.Input);
            cmd.Parameters.Add(":psifraOpreme", OracleDbType.Int32, 3, o.sifraOpreme, ParameterDirection.Input);
            cmd.Parameters.Add(":pfabrickiBrojOpreme", OracleDbType.NVarchar2, 10, fabrickiBrojOpreme, ParameterDirection.Input);

            int count = cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            if (count > 0)
                return true;
            return false;
        }
    }
}
