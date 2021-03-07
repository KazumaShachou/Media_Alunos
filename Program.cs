using System;

namespace revisao
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;

            string Opcaousuario = ObterOpcaoUsuario();

            while (Opcaousuario.ToUpper() != "X")
            {
                switch (Opcaousuario)
                {
                    case "1":
                        //to do : adicionar aluno
                        Console.WriteLine("Informe o nome do Aluno");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine(); 

                        Console.WriteLine("Informe a nota do aluno");

                        if (decimal.TryParse(Console.ReadLine(),out decimal nota ))
                        {
                            aluno.Nota = nota;
                        }
                        
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;

                    case "2":
                        //to do : listar aluno
                        foreach(var a in alunos){
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"Aluno : {a.Nome} - Nota: {a.Nota}");
                            }
                        }
                        break;

                    case "3":
                        //to do : calcular media geral
                        decimal notaTotal = 0;
                        var numerodealunos = 0;
                        for (int i=0; i < alunos.Length; i++)
                        {
                             if (!string.IsNullOrEmpty(alunos[i].Nome))
                             {
                                 notaTotal = notaTotal + alunos[i].Nota;
                                 numerodealunos++;
                             }
                        }

                        var MediaGeral = notaTotal/numerodealunos;
                        Console.WriteLine($"Media geral: {MediaGeral}");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

     

                Opcaousuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string Opcaousuario = Console.ReadLine();
            return Opcaousuario;
        }
    }
}
