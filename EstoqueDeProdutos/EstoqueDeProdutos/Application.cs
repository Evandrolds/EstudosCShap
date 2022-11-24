using EstoqueDeProduto;
using System;
using System.Globalization;


namespace EstoqueDeProdutos {
     class Application {

        static void Main(string[] args) { 
        
            Produto p = new Produto("TV","Eletronico",6,2400.0);
            Console.WriteLine(p.ToString());
            p.AddProduct(6);
            Console.WriteLine(p.ToString());
            p.RemoveProduct(4);
            Console.WriteLine(p.ToString());    

        }
    }
}
