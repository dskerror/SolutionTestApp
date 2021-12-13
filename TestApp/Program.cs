using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Por favor entre el valor de la prima:");
            string prima = Console.ReadLine();

            //int prima = 100;

            double percComm = 0.2;
            double totalComm = 0;
            //double totalComm = prima * percComm;

            try
            {
                totalComm = int.Parse(prima) * percComm;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"El valor debe ser númerico y entero.");
                //Console.WriteLine(ex.Message);
                throw;
            }
            

            //// * multiplicacion
            //// / division
            //// + suma
            //// - resta
            //// % mod
            //// () parentesis

            string numDePoliza = "PA-1234567-00";

            string msgPrima = $"La prima de la póliza {numDePoliza} es:";
            string msgPercComm = "El porciento de comm del productor es:";
            string msgTotalComm = "La comision del productor es:";

            //DateTime effDate = DateTime.Now;

            //Boolean HasBalance = false;


            Console.WriteLine($"{msgPrima} {prima}");
            Console.WriteLine($"{msgPercComm} {percComm}");
            Console.WriteLine($"{msgTotalComm} {totalComm}");
            //Console.WriteLine($"Effective Date: {effDate.ToShortDateString()}");
            //Console.WriteLine($"Has Balance: {HasBalance}");

            Console.ReadLine();
        }
    }
}
