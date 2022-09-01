using System;

namespace AppTurismo
{
    class Program
    {
        static void Main (string[]  args)
        {
            List<decimal> t = new List<decimal>();
            Turista viajante = new Turista();
            PassagensAereas pa = new PassagensAereas();

            Console.WriteLine("Digite a data do voo");

            string entrada = Console.ReadLine();
            t = entrada.Split(" ").Select(x=> decimal.Parse(x)).ToList();
            Console.WriteLine("A data marcada eh: " + string.Join("/",t));

            viajante.Email = null;
            viajante.Nome = null;
            viajante.SobreNome = null;
            viajante.Senha = "*********";
            char[] cript = viajante.Senha.ToCharArray(); 

            Console.WriteLine("Digite uma senha de 9 caracteres");

            for(int i = 0; i < cript.Length;i++){
                if(cript[i] == '*'){
                  cript[i] = ((char) Console.Read());
                }
            }

            Console.WriteLine("Senha Descriptografada"); 
            Console.WriteLine(cript);

            for(int j = 0; j < cript.Length; j++){
                if(cript[j] != '*'){
                    cript[j] = '*';
                }
            }

            Console.WriteLine("Senha Critografada");
            Console.WriteLine(cript);

        } 
    }   
}         