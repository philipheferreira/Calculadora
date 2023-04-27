

namespace principal { 

    class calculadora{  
        public int soma(int x, int y) { 
        return x + y;
        }
        public int sub(int x, int y) {
            return x - y;
        }

        public int mult(int x, int y) { 
            return x * y;
        }

        public float div(float x, float y) {
            return x / y;
        }
    }
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