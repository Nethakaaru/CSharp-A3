using System;
using System.Windows.Forms;

namespace Assigment3
{
    /// <summary>
    /// The MainForm class that is in charge of communicating between all other classes and the GUI.
    /// Written by Sebastian Aspegren
    /// </summary>
    public partial class MainForm : Form
    {
        //private variables of the other classes and the name of the user.
        private FuelCalculator carMilage = new FuelCalculator();
        private BodyMassIndex bmiCalc = new BodyMassIndex();

        /// <summary>
        /// Constructor that calls a build in method to init the GUI
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Auto generated method. Do not touch.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Method to read current odometer value. Uses try to parse a string into a double. If it succeeds it sets the variable for
        /// the current odometer value in FuelCalculator to whatever was fetched.
        /// </summary>
        /// <returns>
        /// returns true on success.
        /// </returns>
        private bool ReadCurrentOdo()
        {
            double value = 0;
            if (double.TryParse(txtboxcurrentOdo.Text, out value))
            {
                carMilage.setCurrReading(value);
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Method used to read previous odometer value. Uses try to parse a string into a double. If it succeeds it sets the variable for
        /// the previous odometer value in FuelCalculator to whatever was fetched.
        /// </summary>
        /// <returns>
        /// Returns true on success.
        /// </returns>
        private bool ReadPrevOdo()
        {
            double value = 0;
            if (double.TryParse(txtboxPreOdo.Text, out value))
            {
                carMilage.setPrevReading(value);
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Read the textbox for amount of fuel tanked. If the parse succeeds the value is inserted into the FuelCalculator class variable for it.
        /// </summary>
        /// <returns>
        /// Returns true on success.
        /// </returns>
        private bool ReadFuelTanked()
        {
            double value = 0;
            if (double.TryParse(txtboxFuel.Text, out value))
            {
                carMilage.setFuelAmount(value);
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// A method used to read the liter price the user input into a textbox. If it passes through the tryParse it is set
        /// as the value for the appropriate variable in the FuelCalculator class.
        /// </summary>
        /// <returns>
        /// Returns true on success.    
        /// </returns>
        private bool ReadLiterPrice()
        {
            double value = 0;
            if (double.TryParse(txtboxLiterPrice.Text, out value))
            {
                carMilage.setUnitPrice(value);
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// A method used to read the height the user input. If it succeeds pass it on to the BodyMassIndex class as a variable value.
        /// </summary>
        /// <returns>
        /// Returns true on success. 
        /// </returns>
        private bool ReadHeight()
        {
            int value = 0;
            if (int.TryParse(txtboxHeight.Text, out value))
            {
                bmiCalc.setHeight(value);
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Attempt to read the value in the textbox for BMI weight. If it succeeds pass it on to the BodyMassIndex class as a variable value.
        /// </summary>
        /// <returns>
        /// Returns true on success.  
        /// </returns>
        private bool ReadWeight()
        {
            int value = 0;
            if (int.TryParse(txtboxWeight.Text, out value))
            {
                bmiCalc.setWeight(value);
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// A method used to read the name of the user. First we remove any blank spaces before or after the name. If the name is null of empty the name is set to "noName".
        /// Otherwise set the name to the input and use it to edit the groupbox text.
        /// </summary>
        private void ReadName()
        {
            string name;
            txtboxName.Text.Trim();
            if (string.IsNullOrEmpty(txtboxName.Text))
                name = "NoName";
            else
                name = txtboxName.Text;
            grpboxBMIResult.Text = "Results for " + name;
        }
        /// <summary>
        /// When the button to calculate the milage is clicked we read all the input then check if it is acceptable.
        /// If it is we calculate and print out the results in labels, if it isn't we display a messagebox prompting to edit the input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcFuel_Click(object sender, EventArgs e)
        {
            ReadCurrentOdo();
            ReadFuelTanked();
            ReadLiterPrice();
            ReadPrevOdo();
            if (carMilage.ValidateOdometerValues())
            {
                //Math.round is used to limit the number of decimals. We round away from zero (0,005 = 0,01).
                lblFuelKmLitRes.Text = Math.Round(carMilage.CalcConsumptionKilometerPerLiter(), 2, MidpointRounding.AwayFromZero).ToString();
                lblFuelLitKmRes.Text = Math.Round(carMilage.CalcFuelConsumptionPerKm(), 2, MidpointRounding.AwayFromZero).ToString();
                lblFuelLitMetricRes.Text = Math.Round(carMilage.CalcConsumptionPerMetricMile(), 2, MidpointRounding.AwayFromZero).ToString();
                lblFuelLitSweRes.Text = Math.Round(carMilage.CalcFuelConsumptionPerSweMil(), 2, MidpointRounding.AwayFromZero).ToString();
                lblFuelCostRes.Text = Math.Round(carMilage.CalcCostPerKm(), 2, MidpointRounding.AwayFromZero).ToString();
            }
            else
            {
                MessageBox.Show("Something seems to be wrong with the input. Check your input then try again.");
            }

        }
        /// <summary>
        /// When the button for BMI is clicked we read all the user input and the radio button. If everything is in order we calculate and print the results.
        /// If not we display a messagebox prompting the user to edit the input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBMI_Click(object sender, EventArgs e)
        {
            ReadName();
            ReadHeight();
            ReadWeight();
            bmiCalc.setIsMetricChecked(rbMetric.Checked);
            if (bmiCalc.ValidateValues())
            {
                //Only limit BMI to 1 decimal.
                lblBMIRes.Text = Math.Round(bmiCalc.CalcBMI(), 1, MidpointRounding.AwayFromZero).ToString();
                lblCategoryRes.Text = bmiCalc.calcCategory();

            }
            else
            {
                MessageBox.Show("Something seems to be wrong with the input. Check your input then try again.");
            }
        }
    }
}
