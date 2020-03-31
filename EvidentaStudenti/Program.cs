using LibrarieEntitati;
using System;


namespace ManagementStudenti
{

    class Program
    {
        public void Meniu(ref string optiune)
        {
            Console.Clear();
            Console.WriteLine("S.: Citeste note de la tastatura ca un sir de caractere");
            Console.WriteLine("T: Citeste note de la tastatura (cate o nota pe rand)");
            Console.WriteLine("C: Citeste note din linia de comanda");
            Console.WriteLine("A: Afisare note");
            Console.WriteLine("X: Exit");
            Console.WriteLine("Introduceti optiunea");
            Console.WriteLine("--------------------");
            optiune = Console.ReadLine().ToUpper();
            
        }
        static void Main(string[] args)
        {
            Program functii = new Program();
            int[] note_int;
            string optiune = string.Empty;
            Student Ion = new Student("Ion");
            Student George = new Student("George");

            do
            {
                functii.Meniu(ref optiune);
                switch (optiune)
                {
                    case "S":
                        string note;
                        note = Console.ReadLine();
                        Ion.SetNote(note);
                        Console.WriteLine(Ion.ConversieLaSir());
                        Console.ReadKey();
                        break;
                    case "T":
                        int an = 0;
                           while (an < 4) {
                            Console.WriteLine("Cate note doriti sa introduceti in anul {0} de studiu", an+1);
                            int n = Convert.ToInt32(Console.ReadLine());
                            note_int = new int[n];
                            for (int i = 0; i < n; i++)
                                note_int[i] = Convert.ToInt32(Console.ReadLine());
                            George.SetNote_ONE_BY_ONE(note_int,n,an);
                            an++;
                            
                        }
                        break;
                    case "C":
                        string note_arg = string.Empty;
                        if (args.Length != 0)
                            note_arg = string.Join(" ", args);
                        George.SetNote(note_arg);
                        Console.WriteLine(George.ConversieLaSir());
                        Console.ReadKey();
                        break;
                    case "A":
                        Console.WriteLine(George.ConversieLaSir());
                        Console.ReadKey();

                        break;
                    case "X":
                        break;
                        return;


                }



            } while (true);


        }
            
    }
}
