using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermTest
{
    /**
     * <summary>
     * This abstract class is a blueprint for all Lotto Games
     * </summary>
     * 
     * @class LottoGame
     * @property {int} ElementNum;
     * @property {int} SetSize;
     */
    public abstract class LottoGame
    {

        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE private fields here --------------------------------------------
        // Private fields and field lists are used to pass values to the propeties below
        private List<int> _elementList;
        private int _elementNumber;
        private List<int> _numberList;
        private Random _random;
        private int _setSize;
        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE public properties here -----------------------------------------
        // These public properties are used to get the values from private fields
        public List<int> ElementList
        {
            get => _elementList;
        }

        public int ElementNumber
        {
            get => _elementNumber;
            set
            {
                _elementNumber = value;
            }
        }

        public List<int> NumberList
        {
            get => _numberList;
        }

        public Random random
        {
            get => _random;
        }

        public int SetSize
        {
            get => _setSize;
            set
            {
                _setSize = value;
            }
        }
        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes two parameters: elementNumber and setSize
         * The elementNumber parameter has a default value of 6
         * The setSize parameter has a default value of 49
         * </summary>
         * 
         * @constructor LottoGame
         * @param {int} elementNumber
         * @param {int} setSize
         */
        public LottoGame(int elementNumber = 6, int setSize = 49)
        {
            // assign elementNumber local variable to the ElementNumber property
            this.ElementNumber = elementNumber;

            // assign setSize local variable tot he SetSize property
            this.SetSize = setSize;

            // call the _initialize method
            this._initialize();

            // call the _build method
            this._build();
        }

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // CREATE the private _initialize method here -----------------------------
        // _initizalize metod initializes all private properties
        private void _initialize()
        {
            _numberList = new List<int>().Distinct().ToList();
            _elementList = new List<int>().Distinct().ToList();
            _random = new Random();
        }

        // CREATE the private _build method here -----------------------------------
        // _build method uses foreach loop to read values from NumberList
        //  and adds them randomly to the same list Set size times ,which is 49 , in a for loop
        private void _build()
        {
            for (int i=1; i<SetSize; i++)
            {
                foreach(int num in NumberList)
                {
                    NumberList.Add(_random.Next(SetSize));
                }
            }
        }
        // OVERRIDEN METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * Override the default ToString function so that it displays the current
         * ElementList
         * </summary>
         * 
         * @override
         * @method ToString
         * @returns {string}
         */
        public override string ToString()
        {
            // create a string variable named lottoNumberString and intialize it with the empty string
            string lottoNumberString = String.Empty;

            // for each lottoNumber in ElementList, loop...
            foreach (int lottoNumber in ElementList)
            {
                // add lottoNumber and appropriate spaces to the lottoNumberString variable
                lottoNumberString += lottoNumber > 9 ? (lottoNumber + " ") : (lottoNumber + "  ");
            }
           
            return $"{lottoNumberString}";
          
                
           

            //if (ElementNumber == 6)
            //{
            //    return

            //       $"Ticket 1: {lottoNumberString}\n"
            //     + $"Ticket 2: {lottoNumberString}\n"
            //     + $"Ticket 3: {lottoNumberString}\n"
            //     + $"Ticket 4: {lottoNumberString}\n"
            //     + $"Ticket 5: {lottoNumberString}\n"
            //     + $"Ticket 6: {lottoNumberString}\n";
            //}
            //else
            //{
            //    return $"Ticket 1: {lottoNumberString}\n"
            //     + $"Ticket 2: {lottoNumberString}\n"
            //     + $"Ticket 3: {lottoNumberString}\n"
            //     + $"Ticket 4: {lottoNumberString}\n"
            //     + $"Ticket 5: {lottoNumberString}\n"
            //     + $"Ticket 6: {lottoNumberString}\n"
            //     + $"Ticket 7: {lottoNumberString}\n";
            //}


        }


        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE the public PickElements method here ----------------------------
        public void PickElements()
        {

            // If number of elements is greater than 0 > Call Clear methods and build method
          
            
                if (ElementList.Count > 0)

                {
                    ElementList.Clear();
                    NumberList.Clear();
                    _build();
                }
            
            for (int i = 0; i < ElementNumber; i++) 
            {
                int integer;

                do
                {
                    integer = _random.Next(SetSize);
                    ElementList.Remove(integer);
                    ElementList.Add(integer);


                }
                while (NumberList.Contains(integer));

            }

            ElementList.Sort();

        }




    }
}