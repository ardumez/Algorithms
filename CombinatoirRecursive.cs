 class Program
    {
        static string tab = "1234";
        static int taille = tab.Length;

        static void Main(string[] args)
        {
            for(int i=1; i <= taille; i++)
            {
                generer(i, "", 0);
            }
            Console.ReadLine();
        }

        public static void generer(int loop, string sb, int start)
        {
            if(sb.Length >= loop)
            {
                Console.WriteLine(sb);
                return;
            }

            for (int i = start; i < taille; i++)
            {
                generer(loop, sb + tab[i], i + 1);
            }
        }
    }
