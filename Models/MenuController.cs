using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class MenuController
    {
        public static void mainMenu(ref bool executingStatus, ref Node masterNode)
        {
            Console.WriteLine("Select an option (press enter to exit)");

            Console.WriteLine(
                "1. add a node\n" +
                "2. navigation Options");
            string option = Console.ReadLine() ?? "";
            switch (option.ToLower())
            {
                case "1":
                    masterNode.addChild(Node.initNode());
                    break;
                case "2":
                    navigationOptions();
                    break;
                default:
                    executingStatus = false;
                    break;
            }
        }

        public static void navigationOptions()
        {

        }

        public static void finalMenu()
        {
            Console.WriteLine("go back to menu? Y/N");
            string answer = Console.ReadLine() ?? "";
            switch (answer.ToLower())
            {
                case "Y":
                    break;
                case "N":
                    Environment.Exit(0); break;
                default:
                    Console.WriteLine("please type Y/N");
                    break;
            }
        }
    }
}
