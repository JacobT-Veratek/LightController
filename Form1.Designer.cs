namespace LightController
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
            this.green_1 = new System.Windows.Forms.CheckBox();
            this.green_2 = new System.Windows.Forms.CheckBox();
            this.red_1 = new System.Windows.Forms.CheckBox();
            this.red_2 = new System.Windows.Forms.CheckBox();
            this.yellow_1 = new System.Windows.Forms.CheckBox();
            this.yellow_2 = new System.Windows.Forms.CheckBox();
            this.blue_1 = new System.Windows.Forms.CheckBox();
            this.blue_2 = new System.Windows.Forms.CheckBox();
            this.On_All = new System.Windows.Forms.Button();
            this.Off_All = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // green_1
            // 
            this.green_1.AutoSize = true;
            this.green_1.Location = new System.Drawing.Point(12, 12);
            this.green_1.Name = "green_1";
            this.green_1.Size = new System.Drawing.Size(70, 17);
            this.green_1.TabIndex = 0;
            this.green_1.Text = "GREEN1";
            this.green_1.UseVisualStyleBackColor = true;
            this.green_1.CheckedChanged += new System.EventHandler(this.green_1_CheckedChanged);
            // 
            // green_2
            // 
            this.green_2.AutoSize = true;
            this.green_2.Location = new System.Drawing.Point(12, 35);
            this.green_2.Name = "green_2";
            this.green_2.Size = new System.Drawing.Size(70, 17);
            this.green_2.TabIndex = 1;
            this.green_2.Text = "GREEN2";
            this.green_2.UseVisualStyleBackColor = true;
            this.green_2.CheckedChanged += new System.EventHandler(this.green_2_CheckedChanged);
            // 
            // red_1
            // 
            this.red_1.AutoSize = true;
            this.red_1.Location = new System.Drawing.Point(12, 76);
            this.red_1.Name = "red_1";
            this.red_1.Size = new System.Drawing.Size(55, 17);
            this.red_1.TabIndex = 2;
            this.red_1.Text = "RED1";
            this.red_1.UseVisualStyleBackColor = true;
            this.red_1.CheckedChanged += new System.EventHandler(this.red_1_CheckedChanged);
            // 
            // red_2
            // 
            this.red_2.AutoSize = true;
            this.red_2.Location = new System.Drawing.Point(12, 99);
            this.red_2.Name = "red_2";
            this.red_2.Size = new System.Drawing.Size(55, 17);
            this.red_2.TabIndex = 3;
            this.red_2.Text = "RED2";
            this.red_2.UseVisualStyleBackColor = true;
            this.red_2.CheckedChanged += new System.EventHandler(this.red_2_CheckedChanged);
            // 
            // yellow_1
            // 
            this.yellow_1.AutoSize = true;
            this.yellow_1.Location = new System.Drawing.Point(12, 136);
            this.yellow_1.Name = "yellow_1";
            this.yellow_1.Size = new System.Drawing.Size(77, 17);
            this.yellow_1.TabIndex = 4;
            this.yellow_1.Text = "YELLOW1";
            this.yellow_1.UseVisualStyleBackColor = true;
            this.yellow_1.CheckedChanged += new System.EventHandler(this.yellow_1_CheckedChanged);
            // 
            // yellow_2
            // 
            this.yellow_2.AutoSize = true;
            this.yellow_2.Location = new System.Drawing.Point(12, 159);
            this.yellow_2.Name = "yellow_2";
            this.yellow_2.Size = new System.Drawing.Size(77, 17);
            this.yellow_2.TabIndex = 5;
            this.yellow_2.Text = "YELLOW2";
            this.yellow_2.UseVisualStyleBackColor = true;
            this.yellow_2.CheckedChanged += new System.EventHandler(this.yellow_2_CheckedChanged);
            // 
            // blue_1
            // 
            this.blue_1.AutoSize = true;
            this.blue_1.Location = new System.Drawing.Point(12, 196);
            this.blue_1.Name = "blue_1";
            this.blue_1.Size = new System.Drawing.Size(60, 17);
            this.blue_1.TabIndex = 6;
            this.blue_1.Text = "BLUE1";
            this.blue_1.UseVisualStyleBackColor = true;
            this.blue_1.CheckedChanged += new System.EventHandler(this.blue_1_CheckedChanged);
            // 
            // blue_2
            // 
            this.blue_2.AutoSize = true;
            this.blue_2.Location = new System.Drawing.Point(12, 219);
            this.blue_2.Name = "blue_2";
            this.blue_2.Size = new System.Drawing.Size(60, 17);
            this.blue_2.TabIndex = 7;
            this.blue_2.Text = "BLUE2";
            this.blue_2.UseVisualStyleBackColor = true;
            this.blue_2.CheckedChanged += new System.EventHandler(this.blue_2_CheckedChanged);
            // 
            // On_All
            // 
            this.On_All.Location = new System.Drawing.Point(713, 12);
            this.On_All.Name = "On_All";
            this.On_All.Size = new System.Drawing.Size(75, 23);
            this.On_All.TabIndex = 8;
            this.On_All.Text = "ON_ALL";
            this.On_All.UseVisualStyleBackColor = true;
            this.On_All.Click += new System.EventHandler(this.On_All_Click);
            // 
            // Off_All
            // 
            this.Off_All.Location = new System.Drawing.Point(713, 41);
            this.Off_All.Name = "Off_All";
            this.Off_All.Size = new System.Drawing.Size(75, 23);
            this.Off_All.TabIndex = 9;
            this.Off_All.Text = "OFF_ALL";
            this.Off_All.UseVisualStyleBackColor = true;
            this.Off_All.Click += new System.EventHandler(this.Off_All_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Off_All);
            this.Controls.Add(this.On_All);
            this.Controls.Add(this.blue_2);
            this.Controls.Add(this.blue_1);
            this.Controls.Add(this.yellow_2);
            this.Controls.Add(this.yellow_1);
            this.Controls.Add(this.red_2);
            this.Controls.Add(this.red_1);
            this.Controls.Add(this.green_2);
            this.Controls.Add(this.green_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox green_1;
        private System.Windows.Forms.CheckBox green_2;
        private System.Windows.Forms.CheckBox red_1;
        private System.Windows.Forms.CheckBox red_2;
        private System.Windows.Forms.CheckBox yellow_1;
        private System.Windows.Forms.CheckBox yellow_2;
        private System.Windows.Forms.CheckBox blue_1;
        private System.Windows.Forms.CheckBox blue_2;
        private System.Windows.Forms.Button On_All;
        private System.Windows.Forms.Button Off_All;
    }
}

