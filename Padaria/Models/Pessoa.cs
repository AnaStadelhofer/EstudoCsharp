using System;

namespace Models
{
    public class Pessoa
    {
        public int IdPeople {set; get;}
        public string NamePeople {set; get;}
        public string CPF {set; get;}
        public string DateNasc {set; get;}

        public Pessoa(int IdPeople,
                      string NamePeople,
                      string CPF,
                      string DateNasc)
        {
            this.IdPeople = IdPeople;
            this.NamePeople = NamePeople;
            this.CPF = CPF;
            this.DateNasc = DateNasc;
        }

        public override string ToString()
        {
            return "\n =====================" +
                   "\n Id: " + IdPeople +
                   "\n Nome: " + NamePeople + 
                   "\n CPF: " + CPF +
                   "\n Data de Nascimento: " + DateNasc +
                   "\n =====================" ;
        }
    }
}