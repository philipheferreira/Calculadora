using System; // importacao do sistema
using calc;

    public class Program {  
        static void MenuCronometro() {
            Console.WriteLine("Menu do cronometro sera feito");
        }

        static void MenuCalculadora() {
            int primeiroNumero, segundoNumero, menuCalculadora;
            calculadora meuObjt1 = new calculadora();

            do
            {
                Console.WriteLine("####---Calculadora---#######");

                Console.WriteLine("1- somar");

                Console.WriteLine("2-subtrair");

                Console.WriteLine("3-multiplicar");

                Console.WriteLine("4-dividir");

                Console.WriteLine("0-sair");

                menuCalculadora = Convert.ToInt32(Console.ReadLine());


                if (menuCalculadora == 1)
                {
                    Console.WriteLine("Digite o primeiro numero da operacao:");
                    primeiroNumero = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o segundo numero da operacao");
                    segundoNumero = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("A soma do numero " + primeiroNumero + " com o numero " + segundoNumero + " é igual a " + meuObjt1.soma(primeiroNumero, segundoNumero));

                }
                else if (menuCalculadora == 2)
                {
                    Console.WriteLine("Digite o primeiro numero da operacao:");
                    primeiroNumero = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o segundo numero da operacao");
                    segundoNumero = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("A subtracao do numero " + primeiroNumero + " com o numero " + segundoNumero + " é igual a " + meuObjt1.sub(primeiroNumero, segundoNumero));

                }
                else if (menuCalculadora == 3)
                {
                    Console.WriteLine("Digite o primeiro numero da operacao:");
                    primeiroNumero = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o segundo numero da operacao");
                    segundoNumero = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("A Multiplicação do numero " + primeiroNumero + " com o numero " + segundoNumero + " é igual a " + meuObjt1.mult(primeiroNumero, segundoNumero));

                }
                else if (menuCalculadora == 4)
                {
                    Console.WriteLine("Digite o primeiro numero da operacao:");
                    primeiroNumero = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o segundo numero da operacao");
                    segundoNumero = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("A divisão do numero " + primeiroNumero + " com o numero " + segundoNumero + " é igual a " + meuObjt1.div(primeiroNumero, segundoNumero));

                }
                else
                {
                    Console.WriteLine("Voce colocou uma informacao incorreta");
                }
            } while (menuCalculadora != 0);

        }

        static void Main(string[] args) {
        MenuCronometro();
        }
    }