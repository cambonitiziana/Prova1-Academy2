using ExpensesManagement;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExpensesManagementWatcher
{
    public class EventManagementWatcher
    {

        public static void NewFileAllert(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File {e.Name} has been created");
            
            using (StreamReader reader = File.OpenText(e.FullPath))
            {
                Console.WriteLine($"Reading {e.Name} ");
                string line; 
                while ((line = reader.ReadLine()) != null)
                {

                    string[] splittedLine = line.Split(";");
                    
                    Console.WriteLine("{0} - {1} - {2} - {3}", splittedLine[0], splittedLine[1], splittedLine[2], splittedLine[3]);

                    
                }

                
                Console.WriteLine("End");
                Console.WriteLine();
                reader.Close();
            }
            

        }

        public static List<Expense> NewListExp()
        {
            
            List<Expense> expences = new List<Expense>();//faccio una lista di spese
            using (StreamReader reader = File.OpenText(@"C:\Users\tiziana.camboni\Desktop\Academy\Academy2\Settimana1\Week1Test\spese.txt"))
            {
                
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    string[] splittedLine = line.Split(";");
                    var ex = new Expense(splittedLine[2], Convert.ToDecimal(splittedLine[3]), Convert.ToDateTime(splittedLine[0]), splittedLine[1]);
                    expences.Add(ex);
                }


              
                reader.Close();
            }
            return expences;

        }

    }
}
