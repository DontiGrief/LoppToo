using System.Collections;

namespace LoppToo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LÕPP TÖÖ");
            Console.WriteLine("---------");
            Console.WriteLine("Kirjuta 1 - WHERE AVERAGE");
            Console.WriteLine("Kirjuta 2 - FILE WRITER");
            Console.WriteLine("Kirjuta 3 - PYRAMIID");


            string input = Console.ReadLine();
            switch (input) 
            {
                case "1":
                    WhereAverage();
                    break;
                case "2":
                    FileWrite();
                    break;
                case "3":
                    Pyramiid();
                    break;
                default:
                    Console.WriteLine("Vali 1-3");
                    break;
            }
        }
        public static void WhereAverage()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            var where = list.Where(x => x > 0).Average();
            Console.WriteLine(where);
        }
        public static void FileWrite()
        {
            try
            {
                using (StreamWriter kirjuta = new StreamWriter("C:/Users/opilane/Desktop/text.txt", true))
                {
                    if (kirjuta != null)
                    {

                    
                    Console.WriteLine("Kirjuta midagi");
                    string input = Console.ReadLine();
                    if (input != null && input != "")
                    {
                        kirjuta.WriteLine(input);
                        Console.WriteLine("Sa sistasid tekst '" + input + "' faili 'text.txt'");
                    } else {
                        Console.WriteLine("Ei sisetanud teksti");
                           }
                }
                    else
                    {
                        Console.WriteLine("Fail 'text.txt' is null");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Mingi error");
                Console.WriteLine(e.Message);
            }
      
    }
        static void Pyramiid()
        {
            int i, j, rows;
            int num = 0;
            Console.WriteLine("Numbri püramiid");

            Console.WriteLine("Sisesta ridade arv");

            rows = Convert.ToInt32(Console.ReadLine());


            for (i = 0; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                    
                }
                for (j = 1; j <= i - 1; j++)
                {
                    Console.Write("{0} ", num++);
                }
                Console.Write("\n");
            }
        }
    }
}
