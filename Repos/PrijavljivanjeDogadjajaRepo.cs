using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using Vatrogasna_stanica.Models;


namespace Vatrogasna_stanica.Repos
{
    internal class PrijavljivanjeDogadjajaRepo
    {
        private string command { get; set; }
        public List<PrijavljivanjeDogadjaja> GetPrijavljivanjeDogadjaja()
        {
            OracleConnection con = new OracleConnection(Constants.connectionString);

            command = "SELECT * FROM PrijavljivanjeDogadjaja";

            con.Open();

            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(command, con);

            DataSet dataSet = new DataSet();
            oracleDataAdapter.Fill(dataSet);

            List<PrijavljivanjeDogadjaja> prijaveDogadjaja = new List<PrijavljivanjeDogadjaja>();

            foreach (DataRow dr in dataSet.Tables[0].Rows)
            {
                prijaveDogadjaja.Add(new PrijavljivanjeDogadjaja { sifra = Convert.ToInt32(dr["sifra"]), datum = Convert.ToDateTime(dr["datum"]), imePrezimeDojavio = Convert.ToString(dr["imePrezimeDojavio"]), telefonDojavio = Convert.ToString(dr["telefonDojavio"]), napomena = Convert.ToString(dr["napomena"]), jmbgRadnika = Convert.ToString(dr["jmbgRadnika"]), sifraDogadjaja = Convert.ToString(dr["sifraDogadjaja"]) });
            }

            con.Close();

            return prijaveDogadjaja;
        }
    }
}
