using System;
using Views;

namespace Padaria
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int Option = 0;
            do
            {
                Console.WriteLine(" Escolha uma opção: ");
                Console.WriteLine("\n [1] - Insert Cliente");
                Console.WriteLine("\n [2] - Update Cliente");
                Console.WriteLine("\n [3] - Delete Cliente");
                Console.WriteLine("\n [4] - Select Cliente");
                Console.WriteLine("\n [5] - Update Chef");
                Console.WriteLine("\n [6] - Delete Chef");
                Console.WriteLine("\n [7] - Select Chef");
                Console.WriteLine("\n [8] - Insert Chef");
                Console.WriteLine("\n [9] - Sair");
                Console.WriteLine("\n Escolha a opção: ");
                try
                {
                    Option = Convert.ToInt32(Console.ReadLine());
                } 
                catch (Exception)
                {
                    Console.WriteLine("\n Opção inválida!");
                }

                switch(Option)
                {
                    case 1:
                        Console.WriteLine("Insert Cliente");
                        try
                        {
                            InsertClientView.InsertClienteViews();
                        }
                        catch(Exception)
                        {
                            Console.WriteLine("\n Erro ao chamar o View do InsertClient");
                        }
                    break;
                    case 2:
                        Console.WriteLine("Update Cliente");
                        try
                        {
                            UpdateClientViews.UpdateClienteViews();
                        }
                        catch(Exception)
                        {
                            Console.WriteLine("\n Erro ao chamar o View do UpdateClient");
                        }
                    break;
                    case 3:
                        Console.WriteLine("Delete Cliente");
                        try
                        {
                            DeleteClientView.DeleteClientViews();
                        }
                        catch(Exception)
                        {
                            Console.WriteLine("\n Erro ao chamar o View do Deletelient");
                        }
                    break;
                    case 4:
                        try
                        {
                            SelectClienteView.SelectClienteViews();
                        }
                        catch(Exception)
                        {
                            Console.WriteLine("\n Erro ao chamar o View do SelectClient");
                        }
                    break;
                    case 5:
                        Console.WriteLine("Update Chef");
                    break;
                    case 6:
                        Console.WriteLine("Delete Chef");    
                    break;
                    case 7:
                        Console.WriteLine("Select Chef");
                    break;
                    case 8:
                        Console.WriteLine("Select Chef");
                    break;
                    default:
                        Console.WriteLine("\n\n Adeus...\n\n");
                    break;
                }
            }
            while(Option != 9);
        }
    }
}
