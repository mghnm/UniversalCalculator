namespace UniversalCalculator
{
    using System;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fuelGroup = new System.Windows.Forms.GroupBox();
            this.fuelGroupCalcButton = new System.Windows.Forms.Button();
            this.fuelGroupPricePerLiterTextBox = new System.Windows.Forms.TextBox();
            this.fuelGroupCurFuelTankedTextBox = new System.Windows.Forms.TextBox();
            this.fuelGroupPrevOdoLabelTextBox = new System.Windows.Forms.TextBox();
            this.fuelGroupCurOdoTextBox = new System.Windows.Forms.TextBox();
            this.fuelGroupPricePerLiterLabel = new System.Windows.Forms.Label();
            this.fuelGroupCurFuelTankedLabel = new System.Windows.Forms.Label();
            this.fuelGroupPrevOdoLabel = new System.Windows.Forms.Label();
            this.fuelGroupCurOdoLabel = new System.Windows.Forms.Label();
            this.fuelGroupResults = new System.Windows.Forms.GroupBox();
            this.fuelGroupResultsCostRes = new System.Windows.Forms.Label();
            this.fuelGroupResultsFClitmilRes = new System.Windows.Forms.Label();
            this.fuelGroupResultsFClitmileRes = new System.Windows.Forms.Label();
            this.fuelGroupResultsFClitkmRes = new System.Windows.Forms.Label();
            this.fuelGroupResultsFCkmlitRes = new System.Windows.Forms.Label();
            this.fuelGroupResultsCost = new System.Windows.Forms.Label();
            this.fuelGroupResultsFClitmil = new System.Windows.Forms.Label();
            this.fuelGroupResultsFClitmile = new System.Windows.Forms.Label();
            this.fuelGroupResultsFClitkm = new System.Windows.Forms.Label();
            this.fuelGroupResultsFCkmlit = new System.Windows.Forms.Label();
            this.bmiGroup = new System.Windows.Forms.GroupBox();
            this.bmiGroupWeightLabel = new System.Windows.Forms.Label();
            this.bmiGroupHeightLabel = new System.Windows.Forms.Label();
            this.bmiGroupYourNameLabel = new System.Windows.Forms.Label();
            this.bmiGroupCalcButton = new System.Windows.Forms.Button();
            this.bmiGroupRadioUS = new System.Windows.Forms.RadioButton();
            this.bmiGroupRadioMetric = new System.Windows.Forms.RadioButton();
            this.bmiGroupWeightLabelTextBox = new System.Windows.Forms.TextBox();
            this.bmiGroupHeightLabelTextBox = new System.Windows.Forms.TextBox();
            this.bmiGroupYourNameTextBox = new System.Windows.Forms.TextBox();
            this.bmiGroupResults = new System.Windows.Forms.GroupBox();
            this.bmiGroupResNormBMILabel = new System.Windows.Forms.Label();
            this.bmiGroupResultsWeightCatLabelRes = new System.Windows.Forms.Label();
            this.bmiGroupResultsYourBMILabelRes = new System.Windows.Forms.Label();
            this.bmiGroupResultsYourBMILabel = new System.Windows.Forms.Label();
            this.bmiGroupResultsWeightCatLabel = new System.Windows.Forms.Label();
            this.bmrGroup = new System.Windows.Forms.GroupBox();
            this.bmrGroupSelectedIndexLabel = new System.Windows.Forms.Label();
            this.bmrGroupUnselectButton = new System.Windows.Forms.Button();
            this.bmrGroupCalcButton = new System.Windows.Forms.Button();
            this.bmrGroupAgeTextBox = new System.Windows.Forms.TextBox();
            this.bmrGroupAgeLabel = new System.Windows.Forms.Label();
            this.bmrGroupRadioMale = new System.Windows.Forms.RadioButton();
            this.bmrGroupRadioFemale = new System.Windows.Forms.RadioButton();
            this.BMRResult = new System.Windows.Forms.ListBox();
            this.bmrGroupActivityLevel = new System.Windows.Forms.GroupBox();
            this.bmrAvctivityLevelRadioExtraActive = new System.Windows.Forms.RadioButton();
            this.bmrAvctivityLevelRadioVeryActive = new System.Windows.Forms.RadioButton();
            this.bmrAvctivityLevelRadioModerateActivity = new System.Windows.Forms.RadioButton();
            this.bmrAvctivityLevelRadioLightlyActivity = new System.Windows.Forms.RadioButton();
            this.bmrAvctivityLevelRadioSedentary = new System.Windows.Forms.RadioButton();
            this.fuelGroup.SuspendLayout();
            this.fuelGroupResults.SuspendLayout();
            this.bmiGroup.SuspendLayout();
            this.bmiGroupResults.SuspendLayout();
            this.bmrGroup.SuspendLayout();
            this.bmrGroupActivityLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fuelGroup
            // 
            this.fuelGroup.Controls.Add(this.fuelGroupCalcButton);
            this.fuelGroup.Controls.Add(this.fuelGroupPricePerLiterTextBox);
            this.fuelGroup.Controls.Add(this.fuelGroupCurFuelTankedTextBox);
            this.fuelGroup.Controls.Add(this.fuelGroupPrevOdoLabelTextBox);
            this.fuelGroup.Controls.Add(this.fuelGroupCurOdoTextBox);
            this.fuelGroup.Controls.Add(this.fuelGroupPricePerLiterLabel);
            this.fuelGroup.Controls.Add(this.fuelGroupCurFuelTankedLabel);
            this.fuelGroup.Controls.Add(this.fuelGroupPrevOdoLabel);
            this.fuelGroup.Controls.Add(this.fuelGroupCurOdoLabel);
            this.fuelGroup.Controls.Add(this.fuelGroupResults);
            this.fuelGroup.ForeColor = System.Drawing.Color.RoyalBlue;
            this.fuelGroup.Location = new System.Drawing.Point(12, 12);
            this.fuelGroup.Name = "fuelGroup";
            this.fuelGroup.Size = new System.Drawing.Size(495, 381);
            this.fuelGroup.TabIndex = 0;
            this.fuelGroup.TabStop = false;
            this.fuelGroup.Text = "Fuel";
            // 
            // fuelGroupCalcButton
            // 
            this.fuelGroupCalcButton.Location = new System.Drawing.Point(137, 160);
            this.fuelGroupCalcButton.Name = "fuelGroupCalcButton";
            this.fuelGroupCalcButton.Size = new System.Drawing.Size(211, 23);
            this.fuelGroupCalcButton.TabIndex = 13;
            this.fuelGroupCalcButton.Text = "Calculate";
            this.fuelGroupCalcButton.UseVisualStyleBackColor = true;
            this.fuelGroupCalcButton.Click += new System.EventHandler(this.btnCalcFuel_Click);
            // 
            // fuelGroupPricePerLiterTextBox
            // 
            this.fuelGroupPricePerLiterTextBox.Location = new System.Drawing.Point(320, 118);
            this.fuelGroupPricePerLiterTextBox.Name = "fuelGroupPricePerLiterTextBox";
            this.fuelGroupPricePerLiterTextBox.Size = new System.Drawing.Size(100, 20);
            this.fuelGroupPricePerLiterTextBox.TabIndex = 12;
            // 
            // fuelGroupCurFuelTankedTextBox
            // 
            this.fuelGroupCurFuelTankedTextBox.Location = new System.Drawing.Point(320, 88);
            this.fuelGroupCurFuelTankedTextBox.Name = "fuelGroupCurFuelTankedTextBox";
            this.fuelGroupCurFuelTankedTextBox.Size = new System.Drawing.Size(100, 20);
            this.fuelGroupCurFuelTankedTextBox.TabIndex = 11;
            // 
            // fuelGroupPrevOdoLabelTextBox
            // 
            this.fuelGroupPrevOdoLabelTextBox.Location = new System.Drawing.Point(320, 60);
            this.fuelGroupPrevOdoLabelTextBox.Name = "fuelGroupPrevOdoLabelTextBox";
            this.fuelGroupPrevOdoLabelTextBox.Size = new System.Drawing.Size(100, 20);
            this.fuelGroupPrevOdoLabelTextBox.TabIndex = 10;
            // 
            // fuelGroupCurOdoTextBox
            // 
            this.fuelGroupCurOdoTextBox.Location = new System.Drawing.Point(320, 30);
            this.fuelGroupCurOdoTextBox.Name = "fuelGroupCurOdoTextBox";
            this.fuelGroupCurOdoTextBox.Size = new System.Drawing.Size(100, 20);
            this.fuelGroupCurOdoTextBox.TabIndex = 9;
            // 
            // fuelGroupPricePerLiterLabel
            // 
            this.fuelGroupPricePerLiterLabel.AutoSize = true;
            this.fuelGroupPricePerLiterLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.fuelGroupPricePerLiterLabel.Location = new System.Drawing.Point(12, 121);
            this.fuelGroupPricePerLiterLabel.Name = "fuelGroupPricePerLiterLabel";
            this.fuelGroupPricePerLiterLabel.Size = new System.Drawing.Size(68, 13);
            this.fuelGroupPricePerLiterLabel.TabIndex = 8;
            this.fuelGroupPricePerLiterLabel.Text = "Price per liter";
            // 
            // fuelGroupCurFuelTankedLabel
            // 
            this.fuelGroupCurFuelTankedLabel.AutoSize = true;
            this.fuelGroupCurFuelTankedLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.fuelGroupCurFuelTankedLabel.Location = new System.Drawing.Point(12, 91);
            this.fuelGroupCurFuelTankedLabel.Name = "fuelGroupCurFuelTankedLabel";
            this.fuelGroupCurFuelTankedLabel.Size = new System.Drawing.Size(177, 13);
            this.fuelGroupCurFuelTankedLabel.TabIndex = 7;
            this.fuelGroupCurFuelTankedLabel.Text = "Current amount of fuel tanked (liters)";
            // 
            // fuelGroupPrevOdoLabel
            // 
            this.fuelGroupPrevOdoLabel.AutoSize = true;
            this.fuelGroupPrevOdoLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.fuelGroupPrevOdoLabel.Location = new System.Drawing.Point(12, 63);
            this.fuelGroupPrevOdoLabel.Name = "fuelGroupPrevOdoLabel";
            this.fuelGroupPrevOdoLabel.Size = new System.Drawing.Size(156, 13);
            this.fuelGroupPrevOdoLabel.TabIndex = 6;
            this.fuelGroupPrevOdoLabel.Text = "Previous odometer reading (km)";
            // 
            // fuelGroupCurOdoLabel
            // 
            this.fuelGroupCurOdoLabel.AutoSize = true;
            this.fuelGroupCurOdoLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.fuelGroupCurOdoLabel.Location = new System.Drawing.Point(12, 33);
            this.fuelGroupCurOdoLabel.Name = "fuelGroupCurOdoLabel";
            this.fuelGroupCurOdoLabel.Size = new System.Drawing.Size(149, 13);
            this.fuelGroupCurOdoLabel.TabIndex = 5;
            this.fuelGroupCurOdoLabel.Text = "Current odometer reading (km)";
            // 
            // fuelGroupResults
            // 
            this.fuelGroupResults.AutoSize = true;
            this.fuelGroupResults.Controls.Add(this.fuelGroupResultsCostRes);
            this.fuelGroupResults.Controls.Add(this.fuelGroupResultsFClitmilRes);
            this.fuelGroupResults.Controls.Add(this.fuelGroupResultsFClitmileRes);
            this.fuelGroupResults.Controls.Add(this.fuelGroupResultsFClitkmRes);
            this.fuelGroupResults.Controls.Add(this.fuelGroupResultsFCkmlitRes);
            this.fuelGroupResults.Controls.Add(this.fuelGroupResultsCost);
            this.fuelGroupResults.Controls.Add(this.fuelGroupResultsFClitmil);
            this.fuelGroupResults.Controls.Add(this.fuelGroupResultsFClitmile);
            this.fuelGroupResults.Controls.Add(this.fuelGroupResultsFClitkm);
            this.fuelGroupResults.Controls.Add(this.fuelGroupResultsFCkmlit);
            this.fuelGroupResults.Location = new System.Drawing.Point(6, 189);
            this.fuelGroupResults.Name = "fuelGroupResults";
            this.fuelGroupResults.Size = new System.Drawing.Size(483, 186);
            this.fuelGroupResults.TabIndex = 0;
            this.fuelGroupResults.TabStop = false;
            this.fuelGroupResults.Text = "Results";
            // 
            // fuelGroupResultsCostRes
            // 
            this.fuelGroupResultsCostRes.AutoSize = true;
            this.fuelGroupResultsCostRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fuelGroupResultsCostRes.ForeColor = System.Drawing.Color.DarkGreen;
            this.fuelGroupResultsCostRes.Location = new System.Drawing.Point(385, 140);
            this.fuelGroupResultsCostRes.Name = "fuelGroupResultsCostRes";
            this.fuelGroupResultsCostRes.Size = new System.Drawing.Size(29, 15);
            this.fuelGroupResultsCostRes.TabIndex = 9;
            this.fuelGroupResultsCostRes.Text = "N/A";
            // 
            // fuelGroupResultsFClitmilRes
            // 
            this.fuelGroupResultsFClitmilRes.AutoSize = true;
            this.fuelGroupResultsFClitmilRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fuelGroupResultsFClitmilRes.ForeColor = System.Drawing.Color.DarkGreen;
            this.fuelGroupResultsFClitmilRes.Location = new System.Drawing.Point(385, 112);
            this.fuelGroupResultsFClitmilRes.Name = "fuelGroupResultsFClitmilRes";
            this.fuelGroupResultsFClitmilRes.Size = new System.Drawing.Size(29, 15);
            this.fuelGroupResultsFClitmilRes.TabIndex = 8;
            this.fuelGroupResultsFClitmilRes.Text = "N/A";
            // 
            // fuelGroupResultsFClitmileRes
            // 
            this.fuelGroupResultsFClitmileRes.AutoSize = true;
            this.fuelGroupResultsFClitmileRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fuelGroupResultsFClitmileRes.ForeColor = System.Drawing.Color.DarkGreen;
            this.fuelGroupResultsFClitmileRes.Location = new System.Drawing.Point(385, 86);
            this.fuelGroupResultsFClitmileRes.Name = "fuelGroupResultsFClitmileRes";
            this.fuelGroupResultsFClitmileRes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fuelGroupResultsFClitmileRes.Size = new System.Drawing.Size(29, 15);
            this.fuelGroupResultsFClitmileRes.TabIndex = 7;
            this.fuelGroupResultsFClitmileRes.Text = "N/A";
            // 
            // fuelGroupResultsFClitkmRes
            // 
            this.fuelGroupResultsFClitkmRes.AutoSize = true;
            this.fuelGroupResultsFClitkmRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fuelGroupResultsFClitkmRes.ForeColor = System.Drawing.Color.DarkGreen;
            this.fuelGroupResultsFClitkmRes.Location = new System.Drawing.Point(385, 59);
            this.fuelGroupResultsFClitkmRes.Name = "fuelGroupResultsFClitkmRes";
            this.fuelGroupResultsFClitkmRes.Size = new System.Drawing.Size(29, 15);
            this.fuelGroupResultsFClitkmRes.TabIndex = 6;
            this.fuelGroupResultsFClitkmRes.Text = "N/A";
            // 
            // fuelGroupResultsFCkmlitRes
            // 
            this.fuelGroupResultsFCkmlitRes.AutoSize = true;
            this.fuelGroupResultsFCkmlitRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fuelGroupResultsFCkmlitRes.ForeColor = System.Drawing.Color.DarkGreen;
            this.fuelGroupResultsFCkmlitRes.Location = new System.Drawing.Point(385, 32);
            this.fuelGroupResultsFCkmlitRes.Name = "fuelGroupResultsFCkmlitRes";
            this.fuelGroupResultsFCkmlitRes.Size = new System.Drawing.Size(29, 15);
            this.fuelGroupResultsFCkmlitRes.TabIndex = 5;
            this.fuelGroupResultsFCkmlitRes.Text = "N/A";
            // 
            // fuelGroupResultsCost
            // 
            this.fuelGroupResultsCost.AutoSize = true;
            this.fuelGroupResultsCost.ForeColor = System.Drawing.Color.DarkGreen;
            this.fuelGroupResultsCost.Location = new System.Drawing.Point(6, 140);
            this.fuelGroupResultsCost.Name = "fuelGroupResultsCost";
            this.fuelGroupResultsCost.Size = new System.Drawing.Size(91, 13);
            this.fuelGroupResultsCost.TabIndex = 4;
            this.fuelGroupResultsCost.Text = "Cost per kilometer";
            // 
            // fuelGroupResultsFClitmil
            // 
            this.fuelGroupResultsFClitmil.AutoSize = true;
            this.fuelGroupResultsFClitmil.ForeColor = System.Drawing.Color.DarkGreen;
            this.fuelGroupResultsFClitmil.Location = new System.Drawing.Point(6, 112);
            this.fuelGroupResultsFClitmil.Name = "fuelGroupResultsFClitmil";
            this.fuelGroupResultsFClitmil.Size = new System.Drawing.Size(123, 13);
            this.fuelGroupResultsFClitmil.TabIndex = 3;
            this.fuelGroupResultsFClitmil.Text = "Fuel consumption (lit/mil)";
            // 
            // fuelGroupResultsFClitmile
            // 
            this.fuelGroupResultsFClitmile.AutoSize = true;
            this.fuelGroupResultsFClitmile.ForeColor = System.Drawing.Color.DarkGreen;
            this.fuelGroupResultsFClitmile.Location = new System.Drawing.Point(6, 86);
            this.fuelGroupResultsFClitmile.Name = "fuelGroupResultsFClitmile";
            this.fuelGroupResultsFClitmile.Size = new System.Drawing.Size(129, 13);
            this.fuelGroupResultsFClitmile.TabIndex = 2;
            this.fuelGroupResultsFClitmile.Text = "Fuel consumption (lit/mile)";
            // 
            // fuelGroupResultsFClitkm
            // 
            this.fuelGroupResultsFClitkm.AutoSize = true;
            this.fuelGroupResultsFClitkm.ForeColor = System.Drawing.Color.DarkGreen;
            this.fuelGroupResultsFClitkm.Location = new System.Drawing.Point(6, 59);
            this.fuelGroupResultsFClitkm.Name = "fuelGroupResultsFClitkm";
            this.fuelGroupResultsFClitkm.Size = new System.Drawing.Size(125, 13);
            this.fuelGroupResultsFClitkm.TabIndex = 1;
            this.fuelGroupResultsFClitkm.Text = "Fuel consumption (lit/km)";
            // 
            // fuelGroupResultsFCkmlit
            // 
            this.fuelGroupResultsFCkmlit.AutoSize = true;
            this.fuelGroupResultsFCkmlit.ForeColor = System.Drawing.Color.DarkGreen;
            this.fuelGroupResultsFCkmlit.Location = new System.Drawing.Point(6, 32);
            this.fuelGroupResultsFCkmlit.Name = "fuelGroupResultsFCkmlit";
            this.fuelGroupResultsFCkmlit.Size = new System.Drawing.Size(125, 13);
            this.fuelGroupResultsFCkmlit.TabIndex = 0;
            this.fuelGroupResultsFCkmlit.Text = "Fuel consumption (km/lit)";
            // 
            // bmiGroup
            // 
            this.bmiGroup.Controls.Add(this.bmiGroupWeightLabel);
            this.bmiGroup.Controls.Add(this.bmiGroupHeightLabel);
            this.bmiGroup.Controls.Add(this.bmiGroupYourNameLabel);
            this.bmiGroup.Controls.Add(this.bmiGroupCalcButton);
            this.bmiGroup.Controls.Add(this.bmiGroupRadioUS);
            this.bmiGroup.Controls.Add(this.bmiGroupRadioMetric);
            this.bmiGroup.Controls.Add(this.bmiGroupWeightLabelTextBox);
            this.bmiGroup.Controls.Add(this.bmiGroupHeightLabelTextBox);
            this.bmiGroup.Controls.Add(this.bmiGroupYourNameTextBox);
            this.bmiGroup.Controls.Add(this.bmiGroupResults);
            this.bmiGroup.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bmiGroup.Location = new System.Drawing.Point(513, 12);
            this.bmiGroup.Name = "bmiGroup";
            this.bmiGroup.Size = new System.Drawing.Size(923, 381);
            this.bmiGroup.TabIndex = 1;
            this.bmiGroup.TabStop = false;
            this.bmiGroup.Text = "BMI";
            // 
            // bmiGroupWeightLabel
            // 
            this.bmiGroupWeightLabel.AutoSize = true;
            this.bmiGroupWeightLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.bmiGroupWeightLabel.Location = new System.Drawing.Point(27, 95);
            this.bmiGroupWeightLabel.Name = "bmiGroupWeightLabel";
            this.bmiGroupWeightLabel.Size = new System.Drawing.Size(62, 13);
            this.bmiGroupWeightLabel.TabIndex = 18;
            this.bmiGroupWeightLabel.Text = "Weight (kg)";
            // 
            // bmiGroupHeightLabel
            // 
            this.bmiGroupHeightLabel.AutoSize = true;
            this.bmiGroupHeightLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.bmiGroupHeightLabel.Location = new System.Drawing.Point(27, 61);
            this.bmiGroupHeightLabel.Name = "bmiGroupHeightLabel";
            this.bmiGroupHeightLabel.Size = new System.Drawing.Size(61, 13);
            this.bmiGroupHeightLabel.TabIndex = 17;
            this.bmiGroupHeightLabel.Text = "Height (cm)";
            // 
            // bmiGroupYourNameLabel
            // 
            this.bmiGroupYourNameLabel.AutoSize = true;
            this.bmiGroupYourNameLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.bmiGroupYourNameLabel.Location = new System.Drawing.Point(27, 30);
            this.bmiGroupYourNameLabel.Name = "bmiGroupYourNameLabel";
            this.bmiGroupYourNameLabel.Size = new System.Drawing.Size(58, 13);
            this.bmiGroupYourNameLabel.TabIndex = 16;
            this.bmiGroupYourNameLabel.Text = "Your name";
            // 
            // bmiGroupCalcButton
            // 
            this.bmiGroupCalcButton.Location = new System.Drawing.Point(359, 160);
            this.bmiGroupCalcButton.Name = "bmiGroupCalcButton";
            this.bmiGroupCalcButton.Size = new System.Drawing.Size(211, 23);
            this.bmiGroupCalcButton.TabIndex = 15;
            this.bmiGroupCalcButton.Text = "Calculate";
            this.bmiGroupCalcButton.UseVisualStyleBackColor = true;
            this.bmiGroupCalcButton.Click += new System.EventHandler(this.btnCalcBMI_Click);
            // 
            // bmiGroupRadioUS
            // 
            this.bmiGroupRadioUS.AutoSize = true;
            this.bmiGroupRadioUS.ForeColor = System.Drawing.Color.DarkGreen;
            this.bmiGroupRadioUS.Location = new System.Drawing.Point(624, 87);
            this.bmiGroupRadioUS.Name = "bmiGroupRadioUS";
            this.bmiGroupRadioUS.Size = new System.Drawing.Size(105, 17);
            this.bmiGroupRadioUS.TabIndex = 14;
            this.bmiGroupRadioUS.TabStop = true;
            this.bmiGroupRadioUS.Text = "US Unit (lb, inch)";
            this.bmiGroupRadioUS.UseVisualStyleBackColor = true;
            this.bmiGroupRadioUS.CheckedChanged += new System.EventHandler(this.bmiRadio_CheckedChanged);
            // 
            // bmiGroupRadioMetric
            // 
            this.bmiGroupRadioMetric.AutoSize = true;
            this.bmiGroupRadioMetric.ForeColor = System.Drawing.Color.DarkGreen;
            this.bmiGroupRadioMetric.Location = new System.Drawing.Point(624, 61);
            this.bmiGroupRadioMetric.Name = "bmiGroupRadioMetric";
            this.bmiGroupRadioMetric.Size = new System.Drawing.Size(117, 17);
            this.bmiGroupRadioMetric.TabIndex = 13;
            this.bmiGroupRadioMetric.TabStop = true;
            this.bmiGroupRadioMetric.Text = "Metric Unit (kg, cm)";
            this.bmiGroupRadioMetric.UseVisualStyleBackColor = true;
            this.bmiGroupRadioMetric.CheckedChanged += new System.EventHandler(this.bmiRadio_CheckedChanged);
            // 
            // bmiGroupWeightLabelTextBox
            // 
            this.bmiGroupWeightLabelTextBox.Location = new System.Drawing.Point(216, 88);
            this.bmiGroupWeightLabelTextBox.Name = "bmiGroupWeightLabelTextBox";
            this.bmiGroupWeightLabelTextBox.Size = new System.Drawing.Size(100, 20);
            this.bmiGroupWeightLabelTextBox.TabIndex = 12;
            // 
            // bmiGroupHeightLabelTextBox
            // 
            this.bmiGroupHeightLabelTextBox.Location = new System.Drawing.Point(216, 60);
            this.bmiGroupHeightLabelTextBox.Name = "bmiGroupHeightLabelTextBox";
            this.bmiGroupHeightLabelTextBox.Size = new System.Drawing.Size(100, 20);
            this.bmiGroupHeightLabelTextBox.TabIndex = 11;
            // 
            // bmiGroupYourNameTextBox
            // 
            this.bmiGroupYourNameTextBox.Location = new System.Drawing.Point(216, 30);
            this.bmiGroupYourNameTextBox.Name = "bmiGroupYourNameTextBox";
            this.bmiGroupYourNameTextBox.Size = new System.Drawing.Size(652, 20);
            this.bmiGroupYourNameTextBox.TabIndex = 10;
            // 
            // bmiGroupResults
            // 
            this.bmiGroupResults.Controls.Add(this.bmiGroupResNormBMILabel);
            this.bmiGroupResults.Controls.Add(this.bmiGroupResultsWeightCatLabelRes);
            this.bmiGroupResults.Controls.Add(this.bmiGroupResultsYourBMILabelRes);
            this.bmiGroupResults.Controls.Add(this.bmiGroupResultsYourBMILabel);
            this.bmiGroupResults.Controls.Add(this.bmiGroupResultsWeightCatLabel);
            this.bmiGroupResults.Location = new System.Drawing.Point(6, 189);
            this.bmiGroupResults.Name = "bmiGroupResults";
            this.bmiGroupResults.Size = new System.Drawing.Size(911, 186);
            this.bmiGroupResults.TabIndex = 0;
            this.bmiGroupResults.TabStop = false;
            this.bmiGroupResults.Text = "Results";
            // 
            // bmiGroupResNormBMILabel
            // 
            this.bmiGroupResNormBMILabel.AutoSize = true;
            this.bmiGroupResNormBMILabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.bmiGroupResNormBMILabel.Location = new System.Drawing.Point(544, 140);
            this.bmiGroupResNormBMILabel.Name = "bmiGroupResNormBMILabel";
            this.bmiGroupResNormBMILabel.Size = new System.Drawing.Size(185, 13);
            this.bmiGroupResNormBMILabel.TabIndex = 9;
            this.bmiGroupResNormBMILabel.Text = "Normal BMI is between 18.5 and 24.9";
            // 
            // bmiGroupResultsWeightCatLabelRes
            // 
            this.bmiGroupResultsWeightCatLabelRes.AutoSize = true;
            this.bmiGroupResultsWeightCatLabelRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bmiGroupResultsWeightCatLabelRes.ForeColor = System.Drawing.Color.DarkGreen;
            this.bmiGroupResultsWeightCatLabelRes.Location = new System.Drawing.Point(700, 86);
            this.bmiGroupResultsWeightCatLabelRes.Name = "bmiGroupResultsWeightCatLabelRes";
            this.bmiGroupResultsWeightCatLabelRes.Size = new System.Drawing.Size(29, 15);
            this.bmiGroupResultsWeightCatLabelRes.TabIndex = 8;
            this.bmiGroupResultsWeightCatLabelRes.Text = "N/A";
            // 
            // bmiGroupResultsYourBMILabelRes
            // 
            this.bmiGroupResultsYourBMILabelRes.AutoSize = true;
            this.bmiGroupResultsYourBMILabelRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bmiGroupResultsYourBMILabelRes.ForeColor = System.Drawing.Color.DarkGreen;
            this.bmiGroupResultsYourBMILabelRes.Location = new System.Drawing.Point(700, 59);
            this.bmiGroupResultsYourBMILabelRes.Name = "bmiGroupResultsYourBMILabelRes";
            this.bmiGroupResultsYourBMILabelRes.Size = new System.Drawing.Size(29, 15);
            this.bmiGroupResultsYourBMILabelRes.TabIndex = 7;
            this.bmiGroupResultsYourBMILabelRes.Text = "N/A";
            // 
            // bmiGroupResultsYourBMILabel
            // 
            this.bmiGroupResultsYourBMILabel.AutoSize = true;
            this.bmiGroupResultsYourBMILabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.bmiGroupResultsYourBMILabel.Location = new System.Drawing.Point(6, 59);
            this.bmiGroupResultsYourBMILabel.Name = "bmiGroupResultsYourBMILabel";
            this.bmiGroupResultsYourBMILabel.Size = new System.Drawing.Size(51, 13);
            this.bmiGroupResultsYourBMILabel.TabIndex = 2;
            this.bmiGroupResultsYourBMILabel.Text = "Your BMI";
            // 
            // bmiGroupResultsWeightCatLabel
            // 
            this.bmiGroupResultsWeightCatLabel.AutoSize = true;
            this.bmiGroupResultsWeightCatLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.bmiGroupResultsWeightCatLabel.Location = new System.Drawing.Point(6, 86);
            this.bmiGroupResultsWeightCatLabel.Name = "bmiGroupResultsWeightCatLabel";
            this.bmiGroupResultsWeightCatLabel.Size = new System.Drawing.Size(86, 13);
            this.bmiGroupResultsWeightCatLabel.TabIndex = 1;
            this.bmiGroupResultsWeightCatLabel.Text = "Weight Category";
            // 
            // bmrGroup
            // 
            this.bmrGroup.Controls.Add(this.bmrGroupSelectedIndexLabel);
            this.bmrGroup.Controls.Add(this.bmrGroupUnselectButton);
            this.bmrGroup.Controls.Add(this.bmrGroupCalcButton);
            this.bmrGroup.Controls.Add(this.bmrGroupAgeTextBox);
            this.bmrGroup.Controls.Add(this.bmrGroupAgeLabel);
            this.bmrGroup.Controls.Add(this.bmrGroupRadioMale);
            this.bmrGroup.Controls.Add(this.bmrGroupRadioFemale);
            this.bmrGroup.Controls.Add(this.BMRResult);
            this.bmrGroup.Controls.Add(this.bmrGroupActivityLevel);
            this.bmrGroup.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bmrGroup.Location = new System.Drawing.Point(12, 399);
            this.bmrGroup.Name = "bmrGroup";
            this.bmrGroup.Size = new System.Drawing.Size(1424, 270);
            this.bmrGroup.TabIndex = 2;
            this.bmrGroup.TabStop = false;
            this.bmrGroup.Text = "BMR";
            // 
            // bmrGroupSelectedIndexLabel
            // 
            this.bmrGroupSelectedIndexLabel.AutoSize = true;
            this.bmrGroupSelectedIndexLabel.Location = new System.Drawing.Point(501, 235);
            this.bmrGroupSelectedIndexLabel.Name = "bmrGroupSelectedIndexLabel";
            this.bmrGroupSelectedIndexLabel.Size = new System.Drawing.Size(16, 13);
            this.bmrGroupSelectedIndexLabel.TabIndex = 8;
            this.bmrGroupSelectedIndexLabel.Text = "-1";
            // 
            // bmrGroupUnselectButton
            // 
            this.bmrGroupUnselectButton.Location = new System.Drawing.Point(1207, 234);
            this.bmrGroupUnselectButton.Name = "bmrGroupUnselectButton";
            this.bmrGroupUnselectButton.Size = new System.Drawing.Size(211, 23);
            this.bmrGroupUnselectButton.TabIndex = 7;
            this.bmrGroupUnselectButton.Text = "Unselect";
            this.bmrGroupUnselectButton.UseVisualStyleBackColor = true;
            this.bmrGroupUnselectButton.Click += new EventHandler(btnUnselect_Click);
            // 
            // bmrGroupCalcButton
            // 
            this.bmrGroupCalcButton.Location = new System.Drawing.Point(137, 234);
            this.bmrGroupCalcButton.Name = "bmrGroupCalcButton";
            this.bmrGroupCalcButton.Size = new System.Drawing.Size(211, 23);
            this.bmrGroupCalcButton.TabIndex = 6;
            this.bmrGroupCalcButton.Text = "Calculate";
            this.bmrGroupCalcButton.UseVisualStyleBackColor = true;
            this.bmrGroupCalcButton.Click += new System.EventHandler(this.btnCalcBMR_Click);
            // 
            // bmrGroupAgeTextBox
            // 
            this.bmrGroupAgeTextBox.Location = new System.Drawing.Point(85, 48);
            this.bmrGroupAgeTextBox.Name = "bmrGroupAgeTextBox";
            this.bmrGroupAgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.bmrGroupAgeTextBox.TabIndex = 5;
            // 
            // bmrGroupAgeLabel
            // 
            this.bmrGroupAgeLabel.AutoSize = true;
            this.bmrGroupAgeLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.bmrGroupAgeLabel.Location = new System.Drawing.Point(6, 51);
            this.bmrGroupAgeLabel.Name = "bmrGroupAgeLabel";
            this.bmrGroupAgeLabel.Size = new System.Drawing.Size(26, 13);
            this.bmrGroupAgeLabel.TabIndex = 4;
            this.bmrGroupAgeLabel.Text = "Age";
            // 
            // bmrGroupRadioMale
            // 
            this.bmrGroupRadioMale.AutoSize = true;
            this.bmrGroupRadioMale.ForeColor = System.Drawing.Color.DarkGreen;
            this.bmrGroupRadioMale.Location = new System.Drawing.Point(137, 20);
            this.bmrGroupRadioMale.Name = "bmrGroupRadioMale";
            this.bmrGroupRadioMale.Size = new System.Drawing.Size(48, 17);
            this.bmrGroupRadioMale.TabIndex = 3;
            this.bmrGroupRadioMale.TabStop = true;
            this.bmrGroupRadioMale.Text = "Male";
            this.bmrGroupRadioMale.UseVisualStyleBackColor = true;
            // 
            // bmrGroupRadioFemale
            // 
            this.bmrGroupRadioFemale.AutoSize = true;
            this.bmrGroupRadioFemale.ForeColor = System.Drawing.Color.DarkGreen;
            this.bmrGroupRadioFemale.Location = new System.Drawing.Point(7, 20);
            this.bmrGroupRadioFemale.Name = "bmrGroupRadioFemale";
            this.bmrGroupRadioFemale.Size = new System.Drawing.Size(59, 17);
            this.bmrGroupRadioFemale.TabIndex = 2;
            this.bmrGroupRadioFemale.TabStop = true;
            this.bmrGroupRadioFemale.Text = "Female";
            this.bmrGroupRadioFemale.UseVisualStyleBackColor = true;
            // 
            // BMRResult
            // 
            this.BMRResult.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMRResult.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BMRResult.FormattingEnabled = true;
            this.BMRResult.ItemHeight = 15;
            this.BMRResult.Location = new System.Drawing.Point(501, 16);
            this.BMRResult.Name = "BMRResult";
            this.BMRResult.Size = new System.Drawing.Size(917, 199);
            this.BMRResult.TabIndex = 1;
            this.BMRResult.SelectedIndexChanged += new EventHandler(BMRResult_SelectedIndexChanged);
            // 
            // bmrGroupActivityLevel
            // 
            this.bmrGroupActivityLevel.Controls.Add(this.bmrAvctivityLevelRadioExtraActive);
            this.bmrGroupActivityLevel.Controls.Add(this.bmrAvctivityLevelRadioVeryActive);
            this.bmrGroupActivityLevel.Controls.Add(this.bmrAvctivityLevelRadioModerateActivity);
            this.bmrGroupActivityLevel.Controls.Add(this.bmrAvctivityLevelRadioLightlyActivity);
            this.bmrGroupActivityLevel.Controls.Add(this.bmrAvctivityLevelRadioSedentary);
            this.bmrGroupActivityLevel.Location = new System.Drawing.Point(7, 74);
            this.bmrGroupActivityLevel.Name = "bmrGroupActivityLevel";
            this.bmrGroupActivityLevel.Size = new System.Drawing.Size(489, 154);
            this.bmrGroupActivityLevel.TabIndex = 0;
            this.bmrGroupActivityLevel.TabStop = false;
            this.bmrGroupActivityLevel.Text = "Activity level per week";
            // 
            // bmrAvctivityLevelRadioExtraActive
            // 
            this.bmrAvctivityLevelRadioExtraActive.AutoSize = true;
            this.bmrAvctivityLevelRadioExtraActive.ForeColor = System.Drawing.Color.DarkGreen;
            this.bmrAvctivityLevelRadioExtraActive.Location = new System.Drawing.Point(6, 125);
            this.bmrAvctivityLevelRadioExtraActive.Name = "bmrAvctivityLevelRadioExtraActive";
            this.bmrAvctivityLevelRadioExtraActive.Size = new System.Drawing.Size(179, 17);
            this.bmrAvctivityLevelRadioExtraActive.TabIndex = 4;
            this.bmrAvctivityLevelRadioExtraActive.TabStop = true;
            this.bmrAvctivityLevelRadioExtraActive.Text = "Extra active, hard exercise or job";
            this.bmrAvctivityLevelRadioExtraActive.UseVisualStyleBackColor = true;
            // 
            // bmrAvctivityLevelRadioVeryActive
            // 
            this.bmrAvctivityLevelRadioVeryActive.AutoSize = true;
            this.bmrAvctivityLevelRadioVeryActive.ForeColor = System.Drawing.Color.DarkGreen;
            this.bmrAvctivityLevelRadioVeryActive.Location = new System.Drawing.Point(6, 101);
            this.bmrAvctivityLevelRadioVeryActive.Name = "bmrAvctivityLevelRadioVeryActive";
            this.bmrAvctivityLevelRadioVeryActive.Size = new System.Drawing.Size(141, 17);
            this.bmrAvctivityLevelRadioVeryActive.TabIndex = 3;
            this.bmrAvctivityLevelRadioVeryActive.TabStop = true;
            this.bmrAvctivityLevelRadioVeryActive.Text = "Very active (6 to 7 times)";
            this.bmrAvctivityLevelRadioVeryActive.UseVisualStyleBackColor = true;
            // 
            // bmrAvctivityLevelRadioModerateActivity
            // 
            this.bmrAvctivityLevelRadioModerateActivity.AutoSize = true;
            this.bmrAvctivityLevelRadioModerateActivity.ForeColor = System.Drawing.Color.DarkGreen;
            this.bmrAvctivityLevelRadioModerateActivity.Location = new System.Drawing.Point(6, 78);
            this.bmrAvctivityLevelRadioModerateActivity.Name = "bmrAvctivityLevelRadioModerateActivity";
            this.bmrAvctivityLevelRadioModerateActivity.Size = new System.Drawing.Size(172, 17);
            this.bmrAvctivityLevelRadioModerateActivity.TabIndex = 2;
            this.bmrAvctivityLevelRadioModerateActivity.TabStop = true;
            this.bmrAvctivityLevelRadioModerateActivity.Text = "Moderately active (3 to 5 times)";
            this.bmrAvctivityLevelRadioModerateActivity.UseVisualStyleBackColor = true;
            // 
            // bmrAvctivityLevelRadioLightlyActivity
            // 
            this.bmrAvctivityLevelRadioLightlyActivity.AutoSize = true;
            this.bmrAvctivityLevelRadioLightlyActivity.ForeColor = System.Drawing.Color.DarkGreen;
            this.bmrAvctivityLevelRadioLightlyActivity.Location = new System.Drawing.Point(6, 55);
            this.bmrAvctivityLevelRadioLightlyActivity.Name = "bmrAvctivityLevelRadioLightlyActivity";
            this.bmrAvctivityLevelRadioLightlyActivity.Size = new System.Drawing.Size(150, 17);
            this.bmrAvctivityLevelRadioLightlyActivity.TabIndex = 1;
            this.bmrAvctivityLevelRadioLightlyActivity.TabStop = true;
            this.bmrAvctivityLevelRadioLightlyActivity.Text = "Lightly active (1 to 3 times)";
            this.bmrAvctivityLevelRadioLightlyActivity.UseVisualStyleBackColor = true;
            // 
            // bmrAvctivityLevelRadioSedentary
            // 
            this.bmrAvctivityLevelRadioSedentary.AutoSize = true;
            this.bmrAvctivityLevelRadioSedentary.ForeColor = System.Drawing.Color.DarkGreen;
            this.bmrAvctivityLevelRadioSedentary.Location = new System.Drawing.Point(6, 32);
            this.bmrAvctivityLevelRadioSedentary.Name = "bmrAvctivityLevelRadioSedentary";
            this.bmrAvctivityLevelRadioSedentary.Size = new System.Drawing.Size(169, 17);
            this.bmrAvctivityLevelRadioSedentary.TabIndex = 0;
            this.bmrAvctivityLevelRadioSedentary.TabStop = true;
            this.bmrAvctivityLevelRadioSedentary.Text = "Sedentary (little or no exercise)";
            this.bmrAvctivityLevelRadioSedentary.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 681);
            this.Controls.Add(this.bmrGroup);
            this.Controls.Add(this.bmiGroup);
            this.Controls.Add(this.fuelGroup);
            this.Name = "MainForm";
            this.Text = "Universal Calculator";
            this.fuelGroup.ResumeLayout(false);
            this.fuelGroup.PerformLayout();
            this.fuelGroupResults.ResumeLayout(false);
            this.fuelGroupResults.PerformLayout();
            this.bmiGroup.ResumeLayout(false);
            this.bmiGroup.PerformLayout();
            this.bmiGroupResults.ResumeLayout(false);
            this.bmiGroupResults.PerformLayout();
            this.bmrGroup.ResumeLayout(false);
            this.bmrGroup.PerformLayout();
            this.bmrGroupActivityLevel.ResumeLayout(false);
            this.bmrGroupActivityLevel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox fuelGroup;
        private System.Windows.Forms.GroupBox fuelGroupResults;
        private System.Windows.Forms.GroupBox bmiGroup;
        private System.Windows.Forms.GroupBox bmrGroup;
        private System.Windows.Forms.Button bmrGroupUnselectButton;
        private System.Windows.Forms.Button bmrGroupCalcButton;
        private System.Windows.Forms.TextBox bmrGroupAgeTextBox;
        private System.Windows.Forms.Label bmrGroupAgeLabel;
        private System.Windows.Forms.RadioButton bmrGroupRadioMale;
        private System.Windows.Forms.RadioButton bmrGroupRadioFemale;
        private System.Windows.Forms.ListBox BMRResult;
        private System.Windows.Forms.GroupBox bmrGroupActivityLevel;
        private System.Windows.Forms.RadioButton bmrAvctivityLevelRadioExtraActive;
        private System.Windows.Forms.RadioButton bmrAvctivityLevelRadioVeryActive;
        private System.Windows.Forms.RadioButton bmrAvctivityLevelRadioModerateActivity;
        private System.Windows.Forms.RadioButton bmrAvctivityLevelRadioLightlyActivity;
        private System.Windows.Forms.RadioButton bmrAvctivityLevelRadioSedentary;
        private System.Windows.Forms.Label bmrGroupSelectedIndexLabel;
        private System.Windows.Forms.Label fuelGroupResultsFClitmile;
        private System.Windows.Forms.Label fuelGroupResultsFClitkm;
        private System.Windows.Forms.Label fuelGroupResultsFCkmlit;
        private System.Windows.Forms.Label fuelGroupResultsFClitmil;
        private System.Windows.Forms.Label fuelGroupResultsFClitkmRes;
        private System.Windows.Forms.Label fuelGroupResultsFCkmlitRes;
        private System.Windows.Forms.Label fuelGroupResultsCost;
        private System.Windows.Forms.Label fuelGroupResultsCostRes;
        private System.Windows.Forms.Label fuelGroupResultsFClitmilRes;
        private System.Windows.Forms.Label fuelGroupResultsFClitmileRes;
        private System.Windows.Forms.GroupBox bmiGroupResults;
        private System.Windows.Forms.Label bmiGroupResNormBMILabel;
        private System.Windows.Forms.Label bmiGroupResultsWeightCatLabelRes;
        private System.Windows.Forms.Label bmiGroupResultsYourBMILabelRes;
        private System.Windows.Forms.Label bmiGroupResultsYourBMILabel;
        private System.Windows.Forms.Label bmiGroupResultsWeightCatLabel;
        private System.Windows.Forms.TextBox fuelGroupPricePerLiterTextBox;
        private System.Windows.Forms.TextBox fuelGroupCurFuelTankedTextBox;
        private System.Windows.Forms.TextBox fuelGroupPrevOdoLabelTextBox;
        private System.Windows.Forms.TextBox fuelGroupCurOdoTextBox;
        private System.Windows.Forms.Label fuelGroupPricePerLiterLabel;
        private System.Windows.Forms.Label fuelGroupCurFuelTankedLabel;
        private System.Windows.Forms.Label fuelGroupPrevOdoLabel;
        private System.Windows.Forms.Label fuelGroupCurOdoLabel;
        private System.Windows.Forms.TextBox bmiGroupWeightLabelTextBox;
        private System.Windows.Forms.TextBox bmiGroupHeightLabelTextBox;
        private System.Windows.Forms.TextBox bmiGroupYourNameTextBox;
        private System.Windows.Forms.RadioButton bmiGroupRadioUS;
        private System.Windows.Forms.RadioButton bmiGroupRadioMetric;
        private System.Windows.Forms.Button fuelGroupCalcButton;
        private System.Windows.Forms.Label bmiGroupWeightLabel;
        private System.Windows.Forms.Label bmiGroupHeightLabel;
        private System.Windows.Forms.Label bmiGroupYourNameLabel;
        private System.Windows.Forms.Button bmiGroupCalcButton;


       
    }
}

