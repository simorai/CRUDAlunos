namespace WindowsFormsAlunos
{
    partial class EditarAlunoForm
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
            TxtIdAluno = new TextBox();
            TxtNomeAluno = new TextBox();
            TxtApelido = new TextBox();
            BtnGuardar = new Button();
            BtnCancelar = new Button();
            txtDisciplina = new TextBox();
            SuspendLayout();
            // 
            // TxtIdAluno
            // 
            TxtIdAluno.Enabled = false;
            TxtIdAluno.Location = new Point(54, 51);
            TxtIdAluno.Name = "TxtIdAluno";
            TxtIdAluno.ReadOnly = true;
            TxtIdAluno.Size = new Size(155, 31);
            TxtIdAluno.TabIndex = 0;
            // 
            // TxtNomeAluno
            // 
            TxtNomeAluno.Location = new Point(54, 110);
            TxtNomeAluno.Name = "TxtNomeAluno";
            TxtNomeAluno.Size = new Size(426, 31);
            TxtNomeAluno.TabIndex = 1;
            // 
            // TxtApelido
            // 
            TxtApelido.Location = new Point(54, 173);
            TxtApelido.Name = "TxtApelido";
            TxtApelido.Size = new Size(426, 31);
            TxtApelido.TabIndex = 2;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(533, 375);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(94, 29);
            BtnGuardar.TabIndex = 3;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(664, 375);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(94, 29);
            BtnCancelar.TabIndex = 4;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // txtDisciplina
            // 
            txtDisciplina.Location = new Point(54, 230);
            txtDisciplina.Name = "txtDisciplina";
            txtDisciplina.Size = new Size(426, 31);
            txtDisciplina.TabIndex = 5;
            // 
            // EditarAlunoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDisciplina);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(TxtApelido);
            Controls.Add(TxtNomeAluno);
            Controls.Add(TxtIdAluno);
            Name = "EditarAlunoForm";
            Text = "Editar Aluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtIdAluno;
        private TextBox TxtNomeAluno;
        private TextBox TxtApelido;
        private Button BtnGuardar;
        private Button BtnCancelar;
        private TextBox txtDisciplina;
    }
}