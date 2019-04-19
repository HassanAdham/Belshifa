using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Belshifa2.presenter;

namespace Belshifa2.model
{
    class SystemDatabase
    {
        private string ordb;
        private OracleConnection conn;
        private OracleCommand cmd;
        private Contractor.PatientPresenterContractor patientPresenterInstance;

        public SystemDatabase(Contractor.PatientPresenterContractor patientPresenterInstance)
        {
            this.patientPresenterInstance = patientPresenterInstance;

            ordb = "Data source = orcl;user id=scott; password = tiger";
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        public void signIn(string username, string password, bool type)// 0 for patient 1 for pharm
        {
            if(type == false)
            {
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "CHECKPATIENT";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("Email", username);
                cmd.Parameters.Add("Password", OracleDbType.Varchar2, System.Data.ParameterDirection.Output);
                cmd.ExecuteNonQuery();

                try
                {
                    if (password == cmd.Parameters["outputParameter"].Value.ToString())
                    {
                        patientPresenterInstance.modelRespone("Account is Verified");
                    }
                    else
                    {
                        patientPresenterInstance.modelRespone("Something is wrong check your username or password");
                    }
                }
                catch
                {
                    patientPresenterInstance.modelRespone("Error connecting to the database");
                }
            }
            else if(type == true)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "CheckPharmacist";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("Email", username);
                cmd.Parameters.Add("Password", OracleDbType.Varchar2, System.Data.ParameterDirection.Output);
                cmd.ExecuteNonQuery();

                if (password == cmd.Parameters["outputParameter"].Value.ToString())
                {
                    patientPresenterInstance.modelRespone("Account is Verified");
                }
                else
                {
                    patientPresenterInstance.modelRespone("Something is wrong please Check your username or password");
                }
            }
           
        }

        public void signUp(Object person, bool type) // 0 for patient 1 for pharm.
        {
            throw new NotImplementedException();
        }

        public void getProfile(int id, bool type) // 0 for patient 1 for pharm.
        {
            throw new NotImplementedException();
        }


        public void getOrderHistory(int id) // for patient.
        {
            throw new NotImplementedException();
        }

        public void getPatientPendingOrders(int id)
        {
            throw new NotImplementedException();
        }

        public void getPharmacistPendingOrders(int id)
        {
            throw new NotImplementedException();
        }

        public void getMedicines(int sec_id)
        {

        }

        public void getSections()
        {

        }
    }
}
