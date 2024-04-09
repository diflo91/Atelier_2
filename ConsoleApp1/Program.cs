namespace System;

class Ateliers
{
    static void Main(string[] args)
    {
        // Declaration des variables

        // 1 Declaration des entiers
        byte monEntierByte = 255;
        short monEntierShort = short.MaxValue;

        int monEntierInt = monEntierByte + monEntierShort;

        Console.WriteLine($"mon Byte {monEntierByte}");
        Console.WriteLine($"mon Short {monEntierShort}");
        Console.WriteLine($"mon Int {monEntierInt}");



        // 2 Declaration des flottants

        float monFloatFloat = 2.3f;
        double monFloatDouble = monFloatFloat / 1.7;

        Console.WriteLine($"float :{monFloatFloat.ToString()} et double :{monFloatDouble}");


        // 3 Declaration de ma chaine de carectere

        int maChaineDeCaractere = 'A';
        Console.WriteLine($" Mon char :{maChaineDeCaractere}");
        maChaineDeCaractere = (char) (maChaineDeCaractere++);
        Console.WriteLine($"mon char :{maChaineDeCaractere}");

        // Cast
        //
        //char monCharF = (char)70;
        char monCharF = (char) 0x46;
        Console.WriteLine(monCharF);

        monCharF++;
        Console.WriteLine(monCharF);


    }
}