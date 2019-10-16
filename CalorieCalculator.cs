namespace UniversalCalculator
{
    /// <summary>
    /// This class does all numeric operations for calculating the BMR of an individual. All values are returned in methods to
    /// the visual form element class.
    /// </summary>
    internal class CalorieCalculator
    {
        private Sexes sex;
        private ActivityLevels activityLevel;
        private double weight;
        private double height;
        private double age;
        private double bmr;
        private double maintainWeightCalories;

        private const double bmrMaleOffset = 5;
        private const double bmrFemaleOffset = -161;

        private const double sedentaryFactor = 1.2;
        private const double lightlyactiveFactor = 1.375;
        private const double moderatelyactiveFactor = 1.550;
        private const double veryactiveFactor = 1.725;
        private const double extraactiveFactor = 1.9;


        public CalorieCalculator()
        {
        }

        public double CalcBMR() {
            double bmr = 10 * this.weight + 6.25 * this.height - 5 * this.age;
            if (this.sex == Sexes.Male)
            {
                this.bmr = bmr + bmrMaleOffset;
                return this.bmr;
            }
            else
            {
                this.bmr = bmr + bmrFemaleOffset;
                return this.bmr;
            }
        }

        public double CalcMaintainWeightCaloreis()
        {
            double bmr = CalcBMR();

            switch (this.activityLevel)
            {
                case ActivityLevels.Sedentary:
                    {
                        this.maintainWeightCalories = bmr * sedentaryFactor;
                        break;
                    }
                case ActivityLevels.LightlyActive:
                    {
                        this.maintainWeightCalories = bmr * lightlyactiveFactor;
                        break;
                    }
                case ActivityLevels.ModeratelyActive:
                    {
                        this.maintainWeightCalories = bmr * moderatelyactiveFactor;
                        break;
                    }
                case ActivityLevels.VeryActive:
                    {
                        this.maintainWeightCalories = bmr * veryactiveFactor;
                        break;
                    }
                case ActivityLevels.ExtraActive:
                    {
                        this.maintainWeightCalories = bmr * extraactiveFactor;
                        break;
                    }

            }

            return this.maintainWeightCalories;

        }

        public double CalcGainHalfKilo()
        {
            double calories = CalcMaintainWeightCaloreis();
            return calories + 500;
        }

        public double CalcGainAKilo()
        {
            double calories = CalcMaintainWeightCaloreis();
            return calories + 1000;
        }

        public double CalcLoseHalfKilo()
        {
            double calories = CalcMaintainWeightCaloreis();
            return calories - 500;
        }

        public double CalcLoseAKilo()
        {
            double calories = CalcMaintainWeightCaloreis();
            return calories - 1000;
        }



        //------------------Getters and Setters ----------------//

        public void SetMaintainWeightCalories(double maintainWeightCalories)
        {
            this.maintainWeightCalories = maintainWeightCalories;
        }

        public void SetBMR(double bmr)
        {
            this.bmr = bmr;
        }

        public void SetSex(Sexes sex)
        {
            this.sex = sex;
        }

        public void SetActivityLevel(ActivityLevels activityLevel)
        {
            this.activityLevel = activityLevel;
        }

        public void SetWeight(double weight)
        {
            this.weight = weight;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }

        public void SetAge(double age)
        {
            this.age = age;
        }

        public double GetMaintainWeightCalories()
        {
            return this.maintainWeightCalories;
        }

        public double GetBMR()
        {
            return this.bmr;
        }

        public Sexes GetSex()
        {
            return this.sex;
        }

        public ActivityLevels GetActivityLevel()
        {
            return this.activityLevel;
        }

        public double GetWeight()
        {
            return this.weight;
        }

        public double GetHeight()
        {
            return this.height;
        }

        public double GetAge()
        {
            return this.age;
        }
    }
}