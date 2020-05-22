using System;

namespace Aula_3
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Personagem hulk = new Personagem();
            hulk.armadura =  "super força";
            hulk.name = "Robert Bruce Banner";
            hulk.age = 72 ;
            
            Console.WriteLine("Seu nome verdadeiro é " + hulk.name);
            Console.WriteLine("Ele já possui " + hulk.age + " anos");
            Console.WriteLine(hulk.Defender() );

            Console.WriteLine(hulk.Atacar(100f, 80f) + "!!!");

        }
    }
}
