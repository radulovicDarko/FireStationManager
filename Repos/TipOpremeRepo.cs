using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using Vatrogasna_stanica.Models;

namespace Vatrogasna_stanica.Repos
{
    internal class TipOpremeRepo
    {
        private string command { get; set; }
        public List<TipOpreme> GetTipoviOpreme()
        {
            OracleConnection con = new OracleConnection(Constants.connectionString);

            command = "SELECT * FROM TipoviOpreme";

            con.Open();

            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(command, con);

            DataSet dataSet = new DataSet();
            oracleDataAdapter.Fill(dataSet);

            List<TipOpreme> tipoviOpreme = new List<TipOpreme>();

            foreach (DataRow dr in dataSet.Tables[0].Rows)
            {
                tipoviOpreme.Add(new TipOpreme { sifra = Convert.ToInt32(dr["sifra"]), naziv = Convert.ToString(dr["naziv"]) });
            }

            con.Close();

            return tipoviOpreme;
        }
    }
}
