namespace ExamenU2_DGGR
{
    public class Examen
    {
        public void Calificaciones()
        {
            int[] calificaciones;
            calificaciones = new int[101];
            Random random = new Random(101);
            for (int i = 0; i < calificaciones.Length; i++)
            {
                calificaciones[i] = random.Next(101);
                Console.Write(calificaciones[i] + ",");
            }
            Console.WriteLine();
            Console.WriteLine("Las calificaciones ordenadas son");
            int temporal = 0;
            for (int y = 0; y < calificaciones.Length - 1; y++)
            {
                for (int x = y + 1; x < calificaciones.Length; x++)
                {
                    if (calificaciones[y] < calificaciones[x])
                    {
                        temporal = calificaciones[y];
                        calificaciones[y] = calificaciones[x];
                        calificaciones[x] = temporal;
                    }
                }
            }
            for (int a = 0; a < calificaciones.Length; a++)
            {
                Console.Write(calificaciones[a] + ",");
            }
            Console.WriteLine();
            Console.WriteLine("¿Que numero decea buscar?");
            int buscar = Convert.ToInt32(Console.ReadLine());
            int primero = 0;
            int ultimo = calificaciones.Length - 1;
            int posicion = -1;
            while (primero <= ultimo)
            {
                int medio = (primero + ultimo + 1) / 2;
                Console.WriteLine(medio);
                if (calificaciones[medio] == buscar)
                {
                    posicion = medio;
                    break;

                }
                else if (calificaciones[medio] > buscar)
                {
                    primero = medio + 1;

                }
                else 
                {
                    ultimo = medio - 1;

                }

            }
            if (posicion != -1)
            {
                Console.WriteLine($"El numero {buscar} se encuentra en la pocicion {posicion}");
            }
            else
            { Console.WriteLine($"El numero {buscar} no se encuentra"); }

        }

       /* public void vandedores()
        {
            int[,] productovendedor = new int[5, 4] { { 500, 3000, 100, 400 }, { 1000, 150, 200, 500 }, { 250, 1800, 2900, 300 }, { 400, 130, 90, 2400 }, { 60, 20, 4000, 3600 } };
            for (int i = 0; i < productovendedor.GetLength(1); i++)
            {
                for (int j = 0; i < productovendedor.GetLength(0); j++)
                {
                    Console.Write(productovendedor[i, j] + "|");
                }
            }
        }*/

        public void DatosCurp()
        {
            //GORD040727MSRNZLA3
            Console.WriteLine("Ingrece su Curp");
            string curp = Console.ReadLine();

            string sexo = "";
            string HoM = curp.Substring(10, 1);

            if (HoM == "M" || HoM == "m")
            {
                sexo = "Mujer";
            }
            else if (HoM == "H" || HoM == "h")
            {
                sexo = "Hombre";
            }

            string año = curp.Substring(4, 2);
            string mes = curp.Substring(6, 2);
            string dia = curp.Substring(8,2);

            int añoint = int.Parse(año);
            string añocom = "";
            if (añoint <= 23)
            {
                añocom = "20" + año;
            }
            else if (añoint > 23)
            {
                añocom = "19" + año;
            }

            Console.WriteLine($"El sexo es {sexo} y su fecha de nacimieento es {dia}/{mes}/{añocom}");
        }
    }
}
