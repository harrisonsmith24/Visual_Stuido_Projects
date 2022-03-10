
namespace Smith_10._4
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
            this.empLbl1 = new System.Windows.Forms.Label();
            this.empLbl2 = new System.Windows.Forms.Label();
            this.empblL3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(777, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name        Department        Position           Id Number\r\n";
            // 
            // empLbl1
            // 
            this.empLbl1.AutoSize = true;
            this.empLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empLbl1.Location = new System.Drawing.Point(303, 308);
            this.empLbl1.Name = "empLbl1";
            this.empLbl1.Size = new System.Drawing.Size(0, 37);
            this.empLbl1.TabIndex = 1;
            // 
            // empLbl2
            // 
            this.empLbl2.AutoSize = true;
            this.empLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empLbl2.Location = new System.Drawing.Point(303, 395);
            this.empLbl2.Name = "empLbl2";
            this.empLbl2.Size = new System.Drawing.Size(0, 37);
            this.empLbl2.TabIndex = 3;
            // 
            // empblL3
            // 
            this.empblL3.AutoSize = true;
            this.empblL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empblL3.Location = new System.Drawing.Point(303, 473);
            this.empblL3.Name = "empblL3";
            this.empblL3.Size = new System.Drawing.Size(0, 37);
            this.empblL3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 1156);
            this.Controls.Add(this.empblL3);
            this.Controls.Add(this.empLbl2);
            this.Controls.Add(this.empLbl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label empLbl1;
        private System.Windows.Forms.Label empLbl2;
        private System.Windows.Forms.Label empblL3;
    }
}

