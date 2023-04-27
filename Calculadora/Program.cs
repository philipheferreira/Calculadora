using System;

namespace principal { 

    public class Program {  
        static void Main(string[] args) {

            calculadora meuObjt1 = new calculadora();

            Console.WriteLine(meuObjt1.soma(20, 40));

            Console.WriteLine(meuObjt1.sub(20, 40));

            Console.WriteLine(meuObjt1.mult(20, 40));

            Console.WriteLine(meuObjt1.div(20, 40));
        }
    }

}