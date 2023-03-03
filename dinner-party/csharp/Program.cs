using System;
using System.Collections.Generic;
using System.Linq;

namespace DinnerParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Guest> Table1 = new();
            List<Guest> Table2 = new();


            Guest MarilynMonroe = new Guest("Marilyn Monroe", "entertainer", "(1926 - 1962) American actress, singer, mode");
            Guest AbrahamLincoln = new Guest("Abraham Lincoln", "politician", "(1809 - 1865) US President during American civil war");
            Guest MartinLutherKing = new Guest("Martin Luther King", "activist", "(1929 - 1968)  American civil rights campaigner");
            Guest RosaParks = new Guest("Rosa Parks", "activist", "(1913 - 2005)  American civil rights activist");
            Guest PeterSellers = new Guest("Peter Sellers", "entertainer", "(1925 - 1980) British actor and comedian");
            Guest AlanTuring = new Guest("Alan Turing", "computer scientist", "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world");
            Guest AdmiralGraceHopper = new Guest("Admiral GraceHopper", "computer scientist", "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds");
            Guest IndiraGandhi = new Guest("Indira Gandhi", "politician", "(1917 - 1984) Prime Minister of India 1966 - 1977");

            List<Guest> Guests = new()
            {
                MarilynMonroe,
                AbrahamLincoln,
                MartinLutherKing,
                RosaParks,
                PeterSellers,
                AlanTuring,
                AdmiralGraceHopper,
                IndiraGandhi
            };

            List<string> table1Occupations = new List<string>();

            foreach (Guest guest in Guests)
            {
                if (!table1Occupations.Contains(guest.Occupation))
                {
                    table1Occupations.Add(guest.Occupation);
                    Table1.Add(guest);
                }
                else
                {
                    Table2.Add(guest);
                }
            }

            Console.WriteLine("Table 1:");
            foreach (Guest guest in Table1)
            {
                Console.WriteLine($"{guest.Name}");
            }
            Console.WriteLine("Table 2:");
            foreach (Guest guest in Table2)
            {
                Console.WriteLine($"{guest.Name}");
            }
        }
    }
}



