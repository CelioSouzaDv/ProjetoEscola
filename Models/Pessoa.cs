using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEscola.Models
{
    public class Pessoa
    {
        private string _nome;
        public string Nome 
        {
            get => _nome;

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O campo nome deve ser preenchido");
                } _nome = value;
            }
        }
        public string DataNascimento {get; set;}
        public string Registro {get; set;}
    }
}