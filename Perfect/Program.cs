internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter number 1");
        int a =int.Parse(Console.ReadLine());
        Console.WriteLine("Enterr the sec number ");
        int b =int.Parse(Console.ReadLine());
        for(; a<=b; a++)
        {
            int c= 0;
            for (int n =1 ; n<a; n++)
            {
                if (a%n==0)
                {
                    c += n;
                }
            }
            if (c == a)
            {
                Console.WriteLine(a);
            }
        }
        Console.ReadKey();  
    }
}