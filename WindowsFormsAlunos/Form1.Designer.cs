namespace WindowsFormsAlunos
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
            TxtIdAluno = new TextBox();
            TxtNomeAluno = new TextBox();
            label2 = new Label();
            label3 = new Label();
            TxtApelido = new TextBox();
            BtnGuardar = new Button();
            BtnCancelar = new Button();
            AlunosListBox = new ListBox();
            BtnApagarAluno = new Button();
            BtnEditarAluno = new Button();
            label4 = new Label();
            txtNomeDisciplina = new TextBox();
            label5 = new Label();
            txtIdDisciplina = new TextBox();
            btnGuardarDisciplina = new Button();
            BtnLimparDisciplina = new Button();
            DisciplinasListBox = new ListBox();
            BtnEditarDisciplina = new Button();
            BtnApagarDisciplina = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 40);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 0;
            label1.Text = "ID de aluno:";
            // 
            // TxtIdAluno
            // 
            TxtIdAluno.Enabled = false;
            TxtIdAluno.Location = new Point(157, 40);
            TxtIdAluno.Name = "TxtIdAluno";
            TxtIdAluno.Size = new Size(125, 31);
            TxtIdAluno.TabIndex = 1;
            // 
            // TxtNomeAluno
            // 
            TxtNomeAluno.Location = new Point(157, 84);
            TxtNomeAluno.Name = "TxtNomeAluno";
            TxtNomeAluno.Size = new Size(125, 31);
            TxtNomeAluno.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 84);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 3;
            label2.Text = "Nome de aluno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 130);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 4;
            label3.Text = "Apelido de aluno:";
            // 
            // TxtApelido
            // 
            TxtApelido.Location = new Point(157, 130);
            TxtApelido.Name = "TxtApelido";
            TxtApelido.Size = new Size(125, 31);
            TxtApelido.TabIndex = 5;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(12, 181);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(94, 29);
            BtnGuardar.TabIndex = 6;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(122, 181);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(94, 29);
            BtnCancelar.TabIndex = 7;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // AlunosListBox
            // 
            AlunosListBox.BackColor = SystemColors.Info;
            AlunosListBox.FormattingEnabled = true;
            AlunosListBox.ItemHeight = 25;
            AlunosListBox.Location = new Point(23, 285);
            AlunosListBox.Name = "AlunosListBox";
            AlunosListBox.Size = new Size(471, 104);
            AlunosListBox.TabIndex = 8;
            // 
            // BtnApagarAluno
            // 
            BtnApagarAluno.Location = new Point(12, 404);
            BtnApagarAluno.Name = "BtnApagarAluno";
            BtnApagarAluno.Size = new Size(238, 35);
            BtnApagarAluno.TabIndex = 9;
            BtnApagarAluno.Text = "Apagar aluno selecionado";
            BtnApagarAluno.UseVisualStyleBackColor = true;
            BtnApagarAluno.Click += BtnApagarAluno_Click;
            // 
            // BtnEditarAluno
            // 
            BtnEditarAluno.Location = new Point(256, 404);
            BtnEditarAluno.Name = "BtnEditarAluno";
            BtnEditarAluno.Size = new Size(238, 35);
            BtnEditarAluno.TabIndex = 10;
            BtnEditarAluno.Text = "Editar aluno selecionado";
            BtnEditarAluno.UseVisualStyleBackColor = true;
            BtnEditarAluno.Click += BtnEditarAluno_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(631, 96);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 11;
            label4.Text = "Disciplina:";
            // 
            // txtNomeDisciplina
            // 
            txtNomeDisciplina.Location = new Point(743, 93);
            txtNomeDisciplina.Name = "txtNomeDisciplina";
            txtNomeDisciplina.Size = new Size(367, 31);
            txtNomeDisciplina.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(631, 37);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 13;
            label5.Text = "ID Disciplna";
            // 
            // txtIdDisciplina
            // 
            txtIdDisciplina.Enabled = false;
            txtIdDisciplina.Location = new Point(743, 37);
            txtIdDisciplina.Name = "txtIdDisciplina";
            txtIdDisciplina.Size = new Size(86, 31);
            txtIdDisciplina.TabIndex = 14;
            // 
            // btnGuardarDisciplina
            // 
            btnGuardarDisciplina.Location = new Point(678, 196);
            btnGuardarDisciplina.Name = "btnGuardarDisciplina";
            btnGuardarDisciplina.Size = new Size(94, 29);
            btnGuardarDisciplina.TabIndex = 15;
            btnGuardarDisciplina.Text = "Guardar";
            btnGuardarDisciplina.UseVisualStyleBackColor = true;
            btnGuardarDisciplina.Click += btnGuardarDisciplina_Click;
            // 
            // BtnLimparDisciplina
            // 
            BtnLimparDisciplina.Location = new Point(790, 196);
            BtnLimparDisciplina.Name = "BtnLimparDisciplina";
            BtnLimparDisciplina.Size = new Size(94, 29);
            BtnLimparDisciplina.TabIndex = 16;
            BtnLimparDisciplina.Text = "cancelar";
            BtnLimparDisciplina.UseVisualStyleBackColor = true;
            // 
            // DisciplinasListBox
            // 
            DisciplinasListBox.BackColor = SystemColors.Info;
            DisciplinasListBox.FormattingEnabled = true;
            DisciplinasListBox.ItemHeight = 25;
            DisciplinasListBox.Location = new Point(638, 285);
            DisciplinasListBox.Name = "DisciplinasListBox";
            DisciplinasListBox.Size = new Size(471, 104);
            DisciplinasListBox.TabIndex = 17;
            // 
            // BtnEditarDisciplina
            // 
            BtnEditarDisciplina.Location = new Point(882, 404);
            BtnEditarDisciplina.Name = "BtnEditarDisciplina";
            BtnEditarDisciplina.Size = new Size(238, 35);
            BtnEditarDisciplina.TabIndex = 19;
            BtnEditarDisciplina.Text = "Editar Disciplina";
            BtnEditarDisciplina.UseVisualStyleBackColor = true;
            // 
            // BtnApagarDisciplina
            // 
            BtnApagarDisciplina.Location = new Point(638, 404);
            BtnApagarDisciplina.Name = "BtnApagarDisciplina";
            BtnApagarDisciplina.Size = new Size(238, 35);
            BtnApagarDisciplina.TabIndex = 18;
            BtnApagarDisciplina.Text = "Apagar disciplina";
            BtnApagarDisciplina.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1129, 566);
            Controls.Add(BtnEditarDisciplina);
            Controls.Add(BtnApagarDisciplina);
            Controls.Add(DisciplinasListBox);
            Controls.Add(BtnLimparDisciplina);
            Controls.Add(btnGuardarDisciplina);
            Controls.Add(txtIdDisciplina);
            Controls.Add(label5);
            Controls.Add(txtNomeDisciplina);
            Controls.Add(label4);
            Controls.Add(BtnEditarAluno);
            Controls.Add(BtnApagarAluno);
            Controls.Add(AlunosListBox);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(TxtApelido);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TxtNomeAluno);
            Controls.Add(TxtIdAluno);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtIdAluno;
        private TextBox TxtNomeAluno;
        private Label label2;
        private Label label3;
        private TextBox TxtApelido;
        private Button BtnGuardar;
        private Button BtnCancelar;
        private ListBox AlunosListBox;
        private Button BtnApagarAluno;
        private Button BtnEditarAluno;
        private Label label4;
        private TextBox txtNomeDisciplina;
        private Label label5;
        private TextBox txtIdDisciplina;
        private Button btnGuardarDisciplina;
        private Button BtnLimparDisciplina;
        private ListBox DisciplinasListBox;
        private Button BtnEditarDisciplina;
        private Button BtnApagarDisciplina;
    }
}
