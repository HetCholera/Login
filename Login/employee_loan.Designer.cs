namespace Login
{
    partial class employee_loan
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button22);
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.button21);
            this.panel2.Controls.Add(this.button20);
            this.panel2.Location = new System.Drawing.Point(12, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 65);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Coral;
            this.button22.Location = new System.Drawing.Point(380, 20);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(132, 23);
            this.button22.TabIndex = 188;
            this.button22.Text = "View Installment";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Coral;
            this.button19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button19.Location = new System.Drawing.Point(12, 20);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(118, 23);
            this.button19.TabIndex = 187;
            this.button19.Text = "Add New Applicant";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Coral;
            this.button21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button21.Location = new System.Drawing.Point(135, 20);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(101, 23);
            this.button21.TabIndex = 185;
            this.button21.Text = "Add New Loan";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Coral;
            this.button20.Location = new System.Drawing.Point(242, 20);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(132, 23);
            this.button20.TabIndex = 186;
            this.button20.Text = "Loan Scheme";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // employee_loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employee_loan";
            this.Text = "employee_loan";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button1;
    }
}