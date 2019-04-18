using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointsandLines;
using Utilities;

class EntryPoint
{
    static Random rng = new Random();
    static void Main()
    {
        User user = new User("Vachev", "Zorkbip");
        

        User secondUser = new User();

        User thirduser = new User();

        Utilities.Utilities.ColorfulWriteLine(user.Username, ConsoleColor.DarkRed);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(user.ID);
        Console.WriteLine(secondUser.ID);
        Console.WriteLine(thirduser.ID);
        Console.WriteLine(User.currentID);
    }// static void Main() Ends
}// class EntryPoint Ends