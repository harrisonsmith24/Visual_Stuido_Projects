
namespace Smith_10._6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allenHall = new System.Windows.Forms.RadioButton();
            this.pikeHall = new System.Windows.Forms.RadioButton();
            this.farthingHall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uniSuites = new System.Windows.Forms.RadioButton();
            this.sevenMeals = new System.Windows.Forms.RadioButton();
            this.fourteenMeals = new System.Windows.Forms.RadioButton();
            this.unlimMeals = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Maroon;
            this.groupBox1.Controls.Add(this.uniSuites);
            this.groupBox1.Controls.Add(this.farthingHall);
            this.groupBox1.Controls.Add(this.pikeHall);
            this.groupBox1.Controls.Add(this.allenHall);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(64, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dormitory";
            // 
            // allenHall
            // 
            this.allenHall.AutoSize = true;
            this.allenHall.Location = new System.Drawing.Point(22, 42);
            this.allenHall.Name = "allenHall";
            this.allenHall.Size = new System.Drawing.Size(214, 22);
            this.allenHall.TabIndex = 0;
            this.allenHall.TabStop = true;
            this.allenHall.Text = "Allen Hall  ($,1500/sem)";
            this.allenHall.UseVisualStyleBackColor = true;
            // 
            // pikeHall
            // 
            this.pikeHall.AutoSize = true;
            this.pikeHall.Location = new System.Drawing.Point(22, 89);
            this.pikeHall.Name = "pikeHall";
            this.pikeHall.Size = new System.Drawing.Size(209, 22);
            this.pikeHall.TabIndex = 1;
            this.pikeHall.TabStop = true;
            this.pikeHall.Text = "Pike Hall  ($1,600/sem)";
            this.pikeHall.UseVisualStyleBackColor = true;
            // 
            // farthingHall
            // 
            this.farthingHall.AutoSize = true;
            this.farthingHall.Location = new System.Drawing.Point(22, 134);
            this.farthingHall.Name = "farthingHall";
            this.farthingHall.Size = new System.Drawing.Size(239, 22);
            this.farthingHall.TabIndex = 2;
            this.farthingHall.TabStop = true;
            this.farthingHall.Text = "Farthing Hall  ($1,800/sem)";
            this.farthingHall.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Maroon;
            this.groupBox2.Controls.Add(this.unlimMeals);
            this.groupBox2.Controls.Add(this.fourteenMeals);
            this.groupBox2.Controls.Add(this.sevenMeals);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(436, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meal Plan";
            // 
            // uniSuites
            // 
            this.uniSuites.AutoSize = true;
            this.uniSuites.Location = new System.Drawing.Point(22, 178);
            this.uniSuites.Name = "uniSuites";
            this.uniSuites.Size = new System.Drawing.Size(271, 22);
            this.uniSuites.TabIndex = 3;
            this.uniSuites.TabStop = true;
            this.uniSuites.Text = "University Suites  ($2,500/sem)";
            this.uniSuites.UseVisualStyleBackColor = true;
            // 
            // sevenMeals
            // 
            this.sevenMeals.AutoSize = true;
            this.sevenMeals.Location = new System.Drawing.Point(27, 42);
            this.sevenMeals.Name = "sevenMeals";
            this.sevenMeals.Size = new System.Drawing.Size(234, 22);
            this.sevenMeals.TabIndex = 3;
            this.sevenMeals.TabStop = true;
            this.sevenMeals.Text = "7 meals/week  ($600/sem)";
            this.sevenMeals.UseVisualStyleBackColor = true;
            // 
            // fourteenMeals
            // 
            this.fourteenMeals.AutoSize = true;
            this.fourteenMeals.Location = new System.Drawing.Point(27, 89);
            this.fourteenMeals.Name = "fourteenMeals";
            this.fourteenMeals.Size = new System.Drawing.Size(259, 22);
            this.fourteenMeals.TabIndex = 4;
            this.fourteenMeals.TabStop = true;
            this.fourteenMeals.Text = "14 meals/week  ($1,200/sem)";
            this.fourteenMeals.UseVisualStyleBackColor = true;
            // 
            // unlimMeals
            // 
            this.unlimMeals.AutoSize = true;
            this.unlimMeals.Location = new System.Drawing.Point(27, 134);
            this.unlimMeals.Name = "unlimMeals";
            this.unlimMeals.Size = new System.Drawing.Size(268, 22);
            this.unlimMeals.TabIndex = 5;
            this.unlimMeals.TabStop = true;
            this.unlimMeals.Text = "Unlimited Meals ($1,700/week)";
            this.unlimMeals.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(261, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Display Total";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(421, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 55);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton uniSuites;
        private System.Windows.Forms.RadioButton farthingHall;
        private System.Windows.Forms.RadioButton pikeHall;
        private System.Windows.Forms.RadioButton allenHall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton unlimMeals;
        private System.Windows.Forms.RadioButton fourteenMeals;
        private System.Windows.Forms.RadioButton sevenMeals;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

