namespace Presentation_Layer
{
    partial class LoginScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_ID_txt = new System.Windows.Forms.TextBox();
            this.user_Pass_txt = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.error_message_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Password";
            // 
            // user_ID_txt
            // 
            this.user_ID_txt.Location = new System.Drawing.Point(304, 187);
            this.user_ID_txt.Name = "user_ID_txt";
            this.user_ID_txt.Size = new System.Drawing.Size(285, 20);
            this.user_ID_txt.TabIndex = 2;
            // 
            // user_Pass_txt
            // 
            this.user_Pass_txt.Location = new System.Drawing.Point(304, 223);
            this.user_Pass_txt.Name = "user_Pass_txt";
            this.user_Pass_txt.Size = new System.Drawing.Size(285, 20);
            this.user_Pass_txt.TabIndex = 3;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(514, 263);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(304, 263);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(75, 23);
            this.register_btn.TabIndex = 5;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            // 
            // error_message_lbl
            // 
            this.error_message_lbl.AutoSize = true;
            this.error_message_lbl.Location = new System.Drawing.Point(304, 316);
            this.error_message_lbl.Name = "error_message_lbl";
            this.error_message_lbl.Size = new System.Drawing.Size(0, 13);
            this.error_message_lbl.TabIndex = 6;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.error_message_lbl);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.user_Pass_txt);
            this.Controls.Add(this.user_ID_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_ID_txt;
        private System.Windows.Forms.TextBox user_Pass_txt;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label error_message_lbl;
    }
}