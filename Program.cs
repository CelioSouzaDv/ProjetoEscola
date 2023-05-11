using ProjetoEscola.Models;


class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno();

        Console.WriteLine("Sistema de Boletim Escolar");
        Console.WriteLine("----------------------------");
        Console.Write("Nome do aluno: ");
        aluno.Nome = Console.ReadLine();
        Console.Write("Data de nascimento: ");
        aluno.DataNascimento = Console.ReadLine();
        Console.Write("RA Escolar: ");
        aluno.Registro = Console.ReadLine();

        for (int i = 1; i <= 4; i++)
        {
            Console.Write("Nota {0}º bimestre: ", i);
            double nota = Convert.ToDouble(Console.ReadLine());
            aluno.Notas.Add("Bimestre " + i, nota);

            Console.Write("Faltas {0}º bimestre: ", i);
            int faltas = Convert.ToInt32(Console.ReadLine());
            aluno.Faltas.Add("Bimestre " + i, faltas);
        }

        Professor professor = new Professor();
        professor.Materia = "Matemática";
        professor.Nome = "- Raimundo Neto";

        double somaNotas = 0;
        foreach (var nota in aluno.Notas.Values)
        {
            somaNotas += nota;
        }
        double mediaFinal = somaNotas / 4;

        double somaFalta = 0;
        foreach (var falta in aluno.Faltas.Values)
        {
            somaFalta += falta;
        }
        double faltaFinal = somaFalta;

        
        Console.WriteLine("\nResultados");
        Console.WriteLine("----------------");
        Console.Write("- Aluno: " + aluno.Nome);
        Console.Write(" - Data de Nascimento: " + aluno.DataNascimento);
        Console.Write($" - Registro: {aluno.Registro} ");
        Console.WriteLine(" - Professor Responsável: " + professor.Nome);
        Console.WriteLine("Materia de: " + professor.Materia);
        Console.WriteLine("----------------");
        Console.WriteLine("Notas:");

        foreach (var nota in aluno.Notas)
        {
            Console.WriteLine(nota.Key + ": " + nota.Value);
        }
        Console.WriteLine($"Média Final: {mediaFinal.ToString("0.00")} e {faltaFinal} faltas.");

        if (mediaFinal >= 6 && faltaFinal <= 30)
        {
            Console.WriteLine($"Aluno {aluno.Nome} aprovado! ");
        }
        else
        {
            Console.WriteLine($"Aluno {aluno.Nome} reprovado.");
        }
        Console.WriteLine("\n");
        Console.WriteLine("Condições para aprovação do Aluno");
        Console.WriteLine("A média deve ser maior que 6.");
        Console.WriteLine("E a quantidade de faltas menor do que 30.");

        Console.WriteLine("Aperte enter para que o programa finalize.");
        Console.ReadLine(); 
    }
}
    
