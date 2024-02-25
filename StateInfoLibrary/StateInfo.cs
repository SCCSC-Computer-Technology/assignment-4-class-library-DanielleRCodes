

namespace StateInfoLibrary
{
    /* This class is used to create state objects that I can use to populate
     * userControls within my program. The object will hold all the fields for
     * the state as well as the images for each state.
     */

    
    public class StateInfo
    {
        //Backing Fields
        private string _name = "";
        private string _ABB = "";
        private string _bird = "";
        private string _flower = "";
        private string _capitol = "";
        private string _colors = "";
        private string _flagDescription = "";
        private int _population = 0;
        private int _medIncome = 0;
        private string _cityOne = "";
        private string _cityTwo = "";
        private string _cityThree = "";
        private decimal _compJobs = 0.0m;        
        

        //Setting the Fields
        public string StateName
        {
            get { return _name; }
        }

        public string StateABB
        {
            get { return _ABB; }
        }

        public string StateBird
        {
            get { return _bird; }
        }

        public string StateFlower
        {
            get { return _flower; }
        }

        public string StateCapitol
        {
            get { return _capitol; }
        }

        public string StateColors
        {
            get { return _colors; }
        }

        public string StateFlagDescription
        {
            get { return _flagDescription; }
        }

        public int Population
        {
            get { return _population; }
        }

        public int MedIncome
        {
            get { return _medIncome; }
        }

        public string CityOne
        {
            get { return _cityOne; }
        }

        public string CityTwo
        {
            get { return _cityTwo; }
        }

        public string CityThree
        {
            get { return _cityThree; }
        }

        public decimal CompJobs
        {
            get { return _compJobs; }
        }

        //Constructor
        public StateInfo (string name, string abb, string bird, string flower, string colors,
                            string capitol, string flagDescript, int pop, int income, string city1,
                            string city2, string city3, decimal compJob)
        {
            _name = name;
            _ABB = abb;
            _bird = bird;
            _flower = flower;
            _colors = colors;
            _capitol = capitol;
            _flagDescription = flagDescript;
            _population = pop;
            _medIncome = income;
            _cityOne = city1;
            _cityTwo = city2;   
            _cityThree = city3;
            _compJobs = compJob;
        }
    }
}
