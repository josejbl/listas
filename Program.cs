using System;
using System.Collections.Generic;
using Listas.Classes;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
           //Criando a lista
           List<Produto> produto = new List<Produto>();

            produto.Add (new Produto(1,"Geladeira smart",5890.45f) );
            produto.Add (new Produto(2,"Fogão 5 bocas ",2134.19f) );
            produto.Add (new Produto(3,"Armario de Cozinha",823.1f) );
            produto.Add (new Produto(4,"Guarda-Roupa",1743.12f) );
            produto.Add (new Produto(5,"Mesa de Jantar",618.50f) );
            produto.Add (new Produto(6,"TV Smart",2750.25f) );
            produto.Add (new Produto(7,"Maquina de Lavar",1023.20f) );



            Produto estante = new Produto();
            estante.Codigo = 8;
            estante.Nome = "estante";
            estante.Preco = 550f;

            produto.Add(estante);
             
            foreach(Produto p in produto){
                Console.WriteLine($" {p.Codigo} - {p.Nome} - R$ {p.Preco} ");
            }
            
            produto.RemoveAt(4);
            produto.RemoveAt(2);
            

            produto.RemoveAll(x => x.Nome == "Geladeira Smart");

            Console.WriteLine("\nLista alterada : ");
            foreach(Produto p in produto){
                Console.WriteLine($"{p.Codigo} - {p.Nome} - R${p.Preco}");
            }



        }
    }
}
