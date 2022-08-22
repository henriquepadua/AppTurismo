using System;

namespace AppTurismo
{
    class Program
    {
        static void Main (string[]  args)
        {
            List<Turista> t = new List<Turista>();
            Turista viajante = new Turista();

            if(t != null){
               t.Add(viajante);
               viajante.Email = "henrique.lommes@gmail.com";
               viajante.Nome = "Henrique";
               viajante.SobreNome = "Lommes";

               Console.WriteLine(t.First().Email + " " + t.First().Nome + " " + t.First().SobreNome);
            }
        } 
    }   
}        
