using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.IO;

/// <summary>
/// Jonathan Nunez
/// VFW Section 01
/// Final: Synthesis
/// </summary>
/// 
/// Credit for Icon usage
///<div>Icons made by<a href="https://www.flaticon.com/authors/pixelmeetup" title="Pixelmeetup"> Pixelmeetup</a> from<a href="https://www.flaticon.com/" title="Flaticon"> www.flaticon.com</a> is licensed by <a href = "http://creativecommons.org/licenses/by/3.0/" title= "Creative Commons BY 3.0" target= "_blank" > CC 3.0 BY</a></div>
///<div>Icons made by <a href="http://www.freepik.com" title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a> is licensed by <a href="http://creativecommons.org/licenses/by/3.0/" title="Creative Commons BY 3.0" target="_blank">CC 3.0 BY</a></div>
namespace JonathanNunez_Final
{
    public partial class Form1 : Form
    {
        // Instantiate mysqlconnection
        MySqlConnection conn = null;
        //Global connection string
        string connString;

        public Form1()
        {
            InitializeComponent();
        }

        // Form Load event
        private void Form1_Load(object sender, EventArgs e)
        {
            connString = BuildSQLConnectionString();

            // Try..catch..finally
            // Test connection, catch exceptions, close connection at end
            try
            {
                // Open a connection to MySQL 
                conn = new MySqlConnection(connString);
                conn.Open();

                // Declare a MySQL Data Reader
                MySqlDataReader rdr = null;

                // Create SQL Statement
                string sqlCmd = "SELECT dvdId, DVD_Title, Price, Rating, Year " +
                    "FROM dvd " +
                    "LIMIT 15";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(sqlCmd, conn);

                // Execute SQL statement and place the returned data into rdr
                rdr = cmd.ExecuteReader();

                // Loop through rows returned from MySQL
                while (rdr.Read())
                {
                    // Strings                   
                    string dvdTitle = rdr["DVD_Title"] as string;
                    string dvdRating = rdr["Rating"] as string;

                    // String to number Parse
                    string dvdIdString = rdr["dvdId"] + "";
                    string priceString = rdr["Price"] + "";
                    string yearOfReleaseString = rdr["year"] + "";

                    int dvdId = Int32.Parse(dvdIdString);
                    decimal dvdPrice = decimal.Parse(priceString);
                    decimal dvdYearOfRelease = decimal.Parse(yearOfReleaseString);

                    // Create object using data
                    DVD newDVD = new DVD(dvdId, dvdTitle, dvdRating, dvdYearOfRelease, dvdPrice);

                    // Create listviewitem to be used in listview
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = newDVD.ToString();
                    lvi.Tag = newDVD;
                    lvi.ImageIndex = 0;

                    // Add listviewitem to listview
                    dvdLV.Items.Add(lvi);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        // Method to clear all DVD detail inputs
        private void ClearDVDDetails()
        {
            titleTxtBx.Clear();
            ratingTxtBx.Clear();
            priceNum.Value = 0;
            yearOfReleaseNum.Value = 0;
        }

        // LargeIcons Menu Option Click Event
        // Change listview view to LargeIcon
        private void largeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dvdLV.View = View.LargeIcon;
        }

        // SmallIcons Menu Option Click Event
        // Change listview view to SmallIcon
        private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dvdLV.View = View.SmallIcon;
        }

        // Listview item Double-Click Event
        // Print values from item to user inputs field
        private void dvdLV_DoubleClick(object sender, EventArgs e)
        {
            // Get the listviewitem
            ListViewItem lvi = dvdLV.SelectedItems[0];
            // Set a new DVD(object) to listviewitem tag value
            DVD dvd = lvi.Tag as DVD;

            // Set user input fields to values from DVD(object)
            titleTxtBx.Text = dvd.GetTitle;
            ratingTxtBx.Text = dvd.GetRating;
            priceNum.Value = dvd.GetPrice;
            yearOfReleaseNum.Value = dvd.GetReleaseDate;
        }


        // Method to close application
        private void exitFileMenuOption_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Method to update SQL database with user input values
        private void UpdateSQLDatabase(DVD dvd)
        {
            // Try..catch..finally
            // Test connection, catch exceptions, close connection at end
            try
            {
                // Open a connection to MySQL 
                MySqlConnection connect = new MySqlConnection(connString);
                connect.Open();

                // Declare a MySQL Data Reader
                MySqlDataReader rdr = null;

                // Create SQL Statement
                string sqlCmd = "UPDATE dvd " +
                    "SET DVD_Title = @dvdTitle, Price = @dvdPrice, Rating = @dvdRating, Year = @dvdYear " +
                    "WHERE dvdId = @dvdID";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(sqlCmd, connect);
                cmd.Parameters.AddWithValue("@dvdID", dvd.GetID);
                cmd.Parameters.AddWithValue("@dvdTitle", dvd.GetTitle);
                cmd.Parameters.AddWithValue("@dvdPrice", dvd.GetPrice);
                cmd.Parameters.AddWithValue("@dvdRating", dvd.GetRating);
                cmd.Parameters.AddWithValue("@dvdYear", dvd.GetReleaseDate);

                // Execute SQL statement and place the returned data into rdr
                rdr = cmd.ExecuteReader();
                
                MessageBox.Show("Update SQL Successful!");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        // Save Menu Option Click Event
        // Update the ListView selected item, and update the SQL database for the selected entry
        private void saveToSQLBtn_Click(object sender, EventArgs e)
        {
            // Get the listview item of the selected item
            ListViewItem lvi = dvdLV.SelectedItems[0];
            // Get DVD(object) to the value of the selected listviewitem
            DVD modifiedDVD = lvi.Tag as DVD;

            // Update the values of the DVD(object) with the values in the user input fields
            modifiedDVD.GetTitle = titleTxtBx.Text;
            modifiedDVD.GetRating = ratingTxtBx.Text;
            modifiedDVD.GetReleaseDate = yearOfReleaseNum.Value;
            modifiedDVD.GetPrice = priceNum.Value;

            // Add the DVD(object) back into the selected listviewitem
            lvi.Text = modifiedDVD.ToString();
            lvi.Tag = modifiedDVD;

            // Call method to upate SQL Database
            UpdateSQLDatabase(modifiedDVD);
        }

        // Method to build sql connection string from local file in C:\
        private string BuildSQLConnectionString()
        {
            string serverIP = "";

            try
            {
                // Open txt file using StreamReader
                using (StreamReader sr = new StreamReader("C:\\VFW\\connect.txt"))
                {
                    serverIP = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return "server=" + serverIP + ";userid=dbsAdmin;password=password;database=exampleDatabase;port=8889;SslMode=none";
        }
    }
}
