using System;
using System.IO;
namespace ExceptionHandlingDemo
{
    class Program
    {
        public static void Main()
        {
            try
            {
                try
                {
                  
                    Console.WriteLine("Enter First Number");
                    int FN = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    int SN = Convert.ToInt32(Console.ReadLine());
                    int Result = FN / SN;
                    Console.WriteLine("Result = {0}", Result);
                }
                catch (Exception ex)
                {
                    
                    string filePath = @"C:\LogFile\Log.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.Write(ex.GetType().Name + ex.Message + ex.StackTrace);
                        sw.Close();
                        Console.WriteLine("There is a problem! Plese try later");
                    }
                    else
                    {
                       
                        throw new FileNotFoundException(filePath + " Does not Exist", ex);
                    }
                }
            }
            catch (Exception e)
            {
               
                Console.WriteLine("Current or Outer Exception = " + e.Message);
                
                if (e.InnerException != null)
                {
                    Console.Write("Inner Exception : ");
                    Console.WriteLine(String.Concat(e.InnerException.StackTrace, e.InnerException.Message));
                }
            }
            Console.ReadLine();
        }
    }
}
