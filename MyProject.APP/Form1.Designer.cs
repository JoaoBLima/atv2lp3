namespace MyProject.APP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginTxt = new TextBox();
            senhaTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btLogin = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // loginTxt
            // 
            loginTxt.Location = new Point(34, 67);
            loginTxt.Name = "loginTxt";
            loginTxt.Size = new Size(246, 27);
            loginTxt.TabIndex = 0;
            loginTxt.Tag = "loginTxt";
            // 
            // senhaTxt
            // 
            senhaTxt.Location = new Point(34, 134);
            senhaTxt.Name = "senhaTxt";
            senhaTxt.PasswordChar = '*';
            senhaTxt.Size = new Size(246, 27);
            senhaTxt.TabIndex = 1;
            senhaTxt.Tag = "senhaTxt";
            senhaTxt.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 44);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 2;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 111);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // btLogin
            // 
            btLogin.Location = new Point(34, 197);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(94, 29);
            btLogin.TabIndex = 4;
            btLogin.Tag = "btLogin";
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 255);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 5;
            label3.Tag = "resultado";
            label3.Text = "RESULTADO";
            label3.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 318);
            Controls.Add(label3);
            Controls.Add(btLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(senhaTxt);
            Controls.Add(loginTxt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginTxt;
        private TextBox senhaTxt;
        private Label label1;
        private Label label2;
        private Button btLogin;
        private Label label3;
    }
}