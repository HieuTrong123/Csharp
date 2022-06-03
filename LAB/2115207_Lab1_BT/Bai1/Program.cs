using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Cau :1,2,3
            Console.WriteLine("Question 1 answer:" +
                "\na. elctricBill\n" +
                "b.ElctricBill\n" +
                "d. Static\n" +
                "g. Ay56we\n" +
                "h.Theater_Tickets\n" +
                "j. heightInCentimeters\n " +
                "k. Zip23891\n" +
                "l. Void\n");
            Console.WriteLine("Question 2 answer: c.JobApplication \n");
            Console.WriteLine("Question 3 answer: c. Egypt \n");
            #endregion
            PersonalInfo();
            Lyrics();
            Comments();
            StopSign();
            BigLetter();
            BurmaShave();
            Console.ReadKey();

        }
        static void PersonalInfo()
        {
            Console.WriteLine("4.Hoc Vien :" +
                "\nName:Dinh Trong Hieu\n" +
                "birthdate: 19/4/2003\n" +
                "Work Phone number: 0377969085\n" +
                "Cell phone number: 0377969085\n");
        }
        static void Lyrics()
        {
            Console.WriteLine("5.The favorite song: regression" +
                "\nEvery night brings a dream but the day, relentlessly keeps me awake\n" +
                "All the rest will be torn up whenever a choice is made\n" +
                "Every living soul in the fray striving for their own safe place\n" +
                "Life is too long to end at a grave\n");
        }
        static void Comments()
        {
            #region Question 6
            Console.WriteLine("6.\n");
            //this is private
            #endregion

        }
        static void StopSign()
        {
            Console.WriteLine("7.figure 1.19\n" +
                "    XXXXXX  \n" +
                " X          X\n" +
                "X    STOP    X\n" +
                " X         X\n" +
                "    XXXXXX  \n" +
                "       X\n" +
                "       X\n" +
                "       X\n");
        }
        static void BigLetter()
        {
            Console.WriteLine("8.\n" +
                "H      H\n" +
                "H      H\n" +
                "HHHHHHHH\n" +
                "H      H\n" +
                "H      H\n" +
                "H      H\n");
        }
        static void BurmaShave()
        {
            Console.WriteLine("9." +
                "Shaving brushes\n" +
                "You’ll soon see ’em\n" +
                "On a shelf\n" +
                "In some museum\n" +
                "Burma Shave\n");
        }
    }
}
