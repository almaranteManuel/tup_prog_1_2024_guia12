namespace Ejercicio_1
{
    partial class Form2
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
            button1 = new Button();
            btnAceptar = new Button();
            label1 = new Label();
            tbValor = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(135, 265);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(386, 265);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 147);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "Valor";
            // 
            // tbValor
            // 
            tbValor.Location = new Point(197, 144);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(100, 23);
            tbValor.TabIndex = 3;
            tbValor.TextChanged += tbValor_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbValor);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += btnCancelar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnAceptar;
        private Label label1;
        public TextBox tbValor;
    }
}