namespace UniversalCalculator
{
    /// <summary>
    /// This class does all numeric operations for calculating the BMI of an individual. All values are returned in methods to
    /// the visual form element class.
    /// </summary>
    internal class BodyMassIndexCalculator
    {
        private double height;
        private double weight;
        private UnityTypes unit;

        public BodyMassIndexCalculator()
        {

        }




        public double CalculateBMI()
        {
            if (this.unit == UnityTypes.Metric)
            {
                return this.weight / System.Math.Pow(((double)(this.height)/100), 2);
            }
            else
            {
                return (703) * (this.weight / System.Math.Pow(this.height, 2));

            }

        }

        public string BMIWeightCategory()
        {
            double bmi = CalculateBMI();

            string stringout = string.Empty;

            if (bmi > 40)
            {
                stringout = "Obesity class III";
            }
            else if (bmi >= 35)
            {
                stringout = "Obesity class II";
            }
            else if (bmi >= 30)
            {
                stringout = "Obesity class I";
            }
            else if (bmi >= 25)
            {
                stringout = "Overweight (Pre-obesity)";
            }
            else if (bmi >= 18.5)
            {
                stringout = "Normal weight";
            }
            else
            {
                stringout = "Underweight";
            }

            return stringout;

        }


        public double getHeight()
        {

            return this.height;
        }


        public double getWeight()
        {
            return this.weight;

        }

        public void setHeight(double height)
        {
            this.height = height;

        }

        public void setWeight(double weight)
        {
            this.weight = weight;
        }

        public UnityTypes GetUnityType()
        {
            return this.unit;

        }

        public void setUnityType(UnityTypes unit)
        {
            this.unit = unit;

        }




    }
}