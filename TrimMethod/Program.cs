namespace TrimMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string b = " *Azerbaijan  *";
            b = TrimMethod.Trim(b);
            Console.WriteLine(b);

            Console.WriteLine("Enter:  ");
            string c =Console.ReadLine();
            c = TrimMethod.TrimStart(c);
            Console.WriteLine(c);


            string d = "***Hello World   * * * * ";
            d = TrimMethod.TrimEnd(d);
            Console.WriteLine(d);

        }
    }

    static class TrimMethod
    {
        public static string Trim(string cumle)
        {

            char[] a = { ' ', '*' , ':' , ';' };
            string temiz = cumle.Trim(a);
            return temiz;
           
        }

        public static string TrimStart(string cumle)
        {
            char[] a = { ' ', '+', '*', '/' };
            string temiz = cumle.TrimStart(a);
            return temiz;
        }

        public static string TrimEnd(string cumle)
        {
            char[] a = { ' ', '+', '*', '/' };
            string temiz = cumle.TrimEnd(a);
            return temiz;
        }


    }
}