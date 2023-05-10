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
            this.blink_g_1 = new System.Windows.Forms.Button();
            this.g_1_interval = new System.Windows.Forms.TextBox();
            this.blink_r_1 = new System.Windows.Forms.Button();
            this.blink_r_2 = new System.Windows.Forms.Button();
            this.blink_g_2 = new System.Windows.Forms.Button();
            this.blink_y_1 = new System.Windows.Forms.Button();
            this.blink_y_2 = new System.Windows.Forms.Button();
            this.blink_b_1 = new System.Windows.Forms.Button();
            this.blink_b_2 = new System.Windows.Forms.Button();
            this.b_2_interval = new System.Windows.Forms.TextBox();
            this.b_1_interval = new System.Windows.Forms.TextBox();
            this.y_2_interval = new System.Windows.Forms.TextBox();
            this.y_1_interval = new System.Windows.Forms.TextBox();
            this.r_2_interval = new System.Windows.Forms.TextBox();
            this.r_1_interval = new System.Windows.Forms.TextBox();
            this.g_2_interval = new System.Windows.Forms.TextBox();
            this.blink_all = new System.Windows.Forms.Button();
            this.blink_all_interval = new System.Windows.Forms.TextBox();
            this.simultaneous_start = new System.Windows.Forms.Button();
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
            this.On_All.Location = new System.Drawing.Point(12, 272);
            this.On_All.Name = "On_All";
            this.On_All.Size = new System.Drawing.Size(75, 23);
            this.On_All.TabIndex = 8;
            this.On_All.Text = "ON_ALL";
            this.On_All.UseVisualStyleBackColor = true;
            this.On_All.Click += new System.EventHandler(this.On_All_Click);
            // 
            // Off_All
            // 
            this.Off_All.Location = new System.Drawing.Point(137, 272);
            this.Off_All.Name = "Off_All";
            this.Off_All.Size = new System.Drawing.Size(75, 23);
            this.Off_All.TabIndex = 9;
            this.Off_All.Text = "OFF_ALL";
            this.Off_All.UseVisualStyleBackColor = true;
            this.Off_All.Click += new System.EventHandler(this.Off_All_Click);
            // 
            // blink_g_1
            // 
            this.blink_g_1.Location = new System.Drawing.Point(88, 6);
            this.blink_g_1.Name = "blink_g_1";
            this.blink_g_1.Size = new System.Drawing.Size(75, 23);
            this.blink_g_1.TabIndex = 10;
            this.blink_g_1.Text = "BLINK_G1";
            this.blink_g_1.UseVisualStyleBackColor = true;
            this.blink_g_1.Click += new System.EventHandler(this.blink_g_1_Click);
            // 
            // g_1_interval
            // 
            this.g_1_interval.Location = new System.Drawing.Point(169, 6);
            this.g_1_interval.Name = "g_1_interval";
            this.g_1_interval.Size = new System.Drawing.Size(43, 20);
            this.g_1_interval.TabIndex = 11;
            // 
            // blink_r_1
            // 
            this.blink_r_1.Location = new System.Drawing.Point(88, 70);
            this.blink_r_1.Name = "blink_r_1";
            this.blink_r_1.Size = new System.Drawing.Size(75, 23);
            this.blink_r_1.TabIndex = 12;
            this.blink_r_1.Text = "BLINK_R1";
            this.blink_r_1.UseVisualStyleBackColor = true;
            this.blink_r_1.Click += new System.EventHandler(this.blink_r_1_Click);
            // 
            // blink_r_2
            // 
            this.blink_r_2.Location = new System.Drawing.Point(88, 95);
            this.blink_r_2.Name = "blink_r_2";
            this.blink_r_2.Size = new System.Drawing.Size(75, 23);
            this.blink_r_2.TabIndex = 13;
            this.blink_r_2.Text = "BLINK_R2";
            this.blink_r_2.UseVisualStyleBackColor = true;
            this.blink_r_2.Click += new System.EventHandler(this.blink_r_2_Click);
            // 
            // blink_g_2
            // 
            this.blink_g_2.Location = new System.Drawing.Point(88, 31);
            this.blink_g_2.Name = "blink_g_2";
            this.blink_g_2.Size = new System.Drawing.Size(75, 23);
            this.blink_g_2.TabIndex = 14;
            this.blink_g_2.Text = "BLINK_G2";
            this.blink_g_2.UseVisualStyleBackColor = true;
            this.blink_g_2.Click += new System.EventHandler(this.blink_g_2_Click);
            // 
            // blink_y_1
            // 
            this.blink_y_1.Location = new System.Drawing.Point(88, 130);
            this.blink_y_1.Name = "blink_y_1";
            this.blink_y_1.Size = new System.Drawing.Size(75, 23);
            this.blink_y_1.TabIndex = 15;
            this.blink_y_1.Text = "BLINK_Y1";
            this.blink_y_1.UseVisualStyleBackColor = true;
            this.blink_y_1.Click += new System.EventHandler(this.blink_y_1_Click);
            // 
            // blink_y_2
            // 
            this.blink_y_2.Location = new System.Drawing.Point(88, 155);
            this.blink_y_2.Name = "blink_y_2";
            this.blink_y_2.Size = new System.Drawing.Size(75, 23);
            this.blink_y_2.TabIndex = 16;
            this.blink_y_2.Text = "BLINK_Y2";
            this.blink_y_2.UseVisualStyleBackColor = true;
            this.blink_y_2.Click += new System.EventHandler(this.blink_y_2_Click);
            // 
            // blink_b_1
            // 
            this.blink_b_1.Location = new System.Drawing.Point(88, 190);
            this.blink_b_1.Name = "blink_b_1";
            this.blink_b_1.Size = new System.Drawing.Size(75, 23);
            this.blink_b_1.TabIndex = 17;
            this.blink_b_1.Text = "BLINK_B1";
            this.blink_b_1.UseVisualStyleBackColor = true;
            this.blink_b_1.Click += new System.EventHandler(this.blink_b_1_Click);
            // 
            // blink_b_2
            // 
            this.blink_b_2.Location = new System.Drawing.Point(88, 215);
            this.blink_b_2.Name = "blink_b_2";
            this.blink_b_2.Size = new System.Drawing.Size(75, 23);
            this.blink_b_2.TabIndex = 18;
            this.blink_b_2.Text = "BLINK_B2";
            this.blink_b_2.UseVisualStyleBackColor = true;
            this.blink_b_2.Click += new System.EventHandler(this.blink_b_2_Click);
            // 
            // b_2_interval
            // 
            this.b_2_interval.Location = new System.Drawing.Point(169, 215);
            this.b_2_interval.Name = "b_2_interval";
            this.b_2_interval.Size = new System.Drawing.Size(43, 20);
            this.b_2_interval.TabIndex = 19;
            // 
            // b_1_interval
            // 
            this.b_1_interval.Location = new System.Drawing.Point(169, 190);
            this.b_1_interval.Name = "b_1_interval";
            this.b_1_interval.Size = new System.Drawing.Size(43, 20);
            this.b_1_interval.TabIndex = 20;
            // 
            // y_2_interval
            // 
            this.y_2_interval.Location = new System.Drawing.Point(169, 155);
            this.y_2_interval.Name = "y_2_interval";
            this.y_2_interval.Size = new System.Drawing.Size(43, 20);
            this.y_2_interval.TabIndex = 21;
            // 
            // y_1_interval
            // 
            this.y_1_interval.Location = new System.Drawing.Point(169, 130);
            this.y_1_interval.Name = "y_1_interval";
            this.y_1_interval.Size = new System.Drawing.Size(43, 20);
            this.y_1_interval.TabIndex = 22;
            // 
            // r_2_interval
            // 
            this.r_2_interval.Location = new System.Drawing.Point(169, 95);
            this.r_2_interval.Name = "r_2_interval";
            this.r_2_interval.Size = new System.Drawing.Size(43, 20);
            this.r_2_interval.TabIndex = 23;
            // 
            // r_1_interval
            // 
            this.r_1_interval.Location = new System.Drawing.Point(169, 70);
            this.r_1_interval.Name = "r_1_interval";
            this.r_1_interval.Size = new System.Drawing.Size(43, 20);
            this.r_1_interval.TabIndex = 24;
            // 
            // g_2_interval
            // 
            this.g_2_interval.Location = new System.Drawing.Point(169, 31);
            this.g_2_interval.Name = "g_2_interval";
            this.g_2_interval.Size = new System.Drawing.Size(43, 20);
            this.g_2_interval.TabIndex = 25;
            // 
            // blink_all
            // 
            this.blink_all.Location = new System.Drawing.Point(74, 301);
            this.blink_all.Name = "blink_all";
            this.blink_all.Size = new System.Drawing.Size(75, 23);
            this.blink_all.TabIndex = 26;
            this.blink_all.Text = "BLINK_ALL";
            this.blink_all.UseVisualStyleBackColor = true;
            this.blink_all.Click += new System.EventHandler(this.blink_all_Click);
            // 
            // blink_all_interval
            // 
            this.blink_all_interval.Location = new System.Drawing.Point(74, 330);
            this.blink_all_interval.Name = "blink_all_interval";
            this.blink_all_interval.Size = new System.Drawing.Size(75, 20);
            this.blink_all_interval.TabIndex = 27;
            // 
            // simultaneous_start
            // 
            this.simultaneous_start.Location = new System.Drawing.Point(137, 243);
            this.simultaneous_start.Name = "simultaneous_start";
            this.simultaneous_start.Size = new System.Drawing.Size(77, 23);
            this.simultaneous_start.TabIndex = 28;
            this.simultaneous_start.Text = "START_ALL";
            this.simultaneous_start.UseVisualStyleBackColor = true;
            this.simultaneous_start.Click += new System.EventHandler(this.simultaneous_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 366);
            this.Controls.Add(this.simultaneous_start);
            this.Controls.Add(this.blink_all_interval);
            this.Controls.Add(this.blink_all);
            this.Controls.Add(this.g_2_interval);
            this.Controls.Add(this.r_1_interval);
            this.Controls.Add(this.r_2_interval);
            this.Controls.Add(this.y_1_interval);
            this.Controls.Add(this.y_2_interval);
            this.Controls.Add(this.b_1_interval);
            this.Controls.Add(this.b_2_interval);
            this.Controls.Add(this.blink_b_2);
            this.Controls.Add(this.blink_b_1);
            this.Controls.Add(this.blink_y_2);
            this.Controls.Add(this.blink_y_1);
            this.Controls.Add(this.blink_g_2);
            this.Controls.Add(this.blink_r_2);
            this.Controls.Add(this.blink_r_1);
            this.Controls.Add(this.g_1_interval);
            this.Controls.Add(this.blink_g_1);
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
        private System.Windows.Forms.Button blink_g_1;
        private System.Windows.Forms.TextBox g_1_interval;
        private System.Windows.Forms.Button blink_r_1;
        private System.Windows.Forms.Button blink_r_2;
        private System.Windows.Forms.Button blink_g_2;
        private System.Windows.Forms.Button blink_y_1;
        private System.Windows.Forms.Button blink_y_2;
        private System.Windows.Forms.Button blink_b_1;
        private System.Windows.Forms.Button blink_b_2;
        private System.Windows.Forms.TextBox b_2_interval;
        private System.Windows.Forms.TextBox b_1_interval;
        private System.Windows.Forms.TextBox y_2_interval;
        private System.Windows.Forms.TextBox y_1_interval;
        private System.Windows.Forms.TextBox r_2_interval;
        private System.Windows.Forms.TextBox r_1_interval;
        private System.Windows.Forms.TextBox g_2_interval;
        private System.Windows.Forms.Button blink_all;
        private System.Windows.Forms.TextBox blink_all_interval;
        private System.Windows.Forms.Button simultaneous_start;
    }
}

