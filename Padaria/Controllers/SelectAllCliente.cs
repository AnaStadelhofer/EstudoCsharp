using Models;
using System;

namespace Views
{
    public class SelectAllCliente
    {
        public static void SelectAllClients()
        {
            foreach(object it in Cliente.Clients)
            {
                Console.WriteLine(it);
            }
        }
    }
}