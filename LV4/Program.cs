using System;
using System.Collections.Generic;

namespace LV4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset newDataset = new Dataset("csv.txt");
            Analyzer3rdParty newAnalyzer = new Analyzer3rdParty();
            Adapter newAdapter = new Adapter(newAnalyzer);

            double[] averageRows = newAdapter.CalculateAveragePerRow(newDataset);
            double[] averageColumns = newAdapter.CalculateAveragePerColumn(newDataset);
   
            for (int i = 0; i < averageRows.Length; i++)
            {
                Console.WriteLine(averageRows[i]);
            }

            for (int i = 0; i < averageColumns.Length; i++)
            {
                Console.WriteLine(averageColumns[i]);
            }

            List<IRentable> HitList = new List<IRentable>();
            Video video = new Video("Game of Thrones");
            Book book = new Book("Osnove Elektrotenike 1");
            HitList.Add(video);
            HitList.Add(book);
            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.PrintTotalPrice(HitList);
            printer.DisplayItems(HitList);

            HotItem hitVideo = new HotItem(new Video("Breaking Bad"));
            HotItem hitBook = new HotItem(new Book("Osnove elektrotehnike 2"));
            HitList.Add(hitVideo);
            HitList.Add(hitBook);
            printer.PrintTotalPrice(HitList);
            printer.DisplayItems(HitList);

            List<IRentable> flashSale = new List<IRentable>();
            for (int i = 0; i < 4; i++)
            {
                flashSale.Add(new DiscountedItem(HitList[i], 20));
            }
            printer.PrintTotalPrice(flashSale);
            printer.DisplayItems(flashSale);

            string mail = "ana.marek4@gmail.com";
            string password = "gdt675TDjH";
            EmailValidator emailValidator = new EmailValidator();
            PasswordValidator passwordValidator = new PasswordValidator(10);

            if (emailValidator.IsValidAddress(mail))
            {
                Console.WriteLine("E-mail address " + mail + " is correct.");
            }

            else
            {
                Console.WriteLine("E-mail address " + mail + " is NOT correct.");

            }
            if (passwordValidator.IsValidPassword(password))
            {
                Console.WriteLine("Password is correct.");

            }
            else
            {
                Console.WriteLine("Password is NOT correct.");
            }
        }
    }
}
