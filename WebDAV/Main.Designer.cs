namespace WebDAV
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.editHost = new System.Windows.Forms.TextBox();
            this.editLogin = new System.Windows.Forms.TextBox();
            this.editPassword = new System.Windows.Forms.TextBox();
            this.editInfo = new System.Windows.Forms.TextBox();
            this.labelHost = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.labelAction = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.pbOK = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOK)).BeginInit();
            this.SuspendLayout();
            // 
            // editHost
            // 
            this.editHost.Location = new System.Drawing.Point(30, 34);
            this.editHost.Margin = new System.Windows.Forms.Padding(4);
            this.editHost.Name = "editHost";
            this.editHost.Size = new System.Drawing.Size(334, 22);
            this.editHost.TabIndex = 4;
            // 
            // editLogin
            // 
            this.editLogin.Location = new System.Drawing.Point(31, 91);
            this.editLogin.Margin = new System.Windows.Forms.Padding(4);
            this.editLogin.Name = "editLogin";
            this.editLogin.Size = new System.Drawing.Size(334, 22);
            this.editLogin.TabIndex = 5;
            // 
            // editPassword
            // 
            this.editPassword.Location = new System.Drawing.Point(31, 151);
            this.editPassword.Margin = new System.Windows.Forms.Padding(4);
            this.editPassword.Name = "editPassword";
            this.editPassword.Size = new System.Drawing.Size(334, 22);
            this.editPassword.TabIndex = 6;
            this.editPassword.UseSystemPasswordChar = true;
            // 
            // editInfo
            // 
            this.editInfo.Location = new System.Drawing.Point(30, 207);
            this.editInfo.Margin = new System.Windows.Forms.Padding(4);
            this.editInfo.Name = "editInfo";
            this.editInfo.Size = new System.Drawing.Size(334, 22);
            this.editInfo.TabIndex = 7;
            this.editInfo.Visible = false;
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(27, 15);
            this.labelHost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(97, 17);
            this.labelHost.TabIndex = 8;
            this.labelHost.Text = "Host Address:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(28, 70);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(47, 17);
            this.labelLogin.TabIndex = 9;
            this.labelLogin.Text = "Login:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(27, 130);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(73, 17);
            this.labelPassword.TabIndex = 10;
            this.labelPassword.Text = "Password:";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(27, 186);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 17);
            this.labelInfo.TabIndex = 11;
            this.labelInfo.Visible = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // cbAction
            // 
            this.cbAction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Items.AddRange(new object[] {
            "Make Collection",
            "Delete File/Collection",
            "Download File",
            "Upload File"});
            this.cbAction.Location = new System.Drawing.Point(42, 42);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(334, 24);
            this.cbAction.TabIndex = 12;
            this.cbAction.SelectedIndexChanged += new System.EventHandler(this.actionComboBox_SelectedIndexChanged);
            // 
            // labelAction
            // 
            this.labelAction.AutoSize = true;
            this.labelAction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelAction.Location = new System.Drawing.Point(39, 18);
            this.labelAction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(51, 17);
            this.labelAction.TabIndex = 13;
            this.labelAction.Text = "Action:";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pbOK);
            this.panel.Controls.Add(this.editInfo);
            this.panel.Controls.Add(this.editHost);
            this.panel.Controls.Add(this.editLogin);
            this.panel.Controls.Add(this.labelInfo);
            this.panel.Controls.Add(this.editPassword);
            this.panel.Controls.Add(this.labelPassword);
            this.panel.Controls.Add(this.labelHost);
            this.panel.Controls.Add(this.labelLogin);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(12, 88);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(394, 333);
            this.panel.TabIndex = 14;
            // 
            // pbOK
            // 
            this.pbOK.BackgroundImage = global::WebDAV.Properties.Resources.ok;
            this.pbOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOK.Location = new System.Drawing.Point(171, 264);
            this.pbOK.Name = "pbOK";
            this.pbOK.Size = new System.Drawing.Size(52, 46);
            this.pbOK.TabIndex = 12;
            this.pbOK.TabStop = false;
            this.pbOK.Click += new System.EventHandler(this.pbOK_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(418, 433);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.labelAction);
            this.Controls.Add(this.cbAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloud Client";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox editHost;
        private System.Windows.Forms.TextBox editLogin;
        private System.Windows.Forms.TextBox editPassword;
        private System.Windows.Forms.TextBox editInfo;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.Label labelAction;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pbOK;
    }
}

