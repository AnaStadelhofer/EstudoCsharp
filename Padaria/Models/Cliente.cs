using System;
using System.Collections.Generic;

namespace Models
{
    public class Cliente : Pessoa
    {
        public string NumberPhone {get; set;}
        public static List<Cliente> Clients = new List<Cliente>();
        public Cliente(string NumberPhone,
                       int IdPeople,
                       string NamePeople,
                       string CPF,
                       string DateNasc):
                       base(IdPeople, NamePeople, CPF, DateNasc)
        {
            this.NumberPhone = NumberPhone;
            Clients.Add(this);
        }

        public override string ToString()
        {
            return "\n\n =====================" +
                   "\n Id: " + base.IdPeople +
                   "\n Nome: " + base.NamePeople + 
                   "\n CPF: " + base.CPF +
                   "\n Data de Nascimento: " + base.DateNasc +
                   "\n Número de telefone: " + NumberPhone +
                   "\n ===================== \n" ;
        }
    }
}