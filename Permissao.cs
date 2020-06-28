using System;

namespace Aula15TryCatch
{
    public class Permissao
    {
        private bool permitir { get; set; }
        
        //Try = tentar fazer algo ------- catch = se der errado vai pegar a excessão / if-else 
        public void Autorizar(){

            try{

                System.Console.WriteLine("Deseja permitir o acesso? Digite True or False");
                permitir = Boolean.Parse( Console.ReadLine());

            }catch(Exception){

                System.Console.WriteLine("Erro na aplicação: Dados inválidos");

            }
        }
    }
}