using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using Vatrogasna_stanica.Models;

namespace Vatrogasna_stanica.Repos
{
    class UpucivanjeLjudstvaVozilaRepo
    {
        private string command { get; set; }
        public List<UpucivanjeLjudstvaVozila> GetUpucivanjeLjudstvaVozila()
        {
            OracleConnection con = new OracleConnection(Constants.connectionString);

            command = "SELECT * FROM UpucivanjeLjudstvaVozila";

            con.Open();

            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(command, con);

            DataSet dataSet = new DataSet();
            oracleDataAdapter.Fill(dataSet);

            List<UpucivanjeLjudstvaVozila> upucivanjeLjudstvaVozila = new List<UpucivanjeLjudstvaVozila>();

            foreach (DataRow dr in dataSet.Tables[0].Rows)
            {
                upucivanjeLjudstvaVozila.Add(new UpucivanjeLjudstvaVozila { datumUpucivanja = Convert.ToDateTime(dr["datumUpucivanja"]), vremeIzlaska = Convert.ToString(dr["vremeIzlaska"]), opis = Convert.ToString(dr["opis"]), vremeStizanja = Convert.ToString(dr["vremeStizanja"]), vremeLikvidacije = Convert.ToString(dr["vremeStizanja"]), vremeLokalizacije = Convert.ToString(dr["vremeLokalizacije"]), registarskiBrojVozila = Convert.ToString(dr["registarskiBrojVozila"]), jmbgRadnika = Convert.ToString(dr["jmbgRadnika"]), sifraDogadjaja = Convert.ToString(dr["sifraDogadjaja"]) });
            }

            return upucivanjeLjudstvaVozila;
        }
    }
}
