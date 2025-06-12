namespace Ejercicio_3
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
            label1 = new Label();
            label2 = new Label();
            lsbListado = new ListBox();
            btnSolicitar = new Button();
            lbCantidad = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 174);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Listado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 174);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "cantidad";
            // 
            // lsbListado
            // 
            lsbListado.FormattingEnabled = true;
            lsbListado.ItemHeight = 15;
            lsbListado.Location = new Point(145, 192);
            lsbListado.Name = "lsbListado";
            lsbListado.Size = new Size(335, 154);
            lsbListado.TabIndex = 3;
            // 
            // btnSolicitar
            // 
            btnSolicitar.Location = new Point(205, 129);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(127, 23);
            btnSolicitar.TabIndex = 4;
            btnSolicitar.Text = "Solicitar Valor ";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // lbCantidad
            // 
            lbCantidad.AutoSize = true;
            lbCantidad.Location = new Point(349, 173);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(38, 15);
            lbCantidad.TabIndex = 5;
            lbCantidad.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbCantidad);
            Controls.Add(btnSolicitar);
            Controls.Add(lsbListado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ejmplo modal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lsbListado;
        private Button btnSolicitar;
        private Label lbCantidad;
    }
}
