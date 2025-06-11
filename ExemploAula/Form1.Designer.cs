namespace ExemploAula
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
            lbllogin = new Label();
            lblusuario = new Label();
            txtusuario = new TextBox();
            lblsenha = new Label();
            txtsenha = new TextBox();
            btnlogar = new Button();
            SuspendLayout();
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllogin.Location = new Point(333, 25);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(59, 21);
            lbllogin.TabIndex = 0;
            lbllogin.Text = "LOGIN";
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusuario.Location = new Point(248, 122);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(71, 21);
            lblusuario.TabIndex = 1;
            lblusuario.Text = "usuário:";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(404, 124);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(100, 23);
            txtusuario.TabIndex = 2;
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsenha.Location = new Point(248, 184);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(59, 21);
            lblsenha.TabIndex = 3;
            lblsenha.Text = "senha:";
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(404, 186);
            txtsenha.Name = "txtsenha";
            txtsenha.PasswordChar = '*';
            txtsenha.Size = new Size(100, 23);
            txtsenha.TabIndex = 4;
            // 
            // btnlogar
            // 
            btnlogar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogar.Location = new Point(365, 288);
            btnlogar.Name = "btnlogar";
            btnlogar.Size = new Size(97, 43);
            btnlogar.TabIndex = 5;
            btnlogar.Text = "LOGAR";
            btnlogar.UseVisualStyleBackColor = true;
            btnlogar.Click += btnlogar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 401);
            Controls.Add(btnlogar);
            Controls.Add(txtsenha);
            Controls.Add(lblsenha);
            Controls.Add(txtusuario);
            Controls.Add(lblusuario);
            Controls.Add(lbllogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllogin;
        private Label lblusuario;
        private TextBox txtusuario;
        private Label lblsenha;
        private TextBox txtsenha;
        private Button btnlogar;
    }
}
