namespace DbCRUD
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
            this.headerMainForm = new System.Windows.Forms.Panel();
            this.ShopMagazin = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.LinkLabel();
            this.SignUp = new System.Windows.Forms.LinkLabel();
            this.headerMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerMainForm
            // 
            this.headerMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.headerMainForm.Controls.Add(this.ShopMagazin);
            this.headerMainForm.Controls.Add(this.Register);
            this.headerMainForm.Controls.Add(this.SignUp);
            this.headerMainForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerMainForm.Location = new System.Drawing.Point(0, 0);
            this.headerMainForm.Name = "headerMainForm";
            this.headerMainForm.Size = new System.Drawing.Size(800, 70);
            this.headerMainForm.TabIndex = 0;
            this.headerMainForm.Tag = "";
            // 
            // ShopMagazin
            // 
            this.ShopMagazin.AutoSize = true;
            this.ShopMagazin.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShopMagazin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.ShopMagazin.Location = new System.Drawing.Point(271, 10);
            this.ShopMagazin.Name = "ShopMagazin";
            this.ShopMagazin.Size = new System.Drawing.Size(250, 50);
            this.ShopMagazin.TabIndex = 6;
            this.ShopMagazin.Text = "Online store";
            // 
            // Register
            // 
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Register.Location = new System.Drawing.Point(640, 37);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(148, 21);
            this.Register.TabIndex = 5;
            this.Register.TabStop = true;
            this.Register.Text = "Зарегестрироваться";
            this.Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Register_LinkClicked);
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignUp.Location = new System.Drawing.Point(640, 14);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(52, 16);
            this.SignUp.TabIndex = 4;
            this.SignUp.TabStop = true;
            this.SignUp.Text = "Войти";
            this.SignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUp_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(219)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.headerMainForm);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.headerMainForm.ResumeLayout(false);
            this.headerMainForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerMainForm;
        private System.Windows.Forms.LinkLabel Register;
        private System.Windows.Forms.LinkLabel SignUp;
        private System.Windows.Forms.Label ShopMagazin;
    }
}