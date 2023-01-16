using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Diary_Lib
{
    public class Menu
    {
        Functions functions =new Functions();
        public void passwordprotected()
        {
            Console.SetCursorPosition(10, 0);
            Console.WriteLine("*********************************");
            Console.SetCursorPosition(10, 1);
            Console.WriteLine("Password Protected Personal Diary");
            Console.SetCursorPosition(10, 2);
            Console.WriteLine("*********************************");
        }
        public void mainmenu()
        {
            Console.Clear();

            passwordprotected();
            Console.SetCursorPosition(15, 5);
            Console.WriteLine("Add Record     [1]");
            Console.SetCursorPosition(15, 6);
            Console.WriteLine("View Record    [2]");
            Console.SetCursorPosition(15, 7);
            Console.WriteLine("Edit Record    [3]");
            Console.SetCursorPosition(15, 8);
            Console.WriteLine("Delete Record  [4]");
            Console.SetCursorPosition(15, 9);
            Console.WriteLine("Edit Record    [5]");
            Console.SetCursorPosition(15, 10);
            Console.WriteLine("Exit           [6]");

            int choice = getinput();
            performaction(choice);
        }
        public int getinput()
        {
            int choice = -1;
            while (choice < 1 || choice > 8)
            {
                Console.SetCursorPosition(15, 12);
                Console.WriteLine("Enter your choice : ");
                Console.SetCursorPosition(35, 12);
                choice = Convert.ToInt32(Console.ReadLine());
            }
            return choice;
        }
        public void performaction(int choice)
        {
            switch(choice)
            {
 
                case 1:
                    functions.addRecord();
                    break;
                case 2:
                    functions.viewRecord();
                    break;
                case 3:
                    functions.editRecord();
                    break;
                case 4:
                    functions.deleteRecord();
                    break;
                case 5:
                    functions.editRecord();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
