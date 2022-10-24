namespace BasicFormsApp
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
            this.btnstart = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbLocal2 = new System.Windows.Forms.Label();
            this.lbLocal1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnstart
            // 
            this.btnstart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstart.Location = new System.Drawing.Point(103, 228);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(91, 43);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "show variable";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb1.Location = new System.Drawing.Point(122, 202);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(45, 13);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "HolleC#";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(242, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Local variable";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbLocal2
            // 
            this.lbLocal2.AutoSize = true;
            this.lbLocal2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbLocal2.Location = new System.Drawing.Point(259, 190);
            this.lbLocal2.Name = "lbLocal2";
            this.lbLocal2.Size = new System.Drawing.Size(65, 13);
            this.lbLocal2.TabIndex = 3;
            this.lbLocal2.Text = "LabelLocal2";
            // 
            // lbLocal1
            // 
            this.lbLocal1.AutoSize = true;
            this.lbLocal1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbLocal1.Location = new System.Drawing.Point(256, 161);
            this.lbLocal1.Name = "lbLocal1";
            this.lbLocal1.Size = new System.Drawing.Size(65, 13);
            this.lbLocal1.TabIndex = 4;
            this.lbLocal1.Text = "LabelLocal1";
            this.lbLocal1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(359, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "พื้นฐานการทำงานของ String";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbLocal1);
            this.Controls.Add(this.lbLocal2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnstart);
            this.Name = "Form1";
            this.Text = "BasicForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbLocal2;
        private System.Windows.Forms.Label lbLocal1;
        private System.Windows.Forms.Button button2;
    }
}

