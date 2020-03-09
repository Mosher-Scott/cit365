namespace MegaDesk_Mosher
{
    partial class AddQuote
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
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CustomerNameInputBox = new System.Windows.Forms.TextBox();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.GenerateQuoteButton = new System.Windows.Forms.Button();
            this.SurfaceMaterialInputBox = new System.Windows.Forms.TextBox();
            this.SurfaceMaterialLabel = new System.Windows.Forms.Label();
            this.NumberOfDrawersInputBox = new System.Windows.Forms.TextBox();
            this.NumberofDrawersLabel = new System.Windows.Forms.Label();
            this.DeskDepthtInputBox = new System.Windows.Forms.TextBox();
            this.DeskDepthtInputLabel = new System.Windows.Forms.Label();
            this.DeskWidthInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RushOrderInputBox = new System.Windows.Forms.TextBox();
            this.RushOrderLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(144, 259);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(111, 38);
            this.CloseFormButton.TabIndex = 7;
            this.CloseFormButton.Text = "&Return To Main";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            this.CloseFormButton.Click += new System.EventHandler(this.AddNewQuoteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RushOrderInputBox);
            this.groupBox1.Controls.Add(this.RushOrderLabel);
            this.groupBox1.Controls.Add(this.SurfaceMaterialInputBox);
            this.groupBox1.Controls.Add(this.SurfaceMaterialLabel);
            this.groupBox1.Controls.Add(this.NumberOfDrawersInputBox);
            this.groupBox1.Controls.Add(this.NumberofDrawersLabel);
            this.groupBox1.Controls.Add(this.DeskDepthtInputBox);
            this.groupBox1.Controls.Add(this.DeskDepthtInputLabel);
            this.groupBox1.Controls.Add(this.DeskWidthInputBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CustomerNameInputBox);
            this.groupBox1.Controls.Add(this.CustomerNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 209);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            // 
            // CustomerNameInputBox
            // 
            this.CustomerNameInputBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameInputBox.Location = new System.Drawing.Point(132, 28);
            this.CustomerNameInputBox.Name = "CustomerNameInputBox";
            this.CustomerNameInputBox.Size = new System.Drawing.Size(100, 23);
            this.CustomerNameInputBox.TabIndex = 0;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(31, 33);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(94, 15);
            this.CustomerNameLabel.TabIndex = 4;
            this.CustomerNameLabel.Text = "Customer Name";
            // 
            // GenerateQuoteButton
            // 
            this.GenerateQuoteButton.Location = new System.Drawing.Point(12, 259);
            this.GenerateQuoteButton.Name = "GenerateQuoteButton";
            this.GenerateQuoteButton.Size = new System.Drawing.Size(111, 38);
            this.GenerateQuoteButton.TabIndex = 6;
            this.GenerateQuoteButton.Text = "&Generate Quote";
            this.GenerateQuoteButton.UseVisualStyleBackColor = true;
            this.GenerateQuoteButton.Click += new System.EventHandler(this.GenerateQuote);
            // 
            // SurfaceMaterialInputBox
            // 
            this.SurfaceMaterialInputBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceMaterialInputBox.Location = new System.Drawing.Point(132, 141);
            this.SurfaceMaterialInputBox.Name = "SurfaceMaterialInputBox";
            this.SurfaceMaterialInputBox.Size = new System.Drawing.Size(100, 23);
            this.SurfaceMaterialInputBox.TabIndex = 4;
            this.SurfaceMaterialInputBox.MouseHover += new System.EventHandler(this.SurfaceMaterialInputBox_MouseHover);
            this.SurfaceMaterialInputBox.Validating += new System.ComponentModel.CancelEventHandler(this.validateSurfaceMaterialInput);
            // 
            // SurfaceMaterialLabel
            // 
            this.SurfaceMaterialLabel.AutoSize = true;
            this.SurfaceMaterialLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceMaterialLabel.Location = new System.Drawing.Point(33, 144);
            this.SurfaceMaterialLabel.Name = "SurfaceMaterialLabel";
            this.SurfaceMaterialLabel.Size = new System.Drawing.Size(92, 15);
            this.SurfaceMaterialLabel.TabIndex = 26;
            this.SurfaceMaterialLabel.Text = "Surface Material";
            // 
            // NumberOfDrawersInputBox
            // 
            this.NumberOfDrawersInputBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfDrawersInputBox.Location = new System.Drawing.Point(132, 113);
            this.NumberOfDrawersInputBox.Name = "NumberOfDrawersInputBox";
            this.NumberOfDrawersInputBox.Size = new System.Drawing.Size(100, 23);
            this.NumberOfDrawersInputBox.TabIndex = 3;
            this.NumberOfDrawersInputBox.MouseHover += new System.EventHandler(this.NumberOfDrawersInputBox_MouseHover);
            this.NumberOfDrawersInputBox.Validating += new System.ComponentModel.CancelEventHandler(this.validateNumDrawersInput);
            // 
            // NumberofDrawersLabel
            // 
            this.NumberofDrawersLabel.AutoSize = true;
            this.NumberofDrawersLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberofDrawersLabel.Location = new System.Drawing.Point(14, 116);
            this.NumberofDrawersLabel.Name = "NumberofDrawersLabel";
            this.NumberofDrawersLabel.Size = new System.Drawing.Size(112, 15);
            this.NumberofDrawersLabel.TabIndex = 25;
            this.NumberofDrawersLabel.Text = "Number Of Drawers";
            // 
            // DeskDepthtInputBox
            // 
            this.DeskDepthtInputBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepthtInputBox.Location = new System.Drawing.Point(132, 85);
            this.DeskDepthtInputBox.Name = "DeskDepthtInputBox";
            this.DeskDepthtInputBox.Size = new System.Drawing.Size(100, 23);
            this.DeskDepthtInputBox.TabIndex = 2;
            this.DeskDepthtInputBox.MouseHover += new System.EventHandler(this.DesktopHeightInputBox_PopupMessage);
            this.DeskDepthtInputBox.Validating += new System.ComponentModel.CancelEventHandler(this.validateDeskDepthInput);
            // 
            // DeskDepthtInputLabel
            // 
            this.DeskDepthtInputLabel.AutoSize = true;
            this.DeskDepthtInputLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepthtInputLabel.Location = new System.Drawing.Point(55, 88);
            this.DeskDepthtInputLabel.Name = "DeskDepthtInputLabel";
            this.DeskDepthtInputLabel.Size = new System.Drawing.Size(67, 15);
            this.DeskDepthtInputLabel.TabIndex = 24;
            this.DeskDepthtInputLabel.Text = "Desk Depth";
            this.DeskDepthtInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DeskWidthInputBox
            // 
            this.DeskWidthInputBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidthInputBox.Location = new System.Drawing.Point(132, 57);
            this.DeskWidthInputBox.Name = "DeskWidthInputBox";
            this.DeskWidthInputBox.Size = new System.Drawing.Size(100, 23);
            this.DeskWidthInputBox.TabIndex = 1;
            this.DeskWidthInputBox.MouseHover += new System.EventHandler(this.textBox1_PopupMessage);
            this.DeskWidthInputBox.Validating += new System.ComponentModel.CancelEventHandler(this.validateDeskWidthInput);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Desk Width";
            // 
            // RushOrderInputBox
            // 
            this.RushOrderInputBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderInputBox.Location = new System.Drawing.Point(132, 172);
            this.RushOrderInputBox.Name = "RushOrderInputBox";
            this.RushOrderInputBox.Size = new System.Drawing.Size(100, 23);
            this.RushOrderInputBox.TabIndex = 5;
            this.RushOrderInputBox.MouseHover += new System.EventHandler(this.RushOrderInputBox_MouseHover);
            this.RushOrderInputBox.Validating += new System.ComponentModel.CancelEventHandler(this.validateRushoptionInput);
            // 
            // RushOrderLabel
            // 
            this.RushOrderLabel.AutoSize = true;
            this.RushOrderLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderLabel.Location = new System.Drawing.Point(15, 177);
            this.RushOrderLabel.Name = "RushOrderLabel";
            this.RushOrderLabel.Size = new System.Drawing.Size(111, 15);
            this.RushOrderLabel.TabIndex = 28;
            this.RushOrderLabel.Text = "Rush Order Options";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(280, 310);
            this.Controls.Add(this.GenerateQuoteButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CloseFormButton);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CustomerNameInputBox;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Button GenerateQuoteButton;
        private System.Windows.Forms.TextBox RushOrderInputBox;
        private System.Windows.Forms.Label RushOrderLabel;
        private System.Windows.Forms.TextBox SurfaceMaterialInputBox;
        private System.Windows.Forms.Label SurfaceMaterialLabel;
        private System.Windows.Forms.TextBox NumberOfDrawersInputBox;
        private System.Windows.Forms.Label NumberofDrawersLabel;
        private System.Windows.Forms.TextBox DeskDepthtInputBox;
        private System.Windows.Forms.Label DeskDepthtInputLabel;
        private System.Windows.Forms.TextBox DeskWidthInputBox;
        private System.Windows.Forms.Label label1;
    }
}