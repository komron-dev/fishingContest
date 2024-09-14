using System.Xml.Linq;
using TextFile;

namespace fishingContest
{
    class Program
    {
        static void Main(string[] args)
        {
            Club club = new();
            try
            {
                string fullPath = "/Users/macbook/ELTE_subjects/OOP/fishingContest/";
                TextFileReader reader = new TextFileReader(fullPath + "contests.txt");
                reader.ReadLine(out string line);

                string[] names = line.Split(' ');
                 
                foreach (var name in names)
                {
                    club.Enter(new Angler(name));
                }

                while (reader.ReadString(out string str))
                {
                    string filename = fullPath + str;
                    TextFileReader reader1 = new(filename);
                    reader1.ReadLine(out string contestName);
                    Contest contest = club.Organize(contestName);

                    while (reader1.ReadString(out string anglerName))
                    {
                        reader1.ReadString(out string species);
                        reader1.ReadDouble(out double weight);

                        Angler angler = new(anglerName);
                        if (club.IsMember(angler))
                        {
                            contest.Register(angler);

                            if (species == "bream") angler.Catch(Bream.Instance(), weight, contest);
                            if (species == "carp") angler.Catch(Carp.Instance(), weight, contest);
                            if (species == "catfish") angler.Catch(Catfish.Instance(), weight, contest);
                        }
                        else
                        {
                            Console.WriteLine($"{anglerName} is not a member");
                        }
                    }
                }

                // Task 1
                Console.WriteLine("Task 1 answers");
                Angler a = new("Johnny");
                Contest c = new("Doborgaz");


                Tuple<int, double> result1 = task1(a, c, club);
                Console.WriteLine($"{a.name} has caught {result1.Item1} catfishes in the contest in {c.loc}");
                Console.WriteLine($"Value of caught fishes is {result1.Item2}");

                // Task 2

                Console.WriteLine("Task 2 answers");
                if (club.Best().Item1)
                {
                    Console.WriteLine($"The most successfull contest is {club.Best().Item2}");
                }
                else
                {
                    Console.WriteLine("There's no such contest");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
        }

        public static Tuple<int, double> task1(Angler angler, Contest contest, Club club)
        {
            int numCatfishes = 0;
            double sumValues = 0;

            foreach (var item in club.contests)
            {
                if (contest == item)
                {
                    foreach (var a in item.anglers)
                    {
                        if (a == angler)
                        {
                            if (!a.CatFish(contest)) return new Tuple<int, double>(numCatfishes, sumValues);

                            foreach (Catch c in a.catches)
                            {
                                if (c.fish.IsCatfish())
                                {
                                    numCatfishes++;
                                }

                                sumValues += c.Value();
                            }
                            break;
                        }
                    }
                    break;
                }
            }

            return new Tuple<int, double>(numCatfishes, sumValues);
        }
    }


}

