using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Biblioteca
{
    public class Class1
    {
        List<string> Alunos = new List<string>();
        
        Alunos.Add("Auro");
        Alunos.Add("Herculano");
        Alunos.Add("Berenice");
        Alunos.Add("Luiz Antonio");
        Alunos.Add("Eustáquio");
        Alunos.Add("Luzia");
        Alunos.Add("Lucélia");
        Alunos.Add("Carmen");
        Alunos.Add("Geraldino");
        Alunos.Add("Edinelza");
                    
        foreach (string item in Alunos)
         {
            Console.WriteLine(nome + " ");
         }

            Console.ReadKey();
    }
}
