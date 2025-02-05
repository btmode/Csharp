namespace DbCRUD
{
    partial class SignUpForm
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
            this.TextNameOrEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.TextPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.ButtonHome = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TextNameOrEmail
            // 
            this.TextNameOrEmail.AnimateReadOnly = false;
            this.TextNameOrEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextNameOrEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextNameOrEmail.Depth = 0;
            this.TextNameOrEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextNameOrEmail.HideSelection = true;
            this.TextNameOrEmail.LeadingIcon = null;
            this.TextNameOrEmail.Location = new System.Drawing.Point(269, 156);
            this.TextNameOrEmail.MaxLength = 32767;
            this.TextNameOrEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.TextNameOrEmail.Name = "TextNameOrEmail";
            this.TextNameOrEmail.PasswordChar = '\0';
            this.TextNameOrEmail.PrefixSuffixText = null;
            this.TextNameOrEmail.ReadOnly = false;
            this.TextNameOrEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextNameOrEmail.SelectedText = "";
            this.TextNameOrEmail.SelectionLength = 0;
            this.TextNameOrEmail.SelectionStart = 0;
            this.TextNameOrEmail.ShortcutsEnabled = true;
            this.TextNameOrEmail.Size = new System.Drawing.Size(250, 48);
            this.TextNameOrEmail.TabIndex = 0;
            this.TextNameOrEmail.TabStop = false;
            this.TextNameOrEmail.Text = "Введите имя или почту ";
            this.TextNameOrEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextNameOrEmail.TrailingIcon = null;
            this.TextNameOrEmail.UseSystemPasswordChar = false;
            this.TextNameOrEmail.Enter += new System.EventHandler(this.TextNameOrEmail_Enter);
            this.TextNameOrEmail.Leave += new System.EventHandler(this.TextNameOrEmail_Leave);
            // 
            // TextPassword
            // 
            this.TextPassword.AnimateReadOnly = false;
            this.TextPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextPassword.Depth = 0;
            this.TextPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextPassword.HideSelection = true;
            this.TextPassword.LeadingIcon = null;
            this.TextPassword.Location = new System.Drawing.Point(269, 229);
            this.TextPassword.MaxLength = 32767;
            this.TextPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.PasswordChar = '\0';
            this.TextPassword.PrefixSuffixText = null;
            this.TextPassword.ReadOnly = false;
            this.TextPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextPassword.SelectedText = "";
            this.TextPassword.SelectionLength = 0;
            this.TextPassword.SelectionStart = 0;
            this.TextPassword.ShortcutsEnabled = true;
            this.TextPassword.Size = new System.Drawing.Size(250, 48);
            this.TextPassword.TabIndex = 1;
            this.TextPassword.TabStop = false;
            this.TextPassword.Text = "Введите пароль";
            this.TextPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextPassword.TrailingIcon = null;
            this.TextPassword.UseSystemPasswordChar = false;
            this.TextPassword.Enter += new System.EventHandler(this.TextPassword_Enter);
            this.TextPassword.Leave += new System.EventHandler(this.TextPassword_Leave);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(314, 361);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(71, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "Войти";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // ButtonHome
            // 
            this.ButtonHome.Image = global::DbCRUD.Properties.Resources.free_icon_font_house_chimney_9243286;
            this.ButtonHome.Location = new System.Drawing.Point(12, 12);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(40, 40);
            this.ButtonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonHome.TabIndex = 3;
            this.ButtonHome.TabStop = false;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DbCRUD.Properties.Resources.free_icon_font_user_3917711;
            this.pictureBox2.Location = new System.Drawing.Point(233, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DbCRUD.Properties.Resources.free_icon_font_lock_3917642;
            this.pictureBox3.Location = new System.Drawing.Point(233, 238);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(111)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextNameOrEmail);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.ButtonHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 TextNameOrEmail;
        private MaterialSkin.Controls.MaterialTextBox2 TextPassword;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.PictureBox ButtonHome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}