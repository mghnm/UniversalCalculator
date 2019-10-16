namespace UniversalCalculator
{
    /// <summary>
    /// This class does all numeric operations for calculating the fuel consumption and pricing. All values are returned in methods to
    /// the visual form element class.
    /// </summary>
    internal class FuelCalculator
    {
        private double currReading;
        private double fuelAmount;
        private double prevReading;
        private double unitPrice;
        private const double kmToMileFactor = 0.621371192;

        public FuelCalculator()
        {
        }

        public double CalcConsumptionKilometerPerLiter()
        {
           //kmPerLit
            return getDistance(this.currReading, this.prevReading) / this.fuelAmount;

        }

        public double CalcConsumptionPerMetricMile()
        {
            return CalcFuelConsumptionPerKm() / kmToMileFactor;

        }

        public double CalcCostPerKm()
        {
            return CalcFuelConsumptionPerKm() * this.unitPrice;

        }

        public double CalcFuelConsumptionPerKm()
        {
            //litPerKm
            return this.fuelAmount / getDistance(this.currReading, this.prevReading);
        }

        public double CalcFuelConsuptionPerSweMil()
        {
            return CalcFuelConsumptionPerKm() * 10;

        }

        public double GetCurrentReading()
        {
            return this.currReading;
        }

        public double GetFuelAmount()
        {
            return this.fuelAmount;
        }

        public double GetPreviousReading()
        {
            return this.prevReading;

        }

        public double GetUnitPrice()
        {
            return this.unitPrice;
        }

        public void SetCurrentReading(double currReading)
        {

            this.currReading = currReading;
        }

        public void SetPreviousReading(double prevReading)
        {

            this.prevReading = prevReading;
        }

        public void SetFuelAmount(double fuelAmount)
        {
            this.fuelAmount = fuelAmount;

        }

        public void SetUnitPrice(double unitPrice)
        {
            this.unitPrice = unitPrice;

        }

        //Necissary because we do not want a negative distance in our calculations
        public bool ValidateOdometerValues()
        {
            return (getDistance(this.currReading, this.prevReading) >= 0);
        }

        public static double getDistance(double end, double beginning)
        {
            return end - beginning;
        }






    }
}