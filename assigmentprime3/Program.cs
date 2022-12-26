class assigmentprime3
{
    public static void Main(string[] args)

    {
        Console.WriteLine("Welcome To The Calculator.");
        Console.WriteLine("");
        Console.WriteLine("Calculates All Prime Numbers Between 1 and the Number You Choose");
        Console.WriteLine("");
        Console.Write("Enter A Number . İt Have To Bigger Than 1 : ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        bool[] primenumber = new bool[number + 1];
        for (int i = 2; i <= number; i++) primenumber[i] = true;

        int limit = (int)Math.Ceiling(Math.Sqrt(number));

        for (int i = 2; i <= limit; i++)
            if (primenumber[i])
                for (int j = i * i; j <= number; j += i)
                    primenumber[j] = false;

        Console.WriteLine("Prime Numbers Are : ");
        Console.WriteLine("");
        Console.WriteLine(number);

        for (int i = 0; i <= number; i++)
            if (primenumber[i])
                Console.WriteLine(i);
    }

}