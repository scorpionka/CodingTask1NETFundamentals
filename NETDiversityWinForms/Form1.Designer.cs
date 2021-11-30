
namespace NETDiversityWinForms
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
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.btnEnterUserNameAndEmail = new System.Windows.Forms.Button();
            this.lblHelloUserName = new System.Windows.Forms.Label();
            this.txtBoxUserEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(257, 107);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(176, 20);
            this.txtBoxUserName.TabIndex = 0;
            // 
            // btnEnterUserNameAndEmail
            // 
            this.btnEnterUserNameAndEmail.Location = new System.Drawing.Point(257, 159);
            this.btnEnterUserNameAndEmail.Name = "btnEnterUserNameAndEmail";
            this.btnEnterUserNameAndEmail.Size = new System.Drawing.Size(176, 23);
            this.btnEnterUserNameAndEmail.TabIndex = 1;
            this.btnEnterUserNameAndEmail.Text = "Enter user name and email";
            this.btnEnterUserNameAndEmail.UseVisualStyleBackColor = true;
            this.btnEnterUserNameAndEmail.Click += new System.EventHandler(this.BtnEnterUserName_Click);
            // 
            // lblHelloUserName
            // 
            this.lblHelloUserName.AutoSize = true;
            this.lblHelloUserName.Location = new System.Drawing.Point(254, 250);
            this.lblHelloUserName.Name = "lblHelloUserName";
            this.lblHelloUserName.Size = new System.Drawing.Size(52, 13);
            this.lblHelloUserName.TabIndex = 2;
            this.lblHelloUserName.Text = "Waiting...";
            // 
            // txtBoxUserEmail
            // 
            this.txtBoxUserEmail.Location = new System.Drawing.Point(257, 133);
            this.txtBoxUserEmail.Name = "txtBoxUserEmail";
            this.txtBoxUserEmail.Size = new System.Drawing.Size(176, 20);
            this.txtBoxUserEmail.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxUserEmail);
            this.Controls.Add(this.lblHelloUserName);
            this.Controls.Add(this.btnEnterUserNameAndEmail);
            this.Controls.Add(this.txtBoxUserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.Button btnEnterUserNameAndEmail;
        private System.Windows.Forms.Label lblHelloUserName;
        private System.Windows.Forms.TextBox txtBoxUserEmail;
    }
}

