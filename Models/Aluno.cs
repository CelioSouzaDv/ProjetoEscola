using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEscola.Models
{
    public class Aluno : Pessoa
    {
    public Dictionary<string, double> Notas { get; set; }
    public Dictionary<string, double> Faltas { get; set; }

    public Aluno()
    {
        Notas = new Dictionary<string, double>();
        Faltas = new Dictionary<string, double>();
    }
    }
}