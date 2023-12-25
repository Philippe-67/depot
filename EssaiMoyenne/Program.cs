using System.IO.Pipes;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    static void Main(string[] args)

    {
        int[]numbers=new int[5];
        int total = 0;
        double moy = 0.0;
        var rand=new Random();

        for (int i = 0; i < 5; i++)
        {
            numbers[i] = rand.Next(10);
            total += numbers[i];
            Console.WriteLine(numbers[i]);
        }
        Console.WriteLine(total);
        moy = total / 5.0;
       // Console.WriteLine(moy);
       Console.WriteLine($"moyenne: {moy:F2}");

        int maxNumber = 0;

        foreach (var number in numbers)
        {
            maxNumber = Math.Max(maxNumber, number);
        }
        Console.WriteLine(maxNumber);
       // Console.WriteLine(Math.Round(moy,2}}");
         string LeText = File.ReadAllText("Test.text");
        Console.WriteLine(LeText);        //// déclaration du tableau
        //int[]tableau = { 1, 2, 3, 4, 5, 6, 7,8,9, 10};

        ////instanciation d'une variable pour accueillir la valeur de la somme des entiers
        //double somme = 0;
        //double multiplication= 1;

        ////calcul de la somme des entiers présents dans la tableaux

        //foreach (var entier in tableau)
        //{
        //   somme += entier;
        //    Console.WriteLine( somme);
        //    string test = "essai d ecritire dans fichier";
        //    Console.WriteAllText("Test.text", test);       
        //foreach (var entier in tableau)
        //{
        //    multiplication *= entier;
        //    Console.WriteLine(multiplication);
        //}

        //// calcul de la moyenne avec double pour précision decimale
        //double moyenne = 0;
        
        //Console.WriteLine((somme)/tableau.Length);
    }
}