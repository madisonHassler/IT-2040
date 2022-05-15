using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace FinalProject
{
    public static class PlayerLoader
    {
        private static int numItemsInRow = 4;
        public static List<Player> loadPlayers(string filePath)
        {
            List<Player> playerList = new List<Player>();


            try
            {
                using (var playerReader = new StreamReader(filePath))
                {
                    int lineNumber = 0;
                    //start while loop
                    while (!playerReader.EndOfStream)
                    {
                        //read player data from file line by line
                        var lineOfData = playerReader.ReadLine();
                        lineNumber++;
                        //split the player data at the comma to get each value
                        var values = lineOfData.Split(',');

                        if (values.Length != numItemsInRow)
                        {
                            throw new Exception($"Row {lineNumber} contains {values.Length} values. It should contain {numItemsInRow}.");
                        }

                        //create player objects with player data from the file
                        try
                        {
                            string Name = Convert.ToString(values[0]);
                            int Win = Int32.Parse(values[1]);
                            int Loss = Int32.Parse(values[2]);
                            int Tie = Int32.Parse(values[3]);
                            Player player = new Player(Name, Win, Loss, Tie);
                            //store Player objects in a list
                            playerList.Add(player);

                        }
                        catch (Exception e)
                        {
                            throw new Exception($"Row {lineNumber} contains invalid data. ({e.Message})");
                        }

                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to open {filePath} ({e.Message}).");
            }
            return playerList;

        }
    }
}