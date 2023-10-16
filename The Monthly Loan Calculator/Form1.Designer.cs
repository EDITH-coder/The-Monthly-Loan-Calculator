namespace The_Monthly_Loan_Calculator
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
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblDownPaymentAmount = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblAmountToFinance = new System.Windows.Forms.Label();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtDownPaymentAmount = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtTerms = new System.Windows.Forms.TextBox();
            this.txtAmountToFinance = new System.Windows.Forms.TextBox();
            this.txtMontlyPayment = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(35, 34);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(82, 13);
            this.lblPurchasePrice.TabIndex = 0;
            this.lblPurchasePrice.Text = "Purchase Price:";
            // 
            // lblDownPaymentAmount
            // 
            this.lblDownPaymentAmount.AutoSize = true;
            this.lblDownPaymentAmount.Location = new System.Drawing.Point(35, 73);
            this.lblDownPaymentAmount.Name = "lblDownPaymentAmount";
            this.lblDownPaymentAmount.Size = new System.Drawing.Size(121, 13);
            this.lblDownPaymentAmount.TabIndex = 0;
            this.lblDownPaymentAmount.Text = "Down Payment Amount:";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(35, 113);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(109, 13);
            this.lblInterestRate.TabIndex = 0;
            this.lblInterestRate.Text = "Interest Rate(annual):";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(35, 157);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(102, 13);
            this.lblTerm.TabIndex = 0;
            this.lblTerm.Text = "Loan Term(Months):";
            // 
            // lblAmountToFinance
            // 
            this.lblAmountToFinance.AutoSize = true;
            this.lblAmountToFinance.Location = new System.Drawing.Point(488, 34);
            this.lblAmountToFinance.Name = "lblAmountToFinance";
            this.lblAmountToFinance.Size = new System.Drawing.Size(99, 13);
            this.lblAmountToFinance.TabIndex = 0;
            this.lblAmountToFinance.Text = "Amount to Finance:";
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(488, 86);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(91, 13);
            this.lblMonthlyPayment.TabIndex = 0;
            this.lblMonthlyPayment.Text = "Monthly Payment:";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(199, 27);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(100, 20);
            this.txtPurchasePrice.TabIndex = 1;
            // 
            // txtDownPaymentAmount
            // 
            this.txtDownPaymentAmount.Location = new System.Drawing.Point(199, 73);
            this.txtDownPaymentAmount.Name = "txtDownPaymentAmount";
            this.txtDownPaymentAmount.Size = new System.Drawing.Size(100, 20);
            this.txtDownPaymentAmount.TabIndex = 1;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(199, 110);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 20);
            this.txtInterestRate.TabIndex = 1;
            // 
            // txtTerms
            // 
            this.txtTerms.Location = new System.Drawing.Point(199, 157);
            this.txtTerms.Name = "txtTerms";
            this.txtTerms.Size = new System.Drawing.Size(100, 20);
            this.txtTerms.TabIndex = 1;
            // 
            // txtAmountToFinance
            // 
            this.txtAmountToFinance.Location = new System.Drawing.Point(667, 27);
            this.txtAmountToFinance.Name = "txtAmountToFinance";
            this.txtAmountToFinance.Size = new System.Drawing.Size(100, 20);
            this.txtAmountToFinance.TabIndex = 1;
            // 
            // txtMontlyPayment
            // 
            this.txtMontlyPayment.Location = new System.Drawing.Point(667, 86);
            this.txtMontlyPayment.Name = "txtMontlyPayment";
            this.txtMontlyPayment.Size = new System.Drawing.Size(100, 20);
            this.txtMontlyPayment.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(44, 398);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(581, 393);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtMontlyPayment);
            this.Controls.Add(this.txtAmountToFinance);
            this.Controls.Add(this.txtTerms);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtDownPaymentAmount);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.lblMonthlyPayment);
            this.Controls.Add(this.lblAmountToFinance);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.lblDownPaymentAmount);
            this.Controls.Add(this.lblPurchasePrice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblDownPaymentAmount;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblAmountToFinance;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtDownPaymentAmount;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtTerms;
        private System.Windows.Forms.TextBox txtAmountToFinance;
        private System.Windows.Forms.TextBox txtMontlyPayment;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
    }
}

