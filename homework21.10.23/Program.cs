using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace homework21._10._23
{
    internal class Program
    {
        static string StringWork(ref string strings)
        {
            char[] chars = strings.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public static void SearchEmail(ref string s)
        {
            char a = '#';
            int IndexOfa = s.IndexOf(a);
            s = s.Substring(IndexOfa + 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 8.2");
            Console.WriteLine("Enter a string:");
            string strings = Console.ReadLine();
            string reversed = StringWork(ref strings);
            Console.WriteLine("Result:" + reversed);
            

            Console.WriteLine("\nTask 8.3");
            Console.WriteLine("Enter the filename:");
            string path = Console.ReadLine();
            if (File.Exists(path))
            {
                string new_file = "NewFile.txt";
                string content = File.ReadAllText(path);
                string upper = content.ToUpper();
                File.WriteAllText(new_file, upper);
                Console.WriteLine("The file is downloaded successfully.");
                
            }
            else
            {
                Console.WriteLine("The file does not exist.");  
            }

            Console.WriteLine("\nHome task 8.1");
            string path1 = "hometask.txt";
            string[] lines = File.ReadAllLines(path1);
            string file = "emails.txt";
            using (StreamWriter sw = new StreamWriter(file))
            {
                foreach (string line in lines)
                {
                    string email = line;
                    SearchEmail(ref email);
                    sw.Write("\n" + email);
                }
            }
            Console.WriteLine("The file is created.");

            Console.WriteLine("\nHome task 8.2");
            List<Song> songs = new List<Song>(4);
            songs.Add(new Song("Chicago", "Michael Jackson", null));
            songs.Add(new Song("Earned it", "The Weeknd", songs[0]));
            songs.Add(new Song("Trust Nobody", "Hippie Sabotage", songs[1]));
            songs.Add(new Song("Play with Fire", "Hippie Sabotage", songs[2]));
            foreach (Song s in songs)
            {
                Console.WriteLine(s.Title());
            }
            if (songs[0].Equals(songs[1]))
            {
                Console.WriteLine("Song 1 and song 2 are equal.");
            }
            else
            {
                Console.WriteLine("Song 1 and song 2 are not equal.");
            }
            Console.WriteLine("(Pass any key to continue work)");
            Console.ReadKey();

 
        }
    }
}
