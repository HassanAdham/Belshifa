using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Belshifa2.presenter;
using Belshifa2.dataClasses;

namespace Belshifa2.model
{
    class SystemDatabase
    {
        private string ordb;
        private OracleConnection conn;
        private OracleCommand cmd;
        private Contractor.PresenterContractor presenterInstance;

        public SystemDatabase(Contractor.PresenterContractor patientPresenterInstance)
        {
            this.presenterInstance = patientPresenterInstance;

            ordb = "Data source = orcl;user id=hr; password =hr";
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        public void signIn(string username, string password, bool type)
        {
            //Patient
            if (type == false)
            {
                //Step A.2
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select EMAIL , P_PASSWORD from PATIENT where EMAIL = :em and P_PASSWORD = :pass";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("Email", username);
                cmd.Parameters.Add("Password", password);

                
                try
                {
                    OracleDataReader rs = cmd.ExecuteReader();
                    if (rs.Read())
                    {
                        rs.Close();
                        cmd.Dispose();
                        presenterInstance.set_profile(username);
                        presenterInstance.modelResponse("Account is Verified");
                    }
                    else
                    {
                        rs.Close();
                        cmd.Dispose();
                        presenterInstance.modelResponse("Something is wrong check your username or password");
                    }                   
                }
             
                catch
                {
                    cmd.Dispose();
                    presenterInstance.modelErrorMessage("Error connecting to the database");
                }
            }
            //Pharmacist
            else if (type == true)
            {

                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select PH_USERNAME , PH_PASSWORD from PHARMACIST where PH_USERNAME = :em and PH_PASSWORD = :pass";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("Email", username);
                cmd.Parameters.Add("Password", password);
                try
                {
                    OracleDataReader rs = cmd.ExecuteReader();
                    if (rs.Read())
                    {
                        rs.Close();
                        cmd.Dispose();
                        presenterInstance.set_profile(username);
                        presenterInstance.modelResponse("Account is Verified");
                    }
                    else
                    {
                        rs.Close();
                        cmd.Dispose();
                        presenterInstance.modelResponse("Something is wrong check your username or password");
                    }

                }

                catch
                {
                    presenterInstance.modelErrorMessage("Error connecting to the database");
                }
            }
        }

        public void signUp(Object person, bool type)
        {
            cmd = new OracleCommand();
            cmd.Connection = conn;
            //A.3 Insert using CommandType.Text.
            //Patient
            if (!type)
            {
                Patient patient = (Patient)person;
                cmd.CommandText = @"Insert into Patient
                                    values(:email, :p_fname, :p_lname, :address, :phone, :payment, :birthdate, :p_password)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("email", patient.get_email().ToString().ToString());
                cmd.Parameters.Add("p_fname", patient.get_f_name().ToString());
                cmd.Parameters.Add("p_lname", patient.get_l_name().ToString());
                cmd.Parameters.Add("address", patient.get_address().ToString());
                cmd.Parameters.Add("phone", patient.get_phone().ToString());
                cmd.Parameters.Add("payment", patient.get_payment().ToString());
                cmd.Parameters.Add("birthdate", patient.get_birthdate().ToString());
                cmd.Parameters.Add("p_password", patient.get_password().ToString());

                try
                {
                    int numOfRowsAffected = cmd.ExecuteNonQuery();
                    if (numOfRowsAffected == 1)
                        presenterInstance.modelResponse("Account is created successfully!");
                    else
                        presenterInstance.modelResponse("Please make sure of your input!");
                }
                catch
                {
                    presenterInstance.modelErrorMessage("Error connecting to the database");
                }
            }
            //A.6 Insert using Parameterized Procedure.
            //Pharmacist.
            else
            {
                Pharmacist pharmacist = (Pharmacist)person;
                cmd.CommandText = "addPharmacist";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("username", pharmacist.get_username());
                cmd.Parameters.Add("password", pharmacist.get_password());
                cmd.Parameters.Add("id", pharmacist.get_pharmacy_id().ToString());

                try
                {
                    int numOfRowsAffected = cmd.ExecuteNonQuery();
                    if (numOfRowsAffected == 1)
                        presenterInstance.modelResponse("Account is created successfully!");
                    else
                        presenterInstance.modelResponse("Please make sure of your input!");

                }
                catch
                {
                    presenterInstance.modelErrorMessage("Error connecting to the database");
                }
            }
        }

        //A.4 select one row using procedure using out parameters.
        public object getProfile(string key, bool type)
        {
            //Patient.
            if (type == false)
            {
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "GetPatientProfile"; ;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("email", key);
                cmd.Parameters.Add("fname", OracleDbType.Varchar2, 20, 20, System.Data.ParameterDirection.Output);
                cmd.Parameters.Add("lname", OracleDbType.Varchar2, 20, 20, System.Data.ParameterDirection.Output);
                cmd.Parameters.Add("address", OracleDbType.Varchar2, 20, 20, System.Data.ParameterDirection.Output);
                cmd.Parameters.Add("phone", OracleDbType.Int32, System.Data.ParameterDirection.Output);
                cmd.Parameters.Add("payment", OracleDbType.Varchar2, 20, 20, System.Data.ParameterDirection.Output);
                cmd.Parameters.Add("birthdate", OracleDbType.Date, System.Data.ParameterDirection.Output);
                cmd.Parameters.Add("password", OracleDbType.Varchar2, 20, 20, System.Data.ParameterDirection.Output);

                try
                {
                    cmd.ExecuteNonQuery();
                    Patient patient = new Patient(cmd.Parameters["fname"].Value.ToString(),
                                                  cmd.Parameters["lname"].Value.ToString(),
                                                  cmd.Parameters["password"].Value.ToString(),
                                                  cmd.Parameters["address"].Value.ToString(),
                                                  cmd.Parameters["phone"].Value.ToString(),
                                                  cmd.Parameters["email"].Value.ToString(), //equivalent to key.
                                                  cmd.Parameters["payment"].Value.ToString(),
                                                  cmd.Parameters["birthdate"].Value.ToString());
                    cmd.Dispose();
                    return patient;
                }
                catch
                {
                    presenterInstance.modelErrorMessage("Error connecting to the database");
                    return null;
                }

            }
            else
            {
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = " GetPharmacistProfile"; ;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("Email", key);
                cmd.Parameters.Add("password", OracleDbType.Varchar2, 20, 20, System.Data.ParameterDirection.Output);
                cmd.Parameters.Add("pharmacy_id", OracleDbType.Int32, System.Data.ParameterDirection.Output);
                cmd.ExecuteNonQuery();
                try
                {
                    Pharmacist pharmacist = new Pharmacist(cmd.Parameters["Email"].Value.ToString(),
                                                           cmd.Parameters["password"].Value.ToString(),
                                                           int.Parse(cmd.Parameters["pharmacy_id"].Value.ToString()));
                    cmd.Dispose();
                    return pharmacist;
                }
                catch
                {
                    presenterInstance.modelErrorMessage("Error connecting to the database");
                    return null;
                }
            }


        }

        public void getOrderHistory(string key) // for patient.
        {
            throw new NotImplementedException();
        }

        public void getPatientPendingOrders(string key)
        {
            throw new NotImplementedException();
        }

        public void makeOrder(string email, List<int> cart)
        {

        }

        //Step A.5 .. Get Multiple Lines using procedure.
        public void getMedicines(int sec_id)
        {
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetMedicines"; ;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("id", sec_id);
            cmd.Parameters.Add("results", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);
            try
            {
                OracleDataReader rs = cmd.ExecuteReader();
                List<object> medicineList = new List<object>();
                Medicine medicine;
                while (rs.Read())
                {
                    medicine = new Medicine(int.Parse(rs[0].ToString()), rs[1].ToString(), int.Parse(rs[2].ToString()),
                                           float.Parse(rs[3].ToString()), rs[4].ToString(), rs[5].ToString(),
                                           rs[6].ToString(), rs[7].ToString(), rs[8].ToString(), int.Parse(rs[9].ToString()), 
                                           rs[10].ToString());
                    medicineList.Add(medicine);
                }
                rs.Close();

                presenterInstance.sendData(medicineList, "medicine");
            }

            catch
            {
                presenterInstance.modelErrorMessage("Error connecting to the database");
            }
            cmd.Dispose();
        }


        //Step A.1 .. Select Statement Without Where Condition.
        public void getSections()
        {
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Section";
            cmd.CommandType = System.Data.CommandType.Text;
            try
            {
                OracleDataReader rs = cmd.ExecuteReader();
                List<object> sectionsList = new List<object>();
                Section section;
                while (rs.Read())
                {
                    section = new Section(int.Parse(rs[0].ToString()), rs[1].ToString());
                    sectionsList.Add(section);
                }

                rs.Close();
                presenterInstance.sendData(sectionsList, "section");
            }
            catch
            {
                presenterInstance.modelErrorMessage("Error connecting to the database");
            }



        }
    }
}
