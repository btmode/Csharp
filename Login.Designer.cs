namespace DbCRUD
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonLogin = new MaterialSkin.Controls.MaterialButton();
            this.TextPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.TextEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.TextName = new MaterialSkin.Controls.MaterialTextBox2();
            this.TextBirthDate = new MaterialSkin.Controls.MaterialTextBox2();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ButtonHome = new System.Windows.Forms.PictureBox();
            this.ShowPassword = new MaterialSkin.Controls.MaterialSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonHome)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonLogin.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.ButtonLogin.Depth = 0;
            this.ButtonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonLogin.HighEmphasis = true;
            this.ButtonLogin.Icon = null;
            this.ButtonLogin.Location = new System.Drawing.Point(159, 351);
            this.ButtonLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonLogin.Size = new System.Drawing.Size(189, 36);
            this.ButtonLogin.TabIndex = 0;
            this.ButtonLogin.Text = "Зарегестрироваться ";
            this.ButtonLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonLogin.UseAccentColor = false;
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
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
            this.TextPassword.Location = new System.Drawing.Point(130, 205);
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
            this.TextPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextPassword.TrailingIcon = null;
            this.TextPassword.UseSystemPasswordChar = false;
            this.TextPassword.Enter += new System.EventHandler(this.TextPassword_Enter);
            this.TextPassword.Leave += new System.EventHandler(this.TextPassword_Leave);
            // 
            // TextEmail
            // 
            this.TextEmail.AnimateReadOnly = false;
            this.TextEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextEmail.Depth = 0;
            this.TextEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextEmail.HideSelection = true;
            this.TextEmail.LeadingIcon = null;
            this.TextEmail.Location = new System.Drawing.Point(130, 138);
            this.TextEmail.MaxLength = 32767;
            this.TextEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.PasswordChar = '\0';
            this.TextEmail.PrefixSuffixText = null;
            this.TextEmail.ReadOnly = false;
            this.TextEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextEmail.SelectedText = "";
            this.TextEmail.SelectionLength = 0;
            this.TextEmail.SelectionStart = 0;
            this.TextEmail.ShortcutsEnabled = true;
            this.TextEmail.Size = new System.Drawing.Size(250, 48);
            this.TextEmail.TabIndex = 2;
            this.TextEmail.TabStop = false;
            this.TextEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextEmail.TrailingIcon = null;
            this.TextEmail.UseSystemPasswordChar = false;
            this.TextEmail.Enter += new System.EventHandler(this.TextEmail_Enter);
            this.TextEmail.Leave += new System.EventHandler(this.TextEmail_Leave);
            // 
            // TextName
            // 
            this.TextName.AnimateReadOnly = false;
            this.TextName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextName.Depth = 0;
            this.TextName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextName.HideSelection = true;
            this.TextName.LeadingIcon = null;
            this.TextName.Location = new System.Drawing.Point(130, 70);
            this.TextName.MaxLength = 32767;
            this.TextName.MouseState = MaterialSkin.MouseState.OUT;
            this.TextName.Name = "TextName";
            this.TextName.PasswordChar = '\0';
            this.TextName.PrefixSuffixText = null;
            this.TextName.ReadOnly = false;
            this.TextName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextName.SelectedText = "";
            this.TextName.SelectionLength = 0;
            this.TextName.SelectionStart = 0;
            this.TextName.ShortcutsEnabled = true;
            this.TextName.Size = new System.Drawing.Size(250, 48);
            this.TextName.TabIndex = 3;
            this.TextName.TabStop = false;
            this.TextName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextName.TrailingIcon = null;
            this.TextName.UseSystemPasswordChar = false;
            this.TextName.Enter += new System.EventHandler(this.TextName_Enter);
            this.TextName.Leave += new System.EventHandler(this.TextName_Leave);
            // 
            // TextBirthDate
            // 
            this.TextBirthDate.AnimateReadOnly = false;
            this.TextBirthDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextBirthDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBirthDate.Depth = 0;
            this.TextBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBirthDate.HideSelection = true;
            this.TextBirthDate.LeadingIcon = null;
            this.TextBirthDate.Location = new System.Drawing.Point(130, 272);
            this.TextBirthDate.MaxLength = 32767;
            this.TextBirthDate.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBirthDate.Name = "TextBirthDate";
            this.TextBirthDate.PasswordChar = '\0';
            this.TextBirthDate.PrefixSuffixText = null;
            this.TextBirthDate.ReadOnly = false;
            this.TextBirthDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBirthDate.SelectedText = "";
            this.TextBirthDate.SelectionLength = 0;
            this.TextBirthDate.SelectionStart = 0;
            this.TextBirthDate.ShortcutsEnabled = true;
            this.TextBirthDate.Size = new System.Drawing.Size(250, 48);
            this.TextBirthDate.TabIndex = 4;
            this.TextBirthDate.TabStop = false;
            this.TextBirthDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBirthDate.TrailingIcon = null;
            this.TextBirthDate.UseSystemPasswordChar = false;
            this.TextBirthDate.Enter += new System.EventHandler(this.TextBirthDate_Enter);
            this.TextBirthDate.Leave += new System.EventHandler(this.TextBirthDate_Leave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DbCRUD.Properties.Resources.free_icon_font_calendar_3917262;
            this.pictureBox5.Location = new System.Drawing.Point(80, 280);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DbCRUD.Properties.Resources.free_icon_font_user_3917711;
            this.pictureBox4.Location = new System.Drawing.Point(80, 79);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DbCRUD.Properties.Resources.free_icon_font_envelope_3916631;
            this.pictureBox3.Location = new System.Drawing.Point(80, 148);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DbCRUD.Properties.Resources.free_icon_font_lock_3917642;
            this.pictureBox2.Location = new System.Drawing.Point(80, 214);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // ButtonHome
            // 
            this.ButtonHome.Image = global::DbCRUD.Properties.Resources.free_icon_font_house_chimney_9243286;
            this.ButtonHome.Location = new System.Drawing.Point(12, 12);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(40, 38);
            this.ButtonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonHome.TabIndex = 5;
            this.ButtonHome.TabStop = false;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Depth = 0;
            this.ShowPassword.Location = new System.Drawing.Point(383, 210);
            this.ShowPassword.Margin = new System.Windows.Forms.Padding(0);
            this.ShowPassword.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ShowPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Ripple = true;
            this.ShowPassword.Size = new System.Drawing.Size(58, 37);
            this.ShowPassword.TabIndex = 10;
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(494, 417);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.TextBirthDate);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.TextEmail);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.ButtonLogin);
            this.Name = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton ButtonLogin;
        private MaterialSkin.Controls.MaterialTextBox2 TextPassword;
        private MaterialSkin.Controls.MaterialTextBox2 TextEmail;
        private MaterialSkin.Controls.MaterialTextBox2 TextName;
        private MaterialSkin.Controls.MaterialTextBox2 TextBirthDate;
        private System.Windows.Forms.PictureBox ButtonHome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MaterialSkin.Controls.MaterialSwitch ShowPassword;
    }
}

