using System;

namespace verificaCaractere
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letras = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            // int[] numeros = {0, 1, 2, 3, 4, 5, 6, 7, 8 , 9};
            char caracter;
            bool eletra = false;

            Console.WriteLine("Digite um caracter");
            char.TryParse(Console.ReadLine(), out caracter);
            Console.WriteLine($"Caracter informado: {caracter}");
            Console.WriteLine("Identificando...\n");
            for(var i = 0; i < letras.Length; i++)
            {
                if(letras[i].ToLower() == caracter.ToString())
                {
                    eletra = true;
                }
            }
            if (eletra)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine($"O caracter {caracter} é uma letra!");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"O caracter {caracter} é um número!");
                Console.ResetColor();
            }
        }
    }
}
