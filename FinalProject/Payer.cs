using System;

namespace FinalProject
{
    public class Player
    {
        public string Name;
        public float Win, Loss, Tie;

        public Player(string Name, int Win, int Loss, int Tie)
        {
            this.Name = Name;
            this.Win = Win;
            this.Loss = Loss;
            this.Tie = Tie;
        }

        public string getName()
        {
            return this.Name;
        }
        public float getWin()
        {
            return this.Win;
        }
        public float getLoss()
        {
            return this.Loss;
        }
        public float getTie()
        {
            return this.Tie;
        }

        public float roundNumber()
        {
            return this.Win + this.Loss + this.Tie + 1;
        }

        

    }
}