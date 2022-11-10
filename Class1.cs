System.Linq;
namespace arreglos
{

    public static class ArrayExtensions
    {
        public static int IndexOf<T>(this T[] array, T value)
        {
            return Array.IndexOf(array, value);
        }
    }
    internal class Program
    {
        public static int convert(char letter)
        {
            char[] alfabeto = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ', '.' };
            int num = alfabeto.IndexOf(letter);
            return num;
        }
        static void Main(string[] args)
        {
            int[,] clave = { { 1, 2, 1 }, { 0, -1, 3 }, { 2, 1, 0 } };
            string frase;
            Console.WriteLine("Ingresa la frase");
            frase = Console.ReadLine();

            char[] frase_array = frase.ToArray();
            int conteo = frase.Length;
            while (conteo % 3 != 0)
            {
                conteo++;
            }
            int[,] pos = new int[conteo / 3, 3];
            int p = 0;
            for (int i = 0; i < conteo / 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (p < frase_Arrays.Length)
                    {
                        pos[i, j] = convert(frase_Array[p]);
                        ;
                    }
                    else
                    {
                        pos[i, j] = 0;
                    }
                    p++;
                }
            }
            for (int i = 0; i < conteo / 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(pos[i, j] + " ");
                }