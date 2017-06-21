namespace SPA
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
            this.tbx_login = new System.Windows.Forms.TextBox();
            this.tbx_haslo = new System.Windows.Forms.TextBox();
            this.but_login = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_login
            // 
            this.tbx_login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_login.Location = new System.Drawing.Point(307, 144);
            this.tbx_login.Name = "tbx_login";
            this.tbx_login.Size = new System.Drawing.Size(150, 26);
            this.tbx_login.TabIndex = 0;
            this.tbx_login.TextChanged += new System.EventHandler(this.tbx_login_TextChanged);
            // 
            // tbx_haslo
            // 
            this.tbx_haslo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_haslo.Location = new System.Drawing.Point(307, 233);
            this.tbx_haslo.Name = "tbx_haslo";
            this.tbx_haslo.PasswordChar = '●';
            this.tbx_haslo.Size = new System.Drawing.Size(150, 26);
            this.tbx_haslo.TabIndex = 1;
            // 
            // but_login
            // 
            this.but_login.BackColor = System.Drawing.Color.SteelBlue;
            this.but_login.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_login.Location = new System.Drawing.Point(328, 296);
            this.but_login.Name = "but_login";
            this.but_login.Size = new System.Drawing.Size(100, 30);
            this.but_login.TabIndex = 3;
            this.but_login.Text = "ZALOGUJ";
            this.but_login.UseVisualStyleBackColor = false;
            this.but_login.Click += new System.EventHandler(this.but_login_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(10, 246);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(0, 13);
            this.Info.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SPA.Properties.Resources.LOGOWANIE;
            this.ClientSize = new System.Drawing.Size(634, 381);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.but_login);
            this.Controls.Add(this.tbx_haslo);
            this.Controls.Add(this.tbx_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_login;
        private System.Windows.Forms.TextBox tbx_haslo;
        private System.Windows.Forms.Button but_login;
        private System.Windows.Forms.Label Info;
        static public string login;

    }
}

