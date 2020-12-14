using System;

namespace Kata {
    public class Program {
        public static void Main(string[] args) {
            foreach (String cadena in obtenerListado()) {
                Console.WriteLine(cadena);
            }
            Console.ReadKey();
        }
        public static string[] obtenerListado() {
            string[] listado = new string[20];
            for (int i = 1; i <= 20; i++) {
                if ((obtenerFizz(i)) && (obtenerBuzz(i))) {
                    listado[i - 1] = "FizzBuzz";
                } else if (obtenerFizz(i)) {
                    listado[i - 1] = "Fizz";
                } else if (obtenerBuzz(i)) {
                    listado[i - 1] = "Buzz";
                } else {
                    listado[i - 1] = Convert.ToString(i);
                }
            }
            return listado;
        }
        private static bool obtenerFizz(int numero) {
            if (numero % 3 == 0) {
                return true;
            }
            return false;
        }
        private static bool obtenerBuzz(int numero) {
            if (numero % 5 == 0) {
                return true;
            }
            return false;
        }
    }
}