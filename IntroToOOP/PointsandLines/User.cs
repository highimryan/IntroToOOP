using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace PointsandLines
{
    class User
    {
        public readonly int Height;
        public readonly int ID; // constant THE_NAME_OF_THE_CAT

        public static int currentID;

        public string race;

        private string username;
        private int password; // private means accessible only throughout the class starts ln 10 ends ln 66

        public string Username
        {
            get
            {
                return "The username is " + username;
            }
        }
        public int Password
        {
            set
            {
                if(value >= 4 && value <= 10)
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("Oops, this is not a valid password! Please use a password between 4 to 10 characters.");
                }
            }
        }

        public User()
        {
            currentID++;
            ID = currentID;
        }

        public User(string username, string race)
        {
            currentID++;
            ID = currentID;
            this.username = username;
            this.race = race;

            if (this.race == "Floodlebobber")
            {
                Height = 100;
            }
            else if (this.race == "Zorkbip")
            {
                Height = 180;
            }
        }

        public void SayMyName()
        {
            Utilities.Utilities.ColorfulWriteLine(this.username, ConsoleColor.DarkGreen);
        }
    }// class Point Ends

}
