namespace SwapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Swap(a, b);
            Console.WriteLine($"a: {a}, b: {b}");

            Swap(ref a, ref b);
            Console.WriteLine($"a: {a}, b: {b}");

            string s = "Hello";
            ChangeStr(s);
            Console.WriteLine(s);

            string s1 = "Hello";
            ChangeStr(ref s1);
            Console.WriteLine(s1);

            string? s2 = null;      // null forgiving for null ! | -> string? s2 = null; <- nullable string
            ChangeStr2(out s2);
            Console.WriteLine(s2);
        }

        public static void Swap(int a, int b)   // Does not work like Java
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static void Swap(ref int a, ref int b)   // By referance swapping
        {
            //int tmp = a;
            //a = b;
            //b = tmp;
            (a, b) = (b, a);    // Τuples 
        }

        public static void ChangeStr(string str)    // Does not work - local copy
        {
            str = "AUEB";
        }

        public static void ChangeStr(ref string str)    // By referance
        {
            str = "AUEB";
        }

        public static void ChangeStr2(out string? str)    // By referance - can take null as input
        {
            str = "AUEB";
        }
    }
}
