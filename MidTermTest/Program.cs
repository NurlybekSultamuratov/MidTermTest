using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Documentation:
/// The Author's Name : Nurlybek
/// Author's Student Number : 301103746
/// Date Last Modified : 17.07.2020 17:08 p.m.
/// Program Description: LottoGame creates random ticket numbers 
/// and displays it in a form of a table.
/// Tickets are displayed depending on the game a user chooses.
/// Revision History :
/// Used template and started working on 16.07.2020 at 15:00 p.m.
/// Finished coding LottoGame.cs file on 16.07.2020 at 18.00 p.m.
/// Created IGenerateLottoNumbers.cs file and added interface on 16.07.2020 19:00 p.m.
/// Finished coding and included documentation for all features(methods,properties,fields) 
/// and pushed it to GitHub on 17.07.2020 at approximately 20:00 p.m.
/// </summary>
namespace MidTermTest
{
    /**
     * <summary>
     * This is the driver class
     * </summary>
     * 
     * @class Program
     */
    public class Program
    {
        // Instantiate lotto649 object
        static Lotto649 lotto649 = new Lotto649();
      //   Instantiate lottoMax object
        static LottoMax lottoMax = new LottoMax();

        /**
         * @static
         * @method Main
         * @returns {void}
         */
        public static void Main(string[] args)
        {   
            // Call the Menu
            LottoMenu();
        }
        /**
         * <summary>
         * This utility method creates a console menu that allows the user to choose
         * a Lotto game to execute.
         * </summary>
         * 
         * @static
         * @method LottoMenu
         * @returns {void}
         */
        public static void LottoMenu()
        {
            // declare a variable to record if menu is active
            bool menuActive = true;

            // While the menu is active...loop
            while (menuActive)
            {
                // show options in the console menu
                Console.WriteLine("++++++++++++++++++++++++++++++++");
                Console.WriteLine(" Please make your selection");
                Console.WriteLine(" 1. Lotto 6/49");
                Console.WriteLine(" 2. Lotto Max");
                Console.WriteLine(" 3. Exit");
                Console.WriteLine("++++++++++++++++++++++++++++++++");

                // read the user selection
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1: // The "1" Key - Select Lotto 6 / 49
                        Console.Clear();
                        Console.WriteLine("+ Lotto 6/49 +++++++++++++++++++");
                        lotto649.GenerateLottoNumbers();
                        Console.WriteLine("++++++++++++++++++++++++++++++++");
                        Console.WriteLine("Please press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D2: // The "2" Key - Select Lotto Max
                        Console.Clear();
                        Console.WriteLine("+ Lotto MAX ++++++++++++++++++++");
                        lottoMax.GenerateLottoNumbers();
                        Console.WriteLine("++++++++++++++++++++++++++++++++");
                        Console.WriteLine("Please press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D3: // The "3" Key - Exit the menu
                        menuActive = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }


    }
}

