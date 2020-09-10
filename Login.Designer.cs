namespace SelvrappoteringsApp
{
    partial class Login
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
            this.BrugernavnTB = new System.Windows.Forms.TextBox();
            this.LoginB = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AnnullerB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BrugernavnTB
            // 
            this.BrugernavnTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrugernavnTB.Location = new System.Drawing.Point(493, 171);
            this.BrugernavnTB.Name = "BrugernavnTB";
            this.BrugernavnTB.Size = new System.Drawing.Size(234, 30);
            this.BrugernavnTB.TabIndex = 0;
            this.BrugernavnTB.Text = "Admin";
            // 
            // LoginB
            // 
            this.LoginB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginB.Location = new System.Drawing.Point(496, 322);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(123, 62);
            this.LoginB.TabIndex = 1;
            this.LoginB.Text = "Login";
            this.LoginB.UseVisualStyleBackColor = true;
            this.LoginB.Click += new System.EventHandler(this.LoginB_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.Location = new System.Drawing.Point(493, 244);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(234, 30);
            this.PasswordTB.TabIndex = 2;
            this.PasswordTB.Text = "VCRVCR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Brugernavn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // AnnullerB
            // 
            this.AnnullerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnullerB.Location = new System.Drawing.Point(496, 390);
            this.AnnullerB.Name = "AnnullerB";
            this.AnnullerB.Size = new System.Drawing.Size(123, 65);
            this.AnnullerB.TabIndex = 5;
            this.AnnullerB.Text = "Annuller";
            this.AnnullerB.UseVisualStyleBackColor = true;
            this.AnnullerB.Click += new System.EventHandler(this.AnnullerB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(426, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fejl i Brugernavn eller Password";
            this.label3.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 711);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AnnullerB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.LoginB);
            this.Controls.Add(this.BrugernavnTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BrugernavnTB;
        private System.Windows.Forms.Button LoginB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AnnullerB;
        private System.Windows.Forms.Label label3;
    }
}