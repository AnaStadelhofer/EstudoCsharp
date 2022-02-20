using System;
using Controllers;

namespace Views
{
    public class SelectClienteView
    {
        public static void SelectClienteViews()
        {
            Console.WriteLine("\n Todos clientes");
            try
            {
                SelectAllCliente.SelectAllClients();
            }
            catch(Exception)
            {
                Console.WriteLine("\n Erro ao chamar a funçaõ de seleção dos clientes");
            }
        }
    }
}