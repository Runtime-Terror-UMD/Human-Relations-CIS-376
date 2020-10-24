﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Human_Relations
{
    class Utilities
    {
        // DESCRIPTION: Checks to see if user-entered email address is in valid format
        public bool isValidEmail(string email)
        {
            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        // DESCRIPTION: Checks to see if user-entered email exists 
        public bool emailExists(string email)
        {
            // declare and parameterize mySQL Command

            MySqlCommand cmd = new MySqlCommand("SELECT Count(*) from dbo.user where email = @email");
            cmd.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = email;

            // connect to database
            DBConnect emailExistsConn = new DBConnect();

            // if records exist
            if (emailExistsConn.intScalar(cmd) > 0)
                return true;
            else
                return false;
        }

        // DESCRIPTION: Checks to see if user-entered username exists
        public bool usernameExists(string username)
        {
            // declare and parameterize mySQL Command
            MySqlCommand cmd = new MySqlCommand("SELECT Count(*) from dbo.user where username = @username");
            cmd.Parameters.Add("@username", MySqlDbType.VarChar, 45).Value = username;

            // connect to database
            DBConnect usernameExistsConn = new DBConnect();

            // if records exist
            if (usernameExistsConn.intScalar(cmd) > 0)
                return true;
            else
                return false;
        }

        // DESCRIPTION: Checks to see if user ID exists
        public bool userIDExists(int userID)
        {
            // declare and parameterize mySQL Command
            MySqlCommand cmd = new MySqlCommand("SELECT Count(*) from dbo.user where userID = @userID");
            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;

            // connect to database
            DBConnect userIDExistsConn = new DBConnect();

            // if records exist
            if (userIDExistsConn.intScalar(cmd) > 0)
                return true;
            else
                return false;
        }
        
        //// DESCRIPTION: Gets userID based on email address
        //public int getUserIDFromEmail(string email)
        //{
        //    int userID = -1;
        //    DBConnect getUserIDFromEmailConn = new DBConnect();

        //    // build query
        //    MySqlCommand cmd = new MySqlCommand("SELECT userid from dbo.user where email = @email");
        //    cmd.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = email;
            
        //    // assign value to variable
        //    userID = getUserIDFromEmailConn.intScalar(cmd);
        //    return userID;
        //}

        public bool isAdmin(int userID)
        {
            User userInfo = new User(userID);
            if(userInfo.isAdmin == false)
                return false;
            return true;
        }

        // DESCRIPTION: Gets userID based on username
        public int getUserIDFromUsername(string username)
        {
            int userID = -1;
            DBConnect getUserIDFromUsernameConn = new DBConnect();
           
            // build query
            MySqlCommand cmd = new MySqlCommand("SELECT userid from dbo.user where username = @username");
            cmd.Parameters.Add("@username", MySqlDbType.VarChar, 45).Value = username;

            // assign value to variable
            userID = getUserIDFromUsernameConn.intScalar(cmd);
            return userID;
        }


        // DESCRIPTION: Checks if entered password matches specified username
        public bool passwordMatches(string username, string password)
        {

            int userID = getUserIDFromUsername(username);
            if(userID != -1)
            {
                User userInfo = new User(userID);
                if(userInfo.password == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            // construct query
            //MySqlCommand cmd = new MySqlCommand("SELECT Count(*) from dbo.user where username = @username AND password = @password");
            //cmd.Parameters.Add("@username", MySqlDbType.VarChar, 45).Value = username;
            //cmd.Parameters.Add("@password", MySqlDbType.VarChar, 45).Value = password;

            //// connect to database
            //DBConnect passwordMatchesConn = new DBConnect();
            //// if records exist
            //if (passwordMatchesConn.intScalar(cmd) > 0)
            //    return true;
            //else
            //    return false;
        }
        public bool passwordMatches(int userID, string password)
        {
            User userInfo = new User(userID);
            if (userInfo.password == password)
                return true;
            else
                return false;
        }
        //  DESCRIPTION: get minimum charge for a hotel stay from file
        public double getMinCharge()
        {
            double minCharge;
            string[] fileLines = File.ReadAllLines("HotelSettings.txt");
            if(double.TryParse(fileLines[0].Substring(fileLines[0].IndexOf(' ')), out minCharge))
            {
                return minCharge;
            }
            else
            {
                MessageBox.Show("Unable to retrieve minimum charge. 0 will be used.");
                return 0;
            }
        }
        //  DESCRIPTION: get cancelation fee for a hotel stay from file
        public decimal getCancelCharge()
        {
            decimal cancelCharge;
            string[] fileLines = File.ReadAllLines("HotelSettings.txt");
            if (decimal.TryParse(fileLines[1].Substring(fileLines[1].IndexOf(' ')), out cancelCharge))
            {
                return cancelCharge;
            }
            else
            {
                MessageBox.Show("Unable to retrieve cancelation charge. 0 will be used.");
                return 0;
            }
        }
        //  DESCRIPTION: get cancelation window from the file
        public int getCancelWindow()
        {
            int cancelWindow;
            string[] fileLines = File.ReadAllLines("HotelSettings.txt");
            if (int.TryParse(fileLines[2].Substring(fileLines[2].IndexOf(' ')), out cancelWindow))
            {
                return cancelWindow;
            }
            else
            {
                MessageBox.Show("Unable to retrieve cancelation window. 0 will be used.");
                return 0;
            }
        }
        //  DESCRIPTION: get points per day for stay from the file
        public int getDailyPointAmount()
        {
            int points;
            string[] fileLines = File.ReadAllLines("HotelSettings.txt");
            if (int.TryParse(fileLines[3].Substring(fileLines[3].IndexOf(' ')), out points))
            {
                return points;
            }
            else
            {
                MessageBox.Show("Unable to retrieve rewards points per night. 0 will be used.");
                return 0;
            }
        }
        //  DESCRIPTION: get notification window from the file
        public int getNotificationWindow()
        {
            int notifDays;
            string[] fileLines = File.ReadAllLines("HotelSettings.txt");
            if (int.TryParse(fileLines[4].Substring(fileLines[4].IndexOf(' ')), out notifDays))
            {
                return notifDays;
            }
            else
            {
                MessageBox.Show("Unable to retrieve notification window. 0 will be used.");
                return 0;
            }
        }

        // DESCRIPTION: calculates total price of reservation
        public double calculatePrice(double days, double pricePerNight)
        {
            double price =pricePerNight * days;
            return price;
        }

        // DESCRIPTION: Calculates total points accrued by reservation
        public double calculatePoints(double days)
        {
            double points = days * getDailyPointAmount();
            return points;
        }

        // DESCRIPTION: Gets price per night of roomNum at locationID
        public double getPricePerNight(int locationID, int roomNum)
        {
            DBConnect getPricePerNightConn = new DBConnect();
            MySqlCommand getPricePerNight = new MySqlCommand("SELECT pricePerNight from dbo.room WHERE locationID = @locationID and roomNum = @roomNum");
            getPricePerNight.Parameters.Add("@locationID", MySqlDbType.Int32).Value = locationID;
            getPricePerNight.Parameters.Add("@roomNum", MySqlDbType.Int32).Value = roomNum;
            double pricePerNight = getPricePerNightConn.doubleScalar(getPricePerNight);
            return pricePerNight;
        }
        public bool checkIfRewardApplied(int confirmationID)
        {
            DBConnect checkRewardConn = new DBConnect();
            MySqlCommand checkReward = new MySqlCommand("SELECT ifnull(count(*),0) from payment where confirmationID = @confirmationID and usedRewards = 1");
            checkReward.Parameters.Add("@confirmationID", MySqlDbType.Int32).Value = confirmationID;
            int check = checkRewardConn.intScalar(checkReward);
            return (check == 0)?false:true;
        }
        
    }
}
