using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using Vatrogasna_stanica.Models;

namespace Vatrogasna_stanica.Repos
{
    class TipVozilaRepo
    {
        private string command { get; set; }
        public List<TipVozila> GetTipoviVozila()
        {
            OracleConnection con = new OracleConnection(Constants.connectionString);

            command = "SELECT * FROM TipoviVozila";

            con.Open();

            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(command, con);

            DataSet dataSet = new DataSet();
            oracleDataAdapter.Fill(dataSet);

            List<TipVozila> tipoviVozila = new List<TipVozila>();

            foreach (DataRow dr in dataSet.Tables[0].Rows)
            {
                tipoviVozila.Add(new TipVozila { naziv = Convert.ToString(dr["naziv"]) });
            }

            con.Close();

            return tipoviVozila;
        }
    }
}
