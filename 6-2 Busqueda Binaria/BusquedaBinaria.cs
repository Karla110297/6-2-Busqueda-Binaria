using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_Busqueda_Binaria
{
    public class BusquedaBinaria
    {
        public void Menu()
        {
            Console.WriteLine("¿Que numero de ejemplo?");
            Console.WriteLine("1 o 2 y  otro para salir");//0 para que se realize la accion default que es salirse
            int numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.Clear();
                    ejemplo1();

                    Console.ReadKey();
                    Menu();//Regresa al menu
                    break;
                case 2:
                    Console.Clear();
                    ejemplo2();

                    Console.ReadKey();
                    Menu();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Adios");
                    break;

            }
        }

        public void ejemplo1()
        {
            int[] arreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };//arreglo donde se buscara ele elemento



            Console.WriteLine("Elemento a buscar:");//pide el elemento a buscar
            int buscar = int.Parse(Console.ReadLine());

            BusBinaria(0, 9, arreglo, buscar);//se llama al metodo de busqueda

            Console.WriteLine("Arreglo:");//y se imprime el arreglo para ver si se ha acertado
            foreach (int e in arreglo)
            {
                Console.Write(e + "  ");
            }
        }

        public void ejemplo2()
        {
            Console.WriteLine("¿Cuantos elementos desea agregar en su arreglo?");
            int n = int.Parse(Console.ReadLine());//este sera el tamaño del arreglo

            int[] arreglo = new int[n];//arreglo donde se buscara el elemento


            for (int i = 0; i < arreglo.Length; i++)//pide a usuario llenar arreglo ordenadamente y sin repeticiones
            {
                if (i == 0)
                {
                    Console.WriteLine("ingresar numero {0} al arreglo", i + 1);
                    arreglo[i] = int.Parse(Console.ReadLine());
                }
                else
                {
                    do
                    {

                        try
                        {
                            Console.WriteLine("ingresar numero {0} al arreglo", i + 1);
                            arreglo[i] = int.Parse(Console.ReadLine());
                            if (arreglo[i] <= arreglo[i - 1])//lanza excepcion si no esta ordenado
                            {
                                throw new Exception();
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("El numero debe ser mayor al anterior", e);//mensaje a usuario para que corrija
                        }
                    } while (arreglo[i] <=arreglo[i - 1]);
                }
            }


            Console.WriteLine("Elemento a buscar:");//pide el elemento a buscar
            int buscar = int.Parse(Console.ReadLine());

            BusBinaria(0, arreglo.Length-1, arreglo, buscar);//se llama al metodo de busqueda

            Console.WriteLine("Arreglo:");//y se imprime el arreglo para ver si se ha acertado
            foreach (int e in arreglo)
            {
                Console.Write(e + "  ");
            }
        }

        public void BusBinaria(int i, int j, int[] arreglo, int buscar)//i es el indice inicial del arreglo y j el ultimo, se pide el arreglo donde se buscara el elemento y el elemento
        {
            int m = (i + j) / 2;

            if (arreglo.Contains(buscar))//si el elemento esta en el arreglo entonces empieza a buscar el indice 
            {

                if (buscar < arreglo[m])//si el elemento es menor al elemento en m reduce el rango modificando j
                {
                    j = m - 1;

                    BusBinaria(i, j, arreglo, buscar);


                }
                else if (buscar > arreglo[m])//si el elemento es mayor reduce el rango modificando i
                {
                    i = m + 1;
                    BusBinaria(i, j, arreglo, buscar);

                }
                else//si es igual a m se ha encontrado el indice
                {
                    Console.WriteLine("El elemento se encuentra en el indice {0}", m);
                }
            }
            else//si no se encuentra el elemento en el arreglo se manda un mensaje
            {
                Console.WriteLine("El elemento no se encuentra en el arreglo");
            }






        }









    }
}
