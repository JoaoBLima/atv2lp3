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
            button1 = new Button();
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
            // button1
            // 
            button1.Location = new Point(143, 197);
            button1.Name = "button1";
            button1.Size = new Size(137, 29);
            button1.TabIndex = 6;
            button1.Text = "Novo usuário";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btNovoUsuario_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 254);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "label3";
            label3.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 318);
            Controls.Add(label3);
            Controls.Add(button1);
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
        private Button button1;
        private Label label3;
    }
}