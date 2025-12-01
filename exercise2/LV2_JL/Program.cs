using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2_JL
{
    class Program
    {
        static void Main(string[] args)
        {
            // zd1();
            zd5();
            Console.ReadKey();
        }
        /*static void zd1()
        {
            DiceRoller roller = new DiceRoller();
            for (int i = 0; i < 20; i++)
            {
                roller.InsertDie(new Die(6));
            }
             roller.RollAllDice();
            IList<int> results = roller.GetRollingResults();
            foreach(int result in results)
            {
                Console.WriteLine(result);
            } 
        }
        */
      /*  static void zd2()
        {
            Random Maingenerator = new Random();
            DiceRoller roller = new DiceRoller();
            for (int i = 0; i < 20; i++)
            {
                roller.InsertDie(new Die(6,Maingenerator));
            }
            roller.RollAllDice();
            IList<int> results = roller.GetRollingResults();
            foreach (int result in results)
            {
                Console.WriteLine(result);
            }
        }
      */
      /*static void zd3()
        {
            DiceRoller roller = new DiceRoller();
            for (int i = 0; i < 20; i++)
            {
                roller.InsertDie(new Die(6));
            }
            roller.RollAllDice();
            IList<int> results = roller.GetRollingResults();
            foreach (int result in results)
            {
                Console.WriteLine(result);
            }
        }
      */
      /*static void zd4()
        {
            ConsoleLogger consoleLogger = new ConsoleLogger();
            FileLogger filelogger = new FileLogger("aa.txt");
            DiceRoller roller = new DiceRoller(consoleLogger);
            for (int i = 0; i < 20; i++)
            {
                roller.InsertDie(new Die(6));
            }
            roller.RollAllDice();
            IList<int> results = roller.GetRollingResults();
            roller.LogRollingResults();
            
        }
      */
      static void zd5()
        {
            ConsoleLogger logger = new ConsoleLogger();
            DiceRoller roller = new DiceRoller();
            for (int i = 0; i < 20; i++)
            {
                roller.InsertDie(new Die(6));
            }
            roller.RollAllDice();
            IList<int> results = roller.GetRollingResults();
            logger.Log(roller);


        }
    }
}
