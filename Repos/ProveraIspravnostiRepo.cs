using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Vatrogasna_stanica.Models;

namespace Vatrogasna_stanica.Repos
{
    internal class ProveraIspravnostiRepo
    {
        private readonly OracleConnection con;
        private OracleDataAdapter oracleDataAdapter;
        private readonly RadnikRepo radnikRepo;
        private readonly OpremaRepo opremaRepo;
        private string command { get; set; }

        public ProveraIspravnostiRepo()
        {
            con = new OracleConnection(Constants.connectionString);
            radnikRepo = new RadnikRepo();
            opremaRepo = new OpremaRepo();
        }

        public List<ProveraIspravnosti> GetProvereIspravnosti()
        {
            command = "SELECT evidencijskiBroj, datumKontrolisanja, ocenaIspravnosti, fabrickiBroj, jmbgRadnika, NVL(datumIstekaKontrole, '01-JAN-99') datumIstekaKontrole FROM ProvereIspravnosti";

            con.Open();

            oracleDataAdapter = new OracleDataAdapter(command, con);

            DataSet dataSet = new DataSet();
            oracleDataAdapter.Fill(dataSet);

            List<ProveraIspravnosti> provereIspravnosti = new List<ProveraIspravnosti>();

            foreach (DataRow dr in dataSet.Tables[0].Rows)
            {
                provereIspravnosti.Add(new ProveraIspravnosti { evidencijskiBroj = Convert.ToInt32(dr["evidencijskiBroj"]), datumKontrolisanja = Convert.ToDateTime(dr["datumKontrolisanja"]), ocenaIspravnosti = Convert.ToString(dr["ocenaIspravnosti"]), fabrickiBroj = Convert.ToString(dr["fabrickiBroj"]), jmbgRadnika = Convert.ToString(dr["jmbgRadnika"]), datumIstekaKontrole = Convert.ToDateTime(dr["datumIstekaKontrole"]) });
            }

            con.Close();

            return provereIspravnosti;
        }

        public bool InsertProveraIspravnosti(ProveraIspravnosti proveraIspravnosti)
        {
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO provereIspravnosti(evidencijskiBroj, datumKontrolisanja, ocenaIspravnosti, fabrickiBroj, jmbgRadnika)" +
                "VALUES (:pevidencijskiBroj, :pdatumKontrolisanja, :pocenaIspravnosti, :pfabrickiBroj, :pjmbgRadnika)";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(":pevidencijskiBroj", OracleDbType.Int32, 5, proveraIspravnosti.evidencijskiBroj, ParameterDirection.Input);
            cmd.Parameters.Add(":pdatumKontrolisanja", OracleDbType.Date, proveraIspravnosti.datumKontrolisanja, ParameterDirection.Input);
            cmd.Parameters.Add(":pocenaIspravnosti", OracleDbType.NVarchar2, 10, proveraIspravnosti.ocenaIspravnosti, ParameterDirection.Input);
            cmd.Parameters.Add(":pfabrickiBroj", OracleDbType.NVarchar2, 10, proveraIspravnosti.fabrickiBroj, ParameterDirection.Input);
            cmd.Parameters.Add(":pjmbgRadnika", OracleDbType.NVarchar2, 13, proveraIspravnosti.jmbgRadnika, ParameterDirection.Input);

            int count = cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            if (count > 0)
                return true;
            return false;
        }

        public bool DeleteProveraIspravnosti(int evidencijskiBrojProvere)
        {
            con.Open();
            command = "DELETE FROM ProvereIspravnosti WHERE evidencijskiBroj = :pevidencijskiBrojProvere";
            OracleCommand cmd = new OracleCommand(command, con);


            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(":pevidencijskiBrojProvere", OracleDbType.Int32, 5, evidencijskiBrojProvere, ParameterDirection.Input);

            int count = cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            if (count > 0)
                return true;
            return false;
        }
        public bool UpdateProveraIspravnosti(ProveraIspravnosti proveraIspravnosti, int evidBrojProvere)
        {
            con.Open();

            command = "UPDATE provereIspravnosti SET evidencijskiBroj = :pevidencijskiBroj, datumKontrolisanja = :pdatumKontrolisanja, ocenaIspravnosti = :pocenaIspravnosti, fabrickiBroj = :pfabrickiBroj, jmbgRadnika = :pjmbgRadnika WHERE evidencijskiBroj = :pevidencijskiBrojProvere";
            OracleCommand cmd = new OracleCommand(command, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(":pevidencijskiBroj", OracleDbType.Int32, 5, proveraIspravnosti.evidencijskiBroj, ParameterDirection.Input);
            cmd.Parameters.Add(":pdatumKontrolisanja", OracleDbType.Date, proveraIspravnosti.datumKontrolisanja, ParameterDirection.Input);
            cmd.Parameters.Add(":pocenaIspravnosti", OracleDbType.NVarchar2, 10, proveraIspravnosti.ocenaIspravnosti, ParameterDirection.Input);
            cmd.Parameters.Add(":pfabrickiBroj", OracleDbType.NVarchar2, 10, proveraIspravnosti.fabrickiBroj, ParameterDirection.Input);
            cmd.Parameters.Add(":jmbgRadnika", OracleDbType.NVarchar2, 13, proveraIspravnosti.jmbgRadnika, ParameterDirection.Input);
            cmd.Parameters.Add(":pevidencijskiBrojProvere", OracleDbType.Int32, 5, evidBrojProvere, ParameterDirection.Input);

            int count = cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            if (count > 0)
                return true;
            return false;
        }
    }
}
