using System.Windows.Forms;

namespace projeto_acg.View
{
    partial class FormCadAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadAluno));
            this.lbcadastro = new System.Windows.Forms.Label();
            this.btlimpar = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.lbnome = new System.Windows.Forms.Label();
            this.lbsair = new System.Windows.Forms.Label();
            this.mtbmatricula = new System.Windows.Forms.MaskedTextBox();
            this.tbsenha = new System.Windows.Forms.TextBox();
            this.lbsenha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbcadastro
            // 
            this.lbcadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcadastro.AutoSize = true;
            this.lbcadastro.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbcadastro.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbcadastro.Location = new System.Drawing.Point(239, 57);
            this.lbcadastro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcadastro.Name = "lbcadastro";
            this.lbcadastro.Size = new System.Drawing.Size(195, 37);
            this.lbcadastro.TabIndex = 19;
            this.lbcadastro.Text = "CADASTRE-SE";
            this.lbcadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btlimpar
            // 
            this.btlimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btlimpar.BackColor = System.Drawing.Color.GhostWhite;
            this.btlimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btlimpar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btlimpar.Location = new System.Drawing.Point(184, 414);
            this.btlimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(150, 32);
            this.btlimpar.TabIndex = 5;
            this.btlimpar.Text = "LIMPAR";
            this.btlimpar.UseVisualStyleBackColor = false;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btsalvar.BackColor = System.Drawing.Color.SteelBlue;
            this.btsalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btsalvar.ForeColor = System.Drawing.Color.White;
            this.btsalvar.Location = new System.Drawing.Point(184, 450);
            this.btsalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(305, 32);
            this.btsalvar.TabIndex = 7;
            this.btsalvar.Text = "CADASTRAR";
            this.btsalvar.UseVisualStyleBackColor = false;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btcancelar.BackColor = System.Drawing.Color.GhostWhite;
            this.btcancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btcancelar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btcancelar.Location = new System.Drawing.Point(339, 414);
            this.btcancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(150, 32);
            this.btcancelar.TabIndex = 6;
            this.btcancelar.Text = "CANCELAR";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // tbemail
            // 
            this.tbemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbemail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbemail.Location = new System.Drawing.Point(184, 225);
            this.tbemail.Margin = new System.Windows.Forms.Padding(2);
            this.tbemail.MaxLength = 50;
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(305, 29);
            this.tbemail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(185, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-mail Institucional";
            // 
            // tbnome
            // 
            this.tbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbnome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbnome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbnome.Location = new System.Drawing.Point(184, 157);
            this.tbnome.Margin = new System.Windows.Forms.Padding(2);
            this.tbnome.MaxLength = 50;
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(305, 29);
            this.tbnome.TabIndex = 0;
            // 
            // lbnome
            // 
            this.lbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbnome.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbnome.Location = new System.Drawing.Point(185, 134);
            this.lbnome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(55, 21);
            this.lbnome.TabIndex = 0;
            this.lbnome.Text = "Nome";
            // 
            // lbsair
            // 
            this.lbsair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbsair.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.lbsair.ForeColor = System.Drawing.SystemColors.Control;
            this.lbsair.Image = ((System.Drawing.Image)(resources.GetObject("lbsair.Image")));
            this.lbsair.Location = new System.Drawing.Point(460, 361);
            this.lbsair.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbsair.Name = "lbsair";
            this.lbsair.Size = new System.Drawing.Size(29, 29);
            this.lbsair.TabIndex = 68;
            this.lbsair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbsair.MouseCaptureChanged += new System.EventHandler(this.btversenha_Click);
            // 
            // mtbmatricula
            // 
            this.mtbmatricula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbmatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbmatricula.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtbmatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtbmatricula.Location = new System.Drawing.Point(184, 293);
            this.mtbmatricula.Margin = new System.Windows.Forms.Padding(2);
            this.mtbmatricula.Mask = "00-00000";
            this.mtbmatricula.Name = "mtbmatricula";
            this.mtbmatricula.Size = new System.Drawing.Size(105, 29);
            this.mtbmatricula.TabIndex = 22;
            this.mtbmatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbmatricula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbmatricula.Enter += new System.EventHandler(this.mtbmatricula_Enter);
            this.mtbmatricula.Leave += new System.EventHandler(this.mtbmatricula_Leave);
            // 
            // tbsenha
            // 
            this.tbsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbsenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbsenha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbsenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbsenha.Location = new System.Drawing.Point(184, 361);
            this.tbsenha.Margin = new System.Windows.Forms.Padding(2);
            this.tbsenha.MaxLength = 30;
            this.tbsenha.Name = "tbsenha";
            this.tbsenha.Size = new System.Drawing.Size(272, 29);
            this.tbsenha.TabIndex = 4;
            this.tbsenha.UseSystemPasswordChar = true;
            // 
            // lbsenha
            // 
            this.lbsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbsenha.AutoSize = true;
            this.lbsenha.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbsenha.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbsenha.Location = new System.Drawing.Point(185, 338);
            this.lbsenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbsenha.Name = "lbsenha";
            this.lbsenha.Size = new System.Drawing.Size(54, 21);
            this.lbsenha.TabIndex = 8;
            this.lbsenha.Text = "Senha";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(185, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Matrícula";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(533, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FormCadAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 540);
            this.Controls.Add(this.lbsair);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.mtbmatricula);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbsenha);
            this.Controls.Add(this.lbsenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.lbcadastro);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btsalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1100, 579);
            this.Name = "FormCadAluno";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FormCadAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbcadastro;
        private Button btlimpar;
        private Button btsalvar;
        private Button btcancelar;
        private TextBox tbemail;
        private Label label3;
        private TextBox tbnome;
        private Label lbnome;
        private TextBox tbsenha;
        private Label lbsenha;
        private Label label1;
        private PictureBox pictureBox1;
        private MaskedTextBox mtbmatricula;
        private Label lbsair;
    }
}