namespace WindowsFormsDisciplina
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
            BtnEditarDisciplina = new Button();
            BtnApagarDisciplina = new Button();
            DisciplinasListBox = new ListBox();
            BtnLimparDisciplina = new Button();
            btnGuardarDisciplina = new Button();
            txtIdDisciplina = new TextBox();
            label5 = new Label();
            txtNomeDisciplina = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // BtnEditarDisciplina
            // 
            BtnEditarDisciplina.Location = new Point(277, 387);
            BtnEditarDisciplina.Name = "BtnEditarDisciplina";
            BtnEditarDisciplina.Size = new Size(238, 35);
            BtnEditarDisciplina.TabIndex = 46;
            BtnEditarDisciplina.Text = "Editar Disciplina";
            BtnEditarDisciplina.UseVisualStyleBackColor = true;
            BtnEditarDisciplina.Click += BtnEditarDisciplina_Click;
            // 
            // BtnApagarDisciplina
            // 
            BtnApagarDisciplina.Location = new Point(33, 387);
            BtnApagarDisciplina.Name = "BtnApagarDisciplina";
            BtnApagarDisciplina.Size = new Size(238, 35);
            BtnApagarDisciplina.TabIndex = 45;
            BtnApagarDisciplina.Text = "Apagar disciplina";
            BtnApagarDisciplina.UseVisualStyleBackColor = true;
            BtnApagarDisciplina.Click += BtnApagarDisciplina_Click;
            // 
            // DisciplinasListBox
            // 
            DisciplinasListBox.BackColor = SystemColors.Info;
            DisciplinasListBox.FormattingEnabled = true;
            DisciplinasListBox.ItemHeight = 25;
            DisciplinasListBox.Location = new Point(33, 268);
            DisciplinasListBox.Name = "DisciplinasListBox";
            DisciplinasListBox.Size = new Size(471, 104);
            DisciplinasListBox.TabIndex = 44;
            // 
            // BtnLimparDisciplina
            // 
            BtnLimparDisciplina.Location = new Point(185, 179);
            BtnLimparDisciplina.Name = "BtnLimparDisciplina";
            BtnLimparDisciplina.Size = new Size(94, 29);
            BtnLimparDisciplina.TabIndex = 43;
            BtnLimparDisciplina.Text = "cancelar";
            BtnLimparDisciplina.UseVisualStyleBackColor = true;

            // 
            // btnGuardarDisciplina
            // 
            btnGuardarDisciplina.Location = new Point(73, 179);
            btnGuardarDisciplina.Name = "btnGuardarDisciplina";
            btnGuardarDisciplina.Size = new Size(94, 29);
            btnGuardarDisciplina.TabIndex = 42;
            btnGuardarDisciplina.Text = "Guardar";
            btnGuardarDisciplina.UseVisualStyleBackColor = true;

            // 
            // txtIdDisciplina
            // 
            txtIdDisciplina.Enabled = false;
            txtIdDisciplina.Location = new Point(138, 20);
            txtIdDisciplina.Name = "txtIdDisciplina";
            txtIdDisciplina.Size = new Size(86, 31);
            txtIdDisciplina.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 20);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 40;
            label5.Text = "ID Disciplna";
            // 
            // txtNomeDisciplina
            // 
            txtNomeDisciplina.Location = new Point(138, 76);
            txtNomeDisciplina.Name = "txtNomeDisciplina";
            txtNomeDisciplina.Size = new Size(367, 31);
            txtNomeDisciplina.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 79);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 38;
            label4.Text = "Disciplina:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnEditarDisciplina);
            Controls.Add(BtnApagarDisciplina);
            Controls.Add(DisciplinasListBox);
            Controls.Add(BtnLimparDisciplina);
            Controls.Add(btnGuardarDisciplina);
            Controls.Add(txtIdDisciplina);
            Controls.Add(label5);
            Controls.Add(txtNomeDisciplina);
            Controls.Add(label4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnEditarDisciplina;
        private Button BtnApagarDisciplina;
        private ListBox DisciplinasListBox;
        private Button BtnLimparDisciplina;
        private Button btnGuardarDisciplina;
        private TextBox txtIdDisciplina;
        private Label label5;
        private TextBox txtNomeDisciplina;
        private Label label4;
    }
}
