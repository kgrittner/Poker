using CardLibrary;
using CardLibrary.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker
{
    class Program
    {
        private readonly static string BasePath = @"C:\Users\karlg\Downloads\CodeTest2\poker\Tests";
        private readonly static string FileName = @"Test2.tst";
        protected static string FilePath
        {
            get { return Path.Combine(BasePath, FileName); }
        }

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(BasePath); //Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.tst"); //Getting Text files

            foreach (FileInfo file in Files)
            {
                var fileInput = File.ReadAllLines(file.FullName);
                int numPlayers = int.Parse(fileInput[0]);
                var players = new List<Player>();

                for (int i = 1; i <= numPlayers; i++)
                {
                    string[] input = fileInput[i].Split(' ');
                    int playerId = int.Parse(input[0]);
                    string[] cards = new string[] { input[1], input[2], input[3] };
                    var player = new Player(playerId, cards);
                    players.Add(player);
                }

                Console.Write(Path.GetFileNameWithoutExtension(file.Name) + ": ");

                var winningPlayers = PokerGame.FindWinningPlayers(players);

                foreach (var playerId in winningPlayers)
                {
                    Console.Write(playerId + " ");
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }

        

       

        

      


        


    }
}
