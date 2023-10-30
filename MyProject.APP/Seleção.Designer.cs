namespace MyProject.APP
{
    partial class Seleção
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 29);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "Seja bem vindo,";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 29);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 1;
            label2.Text = "user";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 67);
            label3.Name = "label3";
            label3.Size = new Size(207, 20);
            label3.TabIndex = 2;
            label3.Text = "Selecione a opção que deseja";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(31, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(267, 28);
            comboBox1.TabIndex = 3;
            comboBox1.Click += Form1_Load;
            // 
            // button1
            // 
            button1.Location = new Point(31, 149);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btSair_Click;
            // 
            // button2
            // 
            button2.Location = new Point(131, 149);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Selecionar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btEnter_Click;
            // 
            // Seleção
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Seleção";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
    }
}