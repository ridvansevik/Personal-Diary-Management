using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Diary_Lib
{
    public class Functions
    {
        
        Diary diary= new Diary();
        public void addRecord()
        {
            Console.Clear();
            Menu menu = new Menu();
            menu.passwordprotected();
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string filename = Path.Combine(path, "diary.dat");

            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Date : ");
            Console.SetCursorPosition(17, 5);
            diary.Date = Console.ReadLine();

            Console.SetCursorPosition(10, 6);
            Console.WriteLine("Time : ");
            Console.SetCursorPosition(17, 6);
            diary.Time = Console.ReadLine();

            Console.SetCursorPosition(10, 7);
            Console.WriteLine("Name : ");
            Console.SetCursorPosition(17, 7);
            diary.Name = Console.ReadLine();

            Console.SetCursorPosition(10, 8);
            Console.WriteLine("Place : ");
            Console.SetCursorPosition(18, 8);
            diary.Place = Console.ReadLine();

            Console.SetCursorPosition(10, 9);
            Console.WriteLine("Duration : ");
            Console.SetCursorPosition(21, 9);
            diary.Duration = Console.ReadLine();

            Console.SetCursorPosition(10, 10);
            Console.WriteLine("Note : ");
            Console.SetCursorPosition(17, 10);
            diary.Note = Console.ReadLine();


            byte[] diaryBytes = Diary.DiaryToByteArrayBlock(diary);
            FileUtility.AppendBlock(diaryBytes, filename);

            Console.Clear();
            Console.SetCursorPosition(30, 10);
            Console.WriteLine("Succesfully added");
            Console.ReadKey(true);
            menu.mainmenu();
        }
        public void viewRecord() 
        {

        }
        public void editRecord()
        {

        }
        public void deleteRecord() 
        {

        }
        public void editPassword()
        {

        }

    }
}
