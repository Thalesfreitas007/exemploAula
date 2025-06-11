namespace ExemploAula
{
    partial class frmmenu
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
            lblwelcome = new Label();
            btnvoltarlogin = new Button();
            SuspendLayout();
            // 
            // lblwelcome
            // 
            lblwelcome.AutoSize = true;
            lblwelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwelcome.Location = new Point(292, 58);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(221, 21);
            lblwelcome.TabIndex = 0;
            lblwelcome.Text = "SEJA BEM VINDO AO MENU";
            // 
            // btnvoltarlogin
            // 
            btnvoltarlogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnvoltarlogin.Location = new Point(328, 160);
            btnvoltarlogin.Name = "btnvoltarlogin";
            btnvoltarlogin.Size = new Size(130, 28);
            btnvoltarlogin.TabIndex = 1;
            btnvoltarlogin.Text = "voltar ao login";
            btnvoltarlogin.UseVisualStyleBackColor = true;
            btnvoltarlogin.Click += btnvoltarlogin_Click;
            // 
            // frmmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnvoltarlogin);
            Controls.Add(lblwelcome);
            Name = "frmmenu";
            Text = "menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblwelcome;
        private Button btnvoltarlogin;
    }
}