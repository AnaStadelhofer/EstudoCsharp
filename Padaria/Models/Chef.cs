using System;

namespace Models
{
    public class Chef : Pessoa
    {
        public string Especialidade {get; set;}
        public Double Salario {get; set;}
        public Chef(string Especialidade, 
                    Double Salario,
                    int IdPeople,
                    string NamePeople,
                    string CPF,
                    string DateNasc): 
                    base (IdPeople, NamePeople, CPF, DateNasc)
        {
            this.Especialidade = Especialidade;
            this.Salario = Salario;
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