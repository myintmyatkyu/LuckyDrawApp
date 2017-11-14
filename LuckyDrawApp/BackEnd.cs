﻿using System;
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
            MySqlConnection sqlcon = new MySqlConnection();
            MySqlCommand sqlcmd = new MySqlCommand();
            sqlcmd.CommandText = "Select ticketNo,branch_id,user_id,status,remarks,created_at,updated_at from tickets where ticketNo=@ticketNo and status='Staff Entery'";
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

        public static DataTable GetWinningNumbers(string type)
        {
            string tickets = "";

            DataTable dt = new DataTable();
            dt.Columns.Add("SrNo");
            dt.Columns.Add("TicketNo");
            dt.Columns.Add("Branch");

            string filePath = "";
            if (type == "car") { filePath = "Cars.csv"; }
            if (type == "bike") { filePath="Bikes.csv";}
            if (type == "phone") { filePath="Phones.csv";}


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

            MySqlConnection sqlcon = new MySqlConnection();
            MySqlCommand sqlcmd = new MySqlCommand();
            sqlcmd.CommandText = "Select ticketNo,branches.name as branchName from tickets inner join branches on branches.id=tickets.branch_id  where status='Staff Entery' and ticketno in ("+tickets+")";
            
            sqlcon.ConnectionString = conString;
            sqlcmd.Connection = sqlcon;
            sqlcmd.Connection.Open();

            

            MySqlDataReader dr = sqlcmd.ExecuteReader();
            

            int i=1;
            while(dr.Read())
            {
                DataRow dtr = dt.NewRow();
                dtr["SrNo"] = i;
                dtr["TicketNo"] = dr["ticketNo"];
                dtr["Branch"] = dr["branchName"];
                dt.Rows.Add(dtr);
                i++;
            }

            sqlcon.Dispose();
            sqlcmd.Dispose();
            dr.Dispose();

            return dt;
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
