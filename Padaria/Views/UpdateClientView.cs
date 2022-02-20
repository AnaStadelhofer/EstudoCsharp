using System;

namespace Views
{
    public class UpdateClientViews
    {
        public static void UpdateClienteViews()
        {
            int Id = 0;
            string Nome = "";
            string CPF = "";
            string DataNascimento = "";
            string Telefone = "";

            try
            {
                Console.WriteLine("\n Informe o Id do Cliente para editar: ");
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("\n Id inválido");
            }

            try
            {
                Console.WriteLine("\n Insira o nome do Cliente: ");
                Nome = Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("\n Nome inválido");
            }

             try
            {
                Console.WriteLine("\n Insira o telefone do Cliente: ");
                Telefone = Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("\n Telefone inválido");
            }

             try
            {
                Console.WriteLine("\n Insira o CPF do Cliente: ");
                CPF = Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("\n CPF inválido");
            }

             try
            {
                Console.WriteLine("\n Insira o data de nascimento do Cliente: ");
                DataNascimento = Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("\n Data de Nascimento inválido");
            }
        }
    }
}