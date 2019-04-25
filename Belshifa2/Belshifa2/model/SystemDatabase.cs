using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Belshifa2.dataClasses;

namespace Belshifa2.model
{
    class SystemDatabase
    {
        private string ordb;
        private OracleConnection conn;
        private OracleCommand cmd;

        Dictionary<string, List<int>> areasAndPharmacies;
        Dictionary<string, int> areas;
        List<Pharmacy> pharmacyList;

        public SystemDatabase()
        {
            areasAndPharmacies = new Dictionary<string, List<int>>();
            areas = new Dictionary<string, int>();
            pharmacyList = new List<Pharmacy>();
            ordb = "Data source = orcl;user id=hr; password =hr";
            conn = new OracleConnection(ordb);
            conn.Open();

            fillAreasAndPharmacies();
            fillAreas();
            get_Pharmacies();
        }

        public string signIn(string username, string password, bool type)
        {
            string message = "";
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
                        message = "Logging in..";
                    }
                    else
                    {
                        rs.Close();
                        cmd.Dispose();

                        message = "Please check username or password!";
                    }                   
                }
             
                catch
                {
                    cmd.Dispose();
                    message = "Error connecting to the database!";
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
                        message = "Account is Verified";
                    }
                    else
                    {
                        rs.Close();
                        cmd.Dispose();
                        message = "Something is wrong check your username or password";
                    }

                }

                catch
                {
                    message = "Error connecting to the database";
                }
            }

            return message;
        }
        public string signUp(Object person, bool type)
        {
            string message = "";
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
                        message = "Account is created successfully!";
                    else
                        message = "Please make sure of your input!";
                }
                catch
                {
                    message = "Error connecting to the database";
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
                        message = "Account is created successfully!";
                    else
                        message = "Please make sure of your input!";
                }
                catch
                {
                    message = "Error connecting to the database";
                }
            }
            return message;
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
                    cmd.Dispose();
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


        public List<Medicine> getSimilars(string usage)
        {
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"select * from medicine
                                where m_usage = :usage";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("usage", usage);
            try
            {
                OracleDataReader rs = cmd.ExecuteReader();
                List<Medicine> medicineList = new List<Medicine>();
                Medicine medicine;
                while (rs.Read())
                {
                    medicine = new Medicine(int.Parse(rs[0].ToString()), rs[1].ToString(), float.Parse(rs[2].ToString()),
                     rs[3].ToString(), rs[4].ToString(), rs[5].ToString(), rs[6].ToString(), rs[7].ToString(), int.Parse(rs[8].ToString()),
                    rs[9].ToString());
                    medicineList.Add(medicine);
                }
                rs.Close();
                return medicineList;
            }
            catch
            {
                return null;
            }
        }

        //Step A.5 .. Get Multiple Lines using procedure.
        public List<Medicine> getMedicines(int sec_id)
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
                List<Medicine> medicineList = new List<Medicine>();
                Medicine medicine;
                while (rs.Read())
                {
                    medicine = new Medicine(int.Parse(rs[0].ToString()), rs[1].ToString(), float.Parse(rs[2].ToString()),
                     rs[3].ToString(), rs[4].ToString(), rs[5].ToString(), rs[6].ToString(), rs[7].ToString(), int.Parse(rs[8].ToString()),
                    rs[9].ToString());

                    medicineList.Add(medicine);
                }
                rs.Close();
                cmd.Dispose();
                return medicineList;
            }
            catch
            {
                cmd.Dispose();
                return null;
            }
        }


        //Step A.1 .. Select Statement Without Where Condition.
        public List<Section> getSections()
        {
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Section";
            cmd.CommandType = System.Data.CommandType.Text;
            try
            {
                OracleDataReader rs = cmd.ExecuteReader();
                List<Section> sectionsList = new List<Section>();
                Section section;
                while (rs.Read())
                {
                    section = new Section(int.Parse(rs[0].ToString()), rs[1].ToString());
                    sectionsList.Add(section);
                }

                rs.Close();
                return sectionsList;
            }
            catch
            {
                return null;
            }
        }

        public List<Medicine> getAllMedicines()
        {
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from medicine";
            cmd.CommandType = System.Data.CommandType.Text;
            try
            {
                OracleDataReader rs = cmd.ExecuteReader();
                List<Medicine> medicineList = new List<Medicine>();
                Medicine medicine;
                while (rs.Read())
                {
                    medicine = new Medicine(int.Parse(rs[0].ToString()), rs[1].ToString(), float.Parse(rs[2].ToString()),
                     rs[3].ToString(), rs[4].ToString(), rs[5].ToString(), rs[6].ToString(), rs[7].ToString(), int.Parse(rs[8].ToString()),
                    rs[9].ToString());
                    medicineList.Add(medicine);
                }
                rs.Close();
                cmd.Dispose();
                return medicineList;
            }
            catch
            {
                cmd.Dispose();
                return null;
            }
        }

        public void UpdateQuant(List<int> medicines_ids, int pharmacy_id)
        {
            int quant = 0;
            int newquant = 0;
            for (int i = 0; i < medicines_ids.Count; i++)
            {
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UpdateQuantities";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("mid", medicines_ids[i]);
                cmd.Parameters.Add("Quantity", OracleDbType.Int32, System.Data.ParameterDirection.Output);
                cmd.ExecuteNonQuery();
                quant = Convert.ToInt32(cmd.Parameters["OrderID"].Value.ToString());
                newquant = quant - 1;
                cmd.CommandText = " Update medicine set QUANTITY = :quant  where M_ID = :mid";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("quant", newquant);
                cmd.Parameters.Add("mid", medicines_ids[i]);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        //_____________________________________________________________________________________________________________________
        public void makeOrder(string email, string address, List<int> medicines_ids)
        {
            //get max order id from table has
            int sum = 0;
            int maxorderid = 0;
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = " GetOrderID";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("OrderID", OracleDbType.Int32, System.Data.ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            if (cmd.Parameters["OrderID"].Value == null)
                sum = 0;
            else
                sum = int.Parse(cmd.Parameters["OrderID"].Value.ToString());
            maxorderid = sum + 1;
            cmd.Dispose();


            //totalPrice
            int totalprice = 0;
            for (int i = 0; i < medicines_ids.Count; i++)
            {
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "GetPrice";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("mid", medicines_ids[i]);
                cmd.Parameters.Add("MedicinePrice", OracleDbType.Int32, System.Data.ParameterDirection.Output);
                cmd.ExecuteNonQuery();
                totalprice += Convert.ToInt32(cmd.Parameters["MedicinePrice"].Value.ToString());
                cmd.Dispose();
            }

            //Get pharmacy id.
            int pharm_id = 0;
            List<Pharmacy> pharmacies_with_full_order = get_pharmacies_With_full_order(medicines_ids);
            if(pharmacies_with_full_order != null)
            {
                pharm_id = nearest_pharmacy_id(pharmacies_with_full_order, address);
            }


            string orderdate = "23-april-2019";
            string Deliverydate = "27-april-2019";
            //insert into order all the data
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "InsertOrderData";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("orderId", maxorderid);
            cmd.Parameters.Add("orderdate", orderdate);
            cmd.Parameters.Add("deliverydate", Deliverydate);
            cmd.Parameters.Add("totalprice", totalprice);
            cmd.Parameters.Add("email", email);
            cmd.Parameters.Add("pharmacy_id", pharm_id);                //added by Dina, not yet added in procedure.
            cmd.ExecuteNonQuery();
            cmd.Dispose();


            //insert medicines in table has
            for (int i = 0; i < medicines_ids.Count; i++)
            {
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into has values(:oid, :mid)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("oid", maxorderid);
                cmd.Parameters.Add("mid", medicines_ids[i]);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        private List<Pharmacy> get_pharmacies_With_full_order(List<int> medicines_ids)
        {
            int medicineMatchCounter;
            List<Pharmacy> pharmacyWithFullOrder = null;
            foreach(Pharmacy pharmacy in pharmacyList)
            {
                medicineMatchCounter = 0;
                pharmacyWithFullOrder = new List<Pharmacy>();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select m_id from gets where pharmacy_id = :id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id",pharmacy.get_id());

                try
                {
                    OracleDataReader rs = cmd.ExecuteReader();
                    while (rs.Read())
                    {
                        if (medicines_ids.Contains(int.Parse(rs[0].ToString())))
                            medicineMatchCounter++;
                        if(medicineMatchCounter == medicines_ids.Count)
                        {
                            pharmacyWithFullOrder.Add(pharmacy);
                            break;
                        }
                    }
                    rs.Close();
                }
                catch
                {
                    cmd.Dispose();
                }
            }
            return pharmacyWithFullOrder;
        }
        private int nearest_pharmacy_id(List<Pharmacy> pharmacies_with_full_order, string patientAddress)
        {
            int minDistance = 100;
            Pharmacy nearest_pharmacy = null;
            int diff;
            foreach(Pharmacy pharmacy in pharmacies_with_full_order)
            {
                diff = Math.Abs(areas[pharmacy.get_address()] - areas[patientAddress]);
                if ( minDistance > diff)
                {
                    minDistance = diff;
                    nearest_pharmacy = pharmacy;
                }

            }
            return nearest_pharmacy.get_id();
        }

        private void fillAreasAndPharmacies()
        {
            areasAndPharmacies["Sheraton"] = new List<int>();
            areasAndPharmacies["MisrElGdida"] = new List<int>();
            areasAndPharmacies["NasrCity"] = new List<int>();
            areasAndPharmacies["Abassia"] = new List<int>();
            areasAndPharmacies["Ramsis"] = new List<int>();
            areasAndPharmacies["Tahri"] = new List<int>();
            areasAndPharmacies["Dokki"] = new List<int>();
            areasAndPharmacies["Mohndseen"] = new List<int>();
            areasAndPharmacies["October"] = new List<int>();
            areasAndPharmacies["Zayed"] = new List<int>();

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select pharmacy_id, address from Pharmacy";
            cmd.CommandType = CommandType.Text;
            try
            {
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    areasAndPharmacies[dr[1].ToString()].Add(int.Parse(dr[0].ToString()));
                }
                dr.Close();
            }
            catch
            {
                cmd.Dispose();
            }

        }
        private void fillAreas()
        {
            areas["Sheraton"] = 1;
            areas["MisrElGdida"] = 2; //
            areas["NasrCity"] = 3;
            areas["Abassia"] = 4;
            areas["Ramsis"] = 5;/////////////
            areas["Tahri"] = 6; //
            areas["Dokki"] = 7;//
            areas["Mohndseen"] = 8;
            areas["October"] = 9;
            areas["Zayed"] = 10;
        }
        private void get_Pharmacies()
        {
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Pharmacy";
            cmd.CommandType = CommandType.Text;
            try
            {
                OracleDataReader dr = cmd.ExecuteReader();
                Pharmacy pharmacy;
                while (dr.Read())
                {
                    pharmacy = new Pharmacy(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString());
                    pharmacyList.Add(pharmacy);
                }
                dr.Close();
            }
            catch
            {
                cmd.Dispose();
            }
        }
        // ___________________________________________________________________________________________________________________
        public Medicine SearchForMedicine(string MedicineName)
        {
            string cmdtext = "select * from MEDICINE where M_NAME = :medicinename";
            OracleDataAdapter adapt = new OracleDataAdapter(cmdtext, ordb);
            adapt.SelectCommand.Parameters.Add("medicinename", MedicineName);
            DataSet ds = new DataSet();
            adapt.Fill(ds);

            if(ds.Tables[0].Rows.Count == 1)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                int id = int.Parse(dr[0].ToString());
                string name = dr[1].ToString();
                float price = float.Parse(dr[2].ToString());
                string side_effects = dr[3].ToString();
                string usage = dr[4].ToString();
                string precautions = dr[5].ToString();
                string ddInteraction = dr[6].ToString();
                string dfInteraction = dr[7].ToString();
                int secId = int.Parse(dr[8].ToString());
                string src = dr[8].ToString();

                Medicine m = new Medicine(id, name, price, side_effects, usage, precautions, ddInteraction, dfInteraction, secId, src);
                return m;
            }

            return null;
        }
       // _________________________________________________________________________________________________________________________
        public void MasterDetailsForm()
        {
            ordb = "Data source = oracle;user id=scott; password =tiger";
            DataSet ds = new DataSet();
            string cmdtext1 = "select * from SECTIONS";
            string cmdtext2 = "select * from MEDICINES ";

            OracleDataAdapter adapt1 = new OracleDataAdapter(cmdtext1, ordb);
            adapt1.Fill(ds, "Section");
            OracleDataAdapter adapt2 = new OracleDataAdapter(cmdtext2, ordb);
            adapt2.Fill(ds, "Medicines");

            DataRelation r = new DataRelation("FK", ds.Tables[0].Columns["S_ID"], ds.Tables[1].Columns["S_ID"]);
            ds.Relations.Add(r);

            //BindingSource bs_Master = new BindingSource(ds,"Section");
            //BindingSource bs_Child = new BindingSource(bs_Master, "FK");



        }
       // ________________________________________________________________________________________________________________________
        public void OrderDetails()
        {
            ordb = "Data source = oracle;user id=scott; password =tiger";
            string cmdtext = "select * from orderr";
            DataSet ds = new DataSet();
            OracleDataAdapter adapt = new OracleDataAdapter(cmdtext, ordb);
            adapt.Fill(ds);
            OracleCommandBuilder builder = new OracleCommandBuilder(adapt);
            adapt.Update(ds.Tables[0]); // Q: Leh update??
        }
        public List<Order> Get_Pharmacy_Orders(int PharmacyID)
        {
            List<Order> Get_Pharmacy_Orders;

            Get_Pharmacy_Orders = new List<Order>();
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from orderr where PHARMACY_ID = :id and PH_USERNAME is null";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("pharmid", PharmacyID);

            try
            {
                OracleDataReader rs = cmd.ExecuteReader();
                Order ord;
                while (rs.Read())
                {

                    ord = new Order(int.Parse(rs[0].ToString()), rs[1].ToString(), rs[2].ToString(), float.Parse(rs[3].ToString()), rs[4].ToString(), rs[5].ToString(), int.Parse(rs[6].ToString()));
                    Get_Pharmacy_Orders.Add(ord);
                    //Get_Pharmacy_Orders.Add(rs[0].ToString);
                    break;
                }
                rs.Close();
            }
            catch
            {
                cmd.Dispose();
            }


            return Get_Pharmacy_Orders;
        }
        public void disconnect()
        {
            conn.Dispose();
        }
    }
}
