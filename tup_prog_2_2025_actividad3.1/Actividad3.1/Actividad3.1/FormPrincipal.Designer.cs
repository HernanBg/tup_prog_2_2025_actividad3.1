namespace Actividad3._1
{
    partial class FormPrincipal
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
            btnSimular = new Button();
            tbDescripcion = new TextBox();
            SuspendLayout();
            // 
            // btnSimular
            // 
            btnSimular.Location = new Point(386, 103);
            btnSimular.Name = "btnSimular";
            btnSimular.Size = new Size(75, 23);
            btnSimular.TabIndex = 0;
            btnSimular.Text = "Simular";
            btnSimular.UseVisualStyleBackColor = true;
            btnSimular.Click += btnSimular_Click;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(12, 60);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(350, 351);
            tbDescripcion.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbDescripcion);
            Controls.Add(btnSimular);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnSimular;
        public TextBox tbDescripcion;
        private TextBox tb;
    }
}