namespace PizzaShop
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
            this.rbnSmall = new System.Windows.Forms.RadioButton();
            this.rbnMedium = new System.Windows.Forms.RadioButton();
            this.rbnLarge = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbx1 = new System.Windows.Forms.CheckBox();
            this.cbx2 = new System.Windows.Forms.CheckBox();
            this.cbx3 = new System.Windows.Forms.CheckBox();
            this.cbx4 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnSmall);
            this.groupBox1.Controls.Add(this.rbnMedium);
            this.groupBox1.Controls.Add(this.rbnLarge);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza Type";
            // 
            // rbnSmall
            // 
            this.rbnSmall.AutoSize = true;
            this.rbnSmall.Location = new System.Drawing.Point(22, 131);
            this.rbnSmall.Name = "rbnSmall";
            this.rbnSmall.Size = new System.Drawing.Size(82, 29);
            this.rbnSmall.TabIndex = 2;
            this.rbnSmall.Text = "Small";
            this.rbnSmall.UseVisualStyleBackColor = true;
            this.rbnSmall.CheckedChanged += new System.EventHandler(this.rbnSmall_CheckedChanged);
            // 
            // rbnMedium
            // 
            this.rbnMedium.AutoSize = true;
            this.rbnMedium.Location = new System.Drawing.Point(22, 89);
            this.rbnMedium.Name = "rbnMedium";
            this.rbnMedium.Size = new System.Drawing.Size(103, 29);
            this.rbnMedium.TabIndex = 1;
            this.rbnMedium.Text = "Medium";
            this.rbnMedium.UseVisualStyleBackColor = true;
            this.rbnMedium.CheckedChanged += new System.EventHandler(this.rbnMedium_CheckedChanged);
            // 
            // rbnLarge
            // 
            this.rbnLarge.AutoSize = true;
            this.rbnLarge.Location = new System.Drawing.Point(22, 45);
            this.rbnLarge.Name = "rbnLarge";
            this.rbnLarge.Size = new System.Drawing.Size(83, 29);
            this.rbnLarge.TabIndex = 0;
            this.rbnLarge.Text = "Large";
            this.rbnLarge.UseVisualStyleBackColor = true;
            this.rbnLarge.CheckedChanged += new System.EventHandler(this.rbnLarge_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCost);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 87);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pizza Cost";
            // 
            // lblCost
            // 
            this.lblCost.Location = new System.Drawing.Point(50, 37);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(259, 28);
            this.lblCost.TabIndex = 0;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(430, 290);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(107, 47);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbx4);
            this.groupBox3.Controls.Add(this.cbx3);
            this.groupBox3.Controls.Add(this.cbx2);
            this.groupBox3.Controls.Add(this.cbx1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.Location = new System.Drawing.Point(239, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 184);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toppings";
            // 
            // cbx1
            // 
            this.cbx1.AutoSize = true;
            this.cbx1.Location = new System.Drawing.Point(19, 42);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(260, 29);
            this.cbx1.TabIndex = 0;
            this.cbx1.Text = "Pineapple and Cauliflower";
            this.cbx1.UseVisualStyleBackColor = true;
            this.cbx1.CheckedChanged += new System.EventHandler(this.cbx1_CheckedChanged);
            // 
            // cbx2
            // 
            this.cbx2.AutoSize = true;
            this.cbx2.Location = new System.Drawing.Point(19, 78);
            this.cbx2.Name = "cbx2";
            this.cbx2.Size = new System.Drawing.Size(220, 29);
            this.cbx2.TabIndex = 1;
            this.cbx2.Text = "Rhubarb and Custard";
            this.cbx2.UseVisualStyleBackColor = true;
            this.cbx2.CheckedChanged += new System.EventHandler(this.cbx2_CheckedChanged);
            // 
            // cbx3
            // 
            this.cbx3.AutoSize = true;
            this.cbx3.Location = new System.Drawing.Point(19, 114);
            this.cbx3.Name = "cbx3";
            this.cbx3.Size = new System.Drawing.Size(205, 29);
            this.cbx3.TabIndex = 2;
            this.cbx3.Text = "Pepperoni Vindaloo";
            this.cbx3.UseVisualStyleBackColor = true;
            this.cbx3.CheckedChanged += new System.EventHandler(this.cbx3_CheckedChanged);
            // 
            // cbx4
            // 
            this.cbx4.AutoSize = true;
            this.cbx4.Location = new System.Drawing.Point(19, 150);
            this.cbx4.Name = "cbx4";
            this.cbx4.Size = new System.Drawing.Size(123, 29);
            this.cbx4.TabIndex = 3;
            this.cbx4.Text = "Chocolate";
            this.cbx4.UseVisualStyleBackColor = true;
            this.cbx4.CheckedChanged += new System.EventHandler(this.cbx4_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(568, 366);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Shop Selection Screen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnMedium;
        private System.Windows.Forms.RadioButton rbnLarge;
        private System.Windows.Forms.RadioButton rbnSmall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbx4;
        private System.Windows.Forms.CheckBox cbx3;
        private System.Windows.Forms.CheckBox cbx2;
        private System.Windows.Forms.CheckBox cbx1;
    }
}

