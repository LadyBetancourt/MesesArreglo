namespace Meses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número");
            string[] meses = new string[12];

            meses[0] = "Enero";
            meses[1] = "Febrero";
            meses[2] = "Marzo";
            meses[3] = "Abril";
            meses[4] = "Mayo";
            meses[5] = "Junio";
            meses[6] = "Julio";
            meses[7] = "Agosto";
            meses[8] = "Septiembre";
            meses[9] = "Octubre";
            meses[10] = "Noviembre";
            meses[11] = "Diciembre";

            string input = Console.ReadLine();
            int.TryParse(input, out int result);

            if (result > 0 && result <= 12)
            {
                Console.WriteLine(meses[result - 1]);
            }
            else
            {
                Console.WriteLine("Dato incorrecto");
            }

        }
    }
}
