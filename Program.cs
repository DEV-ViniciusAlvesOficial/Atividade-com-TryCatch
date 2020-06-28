using System;
using System.IO;

namespace Aula15TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Permissao app = new Permissao();
            app.Autorizar();

            try{
                using (StreamReader sr = File.OpenText("FraseZigueira.txt"))
                {
                    Console.WriteLine($"A primeira linha do arquivo é: \n {sr.ReadLine()}");
                    //$ serve para se referir a algo fora do WriteLine 
                }
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine($"O arquivo não foi encontrado");
            }
            
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"O diretório não foi encontrado");
            }
            
            catch (IOException)
            {
                Console.WriteLine($"O arquivo não foi encontrado");
            }
        }
    }
}
