﻿using System;
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
                //Step A.4
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "CHECKPATIENT";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("Email", username.ToString());
                cmd.Parameters.Add("Password", OracleDbType.Varchar2,20,20, System.Data.ParameterDirection.Output);

                try
                {
                    cmd.ExecuteNonQuery();
                    if (password == cmd.Parameters["Password"].Value.ToString())
                        presenterInstance.modelResponse("Account is Verified");
                    else
                        presenterInstance.modelResponse("Something is wrong check your username or password");
                }
                catch
                {
                    presenterInstance.modelErrorMessage("Error connecting to the database");
                }
            }
            //Pharmacist
            else if (type == true)
            {
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "CheckPharmacist";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("Email", username);
                cmd.Parameters.Add("Password", OracleDbType.Varchar2, 20, 20, System.Data.ParameterDirection.Output);

                try
                {
                    cmd.ExecuteNonQuery();
                    if (password == cmd.Parameters["Password"].Value.ToString())
                        presenterInstance.modelResponse("Account is Verified");
                    else
                        presenterInstance.modelResponse("Something is wrong please Check your username or password");
                }
                catch
                {
                    presenterInstance.modelErrorMessage("Error connecting to the database");
                }

            }
           
        }

        public void signUp(Object person, bool type) // 0 for patient 1 for pharm.
        {
            cmd = new OracleCommand();
            if (!type) //Patient
            {
                Patient patient = (Patient)person;
                cmd.CommandText = @"Insert into Patient
                                    values(:email, :p_fname, :p_lname, :address, :phone, :payment, p_password)";
                cmd.Parameters.Add("email", patient.get_email());
                cmd.Parameters.Add("p_fname", patient.get_f_name());
                cmd.Parameters.Add("p_lname", patient.get_l_name());
                cmd.Parameters.Add("address", patient.get_address());
                cmd.Parameters.Add("payment", patient.get_payment());
                cmd.Parameters.Add("p_password", patient.get_password());
                cmd.Parameters.Add("phone", Int32.Parse(patient.get_phone()));
                cmd.Parameters.Add("birthdate",OracleDate.Parse(patient.get_birthdate()));

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
            else //Pharmacist.
            {

            }
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
