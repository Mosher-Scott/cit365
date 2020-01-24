namespace CalorieConverter
{
    partial class Form1
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
            this.totalCaloriesLabel = new System.Windows.Forms.Label();
            this.carbsLabel = new System.Windows.Forms.Label();
            this.faLabel = new System.Windows.Forms.Label();
            this.proteinlabel = new System.Windows.Forms.Label();
            this.totalCaloriesInput = new System.Windows.Forms.TextBox();
            this.carbsInput = new System.Windows.Forms.TextBox();
            this.fatInput = new System.Windows.Forms.TextBox();
            this.proteinInput = new System.Windows.Forms.TextBox();
            this.enterValuesLabel = new System.Windows.Forms.Label();
            this.caloriesPerItemLabel = new System.Windows.Forms.Label();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.carbsCalorieResult = new System.Windows.Forms.Label();
            this.fatCaloriesResult = new System.Windows.Forms.Label();
            this.proteinCaloriesResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.proteinPercentDisplay = new System.Windows.Forms.Label();
            this.fatPercentDisplay = new System.Windows.Forms.Label();
            this.carbsPercent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalCaloriesLabel
            // 
            this.totalCaloriesLabel.AutoSize = true;
            this.totalCaloriesLabel.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCaloriesLabel.Location = new System.Drawing.Point(26, 48);
            this.totalCaloriesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalCaloriesLabel.Name = "totalCaloriesLabel";
            this.totalCaloriesLabel.Size = new System.Drawing.Size(128, 28);
            this.totalCaloriesLabel.TabIndex = 0;
            this.totalCaloriesLabel.Text = "Total Calories";
            this.totalCaloriesLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // carbsLabel
            // 
            this.carbsLabel.AutoSize = true;
            this.carbsLabel.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbsLabel.Location = new System.Drawing.Point(90, 82);
            this.carbsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carbsLabel.Name = "carbsLabel";
            this.carbsLabel.Size = new System.Drawing.Size(61, 28);
            this.carbsLabel.TabIndex = 1;
            this.carbsLabel.Text = "Carbs";
            this.carbsLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // faLabel
            // 
            this.faLabel.AutoSize = true;
            this.faLabel.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faLabel.Location = new System.Drawing.Point(113, 122);
            this.faLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.faLabel.Name = "faLabel";
            this.faLabel.Size = new System.Drawing.Size(38, 28);
            this.faLabel.TabIndex = 2;
            this.faLabel.Text = "Fat";
            // 
            // proteinlabel
            // 
            this.proteinlabel.AutoSize = true;
            this.proteinlabel.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinlabel.Location = new System.Drawing.Point(76, 153);
            this.proteinlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.proteinlabel.Name = "proteinlabel";
            this.proteinlabel.Size = new System.Drawing.Size(75, 28);
            this.proteinlabel.TabIndex = 3;
            this.proteinlabel.Text = "Protein";
            // 
            // totalCaloriesInput
            // 
            this.totalCaloriesInput.Location = new System.Drawing.Point(160, 55);
            this.totalCaloriesInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.totalCaloriesInput.Name = "totalCaloriesInput";
            this.totalCaloriesInput.Size = new System.Drawing.Size(51, 20);
            this.totalCaloriesInput.TabIndex = 4;
            this.totalCaloriesInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // carbsInput
            // 
            this.carbsInput.Location = new System.Drawing.Point(160, 90);
            this.carbsInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.carbsInput.Name = "carbsInput";
            this.carbsInput.Size = new System.Drawing.Size(51, 20);
            this.carbsInput.TabIndex = 5;
            // 
            // fatInput
            // 
            this.fatInput.Location = new System.Drawing.Point(160, 129);
            this.fatInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fatInput.Name = "fatInput";
            this.fatInput.Size = new System.Drawing.Size(51, 20);
            this.fatInput.TabIndex = 6;
            // 
            // proteinInput
            // 
            this.proteinInput.Location = new System.Drawing.Point(160, 161);
            this.proteinInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.proteinInput.Name = "proteinInput";
            this.proteinInput.Size = new System.Drawing.Size(51, 20);
            this.proteinInput.TabIndex = 7;
            // 
            // enterValuesLabel
            // 
            this.enterValuesLabel.AutoSize = true;
            this.enterValuesLabel.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.enterValuesLabel.Location = new System.Drawing.Point(141, 35);
            this.enterValuesLabel.Name = "enterValuesLabel";
            this.enterValuesLabel.Size = new System.Drawing.Size(70, 13);
            this.enterValuesLabel.TabIndex = 8;
            this.enterValuesLabel.Text = "Enter Values";
            this.enterValuesLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // caloriesPerItemLabel
            // 
            this.caloriesPerItemLabel.AutoSize = true;
            this.caloriesPerItemLabel.Font = new System.Drawing.Font("Nirmala UI", 15F);
            this.caloriesPerItemLabel.Location = new System.Drawing.Point(219, 47);
            this.caloriesPerItemLabel.Name = "caloriesPerItemLabel";
            this.caloriesPerItemLabel.Size = new System.Drawing.Size(81, 28);
            this.caloriesPerItemLabel.TabIndex = 9;
            this.caloriesPerItemLabel.Text = "Calories";
            this.caloriesPerItemLabel.Click += new System.EventHandler(this.caloriesPerItemLabel_Click);
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Font = new System.Drawing.Font("Nirmala UI", 15F);
            this.percentageLabel.Location = new System.Drawing.Point(306, 47);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(108, 28);
            this.percentageLabel.TabIndex = 10;
            this.percentageLabel.Text = "Percentage";
            // 
            // carbsCalorieResult
            // 
            this.carbsCalorieResult.AutoSize = true;
            this.carbsCalorieResult.Location = new System.Drawing.Point(240, 95);
            this.carbsCalorieResult.Name = "carbsCalorieResult";
            this.carbsCalorieResult.Size = new System.Drawing.Size(13, 14);
            this.carbsCalorieResult.TabIndex = 13;
            this.carbsCalorieResult.Text = "0";
            // 
            // fatCaloriesResult
            // 
            this.fatCaloriesResult.AutoSize = true;
            this.fatCaloriesResult.Location = new System.Drawing.Point(240, 134);
            this.fatCaloriesResult.Name = "fatCaloriesResult";
            this.fatCaloriesResult.Size = new System.Drawing.Size(13, 14);
            this.fatCaloriesResult.TabIndex = 14;
            this.fatCaloriesResult.Text = "0";
            // 
            // proteinCaloriesResult
            // 
            this.proteinCaloriesResult.AutoSize = true;
            this.proteinCaloriesResult.Location = new System.Drawing.Point(240, 166);
            this.proteinCaloriesResult.Name = "proteinCaloriesResult";
            this.proteinCaloriesResult.Size = new System.Drawing.Size(13, 14);
            this.proteinCaloriesResult.TabIndex = 15;
            this.proteinCaloriesResult.Text = "0";
            this.proteinCaloriesResult.Click += new System.EventHandler(this.proteinCaloriesResult_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // proteinPercentDisplay
            // 
            this.proteinPercentDisplay.AutoSize = true;
            this.proteinPercentDisplay.Location = new System.Drawing.Point(342, 166);
            this.proteinPercentDisplay.Name = "proteinPercentDisplay";
            this.proteinPercentDisplay.Size = new System.Drawing.Size(13, 14);
            this.proteinPercentDisplay.TabIndex = 19;
            this.proteinPercentDisplay.Text = "0";
            // 
            // fatPercentDisplay
            // 
            this.fatPercentDisplay.AutoSize = true;
            this.fatPercentDisplay.Location = new System.Drawing.Point(342, 134);
            this.fatPercentDisplay.Name = "fatPercentDisplay";
            this.fatPercentDisplay.Size = new System.Drawing.Size(13, 14);
            this.fatPercentDisplay.TabIndex = 18;
            this.fatPercentDisplay.Text = "0";
            // 
            // carbsPercent
            // 
            this.carbsPercent.AutoSize = true;
            this.carbsPercent.Location = new System.Drawing.Point(342, 95);
            this.carbsPercent.Name = "carbsPercent";
            this.carbsPercent.Size = new System.Drawing.Size(13, 14);
            this.carbsPercent.TabIndex = 17;
            this.carbsPercent.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(450, 225);
            this.Controls.Add(this.proteinPercentDisplay);
            this.Controls.Add(this.fatPercentDisplay);
            this.Controls.Add(this.carbsPercent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.proteinCaloriesResult);
            this.Controls.Add(this.fatCaloriesResult);
            this.Controls.Add(this.carbsCalorieResult);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.caloriesPerItemLabel);
            this.Controls.Add(this.enterValuesLabel);
            this.Controls.Add(this.proteinInput);
            this.Controls.Add(this.fatInput);
            this.Controls.Add(this.carbsInput);
            this.Controls.Add(this.totalCaloriesInput);
            this.Controls.Add(this.proteinlabel);
            this.Controls.Add(this.faLabel);
            this.Controls.Add(this.carbsLabel);
            this.Controls.Add(this.totalCaloriesLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Calorie Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalCaloriesLabel;
        private System.Windows.Forms.Label carbsLabel;
        private System.Windows.Forms.Label faLabel;
        private System.Windows.Forms.Label proteinlabel;
        private System.Windows.Forms.TextBox totalCaloriesInput;
        private System.Windows.Forms.TextBox carbsInput;
        private System.Windows.Forms.TextBox fatInput;
        private System.Windows.Forms.TextBox proteinInput;
        private System.Windows.Forms.Label enterValuesLabel;
        private System.Windows.Forms.Label caloriesPerItemLabel;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.Label carbsCalorieResult;
        private System.Windows.Forms.Label fatCaloriesResult;
        private System.Windows.Forms.Label proteinCaloriesResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label proteinPercentDisplay;
        private System.Windows.Forms.Label fatPercentDisplay;
        private System.Windows.Forms.Label carbsPercent;
    }
}

