namespace _1_InputValidationTests
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
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(76, 24);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(295, 22);
            this.textBox_Name.TabIndex = 0;
            this.textBox_Name.Leave += new System.EventHandler(this.TextBox_Name_Leave);
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(76, 69);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(295, 22);
            this.textBox_Phone.TabIndex = 0;
            this.textBox_Phone.Leave += new System.EventHandler(this.TextBox_Phone_Leave);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(76, 116);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(295, 22);
            this.textBox_Email.TabIndex = 0;
            this.textBox_Email.Leave += new System.EventHandler(this.TextBox_Email_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "E-mail";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(296, 164);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 213);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Save;
    }
}

