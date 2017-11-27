using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;

namespace LuckyDrawApp
{
    public class BackEnd
    {
        public static string conString = System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ToString();
        public static bool isValid(string pickedNo)
        {
            return true;
            MySqlConnection sqlcon = new MySqlConnection();
            MySqlCommand sqlcmd = new MySqlCommand();
            //sqlcmd.CommandText = "Select ticketNo,branch_id,user_id,status,remarks,created_at,updated_at from tickets where ticketNo=@ticketNo and status='Staff Entery'";
            sqlcmd.CommandText = "Select ticketNo,branch_id,user_id,status,remarks,created_at,updated_at from tickets where ticketNo=@ticketNo";
            sqlcmd.Parameters.AddWithValue("@ticketNo", pickedNo);

            sqlcon.ConnectionString = conString;
            sqlcmd.Connection = sqlcon;
            sqlcmd.Connection.Open();

            MySqlDataReader dr = sqlcmd.ExecuteReader();
            bool isExisted=false;

            while(dr.Read())
            {
                isExisted = true;
            }

            sqlcon.Dispose();
            sqlcmd.Dispose();
            dr.Dispose();
            return isExisted;
            
        }

        public static DataSet GetWinningNumbers(string type)
        {
            DataSet ds = new DataSet();
            string tickets = "";

            DataTable dt = new DataTable();
            dt.Columns.Add("SrNo");
            dt.Columns.Add("TicketNo");
            dt.Columns.Add("Branch");

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("SrNo");
            dt2.Columns.Add("TicketNo");
            dt2.Columns.Add("Branch");

            DataTable dt3 = new DataTable();
            dt3.Columns.Add("SrNo");
            dt3.Columns.Add("TicketNo");
            dt3.Columns.Add("Branch");

            DataTable dt4 = new DataTable();
            dt4.Columns.Add("SrNo");
            dt4.Columns.Add("TicketNo");
            dt4.Columns.Add("Branch");

            DataTable dt5 = new DataTable();
            dt5.Columns.Add("SrNo");
            dt5.Columns.Add("TicketNo");
            dt5.Columns.Add("Branch");

            string filePath = "";
            if (type == "car") { filePath = "Cars.csv"; }
            if (type == "bike") { filePath="Bikes.csv";}
            if (type == "phone") { filePath="Phones.csv";}

            if (File.Exists(filePath))
            {
                String[] lines = File.ReadAllLines(filePath);
                int r=1;
                foreach (string s in lines)
                {
                    if (type=="car")
                    {
                        if( r <= 8)
                        {
                            DataRow dd = dt.NewRow();
                            dd["SrNo"] = r;
                            dd["TicketNo"] = s;
                            dd["Branch"] = "";
                            dt.Rows.Add(dd);
                        }
                        else
                        {
                            DataRow dd1 = dt2.NewRow();
                            dd1["SrNo"] = r;
                            dd1["TicketNo"] = s;
                            dd1["Branch"] = "";
                            dt2.Rows.Add(dd1);
                        }
                        
                    }
                    if(type=="bike" && r<=15)
                    {
                        if(r<=15)
                        {
                            DataRow dd = dt.NewRow();
                            dd["SrNo"] = r;
                            dd["TicketNo"] = s;
                            dd["Branch"] = "";
                            dt.Rows.Add(dd);
                        }
                        else
                        {
                            DataRow dd1 = dt2.NewRow();
                            dd1["SrNo"] = r;
                            dd1["TicketNo"] = s;
                            dd1["Branch"] = "";
                            dt2.Rows.Add(dd1);
                        }
                        
                    }
                    if (type == "phone")
                    {
                        if (r <= 10)
                        {
                            DataRow dd = dt.NewRow();
                            dd["SrNo"] = r;
                            dd["TicketNo"] = s;
                            dd["Branch"] = "";
                            dt.Rows.Add(dd);
                        }
                        else if (r <= 20)
                        {
                            DataRow dd1 = dt2.NewRow();
                            dd1["SrNo"] = r;
                            dd1["TicketNo"] = s;
                            dd1["Branch"] = "";
                            dt2.Rows.Add(dd1);
                        }
                        else if (r <= 30)
                        {
                            DataRow dd1 = dt3.NewRow();
                            dd1["SrNo"] = r;
                            dd1["TicketNo"] = s;
                            dd1["Branch"] = "";
                            dt3.Rows.Add(dd1);
                        }
                        else if (r <= 40)
                        {
                            DataRow dd1 = dt4.NewRow();
                            dd1["SrNo"] = r;
                            dd1["TicketNo"] = s;
                            dd1["Branch"] = "";
                            dt4.Rows.Add(dd1);
                        }
                        else
                        {
                            DataRow dd1 = dt5.NewRow();
                            dd1["SrNo"] = r;
                            dd1["TicketNo"] = s;
                            dd1["Branch"] = "";
                            dt5.Rows.Add(dd1);
                        }
                        
                    }
                    r++;
                    
                }
            }

            ds.Tables.Add(dt);
            ds.Tables.Add(dt2);
            ds.Tables.Add(dt3);
            ds.Tables.Add(dt4);
            ds.Tables.Add(dt5);

            return ds;

            //below code will not execute;

            if (File.Exists(filePath))
            {
                String[] lines = File.ReadAllLines(filePath);
                
                foreach (string s in lines)
                {
                    tickets += "'"+ s+"',";
                }
            }  

            if (tickets.Trim().Length>0)
            {
                tickets = tickets.Substring(0, tickets.Trim().Length - 1);
            }

            MySqlConnection sqlcon;
            MySqlCommand sqlcmd;

            sqlcon= new MySqlConnection();
            sqlcmd = new MySqlCommand();
            sqlcmd.CommandText = "Select ticketNo,branches.name as branchName from tickets inner join branches on branches.id=tickets.branch_id  where  ticketno in ("+tickets+")";
            
            sqlcon.ConnectionString = conString;
            sqlcmd.Connection = sqlcon;
            sqlcmd.Connection.Open();

            

            MySqlDataReader dr = sqlcmd.ExecuteReader();
            int i=1;
            while(dr.Read())
            {
                if(i>=16)
                {
                    DataRow dtr = dt2.NewRow();
                    dtr["SrNo"] = i;
                    dtr["TicketNo"] = dr["ticketNo"];
                    dtr["Branch"] = dr["branchName"];
                    dt2.Rows.Add(dtr);
                }
                else
                {
                    DataRow dtr = dt.NewRow();
                    dtr["SrNo"] = i;
                    dtr["TicketNo"] = dr["ticketNo"];
                    dtr["Branch"] = dr["branchName"];
                    dt.Rows.Add(dtr);
                }
                
                i++;
            }

            sqlcon.Dispose();
            sqlcmd.Dispose();
            dr.Dispose();

            ds.Tables.Add(dt);
            ds.Tables.Add(dt2);
            return ds;
        }

