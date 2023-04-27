using System;

namespace principal { 

    public class Program {  
        static void Main(string[] args) {
            int menu;
            calculadora meuObjt1 = new calculadora();

            do {
                Console.WriteLine("####---Calculadora---#######");

                Console.WriteLine("1- somar");

                Console.WriteLine("2-subtrair");

                Console.WriteLine("3-multiplicar");

                Console.WriteLine("4-dividir");

                Console.WriteLine("0-sair");

                menu = Convert.ToInt32(Console.ReadLine());

                if(menu == 1) { 
                    Console.WriteLine(meuObjt1.soma(20, 40));
                } else if(menu == 2) { 
                    Console.WriteLine(meuObjt1.sub(20, 40));
                } else if(menu == 3) { 
                    Console.WriteLine(meuObjt1.mult(20, 40));
                } else if(menu == 4) { 
                    Console.WriteLine(meuObjt1.div(20, 40));
                } else {
                    Console.WriteLine("Voce colocou uma informacao incorreta");
                }
            } while (menu != 0);
        }
    }

}