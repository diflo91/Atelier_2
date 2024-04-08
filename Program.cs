namespace Quetes_1;

class Ateliers
{
    static void Main(string[] args)
    {
        // Declaration des variables

        // 1 Declaration des entiers
        byte monEntierByte = 255;
        short monEntierShort = 32767;
        int monEntierInt = 2147483647;
        long monEntierLong = 9223372036854775807;


        // 2 Declaration des flottants

        float monFloatFloat = 4294967296;
        double monFloatDouble = monFloatFloat / 10;

        Console.WriteLine($"float :{monFloatFloat}, double :{monFloatDouble}");


        // 3 Declaration de ma chaine de carectere

        char maChaineDeCaractere = 'a';
        Console.WriteLine($"{maChaineDeCaractere}");


    }
}

