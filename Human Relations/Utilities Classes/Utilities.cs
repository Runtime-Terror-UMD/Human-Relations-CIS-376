using MySql.Data.MySqlClient;
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

        public bool isFirstLogin(int userID)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT Count(*) from dbo.activityLog where createdBy = @userID and activityTypeID = 14");
            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;

            DBConnect firstLoginConn = new DBConnect();

            if (firstLoginConn.intScalar(cmd) > 0)
                return false;
            return true;
        }

       
        // DESCRIPTION: Gets userID based on email address
        public int getUserIDFromEmail(string email)
        {
            int userID = -1;
            DBConnect getUserIDFromEmailConn = new DBConnect();

            // build query
            MySqlCommand cmd = new MySqlCommand("SELECT userid from dbo.user where email = @email");
            cmd.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = email;
            
            // assign value to variable
            userID = getUserIDFromEmailConn.intScalar(cmd);
            return userID;
        }

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
            MySqlCommand cmd = new MySqlCommand("SELECT userID from dbo.user where username = @username");
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
    }
}
