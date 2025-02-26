namespace WindowsFormsDisciplina
{
    partial class EditarDisciplinaForm
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
            BtnCancelar = new Button();
            BtnGuardar = new Button();
            TxtNomeDisciplina = new TextBox();
            TxtIdDisciplina = new TextBox();
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(658, 373);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(94, 29);
            BtnCancelar.TabIndex = 9;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(527, 373);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(94, 29);
            BtnGuardar.TabIndex = 8;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // TxtNomeDisciplina
            // 
            TxtNomeDisciplina.Location = new Point(48, 108);
            TxtNomeDisciplina.Name = "TxtNomeDisciplina";
            TxtNomeDisciplina.Size = new Size(426, 31);
            TxtNomeDisciplina.TabIndex = 6;
            // 
            // TxtIdDisciplina
            // 
            TxtIdDisciplina.Enabled = false;
            TxtIdDisciplina.Location = new Point(48, 49);
            TxtIdDisciplina.Name = "TxtIdDisciplina";
            TxtIdDisciplina.ReadOnly = true;
            TxtIdDisciplina.Size = new Size(155, 31);
            TxtIdDisciplina.TabIndex = 5;
            // 
            // EditarDisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(TxtNomeDisciplina);
            Controls.Add(TxtIdDisciplina);
            Name = "EditarDisciplinaForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancelar;
        private Button BtnGuardar;
        private TextBox TxtNomeDisciplina;
        private TextBox TxtIdDisciplina;
    }
}