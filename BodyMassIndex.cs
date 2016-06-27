namespace Assigment3
{
    /// <summary>
    /// A class used to calculate values regarding Body Mass Index using height, weight and either american of metric measurements.
    /// Written by Sebastian Aspegren.
    /// </summary>
    public class BodyMassIndex
    {
        private int height, weight;
        private bool isMetricChecked;
        private double BMI;

        /// <summary>
        /// Method used to calculate the BMI using height and weight. if the radiobutton for metric system is checked we assume the height and weight are in metric values, otherwise american.
        /// </summary>
        /// <returns>
        /// The BMI.
        /// </returns>
        public double CalcBMI()
        {
            if (isMetricChecked)
            {
                BMI = weight / ((height * 0.01) * (height * 0.01));
            }
            else
            {
                BMI = 703.0 * weight / (height * height);
            }
            return BMI;
        }
        /// <summary>
        /// Using the previous calculated BMI value we determine what weight class the user is.
        /// </summary>
        /// <returns>
        /// A string of characters for the weight class.
        /// </returns>
        public string calcCategory()
        {
            if (BMI < 18.5)
                return "Underweight";
            else if (BMI < 25)
                return "Normal weight";
            else if (BMI < 30)
                return "Overweight";
            else if (BMI < 35)
                return "Obesity class I";
            else if (BMI < 40)
                return "Obesity class II";
            else
                return "Obesity class III";
        }
        /// <summary>
        /// Method used to set if the button is checked or not so we know if we should use american or metric calculation methods.
        /// </summary>
        /// <param name="isMetricChecked">
        /// bool sent from the caller of this method.
        /// </param>
        public void setIsMetricChecked(bool isMetricChecked)
        {
            this.isMetricChecked = isMetricChecked;
        }
        /// <summary>
        /// Method used to set the weight variable
        /// </summary>
        /// <param name="weight">
        /// int for the weight
        /// </param>
        public void setWeight(int weight)
        {
            this.weight = weight;
        }
        /// <summary>
        /// Method used to set the height variable
        /// </summary>
        /// <param name="height">
        /// An int representing the height of the user.
        /// </param>
        public void setHeight(int height)
        {
            this.height = height;
        }
        /// <summary>
        /// A method used to validate the input. If any of the are abnormaly low we return false to message that such low values wouldn't work to calculate BMI.
        /// This method does only protect against the most extreme cases that probably don't exist.
        /// </summary>
        /// <returns>
        /// true if there are no problems, otherwise false.
        /// </returns>
        public bool ValidateValues()
        {
            if (height <= 0 || weight <= 0)
                return false;
            return true;
        }
    }
}