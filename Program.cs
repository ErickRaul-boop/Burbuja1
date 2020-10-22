using System;

namespace burbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, m = 0; //Variables enteras necesarias
            int[] nums;//arreglo sin definir tamaño

            Console.Write("Escribe una cantidad de números: ");//imprime en pantalla la orden al usuario
            n = int.Parse(Console.ReadLine());
            nums = new int[n];//Dimensiona el arreglo del tamaño que el usuario digitó

            for (int d = 0; d < n; d++)//for que va desde el inicio hasta el final del arreglo
            {
                Console.Write("Escribe el número [{0}]: ", d);//llena el arreglo
                nums[d] = int.Parse(Console.ReadLine());
            }
            //Metodo Burbuja
            for (int x = 1; x < n; x++)//for que va desde la segunda posicion hasta el final
            {

                for (int y = 0; y < n - 1; y++)//segundo for que va desde la primera posicion hasta al final menos uno
                {
                    //Solo cambiamos el operados <0>
                    if (nums[x] > nums[y])//condicion que definira si llos ordenamos de mayor a menor, o menor a MAYOR
                    {
                        m = nums[x];//Variable de apoyo que conserva los valores antes de cambiarlos
                        nums[x] = nums[y];//Cambio de valores de x
                        nums[y] = m;//camio de valores de 
                    }
                }
            }
            //Fin del metodo de burbuja


            for (int r = 0; r < n; r++)//For de salida
            
                Console.WriteLine("{0}", nums[r]);//salida con el nuevo orden
            

                




            Console.ReadKey();
        }
    }
}
