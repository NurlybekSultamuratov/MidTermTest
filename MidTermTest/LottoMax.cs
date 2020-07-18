using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidTermTest
{
    /**
    * <summary>
    * This class is a subclass of the LottoGame abstract superclass
    * </summary>
    * 
    * @class LottoMax
    */

    public class LottoMax : LottoGame , IGenerateLottoNumbers
    {
        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */

        public LottoMax()
            : base(7, 49)
        {

        }

        // CREATE the public GenerateLottoNumbers method here ----------------
        // GenerateLottoNumbers has been added. It calls PickElements method that chooses random numbers.
        // GenerateLottoNumbers calls ToString override method to display a result nicely.
        public void GenerateLottoNumbers()
        {
                PickElements();
                Console.WriteLine($"Ticket 1: {ToString()}");
                PickElements();
                Console.WriteLine($"Ticket 2: {ToString()}");
                PickElements();
                Console.WriteLine($"Ticket 3: {ToString()}");
                PickElements();
                Console.WriteLine($"Ticket 4: {ToString()}");
                PickElements();
                Console.WriteLine($"Ticket 5: {ToString()}");
                PickElements();
                Console.WriteLine($"Ticket 6: {ToString()}");
                PickElements();
                Console.WriteLine($"Ticket 7: {ToString()}");
        }
    }
}