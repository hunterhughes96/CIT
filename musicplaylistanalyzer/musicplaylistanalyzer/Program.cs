using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace musicplaylistanalyzer
{
    class Program
    {
        static void Main(string[] args)
        {


            if (args != null && args.Length > 0)
            {
                using (StreamReader sr = File.OpenText(args[0]))
                {
                   
                    string line;
                    Song[] songs =  {new Song("Name", "Artist", "Album", "Genre", 0, 0, 0, 0)};
                   
                    int count = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(count);
                        // split the line of text into a collection
                        string[] items = line.Split('\t');
                        int[] i = { Int32.Parse(items[4]), Int32.Parse(items[5]), Int32.Parse(items[6]), Int32.Parse(items[7]), };
                        songs[count] = new Song(items[0], items[1], items[2], items[3], i[0],i[1], i[2],i[3]); 
                        count = count + 1;
                        
                      
                    }
                    Console.WriteLine("Songs with over 200 plays:\n");
                    var songsOverTwoHundredPlays = from song in songs where song.Plays > 200 select song;
                    foreach (var title in songsOverTwoHundredPlays)
                    {
                        Console.WriteLine(title);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
 