
namespace THEPA_POS.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlHeader;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();

            this.pnlLogin.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // LoginForm
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor =
                System.Drawing.Color.FromArgb(245, 246, 250);
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THEPA POS | Login";

            // pnlLogin
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.lblMessage);
            this.pnlLogin.Location =
                new System.Drawing.Point(270, 205);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size =
                new System.Drawing.Size(360, 310);
            this.pnlLogin.TabIndex = 0;

            // pnlHeader
            this.pnlHeader.BackColor =
                System.Drawing.Color.FromArgb(123, 20, 43);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Location =
                new System.Drawing.Point(270, 75);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size =
                new System.Drawing.Size(360, 130);
            this.pnlHeader.TabIndex = 1;

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location =
                new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size =
                new System.Drawing.Size(320, 50);
            this.lblTitle.Text = "THEPA POS";
            this.lblTitle.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // lblSubtitle
            this.lblSubtitle.Font = new System.Drawing.Font(
                "Segoe UI", 10F);
            this.lblSubtitle.ForeColor =
                System.Drawing.Color.FromArgb(240, 220, 225);
            this.lblSubtitle.Location =
                new System.Drawing.Point(20, 75);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size =
                new System.Drawing.Size(320, 25);
            this.lblSubtitle.Text = "POINT OF SALE MANAGEMENT SYSTEM";
            this.lblSubtitle.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor =
                System.Drawing.Color.FromArgb(55, 55, 65);
            this.lblUsername.Location =
                new System.Drawing.Point(30, 30);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size =
                new System.Drawing.Size(80, 23);
            this.lblUsername.Text = "Username";

            // txtUsername
            this.txtUsername.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font(
                "Segoe UI", 11F);
            this.txtUsername.Location =
                new System.Drawing.Point(30, 58);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size =
                new System.Drawing.Size(300, 32);
            this.txtUsername.TabIndex = 0;

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor =
                System.Drawing.Color.FromArgb(55, 55, 65);
            this.lblPassword.Location =
                new System.Drawing.Point(30, 110);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size =
                new System.Drawing.Size(78, 23);
            this.lblPassword.Text = "Password";

            // txtPassword
            this.txtPassword.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font(
                "Segoe UI", 11F);
            this.txtPassword.Location =
                new System.Drawing.Point(30, 138);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size =
                new System.Drawing.Size(300, 32);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;

            // btnLogin
            this.btnLogin.BackColor =
                System.Drawing.Color.FromArgb(123, 20, 43);
            this.btnLogin.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font = new System.Drawing.Font(
                "Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location =
                new System.Drawing.Point(30, 190);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size =
                new System.Drawing.Size(300, 42);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "SIGN IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Cursor =
                System.Windows.Forms.Cursors.Hand;

            // lblMessage
            this.lblMessage.Font = new System.Drawing.Font(
                "Segoe UI", 9F);
            this.lblMessage.ForeColor =
                System.Drawing.Color.Firebrick;
            this.lblMessage.Location =
                new System.Drawing.Point(20, 245);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size =
                new System.Drawing.Size(320, 45);
            this.lblMessage.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // Add controls
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlHeader);

            this.AcceptButton = this.btnLogin;

            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
