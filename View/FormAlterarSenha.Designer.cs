namespace projeto_acg
{
    partial class FormAlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlterarSenha));
            this.tbSenhaAtual = new System.Windows.Forms.TextBox();
            this.lbSenhaAtual = new System.Windows.Forms.Label();
            this.tbNovaSenha = new System.Windows.Forms.TextBox();
            this.lbNovaSenha = new System.Windows.Forms.Label();
            this.tbConfirmarNovaSenha = new System.Windows.Forms.TextBox();
            this.lbConfirmarNovaSenha = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbAlterarSenha = new System.Windows.Forms.Label();
            this.lbVerSenhaAtual = new System.Windows.Forms.Label();
            this.lbVerNovaSenha = new System.Windows.Forms.Label();
            this.lbVerConfirmarNovaSenha = new System.Windows.Forms.Label();
            this.lbsair = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSenhaAtual
            // 
            this.tbSenhaAtual.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbSenhaAtual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSenhaAtual.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.tbSenhaAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSenhaAtual.Location = new System.Drawing.Point(579, 188);
            this.tbSenhaAtual.Margin = new System.Windows.Forms.Padding(2);
            this.tbSenhaAtual.MaxLength = 30;
            this.tbSenhaAtual.Name = "tbSenhaAtual";
            this.tbSenhaAtual.Size = new System.Drawing.Size(316, 32);
            this.tbSenhaAtual.TabIndex = 0;
            this.tbSenhaAtual.UseSystemPasswordChar = true;
            // 
            // lbSenhaAtual
            // 
            this.lbSenhaAtual.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbSenhaAtual.AutoSize = true;
            this.lbSenhaAtual.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbSenhaAtual.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbSenhaAtual.Location = new System.Drawing.Point(580, 165);
            this.lbSenhaAtual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSenhaAtual.Name = "lbSenhaAtual";
            this.lbSenhaAtual.Size = new System.Drawing.Size(93, 21);
            this.lbSenhaAtual.TabIndex = 12;
            this.lbSenhaAtual.Text = "Senha atual";
            // 
            // tbNovaSenha
            // 
            this.tbNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbNovaSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNovaSenha.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.tbNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNovaSenha.Location = new System.Drawing.Point(579, 259);
            this.tbNovaSenha.Margin = new System.Windows.Forms.Padding(2);
            this.tbNovaSenha.MaxLength = 30;
            this.tbNovaSenha.Name = "tbNovaSenha";
            this.tbNovaSenha.Size = new System.Drawing.Size(316, 32);
            this.tbNovaSenha.TabIndex = 1;
            this.tbNovaSenha.UseSystemPasswordChar = true;
            // 
            // lbNovaSenha
            // 
            this.lbNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbNovaSenha.AutoSize = true;
            this.lbNovaSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbNovaSenha.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbNovaSenha.Location = new System.Drawing.Point(580, 236);
            this.lbNovaSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNovaSenha.Name = "lbNovaSenha";
            this.lbNovaSenha.Size = new System.Drawing.Size(94, 21);
            this.lbNovaSenha.TabIndex = 14;
            this.lbNovaSenha.Text = "Nova senha";
            // 
            // tbConfirmarNovaSenha
            // 
            this.tbConfirmarNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbConfirmarNovaSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbConfirmarNovaSenha.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.tbConfirmarNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbConfirmarNovaSenha.Location = new System.Drawing.Point(579, 330);
            this.tbConfirmarNovaSenha.Margin = new System.Windows.Forms.Padding(2);
            this.tbConfirmarNovaSenha.MaxLength = 30;
            this.tbConfirmarNovaSenha.Name = "tbConfirmarNovaSenha";
            this.tbConfirmarNovaSenha.Size = new System.Drawing.Size(316, 32);
            this.tbConfirmarNovaSenha.TabIndex = 2;
            this.tbConfirmarNovaSenha.UseSystemPasswordChar = true;
            // 
            // lbConfirmarNovaSenha
            // 
            this.lbConfirmarNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbConfirmarNovaSenha.AutoSize = true;
            this.lbConfirmarNovaSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbConfirmarNovaSenha.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbConfirmarNovaSenha.Location = new System.Drawing.Point(580, 307);
            this.lbConfirmarNovaSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbConfirmarNovaSenha.Name = "lbConfirmarNovaSenha";
            this.lbConfirmarNovaSenha.Size = new System.Drawing.Size(168, 21);
            this.lbConfirmarNovaSenha.TabIndex = 16;
            this.lbConfirmarNovaSenha.Text = "Confirmar nova senha";
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSalvar.BackColor = System.Drawing.Color.SteelBlue;
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btSalvar.ForeColor = System.Drawing.Color.White;
            this.btSalvar.Location = new System.Drawing.Point(579, 422);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(316, 32);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btLimpar.BackColor = System.Drawing.Color.GhostWhite;
            this.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btLimpar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btLimpar.Location = new System.Drawing.Point(579, 386);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(316, 32);
            this.btLimpar.TabIndex = 3;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 88);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lbAlterarSenha
            // 
            this.lbAlterarSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbAlterarSenha.AutoSize = true;
            this.lbAlterarSenha.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbAlterarSenha.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbAlterarSenha.Location = new System.Drawing.Point(622, 88);
            this.lbAlterarSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAlterarSenha.Name = "lbAlterarSenha";
            this.lbAlterarSenha.Size = new System.Drawing.Size(230, 37);
            this.lbAlterarSenha.TabIndex = 38;
            this.lbAlterarSenha.Text = "ALTERAR SENHA";
            this.lbAlterarSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbVerSenhaAtual
            // 
            this.lbVerSenhaAtual.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbVerSenhaAtual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbVerSenhaAtual.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.lbVerSenhaAtual.ForeColor = System.Drawing.SystemColors.Control;
            this.lbVerSenhaAtual.Image = ((System.Drawing.Image)(resources.GetObject("lbVerSenhaAtual.Image")));
            this.lbVerSenhaAtual.Location = new System.Drawing.Point(894, 188);
            this.lbVerSenhaAtual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVerSenhaAtual.Name = "lbVerSenhaAtual";
            this.lbVerSenhaAtual.Size = new System.Drawing.Size(32, 32);
            this.lbVerSenhaAtual.TabIndex = 69;
            this.lbVerSenhaAtual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbVerSenhaAtual.MouseCaptureChanged += new System.EventHandler(this.lbVerSenhaAtual_MouseCaptureChanged);
            // 
            // lbVerNovaSenha
            // 
            this.lbVerNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbVerNovaSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbVerNovaSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.lbVerNovaSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.lbVerNovaSenha.Image = ((System.Drawing.Image)(resources.GetObject("lbVerNovaSenha.Image")));
            this.lbVerNovaSenha.Location = new System.Drawing.Point(894, 259);
            this.lbVerNovaSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVerNovaSenha.Name = "lbVerNovaSenha";
            this.lbVerNovaSenha.Size = new System.Drawing.Size(32, 32);
            this.lbVerNovaSenha.TabIndex = 70;
            this.lbVerNovaSenha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbVerNovaSenha.MouseCaptureChanged += new System.EventHandler(this.lbVerNovaSenha_MouseCaptureChanged);
            // 
            // lbVerConfirmarNovaSenha
            // 
            this.lbVerConfirmarNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbVerConfirmarNovaSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbVerConfirmarNovaSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.lbVerConfirmarNovaSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.lbVerConfirmarNovaSenha.Image = ((System.Drawing.Image)(resources.GetObject("lbVerConfirmarNovaSenha.Image")));
            this.lbVerConfirmarNovaSenha.Location = new System.Drawing.Point(894, 330);
            this.lbVerConfirmarNovaSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVerConfirmarNovaSenha.Name = "lbVerConfirmarNovaSenha";
            this.lbVerConfirmarNovaSenha.Size = new System.Drawing.Size(32, 32);
            this.lbVerConfirmarNovaSenha.TabIndex = 71;
            this.lbVerConfirmarNovaSenha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbVerConfirmarNovaSenha.MouseCaptureChanged += new System.EventHandler(this.lbVerConfirmarNovaSenha_MouseCaptureChanged);
            // 
            // lbsair
            // 
            this.lbsair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbsair.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.lbsair.ForeColor = System.Drawing.SystemColors.Control;
            this.lbsair.Image = ((System.Drawing.Image)(resources.GetObject("lbsair.Image")));
            this.lbsair.Location = new System.Drawing.Point(1033, 491);
            this.lbsair.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbsair.Name = "lbsair";
            this.lbsair.Size = new System.Drawing.Size(40, 40);
            this.lbsair.TabIndex = 72;
            this.lbsair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbsair.Click += new System.EventHandler(this.lbsair_Click);
            // 
            // FormAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 540);
            this.Controls.Add(this.lbsair);
            this.Controls.Add(this.lbAlterarSenha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tbConfirmarNovaSenha);
            this.Controls.Add(this.lbConfirmarNovaSenha);
            this.Controls.Add(this.tbNovaSenha);
            this.Controls.Add(this.lbNovaSenha);
            this.Controls.Add(this.tbSenhaAtual);
            this.Controls.Add(this.lbSenhaAtual);
            this.Controls.Add(this.lbVerConfirmarNovaSenha);
            this.Controls.Add(this.lbVerNovaSenha);
            this.Controls.Add(this.lbVerSenhaAtual);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(858, 509);
            this.Name = "FormAlterarSenha";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.Load += new System.EventHandler(this.FormAlterarSenha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSenhaAtual;
        private System.Windows.Forms.Label lbSenhaAtual;
        private System.Windows.Forms.TextBox tbNovaSenha;
        private System.Windows.Forms.Label lbNovaSenha;
        private System.Windows.Forms.TextBox tbConfirmarNovaSenha;
        private System.Windows.Forms.Label lbConfirmarNovaSenha;
        internal System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbAlterarSenha;
        private System.Windows.Forms.Label lbVerSenhaAtual;
        private System.Windows.Forms.Label lbVerNovaSenha;
        private System.Windows.Forms.Label lbVerConfirmarNovaSenha;
        private System.Windows.Forms.Label lbsair;
    }
}