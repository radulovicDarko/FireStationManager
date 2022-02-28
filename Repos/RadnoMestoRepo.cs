using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using Vatrogasna_stanica.Models;

namespace Vatrogasna_stanica.Repos
{
    internal class RadnoMestoRepo
    {
        private string command { get; set; }
        public List<RadnoMesto> GetRadnaMesta()
        {
            OracleConnection con = new OracleConnection(Constants.connectionString);

            command = "SELECT * FROM RadnaMesta";

            con.Open();

            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(command, con);

            DataSet dataSet = new DataSet();
            oracleDataAdapter.Fill(dataSet);

            List<RadnoMesto> radnaMesta = new List<RadnoMesto>();

            foreach (DataRow dr in dataSet.Tables[0].Rows)
            {
                radnaMesta.Add(new RadnoMesto { sifra = Convert.ToInt32(dr["sifra"]), naziv = Convert.ToString(dr["naziv"]) });
            }

            con.Close();

            return radnaMesta;
        }
    }
}
