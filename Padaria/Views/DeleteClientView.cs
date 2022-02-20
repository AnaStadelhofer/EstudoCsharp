using System;

namespace Views
{
    public class DeleteClientView
    {
        public static void DeleteClientViews()
        {
            int Id = 0;
            try
            {
                Console.WriteLine("\n Informe o Id do Cliente para deletar ");
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("\n Id inválido");
            }
        }
    }
}