
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
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnEnterUserName = new System.Windows.Forms.Button();
            this.lblHelloUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(257, 107);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(176, 20);
            this.txtBox.TabIndex = 0;
            // 
            // btnEnterUserName
            // 
            this.btnEnterUserName.Location = new System.Drawing.Point(458, 104);
            this.btnEnterUserName.Name = "btnEnterUserName";
            this.btnEnterUserName.Size = new System.Drawing.Size(126, 23);
            this.btnEnterUserName.TabIndex = 1;
            this.btnEnterUserName.Text = "Enter user name";
            this.btnEnterUserName.UseVisualStyleBackColor = true;
            this.btnEnterUserName.Click += new System.EventHandler(this.btnEnterUserName_Click);
            // 
            // lblHelloUserName
            // 
            this.lblHelloUserName.AutoSize = true;
            this.lblHelloUserName.Location = new System.Drawing.Point(354, 213);
            this.lblHelloUserName.Name = "lblHelloUserName";
            this.lblHelloUserName.Size = new System.Drawing.Size(0, 13);
            this.lblHelloUserName.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHelloUserName);
            this.Controls.Add(this.btnEnterUserName);
            this.Controls.Add(this.txtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnEnterUserName;
        private System.Windows.Forms.Label lblHelloUserName;
    }
}

