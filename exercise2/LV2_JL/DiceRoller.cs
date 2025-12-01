using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2_JL
{
    class DiceRoller : ILogable
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
      //  private ILogger logger;
       
        public DiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
            //this.logger = logger;
        }
       /* public void SetLogger(ILogger logger)
        {
            this.logger = logger;
        }
       */
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RollAllDice()
        {
            //clear results of previous rolling
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }
        //View of the results
        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(
           this.resultForEachRoll
           );
        }
        /* public void LogRollingResults()
         {
             foreach(int result in this.resultForEachRoll)
             {
                 logger.Log(result.ToString());
             }
         }
        */
        public string GetStringRepresentation()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (int result in this.resultForEachRoll)
            {
                sb.AppendLine(result.ToString());
            }
            return sb.ToString();
        }
    
    public int DiceCount
        {
            get { return dice.Count; }
        }
      

    }
}
