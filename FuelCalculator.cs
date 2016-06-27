namespace Assigment3
{
    /// <summary>
    /// The FuelCalculator class used to calculate values regarding mileage and fuel useage.
    /// Written by Sebastian Aspegren
    /// </summary>
    public class FuelCalculator
    {
        //private variables. Set by the MainForm class when necessary.
        private double currReading, fuelAmount, prevReading, unitPrice;

        /// <summary>
        /// Method used to calculatte fuel consumed per kilometer.
        /// </summary>
        /// <returns>
        /// A double value representing the fuel consumed per kilometer.
        /// </returns>
        public double CalcFuelConsumptionPerKm()
        {
            double distance = (currReading - prevReading);
            return (fuelAmount / distance);
        }
        /// <summary>
        /// A method used to calculate how far you get on one liter of fuel in kilometers.
        /// </summary>
        /// <returns>
        /// A double value representing the distance in kilometers.
        /// </returns>
        public double CalcConsumptionKilometerPerLiter()
        {
            double distance = (currReading - prevReading);
            return (distance / fuelAmount);
        }
        /// <summary>
        /// A method used to calculate fuel consumption per metric mile (non swedish mile)
        /// </summary>
        /// <returns>
        /// A double containing the result.
        /// </returns>
        public double CalcConsumptionPerMetricMile()
        {
            const double kmToMileFactor = 0.621371192;
            return (CalcFuelConsumptionPerKm() / kmToMileFactor);
        }
        /// <summary>
        /// A method used to calculate the price you pay to travel a kilometer. Currency is irrelevant.
        /// </summary>
        /// <returns>
        /// A double for whatever currency the user input representing the cost to travel a kilometer at input fuel price.
        /// </returns>
        public double CalcCostPerKm()
        {
            return (CalcFuelConsumptionPerKm() * unitPrice);
        }
        /// <summary>
        /// A method that calculates fuel consumption per swedish mile
        /// </summary>
        /// <returns>
        /// the value from fuel consumed per kilometer times 10
        /// </returns>
        public double CalcFuelConsumptionPerSweMil()
        {
            return (CalcFuelConsumptionPerKm() * 10);
        }
        /// <summary>
        /// A method used to validate the variable values. 
        /// </summary>
        /// <returns>
        /// false if there is something wrong with a value, otherwise true.
        /// </returns>
        public bool ValidateOdometerValues()
        {
            if (currReading <= prevReading || unitPrice < 0 || prevReading < 0)
                return false;
            else
                return true;
        }
        /// <summary>
        /// A method to set the unitprice
        /// </summary>
        /// <param name="unitPrice">
        /// price input by user
        /// </param>
        public void setUnitPrice(double unitPrice)
        {
            this.unitPrice = unitPrice;
        }
        /// <summary>
        /// method used to set previous odometer reading
        /// </summary>
        /// <param name="prevReading">
        /// previous odometer reading input by user
        /// </param>
        public void setPrevReading(double prevReading)
        {
            this.prevReading = prevReading;
        }
        /// <summary>
        /// Method used to set fuel amount
        /// </summary>
        /// <param name="fuelAmount">
        /// fuel amount input by user
        /// </param>
        public void setFuelAmount(double fuelAmount)
        {
            this.fuelAmount = fuelAmount;
        }
        /// <summary>
        /// A method used to set the current odometer reading.
        /// </summary>
        /// <param name="currReading">
        /// Input of current odometer reading.
        /// </param>
        public void setCurrReading(double currReading)
        {
            this.currReading = currReading;
        }
    }
}