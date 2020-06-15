namespace Lab4
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
            System.Windows.Forms.Button ex1;
            this.ex2 = new System.Windows.Forms.Button();
            this.ex3 = new System.Windows.Forms.Button();
            this.ex4 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ex1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ex1
            // 
            ex1.BackColor = System.Drawing.Color.DarkTurquoise;
            ex1.Location = new System.Drawing.Point(400, 150);
            ex1.Name = "ex1";
            ex1.Size = new System.Drawing.Size(173, 80);
            ex1.TabIndex = 0;
            ex1.Text = "Завдання  №1";
            ex1.UseVisualStyleBackColor = false;
            ex1.Click += new System.EventHandler(this.ex1_Click);
            // 
            // ex2
            // 
            this.ex2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ex2.Location = new System.Drawing.Point(401, 264);
            this.ex2.Name = "ex2";
            this.ex2.Size = new System.Drawing.Size(172, 80);
            this.ex2.TabIndex = 1;
            this.ex2.Text = "Завдання  №2";
            this.ex2.UseVisualStyleBackColor = false;
            this.ex2.Click += new System.EventHandler(this.ex2_Click);
            // 
            // ex3
            // 
            this.ex3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ex3.Location = new System.Drawing.Point(402, 381);
            this.ex3.Name = "ex3";
            this.ex3.Size = new System.Drawing.Size(171, 80);
            this.ex3.TabIndex = 2;
            this.ex3.Text = "Завдання  №3";
            this.ex3.UseVisualStyleBackColor = false;
            this.ex3.Click += new System.EventHandler(this.ex3_Click);
            // 
            // ex4
            // 
            this.ex4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ex4.Location = new System.Drawing.Point(403, 499);
            this.ex4.Name = "ex4";
            this.ex4.Size = new System.Drawing.Size(170, 80);
            this.ex4.TabIndex = 3;
            this.ex4.Text = "Завдання  №4";
            this.ex4.UseVisualStyleBackColor = false;
            this.ex4.Click += new System.EventHandler(this.ex4_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Snow;
            this.exit.Location = new System.Drawing.Point(428, 612);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(117, 42);
            this.exit.TabIndex = 4;
            this.exit.Text = "Вихід";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(310, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Лабораторна  робота  №4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(987, 689);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.ex4);
            this.Controls.Add(this.ex3);
            this.Controls.Add(this.ex2);
            this.Controls.Add(ex1);
            this.Name = "MainForm";
            this.Text = "Лабораторна №4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ex2;
        private System.Windows.Forms.Button ex3;
        private System.Windows.Forms.Button ex4;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
    }
}

