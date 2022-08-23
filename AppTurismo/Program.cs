using System;

namespace AppTurismo
{
    class Program
    {
        static void Main (string[]  args)
        {
            List<Hospedagem> t = new List<Hospedagem>();
            Turista viajante = new Turista();

            int i;
            viajante.Email = null;
            viajante.Nome = null;
            viajante.SobreNome = null;
            viajante.Senha = "*********";
            char[] cript = viajante.Senha.ToCharArray(); 

            Console.WriteLine("Digite uma senha de 9 caracteres");

            for(i = 0; i < cript.Length;i++){
                if(cript[i] == '*'){
                  cript[i] = ((char) Console.Read());
                }
            }

            Console.WriteLine("Senha Descritografada"); 
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