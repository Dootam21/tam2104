
namespace manager_player
{
    partial class F_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_login));
            this.paner_login = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.Cb_showPassword = new System.Windows.Forms.CheckBox();
            this.Tb_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.Tb_userName = new System.Windows.Forms.TextBox();
            this.label_user_name = new System.Windows.Forms.Label();
            this.paner_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // paner_login
            // 
            this.paner_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paner_login.AutoScroll = true;
            this.paner_login.BackColor = System.Drawing.Color.Transparent;
            this.paner_login.Controls.Add(this.btn_login);
            this.paner_login.Controls.Add(this.btn_cancel);
            this.paner_login.Controls.Add(this.Cb_showPassword);
            this.paner_login.Controls.Add(this.Tb_password);
            this.paner_login.Controls.Add(this.label_password);
            this.paner_login.Controls.Add(this.Tb_userName);
            this.paner_login.Controls.Add(this.label_user_name);
            this.paner_login.Location = new System.Drawing.Point(0, 0);
            this.paner_login.Name = "paner_login";
            this.paner_login.Size = new System.Drawing.Size(439, 252);
            this.paner_login.TabIndex = 0;
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.AutoSize = true;
            this.btn_login.BackgroundImage = global::manager_player.Properties.Resources.background;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(172, 186);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(104, 37);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Oke";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.BackgroundImage = global::manager_player.Properties.Resources.background;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(293, 186);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(104, 37);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Cb_showPassword
            // 
            this.Cb_showPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cb_showPassword.AutoSize = true;
            this.Cb_showPassword.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_showPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.Cb_showPassword.Location = new System.Drawing.Point(160, 144);
            this.Cb_showPassword.Name = "Cb_showPassword";
            this.Cb_showPassword.Size = new System.Drawing.Size(150, 23);
            this.Cb_showPassword.TabIndex = 2;
            this.Cb_showPassword.Text = "Show pass word";
            this.Cb_showPassword.UseVisualStyleBackColor = true;
            this.Cb_showPassword.CheckedChanged += new System.EventHandler(this.Cb_showPassword_CheckedChanged);
            // 
            // Tb_password
            // 
            this.Tb_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_password.CausesValidation = false;
            this.Tb_password.Location = new System.Drawing.Point(160, 108);
            this.Tb_password.Name = "Tb_password";
            this.Tb_password.Size = new System.Drawing.Size(237, 30);
            this.Tb_password.TabIndex = 1;
            this.Tb_password.UseSystemPasswordChar = true;
            // 
            // label_password
            // 
            this.label_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_password.AutoSize = true;
            this.label_password.CausesValidation = false;
            this.label_password.ForeColor = System.Drawing.Color.White;
            this.label_password.Location = new System.Drawing.Point(41, 110);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(113, 24);
            this.label_password.TabIndex = 0;
            this.label_password.Text = "Pass Word";
            // 
            // Tb_userName
            // 
            this.Tb_userName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_userName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_userName.Location = new System.Drawing.Point(160, 37);
            this.Tb_userName.Name = "Tb_userName";
            this.Tb_userName.Size = new System.Drawing.Size(237, 30);
            this.Tb_userName.TabIndex = 0;
            // 
            // label_user_name
            // 
            this.label_user_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_user_name.AutoSize = true;
            this.label_user_name.ForeColor = System.Drawing.Color.White;
            this.label_user_name.Location = new System.Drawing.Point(41, 39);
            this.label_user_name.Name = "label_user_name";
            this.label_user_name.Size = new System.Drawing.Size(113, 24);
            this.label_user_name.TabIndex = 0;
            this.label_user_name.Text = "User Name";
            // 
            // F_login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = global::manager_player.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(439, 252);
            this.Controls.Add(this.paner_login);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.F_login_Load);
            this.paner_login.ResumeLayout(false);
            this.paner_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paner_login;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.CheckBox Cb_showPassword;
        private System.Windows.Forms.TextBox Tb_userName;
        private System.Windows.Forms.Label label_user_name;
        private System.Windows.Forms.TextBox Tb_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button btn_login;
    }
}

