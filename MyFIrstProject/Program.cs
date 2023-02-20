namespace MyFIrstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, ucl!");

            Console.Write("hvad er dit fornavn? ");

            string firstName;
            firstName = Console.ReadLine();

            Console.WriteLine("Velkommen " + firstName);

            Console.Write("Hvad er dit Efternavn? ");

            string lastName;
            lastName = Console.ReadLine();
            Console.WriteLine("HEj med dig " + firstName +" "+ lastName );

            Console.WriteLine("håber det her virker");

            Console.ReadLine();
        }
    }
}