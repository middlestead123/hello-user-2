namespace hello_user_2
{
    partial class frmhelloUserProgram2
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
            this.btnHelloUserProgram2 = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHelloUserProgram2
            // 
            this.btnHelloUserProgram2.Location = new System.Drawing.Point(61, 29);
            this.btnHelloUserProgram2.Name = "btnHelloUserProgram2";
            this.btnHelloUserProgram2.Size = new System.Drawing.Size(131, 23);
            this.btnHelloUserProgram2.TabIndex = 0;
            this.btnHelloUserProgram2.Text = "Hello User Program";
            this.btnHelloUserProgram2.UseVisualStyleBackColor = true;
            this.btnHelloUserProgram2.Click += new System.EventHandler(this.btnHelloUser_Click);
            // 
            // lblresult
            // 
            this.lblresult.Location = new System.Drawing.Point(1, 90);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(280, 54);
            this.lblresult.TabIndex = 1;
            // 
            // frmhelloUserProgram2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnHelloUserProgram2);
            this.Name = "frmhelloUserProgram2";
            this.Text = "Hello User program 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHelloUserProgram2;
        private System.Windows.Forms.Label lblresult;
    }
}

