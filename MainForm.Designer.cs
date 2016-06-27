namespace Assigment3
{
    partial class MainForm
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
            this.grpboxFuel = new System.Windows.Forms.GroupBox();
            this.grpboxFuelResult = new System.Windows.Forms.GroupBox();
            this.grpboxBMI = new System.Windows.Forms.GroupBox();
            this.grpboxBMIResult = new System.Windows.Forms.GroupBox();
            this.lblcurrentOdo = new System.Windows.Forms.Label();
            this.lblPreOdo = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblLiterPrice = new System.Windows.Forms.Label();
            this.lblFuelKmLit = new System.Windows.Forms.Label();
            this.lblFuelLitKm = new System.Windows.Forms.Label();
            this.lblFuelLitMetric = new System.Windows.Forms.Label();
            this.lblFuelLitSwe = new System.Windows.Forms.Label();
            this.lblFuelCost = new System.Windows.Forms.Label();
            this.btnCalcFuel = new System.Windows.Forms.Button();
            this.txtboxcurrentOdo = new System.Windows.Forms.TextBox();
            this.txtboxPreOdo = new System.Windows.Forms.TextBox();
            this.txtboxFuel = new System.Windows.Forms.TextBox();
            this.txtboxLiterPrice = new System.Windows.Forms.TextBox();
            this.lblFuelKmLitRes = new System.Windows.Forms.Label();
            this.lblFuelLitKmRes = new System.Windows.Forms.Label();
            this.lblFuelLitMetricRes = new System.Windows.Forms.Label();
            this.lblFuelLitSweRes = new System.Windows.Forms.Label();
            this.lblFuelCostRes = new System.Windows.Forms.Label();
            this.lblBMIName = new System.Windows.Forms.Label();
            this.lblBMIHeight = new System.Windows.Forms.Label();
            this.lblBMIWeight = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.txtboxHeight = new System.Windows.Forms.TextBox();
            this.txtboxWeight = new System.Windows.Forms.TextBox();
            this.rbMetric = new System.Windows.Forms.RadioButton();
            this.rbUS = new System.Windows.Forms.RadioButton();
            this.btnBMI = new System.Windows.Forms.Button();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblBMIRes = new System.Windows.Forms.Label();
            this.lblCategoryRes = new System.Windows.Forms.Label();
            this.lblBMInfo = new System.Windows.Forms.Label();
            this.grpboxFuel.SuspendLayout();
            this.grpboxFuelResult.SuspendLayout();
            this.grpboxBMI.SuspendLayout();
            this.grpboxBMIResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxFuel
            // 
            this.grpboxFuel.Controls.Add(this.txtboxLiterPrice);
            this.grpboxFuel.Controls.Add(this.txtboxFuel);
            this.grpboxFuel.Controls.Add(this.txtboxPreOdo);
            this.grpboxFuel.Controls.Add(this.txtboxcurrentOdo);
            this.grpboxFuel.Controls.Add(this.btnCalcFuel);
            this.grpboxFuel.Controls.Add(this.lblLiterPrice);
            this.grpboxFuel.Controls.Add(this.lblFuel);
            this.grpboxFuel.Controls.Add(this.lblPreOdo);
            this.grpboxFuel.Controls.Add(this.lblcurrentOdo);
            this.grpboxFuel.Location = new System.Drawing.Point(13, 13);
            this.grpboxFuel.Name = "grpboxFuel";
            this.grpboxFuel.Size = new System.Drawing.Size(293, 160);
            this.grpboxFuel.TabIndex = 0;
            this.grpboxFuel.TabStop = false;
            this.grpboxFuel.Text = "Fuel";
            // 
            // grpboxFuelResult
            // 
            this.grpboxFuelResult.Controls.Add(this.lblFuelCostRes);
            this.grpboxFuelResult.Controls.Add(this.lblFuelLitSweRes);
            this.grpboxFuelResult.Controls.Add(this.lblFuelLitMetricRes);
            this.grpboxFuelResult.Controls.Add(this.lblFuelLitKmRes);
            this.grpboxFuelResult.Controls.Add(this.lblFuelKmLitRes);
            this.grpboxFuelResult.Controls.Add(this.lblFuelCost);
            this.grpboxFuelResult.Controls.Add(this.lblFuelLitSwe);
            this.grpboxFuelResult.Controls.Add(this.lblFuelLitMetric);
            this.grpboxFuelResult.Controls.Add(this.lblFuelLitKm);
            this.grpboxFuelResult.Controls.Add(this.lblFuelKmLit);
            this.grpboxFuelResult.Location = new System.Drawing.Point(12, 179);
            this.grpboxFuelResult.Name = "grpboxFuelResult";
            this.grpboxFuelResult.Size = new System.Drawing.Size(293, 160);
            this.grpboxFuelResult.TabIndex = 1;
            this.grpboxFuelResult.TabStop = false;
            this.grpboxFuelResult.Text = "Results";
            // 
            // grpboxBMI
            // 
            this.grpboxBMI.Controls.Add(this.btnBMI);
            this.grpboxBMI.Controls.Add(this.rbUS);
            this.grpboxBMI.Controls.Add(this.rbMetric);
            this.grpboxBMI.Controls.Add(this.txtboxWeight);
            this.grpboxBMI.Controls.Add(this.txtboxHeight);
            this.grpboxBMI.Controls.Add(this.txtboxName);
            this.grpboxBMI.Controls.Add(this.lblBMIWeight);
            this.grpboxBMI.Controls.Add(this.lblBMIHeight);
            this.grpboxBMI.Controls.Add(this.lblBMIName);
            this.grpboxBMI.Location = new System.Drawing.Point(312, 13);
            this.grpboxBMI.Name = "grpboxBMI";
            this.grpboxBMI.Size = new System.Drawing.Size(473, 160);
            this.grpboxBMI.TabIndex = 2;
            this.grpboxBMI.TabStop = false;
            this.grpboxBMI.Text = "BMI";
            // 
            // grpboxBMIResult
            // 
            this.grpboxBMIResult.Controls.Add(this.lblBMInfo);
            this.grpboxBMIResult.Controls.Add(this.lblCategoryRes);
            this.grpboxBMIResult.Controls.Add(this.lblBMIRes);
            this.grpboxBMIResult.Controls.Add(this.lblCategory);
            this.grpboxBMIResult.Controls.Add(this.lblBMI);
            this.grpboxBMIResult.Location = new System.Drawing.Point(311, 179);
            this.grpboxBMIResult.Name = "grpboxBMIResult";
            this.grpboxBMIResult.Size = new System.Drawing.Size(474, 160);
            this.grpboxBMIResult.TabIndex = 3;
            this.grpboxBMIResult.TabStop = false;
            this.grpboxBMIResult.Text = "Results";
            // 
            // lblcurrentOdo
            // 
            this.lblcurrentOdo.AutoSize = true;
            this.lblcurrentOdo.Location = new System.Drawing.Point(1, 21);
            this.lblcurrentOdo.Margin = new System.Windows.Forms.Padding(5);
            this.lblcurrentOdo.Name = "lblcurrentOdo";
            this.lblcurrentOdo.Size = new System.Drawing.Size(149, 13);
            this.lblcurrentOdo.TabIndex = 0;
            this.lblcurrentOdo.Text = "Current odometer reading (km)";
            // 
            // lblPreOdo
            // 
            this.lblPreOdo.AutoSize = true;
            this.lblPreOdo.Location = new System.Drawing.Point(1, 44);
            this.lblPreOdo.Margin = new System.Windows.Forms.Padding(5);
            this.lblPreOdo.Name = "lblPreOdo";
            this.lblPreOdo.Size = new System.Drawing.Size(156, 13);
            this.lblPreOdo.TabIndex = 1;
            this.lblPreOdo.Text = "Previous odometer reading (km)";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(1, 67);
            this.lblFuel.Margin = new System.Windows.Forms.Padding(5);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(141, 13);
            this.lblFuel.TabIndex = 2;
            this.lblFuel.Text = "Amount of fuel tanked (liters)";
            // 
            // lblLiterPrice
            // 
            this.lblLiterPrice.AutoSize = true;
            this.lblLiterPrice.Location = new System.Drawing.Point(1, 90);
            this.lblLiterPrice.Margin = new System.Windows.Forms.Padding(5);
            this.lblLiterPrice.Name = "lblLiterPrice";
            this.lblLiterPrice.Size = new System.Drawing.Size(68, 13);
            this.lblLiterPrice.TabIndex = 3;
            this.lblLiterPrice.Text = "Price per liter";
            // 
            // lblFuelKmLit
            // 
            this.lblFuelKmLit.AutoSize = true;
            this.lblFuelKmLit.Location = new System.Drawing.Point(8, 21);
            this.lblFuelKmLit.Margin = new System.Windows.Forms.Padding(5);
            this.lblFuelKmLit.Name = "lblFuelKmLit";
            this.lblFuelKmLit.Size = new System.Drawing.Size(122, 13);
            this.lblFuelKmLit.TabIndex = 1;
            this.lblFuelKmLit.Text = "Fuel consumpion (km/lit)";
            // 
            // lblFuelLitKm
            // 
            this.lblFuelLitKm.AutoSize = true;
            this.lblFuelLitKm.Location = new System.Drawing.Point(8, 44);
            this.lblFuelLitKm.Margin = new System.Windows.Forms.Padding(5);
            this.lblFuelLitKm.Name = "lblFuelLitKm";
            this.lblFuelLitKm.Size = new System.Drawing.Size(122, 13);
            this.lblFuelLitKm.TabIndex = 2;
            this.lblFuelLitKm.Text = "Fuel consumpion (lit/km)";
            // 
            // lblFuelLitMetric
            // 
            this.lblFuelLitMetric.AutoSize = true;
            this.lblFuelLitMetric.Location = new System.Drawing.Point(8, 67);
            this.lblFuelLitMetric.Margin = new System.Windows.Forms.Padding(5);
            this.lblFuelLitMetric.Name = "lblFuelLitMetric";
            this.lblFuelLitMetric.Size = new System.Drawing.Size(157, 13);
            this.lblFuelLitMetric.TabIndex = 3;
            this.lblFuelLitMetric.Text = "Fuel consumpion (lit/metric mile)";
            // 
            // lblFuelLitSwe
            // 
            this.lblFuelLitSwe.AutoSize = true;
            this.lblFuelLitSwe.Location = new System.Drawing.Point(8, 90);
            this.lblFuelLitSwe.Margin = new System.Windows.Forms.Padding(5);
            this.lblFuelLitSwe.Name = "lblFuelLitSwe";
            this.lblFuelLitSwe.Size = new System.Drawing.Size(147, 13);
            this.lblFuelLitSwe.TabIndex = 4;
            this.lblFuelLitSwe.Text = "Fuel consumpion (lit/ Swe mil)";
            // 
            // lblFuelCost
            // 
            this.lblFuelCost.AutoSize = true;
            this.lblFuelCost.Location = new System.Drawing.Point(8, 113);
            this.lblFuelCost.Margin = new System.Windows.Forms.Padding(5);
            this.lblFuelCost.Name = "lblFuelCost";
            this.lblFuelCost.Size = new System.Drawing.Size(91, 13);
            this.lblFuelCost.TabIndex = 5;
            this.lblFuelCost.Text = "Cost per kilometer";
            // 
            // btnCalcFuel
            // 
            this.btnCalcFuel.Location = new System.Drawing.Point(102, 131);
            this.btnCalcFuel.Name = "btnCalcFuel";
            this.btnCalcFuel.Size = new System.Drawing.Size(75, 23);
            this.btnCalcFuel.TabIndex = 4;
            this.btnCalcFuel.Text = "Calculate";
            this.btnCalcFuel.UseVisualStyleBackColor = true;
            this.btnCalcFuel.Click += new System.EventHandler(this.btnCalcFuel_Click);
            // 
            // txtboxcurrentOdo
            // 
            this.txtboxcurrentOdo.Location = new System.Drawing.Point(187, 18);
            this.txtboxcurrentOdo.Name = "txtboxcurrentOdo";
            this.txtboxcurrentOdo.Size = new System.Drawing.Size(100, 20);
            this.txtboxcurrentOdo.TabIndex = 5;
            this.txtboxcurrentOdo.Text = "0";
            // 
            // txtboxPreOdo
            // 
            this.txtboxPreOdo.Location = new System.Drawing.Point(187, 41);
            this.txtboxPreOdo.Name = "txtboxPreOdo";
            this.txtboxPreOdo.Size = new System.Drawing.Size(100, 20);
            this.txtboxPreOdo.TabIndex = 6;
            this.txtboxPreOdo.Text = "0";
            // 
            // txtboxFuel
            // 
            this.txtboxFuel.Location = new System.Drawing.Point(187, 64);
            this.txtboxFuel.Name = "txtboxFuel";
            this.txtboxFuel.Size = new System.Drawing.Size(100, 20);
            this.txtboxFuel.TabIndex = 7;
            this.txtboxFuel.Text = "0";
            // 
            // txtboxLiterPrice
            // 
            this.txtboxLiterPrice.Location = new System.Drawing.Point(187, 87);
            this.txtboxLiterPrice.Name = "txtboxLiterPrice";
            this.txtboxLiterPrice.Size = new System.Drawing.Size(100, 20);
            this.txtboxLiterPrice.TabIndex = 8;
            this.txtboxLiterPrice.Text = "0";
            // 
            // lblFuelKmLitRes
            // 
            this.lblFuelKmLitRes.AutoSize = true;
            this.lblFuelKmLitRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelKmLitRes.Location = new System.Drawing.Point(238, 21);
            this.lblFuelKmLitRes.Margin = new System.Windows.Forms.Padding(5);
            this.lblFuelKmLitRes.MinimumSize = new System.Drawing.Size(50, 0);
            this.lblFuelKmLitRes.Name = "lblFuelKmLitRes";
            this.lblFuelKmLitRes.Size = new System.Drawing.Size(50, 15);
            this.lblFuelKmLitRes.TabIndex = 6;
            // 
            // lblFuelLitKmRes
            // 
            this.lblFuelLitKmRes.AutoSize = true;
            this.lblFuelLitKmRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelLitKmRes.Location = new System.Drawing.Point(238, 44);
            this.lblFuelLitKmRes.Margin = new System.Windows.Forms.Padding(5);
            this.lblFuelLitKmRes.MinimumSize = new System.Drawing.Size(50, 0);
            this.lblFuelLitKmRes.Name = "lblFuelLitKmRes";
            this.lblFuelLitKmRes.Size = new System.Drawing.Size(50, 15);
            this.lblFuelLitKmRes.TabIndex = 7;
            // 
            // lblFuelLitMetricRes
            // 
            this.lblFuelLitMetricRes.AutoSize = true;
            this.lblFuelLitMetricRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelLitMetricRes.Location = new System.Drawing.Point(238, 67);
            this.lblFuelLitMetricRes.Margin = new System.Windows.Forms.Padding(5);
            this.lblFuelLitMetricRes.MinimumSize = new System.Drawing.Size(50, 0);
            this.lblFuelLitMetricRes.Name = "lblFuelLitMetricRes";
            this.lblFuelLitMetricRes.Size = new System.Drawing.Size(50, 15);
            this.lblFuelLitMetricRes.TabIndex = 8;
            // 
            // lblFuelLitSweRes
            // 
            this.lblFuelLitSweRes.AutoSize = true;
            this.lblFuelLitSweRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelLitSweRes.Location = new System.Drawing.Point(238, 90);
            this.lblFuelLitSweRes.Margin = new System.Windows.Forms.Padding(5);
            this.lblFuelLitSweRes.MinimumSize = new System.Drawing.Size(50, 0);
            this.lblFuelLitSweRes.Name = "lblFuelLitSweRes";
            this.lblFuelLitSweRes.Size = new System.Drawing.Size(50, 15);
            this.lblFuelLitSweRes.TabIndex = 9;
            // 
            // lblFuelCostRes
            // 
            this.lblFuelCostRes.AutoSize = true;
            this.lblFuelCostRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelCostRes.Location = new System.Drawing.Point(238, 113);
            this.lblFuelCostRes.Margin = new System.Windows.Forms.Padding(5);
            this.lblFuelCostRes.MinimumSize = new System.Drawing.Size(50, 0);
            this.lblFuelCostRes.Name = "lblFuelCostRes";
            this.lblFuelCostRes.Size = new System.Drawing.Size(50, 15);
            this.lblFuelCostRes.TabIndex = 10;
            // 
            // lblBMIName
            // 
            this.lblBMIName.AutoSize = true;
            this.lblBMIName.Location = new System.Drawing.Point(8, 21);
            this.lblBMIName.Margin = new System.Windows.Forms.Padding(5);
            this.lblBMIName.Name = "lblBMIName";
            this.lblBMIName.Size = new System.Drawing.Size(58, 13);
            this.lblBMIName.TabIndex = 1;
            this.lblBMIName.Text = "Your name";
            // 
            // lblBMIHeight
            // 
            this.lblBMIHeight.AutoSize = true;
            this.lblBMIHeight.Location = new System.Drawing.Point(8, 44);
            this.lblBMIHeight.Margin = new System.Windows.Forms.Padding(5);
            this.lblBMIHeight.Name = "lblBMIHeight";
            this.lblBMIHeight.Size = new System.Drawing.Size(61, 13);
            this.lblBMIHeight.TabIndex = 2;
            this.lblBMIHeight.Text = "Height (cm)";
            // 
            // lblBMIWeight
            // 
            this.lblBMIWeight.AutoSize = true;
            this.lblBMIWeight.Location = new System.Drawing.Point(8, 67);
            this.lblBMIWeight.Margin = new System.Windows.Forms.Padding(5);
            this.lblBMIWeight.Name = "lblBMIWeight";
            this.lblBMIWeight.Size = new System.Drawing.Size(62, 13);
            this.lblBMIWeight.TabIndex = 3;
            this.lblBMIWeight.Text = "Weight (kg)";
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(119, 18);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(338, 20);
            this.txtboxName.TabIndex = 6;
            // 
            // txtboxHeight
            // 
            this.txtboxHeight.Location = new System.Drawing.Point(119, 41);
            this.txtboxHeight.Name = "txtboxHeight";
            this.txtboxHeight.Size = new System.Drawing.Size(73, 20);
            this.txtboxHeight.TabIndex = 7;
            // 
            // txtboxWeight
            // 
            this.txtboxWeight.Location = new System.Drawing.Point(119, 64);
            this.txtboxWeight.Name = "txtboxWeight";
            this.txtboxWeight.Size = new System.Drawing.Size(73, 20);
            this.txtboxWeight.TabIndex = 8;
            // 
            // rbMetric
            // 
            this.rbMetric.AutoSize = true;
            this.rbMetric.Checked = true;
            this.rbMetric.Location = new System.Drawing.Point(340, 44);
            this.rbMetric.Name = "rbMetric";
            this.rbMetric.Size = new System.Drawing.Size(117, 17);
            this.rbMetric.TabIndex = 9;
            this.rbMetric.TabStop = true;
            this.rbMetric.Text = "Metric Unit (kg, cm)";
            this.rbMetric.UseVisualStyleBackColor = true;
            // 
            // rbUS
            // 
            this.rbUS.AutoSize = true;
            this.rbUS.Location = new System.Drawing.Point(340, 67);
            this.rbUS.Name = "rbUS";
            this.rbUS.Size = new System.Drawing.Size(105, 17);
            this.rbUS.TabIndex = 10;
            this.rbUS.TabStop = true;
            this.rbUS.Text = "US Unit (lb, inch)";
            this.rbUS.UseVisualStyleBackColor = true;
            // 
            // btnBMI
            // 
            this.btnBMI.Location = new System.Drawing.Point(200, 131);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(75, 23);
            this.btnBMI.TabIndex = 11;
            this.btnBMI.Text = "Calculate";
            this.btnBMI.UseVisualStyleBackColor = true;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(13, 44);
            this.lblBMI.Margin = new System.Windows.Forms.Padding(5);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(51, 13);
            this.lblBMI.TabIndex = 2;
            this.lblBMI.Text = "Your BMI";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(13, 69);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(5);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(86, 13);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Weight Category";
            // 
            // lblBMIRes
            // 
            this.lblBMIRes.AutoSize = true;
            this.lblBMIRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBMIRes.Location = new System.Drawing.Point(396, 44);
            this.lblBMIRes.Margin = new System.Windows.Forms.Padding(5);
            this.lblBMIRes.MinimumSize = new System.Drawing.Size(50, 0);
            this.lblBMIRes.Name = "lblBMIRes";
            this.lblBMIRes.Size = new System.Drawing.Size(50, 15);
            this.lblBMIRes.TabIndex = 7;
            // 
            // lblCategoryRes
            // 
            this.lblCategoryRes.AutoSize = true;
            this.lblCategoryRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategoryRes.Location = new System.Drawing.Point(346, 65);
            this.lblCategoryRes.Margin = new System.Windows.Forms.Padding(5);
            this.lblCategoryRes.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblCategoryRes.Name = "lblCategoryRes";
            this.lblCategoryRes.Size = new System.Drawing.Size(100, 15);
            this.lblCategoryRes.TabIndex = 8;
            // 
            // lblBMInfo
            // 
            this.lblBMInfo.AutoSize = true;
            this.lblBMInfo.Location = new System.Drawing.Point(267, 113);
            this.lblBMInfo.Margin = new System.Windows.Forms.Padding(5);
            this.lblBMInfo.Name = "lblBMInfo";
            this.lblBMInfo.Size = new System.Drawing.Size(179, 13);
            this.lblBMInfo.TabIndex = 9;
            this.lblBMInfo.Text = "Normal BMI is between 19 and 24.9.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 359);
            this.Controls.Add(this.grpboxBMIResult);
            this.Controls.Add(this.grpboxBMI);
            this.Controls.Add(this.grpboxFuelResult);
            this.Controls.Add(this.grpboxFuel);
            this.Name = "MainForm";
            this.Text = "Assignment 3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpboxFuel.ResumeLayout(false);
            this.grpboxFuel.PerformLayout();
            this.grpboxFuelResult.ResumeLayout(false);
            this.grpboxFuelResult.PerformLayout();
            this.grpboxBMI.ResumeLayout(false);
            this.grpboxBMI.PerformLayout();
            this.grpboxBMIResult.ResumeLayout(false);
            this.grpboxBMIResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxFuel;
        private System.Windows.Forms.TextBox txtboxLiterPrice;
        private System.Windows.Forms.TextBox txtboxFuel;
        private System.Windows.Forms.TextBox txtboxPreOdo;
        private System.Windows.Forms.TextBox txtboxcurrentOdo;
        private System.Windows.Forms.Button btnCalcFuel;
        private System.Windows.Forms.Label lblLiterPrice;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblPreOdo;
        private System.Windows.Forms.Label lblcurrentOdo;
        private System.Windows.Forms.GroupBox grpboxFuelResult;
        private System.Windows.Forms.Label lblFuelKmLitRes;
        private System.Windows.Forms.Label lblFuelCost;
        private System.Windows.Forms.Label lblFuelLitSwe;
        private System.Windows.Forms.Label lblFuelLitMetric;
        private System.Windows.Forms.Label lblFuelLitKm;
        private System.Windows.Forms.Label lblFuelKmLit;
        private System.Windows.Forms.GroupBox grpboxBMI;
        private System.Windows.Forms.GroupBox grpboxBMIResult;
        private System.Windows.Forms.Label lblFuelCostRes;
        private System.Windows.Forms.Label lblFuelLitSweRes;
        private System.Windows.Forms.Label lblFuelLitMetricRes;
        private System.Windows.Forms.Label lblFuelLitKmRes;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label lblBMIWeight;
        private System.Windows.Forms.Label lblBMIHeight;
        private System.Windows.Forms.Label lblBMIName;
        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.RadioButton rbUS;
        private System.Windows.Forms.RadioButton rbMetric;
        private System.Windows.Forms.TextBox txtboxWeight;
        private System.Windows.Forms.TextBox txtboxHeight;
        private System.Windows.Forms.Label lblBMInfo;
        private System.Windows.Forms.Label lblCategoryRes;
        private System.Windows.Forms.Label lblBMIRes;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblBMI;
    }
}

