
namespace Smith_Exam2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.budgetTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.billsTxt = new System.Windows.Forms.TextBox();
            this.monthLbl = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.infoButton = new System.Windows.Forms.Button();
            this.billLBL1 = new System.Windows.Forms.Label();
            this.billLBL2 = new System.Windows.Forms.Label();
            this.billLBL3 = new System.Windows.Forms.Label();
            this.billLBL4 = new System.Windows.Forms.Label();
            this.billTxt1 = new System.Windows.Forms.TextBox();
            this.billTxt2 = new System.Windows.Forms.TextBox();
            this.billTxt3 = new System.Windows.Forms.TextBox();
            this.billTxt4 = new System.Windows.Forms.TextBox();
            this.errorLbl = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.calcBtn = new System.Windows.Forms.Button();
            this.totalLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Budget";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount per month";
            // 
            // budgetTxt
            // 
            this.budgetTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetTxt.Location = new System.Drawing.Point(495, 106);
            this.budgetTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.budgetTxt.Name = "budgetTxt";
            this.budgetTxt.Size = new System.Drawing.Size(113, 26);
            this.budgetTxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "How many bills do you have this month? (4 max)";
            // 
            // billsTxt
            // 
            this.billsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billsTxt.Location = new System.Drawing.Point(495, 164);
            this.billsTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.billsTxt.Name = "billsTxt";
            this.billsTxt.Size = new System.Drawing.Size(113, 26);
            this.billsTxt.TabIndex = 4;
            // 
            // monthLbl
            // 
            this.monthLbl.AutoSize = true;
            this.monthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLbl.Location = new System.Drawing.Point(55, 225);
            this.monthLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monthLbl.Name = "monthLbl";
            this.monthLbl.Size = new System.Drawing.Size(132, 20);
            this.monthLbl.TabIndex = 5;
            this.monthLbl.Text = "What month is it?";
            // 
            // monthComboBox
            // 
            this.monthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March ",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthComboBox.Location = new System.Drawing.Point(495, 223);
            this.monthComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(113, 28);
            this.monthComboBox.TabIndex = 6;
            // 
            // infoButton
            // 
            this.infoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoButton.Location = new System.Drawing.Point(246, 273);
            this.infoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(92, 38);
            this.infoButton.TabIndex = 7;
            this.infoButton.Text = "Submit";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // billLBL1
            // 
            this.billLBL1.AutoSize = true;
            this.billLBL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billLBL1.Location = new System.Drawing.Point(254, 336);
            this.billLBL1.Name = "billLBL1";
            this.billLBL1.Size = new System.Drawing.Size(42, 20);
            this.billLBL1.TabIndex = 8;
            this.billLBL1.Text = "Bill 1";
            this.billLBL1.Visible = false;
            // 
            // billLBL2
            // 
            this.billLBL2.AutoSize = true;
            this.billLBL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billLBL2.Location = new System.Drawing.Point(254, 373);
            this.billLBL2.Name = "billLBL2";
            this.billLBL2.Size = new System.Drawing.Size(42, 20);
            this.billLBL2.TabIndex = 9;
            this.billLBL2.Text = "Bill 2";
            this.billLBL2.Visible = false;
            // 
            // billLBL3
            // 
            this.billLBL3.AutoSize = true;
            this.billLBL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billLBL3.Location = new System.Drawing.Point(254, 413);
            this.billLBL3.Name = "billLBL3";
            this.billLBL3.Size = new System.Drawing.Size(42, 20);
            this.billLBL3.TabIndex = 10;
            this.billLBL3.Text = "Bill 3";
            this.billLBL3.Visible = false;
            // 
            // billLBL4
            // 
            this.billLBL4.AutoSize = true;
            this.billLBL4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billLBL4.Location = new System.Drawing.Point(254, 453);
            this.billLBL4.Name = "billLBL4";
            this.billLBL4.Size = new System.Drawing.Size(42, 20);
            this.billLBL4.TabIndex = 11;
            this.billLBL4.Text = "Bill 4";
            this.billLBL4.Visible = false;
            // 
            // billTxt1
            // 
            this.billTxt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billTxt1.Location = new System.Drawing.Point(395, 336);
            this.billTxt1.Name = "billTxt1";
            this.billTxt1.Size = new System.Drawing.Size(100, 22);
            this.billTxt1.TabIndex = 12;
            this.billTxt1.Text = "0";
            this.billTxt1.Visible = false;
            // 
            // billTxt2
            // 
            this.billTxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billTxt2.Location = new System.Drawing.Point(395, 373);
            this.billTxt2.Name = "billTxt2";
            this.billTxt2.Size = new System.Drawing.Size(100, 22);
            this.billTxt2.TabIndex = 13;
            this.billTxt2.Text = "0";
            this.billTxt2.Visible = false;
            // 
            // billTxt3
            // 
            this.billTxt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billTxt3.Location = new System.Drawing.Point(395, 413);
            this.billTxt3.Name = "billTxt3";
            this.billTxt3.Size = new System.Drawing.Size(100, 22);
            this.billTxt3.TabIndex = 14;
            this.billTxt3.Text = "0";
            this.billTxt3.Visible = false;
            // 
            // billTxt4
            // 
            this.billTxt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billTxt4.Location = new System.Drawing.Point(395, 453);
            this.billTxt4.Name = "billTxt4";
            this.billTxt4.Size = new System.Drawing.Size(100, 22);
            this.billTxt4.TabIndex = 15;
            this.billTxt4.Text = "0";
            this.billTxt4.Visible = false;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(35, 515);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(157, 13);
            this.errorLbl.TabIndex = 16;
            this.errorLbl.Text = "Value must be between 0 and 4";
            this.errorLbl.Visible = false;
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(367, 273);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(93, 38);
            this.resetBtn.TabIndex = 17;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(290, 493);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(97, 56);
            this.calcBtn.TabIndex = 18;
            this.calcBtn.Text = "Calculate Budget";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Visible = false;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(112, 622);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(0, 20);
            this.totalLbl.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 733);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.billTxt4);
            this.Controls.Add(this.billTxt3);
            this.Controls.Add(this.billTxt2);
            this.Controls.Add(this.billTxt1);
            this.Controls.Add(this.billLBL4);
            this.Controls.Add(this.billLBL3);
            this.Controls.Add(this.billLBL2);
            this.Controls.Add(this.billLBL1);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.monthLbl);
            this.Controls.Add(this.billsTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.budgetTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox budgetTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox billsTxt;
        private System.Windows.Forms.Label monthLbl;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Label billLBL1;
        private System.Windows.Forms.Label billLBL2;
        private System.Windows.Forms.Label billLBL3;
        private System.Windows.Forms.Label billLBL4;
        private System.Windows.Forms.TextBox billTxt1;
        private System.Windows.Forms.TextBox billTxt2;
        private System.Windows.Forms.TextBox billTxt3;
        private System.Windows.Forms.TextBox billTxt4;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label totalLbl;
    }
}

