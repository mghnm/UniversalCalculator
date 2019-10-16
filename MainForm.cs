using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversalCalculator
{
    public partial class MainForm : Form
    {
        //Our fuel calculator responsible for all math operations
        private FuelCalculator fuelCalc = new FuelCalculator();
        //Our bmi calculator responsible for all math operations
        private BodyMassIndexCalculator bmiCalc = new BodyMassIndexCalculator();
        //Our bmr calculator responsible for all math operations
        private CalorieCalculator bmrCalc = new CalorieCalculator();
        //A name to identify the user if they choose to provide their name
        private string name = String.Empty;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        //This method is to initialize some default values to our radio selections and a default name
        private void InitializeGUI()
        {
            this.bmiGroupYourNameTextBox.Text = "NoName";
            this.bmrGroupRadioMale.Checked = true;
            this.bmiGroupRadioMetric.Checked = true;
            this.bmiGroupHeightLabel.Text = "Height (cm)";
            this.bmiGroupWeightLabel.Text = "Weight (kg)";
            this.bmrAvctivityLevelRadioLightlyActivity.Checked = true;
            this.fuelGroupPrevOdoLabelTextBox.Text = "0";

        }



        //------------------BMI calc Methods -------------------//

        //Ensures the validity of our height
        private bool ReadHeight()
        {
            double outValue;

            bool ok = double.TryParse(this.bmiGroupHeightLabelTextBox.Text, out outValue);

            if (ok && outValue > 0)
            {

                bmiCalc.setHeight(outValue);
                return ok;

            }
            else
            {
                MessageBox.Show("Invalid height value!", "Error");
                return false;

            }

        }

        //Ensures the validity of our weight
        private bool ReadWeight()
        {
            {
                double outValue;

                bool ok = double.TryParse(this.bmiGroupWeightLabelTextBox.Text, out outValue);

                if (ok && outValue > 0)
                {

                    bmiCalc.setWeight(outValue);
                    return ok;

                }
                else
                {
                    MessageBox.Show("Invalid weight value!", "Error");
                    return false;

                }

            }

        }

        //Ensures the validity of our unit
        private bool ReadUnit()
        {
            if (this.bmiGroupRadioMetric.Checked)
            {
                bmiCalc.setUnityType(UnityTypes.Metric);
                return true;

            }
            else if (this.bmiGroupRadioUS.Checked)
            {
                bmiCalc.setUnityType(UnityTypes.American);
                return true;
            }
            else
            {
                MessageBox.Show("Please choose a measurment system!", "Error");
                return false;

            }



        }

        //If all operations succed it means we have a valid read of our values and can proceeed
        private bool ReadInputBMI()
        {
            return ReadHeight() && ReadWeight() && ReadUnit();
        }

        //Updates the relevant UI elements with the calculator output
        private void UpdateBMIGUI()
        {
            this.bmiGroupResultsYourBMILabelRes.Text = bmiCalc.CalculateBMI().ToString("f2");
            this.bmiGroupResultsWeightCatLabelRes.Text = bmiCalc.BMIWeightCategory();
        }


        //---------------------Fuel Calc Methods ---------------------//


        //Ensures the validity of our odometer reding
        private bool ReadCurrentOdometer()
        {
            double outValue;

            bool ok = double.TryParse(this.fuelGroupCurOdoTextBox.Text, out outValue);

            if (ok && outValue >= 0)
            {

                fuelCalc.SetCurrentReading(outValue);
                return ok;

            }
            else
            {
                MessageBox.Show("Invalid odometer value!", "Error");
                return false;

            }

        }

        //Ensures the validity of our previous odometer value
        private bool ReadPreviousOdometer()
        {
            {
                double outValue;

                bool ok = double.TryParse(this.fuelGroupPrevOdoLabelTextBox.Text, out outValue);

                if (ok && outValue >= 0)
                {

                    fuelCalc.SetPreviousReading(outValue);
                    return ok;

                }
                else
                {
                    MessageBox.Show("Invalid odometer value!", "Error");
                    return false;

                }

            }

        }

        //Ensures the validity of our price per liter
        private bool ReadPricePerLiter()
        {
            {
                double outValue;

                bool ok = double.TryParse(this.fuelGroupPricePerLiterTextBox.Text, out outValue);

                if (ok && outValue >= 0)
                {

                    fuelCalc.SetUnitPrice(outValue);
                    return ok;

                }
                else
                {
                    MessageBox.Show("Invalid price per liter value!", "Error");
                    return false;

                }

            }

        }
        //Ensures the validity of our current fuel amount
        private bool ReadCurrentAmountofFuel()
        {
            {
                double outValue;

                bool ok = double.TryParse(this.fuelGroupCurFuelTankedTextBox.Text, out outValue);

                if (ok && outValue >= 0)
                {

                    fuelCalc.SetFuelAmount(outValue);
                    return ok;

                }
                else
                {
                    MessageBox.Show("Invalid fuel tanked value!", "Error");
                    return false;

                }

            }

        }

        //We have an additonal condition here where while the values might be valid our distance could be negative
        //That is not allowed.
        private bool ReadInputFuelCalc()
        {
            if (ReadCurrentOdometer() && ReadPreviousOdometer() && ReadPricePerLiter() && ReadCurrentAmountofFuel())
            {
                if (fuelCalc.ValidateOdometerValues())
                {
                    return true;
                }
                else {
                    MessageBox.Show("Invalid distance traveled!", "Error");
                    return false;
                }

            }
            else {
                return false;
            }
        }

        //Updates the relevant ui elements with the data from our calculator
        private void UpdateFuelGUI()
        {
            this.fuelGroupResultsCostRes.Text = fuelCalc.CalcCostPerKm().ToString("f2");
            this.fuelGroupResultsFCkmlitRes.Text = fuelCalc.CalcConsumptionKilometerPerLiter().ToString("f2");
            this.fuelGroupResultsFClitkmRes.Text = fuelCalc.CalcFuelConsumptionPerKm().ToString("f2");
            this.fuelGroupResultsFClitmileRes.Text = fuelCalc.CalcConsumptionPerMetricMile().ToString("f2");
            this.fuelGroupResultsFClitmilRes.Text = fuelCalc.CalcFuelConsuptionPerSweMil().ToString("f2");
        }


        //---------------------BMR Calc Methods ---------------------//
        //Ensures the validity of our name
        private bool ReadName()
        {
            
            this.name = this.bmiGroupYourNameTextBox.Text;
            if (this.name.Length > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Name can not be blank!", "Error");
                return false;
            }
        }

        //Ensures the validity of our height this time for BMR
        private bool ReadBMRHeight()
        {
            {
                double outValue;

                bool ok = double.TryParse(this.bmiGroupHeightLabelTextBox.Text, out outValue);

                if (ok && outValue >= 0)
                {

                    bmrCalc.SetHeight(outValue);
                    return ok;

                }
                else
                {
                    MessageBox.Show("Invalid height value!", "Error");
                    return false;

                }

            }

        }
        //Ensures the validity of our weight this time for BMR
        private bool ReadBMRWeight()
        {
            {
                double outValue;

                bool ok = double.TryParse(this.bmiGroupWeightLabelTextBox.Text, out outValue);

                if (ok && outValue >= 0)
                {

                    bmrCalc.SetWeight(outValue);
                    return ok;

                }
                else
                {
                    MessageBox.Show("Invalid weight value!", "Error");
                    return false;

                }

            }

        }

        //Ensures the validity of our age
        private bool ReadBMRAge()
        {
            {
                double outValue;

                bool ok = double.TryParse(this.bmrGroupAgeTextBox.Text, out outValue);

                if (ok && outValue >= 0)
                {

                    fuelCalc.SetUnitPrice(outValue);
                    return ok;

                }
                else
                {
                    MessageBox.Show("Invalid age value!", "Error");
                    return false;

                }

            }

        }

        //Ensures the validity of our unit we can not do calculations with US units
        private bool ReadBMRUnit()
        {
            if (this.bmiGroupRadioMetric.Checked)
            {
                
                return true;

            }
            else if (this.bmiGroupRadioUS.Checked)
            {
                MessageBox.Show("Please choose the metric system for BMR!", "Error");
                return false;
            }
            else
            {
                MessageBox.Show("Please choose a measurment system!", "Error");
                return false;

            }



        }

        //Ensures the validity of sex
        private bool ReadBMRSex()
        {
            if (this.bmrGroupRadioMale.Checked)
            {
                bmrCalc.SetSex(Sexes.Male);
                return true;

            }
            else if (this.bmrGroupRadioFemale.Checked)
            {
                bmrCalc.SetSex(Sexes.Female);
                return true;
            }
            else
            {
                MessageBox.Show("Please choose a valid sex!", "Error");
                return false;

            }



        }

        //Ensures the validity of our activity selection
        private bool ReadBMRActivityLevel()
        {
            if (this.bmrAvctivityLevelRadioSedentary.Checked)
            {
                bmrCalc.SetActivityLevel(ActivityLevels.Sedentary);
                return true;

            }
            else if (this.bmrAvctivityLevelRadioLightlyActivity.Checked)
            {
                bmrCalc.SetActivityLevel(ActivityLevels.LightlyActive);
                return true;
            }
            else if (this.bmrAvctivityLevelRadioModerateActivity.Checked)
            {
                bmrCalc.SetActivityLevel(ActivityLevels.ModeratelyActive);
                return true;
            }
            else if (this.bmrAvctivityLevelRadioVeryActive.Checked)
            {
                bmrCalc.SetActivityLevel(ActivityLevels.VeryActive);
                return true;
            }
            else if (this.bmrAvctivityLevelRadioExtraActive.Checked)
            {
                bmrCalc.SetActivityLevel(ActivityLevels.ExtraActive);
                return true;
            }
            else
            {
                MessageBox.Show("Please choose a measurment system!", "Error");
                return false;

            }



        }

        //All operations must succeed in order to proceed so we check that
        private bool ReadInputBMR()
        {
            return ReadName() && ReadBMRWeight() && ReadBMRHeight() && ReadBMRAge() && ReadBMRUnit() && ReadBMRSex() && ReadBMRActivityLevel();
        }

        //Update relevant fields with some formatting to make it look nice.
        private void UpdateBMRGUI()
        {
            this.BMRResult.Items.Clear();
            this.BMRResult.Items.Insert(0, "BMR RESULTS FOR " + this.name.ToUpper());
            this.BMRResult.Items.Insert(1, String.Format("{0,-65}{1,60:0.00}", "Your BMR (calories/day):", bmrCalc.CalcBMR()));
            this.BMRResult.Items.Insert(2, String.Format("{0, -65}{1,60:0.00}", "Calories to maintain your weight:", bmrCalc.CalcMaintainWeightCaloreis()));
            this.BMRResult.Items.Insert(3, String.Format("{0, -65}{1,60:0.00}", "Calories to lose 0,5 kg per week:", bmrCalc.CalcLoseHalfKilo()));
            this.BMRResult.Items.Insert(4, String.Format("{0,-65}{1,60:0.00}", "Calories to lose 1 kg per week:", bmrCalc.CalcLoseAKilo()));
            this.BMRResult.Items.Insert(5, String.Format("{0,-65}{1,60:0.00}", "Calories to gain 0,5 kg per week:", bmrCalc.CalcGainHalfKilo()));
            this.BMRResult.Items.Insert(6, String.Format("{0,-65}{1,60:0.00}", "Calories to gain 1 kg per week:", bmrCalc.CalcGainAKilo()));
            this.BMRResult.Items.Insert(7, "Losing more than 1000 calories per day is to be avoided.");      
        }




        //------------------------- Event Listeners --------------------------//

        //Event handler for the calculation button for BMI
        private void btnCalcBMI_Click(Object sender, EventArgs e)
        {
            bool ok = ReadInputBMI();

            if (ok)
            {
                UpdateBMIGUI();
            }

        }


        //Event handler for the calculation button for fuel
        private void btnCalcFuel_Click(Object sender, EventArgs e)
        {
            bool ok = ReadInputFuelCalc();

            if (ok)
            {
                UpdateFuelGUI();
            }

        }
        //Event handler for the calculation button for BMR
        private void btnCalcBMR_Click(Object sender, EventArgs e)
        {
            bool ok = ReadInputBMR();

            if (ok)
            {
                UpdateBMRGUI();
            }
        }
        //Event handler for the unselect button
        private void btnUnselect_Click(Object sender, EventArgs e)
        {
            this.BMRResult.ClearSelected();
        }

        //Event handler for the selectoin of a listbox item to update our label
        private void BMRResult_SelectedIndexChanged(Object sender, EventArgs e)
        {
            this.bmrGroupSelectedIndexLabel.Text = this.BMRResult.SelectedIndex.ToString();
        }


        //Method to dynamically update the UI depending on the metric or imperial system
        private void bmiRadio_CheckedChanged(Object sender,
                                         EventArgs e)
        {
            // Change the check box position to be opposite its current position.
            if (this.bmiGroupRadioMetric.Checked == true)
            {
                //Metric Text
                this.bmiGroupHeightLabel.Text = "Height (cm)";
                this.bmiGroupWeightLabel.Text = "Weight (kg)";
            }
            else
            {   
                //Imperial Text
                this.bmiGroupHeightLabel.Text = "Height (inch)";
                this.bmiGroupWeightLabel.Text = "Weight (lbs)";
            }
        }
    }
}