        public static void Save(string winningNo,string type)
        {
            if(type=="car")
            {
                //Save Car WinningNo
                try
                {
                    if (!File.Exists("Cars.csv"))
                    {
                        FileStream fs= File.Create("Cars.csv");
                        fs.Close();
                    }

                    if (File.Exists("Cars.csv"))
                    {
                        StreamWriter sw = File.AppendText("Cars.csv");
                        sw.WriteLine( winningNo );
                        sw.Close();
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            if(type=="bike")
            {
                //Save cycles
                try
                {
                    if (!File.Exists("Bikes.csv"))
                    {
                        FileStream fs = File.Create("Bikes.csv");
                        fs.Close();
                    }

                    if (File.Exists("Bikes.csv"))
                    {
                        StreamWriter sw = File.AppendText("Bikes.csv");
                        sw.WriteLine(winningNo);
                        sw.Close();
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            if(type=="phone")
            {
                //Save iphone nos
                try
                {
                    if (!File.Exists("Phones.csv"))
                    {
                        FileStream fs = File.Create("Phones.csv");
                        fs.Close();
                    }

                    if (File.Exists("Phones.csv"))
                    {
                        StreamWriter sw = File.AppendText("Phones.csv");
                        sw.WriteLine(winningNo);
                        sw.Close();
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        public static bool isAlreadyWin(string number,ref string category)
        {
            bool isAlreadyWin = false;
            category = "";

            if (File.Exists("Cars.csv"))
            {
                String[] lines = File.ReadAllLines("Cars.csv");
                foreach (string s in lines)
                {
                    if (s == number)
                    {
                        category = "Car";
                        isAlreadyWin = true;
                        return isAlreadyWin;
                        
                    }
                }
            }

            if (File.Exists("Bikes.csv"))
            {
                String[] lines = File.ReadAllLines("Bikes.csv");
                foreach (string s in lines)
                {
                    if (s == number)
                    {
                        category = "Bike";
                        isAlreadyWin = true;
                        return isAlreadyWin;

                    }
                }
            }

            if (File.Exists("Phones.csv"))
            {
                String[] lines = File.ReadAllLines("Phones.csv");
                foreach (string s in lines)
                {
                    if (s == number)
                    {
                        category = "Phone";
                        isAlreadyWin = true;
                        return isAlreadyWin;

                    }
                }
            }

            return isAlreadyWin;


        }
    }
}
