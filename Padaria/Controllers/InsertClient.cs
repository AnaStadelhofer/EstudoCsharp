using Models;

namespace Controllers
{
    public class InsertClient
    {
        public static void InsertClients(int Id, 
                                         string Nome, 
                                         string CPF, 
                                         string DataNascimento, 
                                         string Telefone)
        {
            new Cliente(Telefone, Id, Nome, CPF, DataNascimento);
        }
    }
}