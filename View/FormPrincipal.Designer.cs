using System.Windows.Forms;

namespace projeto_acg.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btenviaracg = new System.Windows.Forms.Button();
            this.bteditaraluno = new System.Windows.Forms.Button();
            this.bteditaracg = new System.Windows.Forms.Button();
            this.btcadastraracg = new System.Windows.Forms.Button();
            this.btverificarsituacao = new System.Windows.Forms.Button();
            this.lbsair = new System.Windows.Forms.Label();
            this.btAlterarSenha = new System.Windows.Forms.Button();
            this.btRevisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(639, 158);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btenviaracg
            // 
            this.btenviaracg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btenviaracg.BackColor = System.Drawing.Color.SteelBlue;
            this.btenviaracg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btenviaracg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btenviaracg.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btenviaracg.ForeColor = System.Drawing.Color.White;
            this.btenviaracg.Location = new System.Drawing.Point(51, 221);
            this.btenviaracg.Margin = new System.Windows.Forms.Padding(2);
            this.btenviaracg.Name = "btenviaracg";
            this.btenviaracg.Size = new System.Drawing.Size(257, 59);
            this.btenviaracg.TabIndex = 1;
            this.btenviaracg.Text = "ENVIAR ACG";
            this.btenviaracg.UseVisualStyleBackColor = false;
            this.btenviaracg.Click += new System.EventHandler(this.btenviaracg_Click);
            // 
            // bteditaraluno
            // 
            this.bteditaraluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bteditaraluno.BackColor = System.Drawing.Color.SteelBlue;
            this.bteditaraluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bteditaraluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bteditaraluno.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.bteditaraluno.ForeColor = System.Drawing.Color.White;
            this.bteditaraluno.Location = new System.Drawing.Point(317, 289);
            this.bteditaraluno.Margin = new System.Windows.Forms.Padding(2);
            this.bteditaraluno.Name = "bteditaraluno";
            this.bteditaraluno.Size = new System.Drawing.Size(257, 59);
            this.bteditaraluno.TabIndex = 5;
            this.bteditaraluno.Text = "EDITAR ALUNO";
            this.bteditaraluno.UseVisualStyleBackColor = false;
            this.bteditaraluno.Click += new System.EventHandler(this.bteditaraluno_Click);
            // 
            // bteditaracg
            // 
            this.bteditaracg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bteditaracg.BackColor = System.Drawing.Color.SteelBlue;
            this.bteditaracg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bteditaracg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bteditaracg.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.bteditaracg.ForeColor = System.Drawing.Color.White;
            this.bteditaracg.Location = new System.Drawing.Point(317, 221);
            this.bteditaracg.Margin = new System.Windows.Forms.Padding(2);
            this.bteditaracg.Name = "bteditaracg";
            this.bteditaracg.Size = new System.Drawing.Size(257, 59);
            this.bteditaracg.TabIndex = 4;
            this.bteditaracg.Text = "EDITAR ACG";
            this.bteditaracg.UseVisualStyleBackColor = false;
            this.bteditaracg.Click += new System.EventHandler(this.bteditaracgs_Click);
            // 
            // btcadastraracg
            // 
            this.btcadastraracg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btcadastraracg.BackColor = System.Drawing.Color.SteelBlue;
            this.btcadastraracg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcadastraracg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcadastraracg.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btcadastraracg.ForeColor = System.Drawing.Color.White;
            this.btcadastraracg.Location = new System.Drawing.Point(317, 153);
            this.btcadastraracg.Margin = new System.Windows.Forms.Padding(2);
            this.btcadastraracg.Name = "btcadastraracg";
            this.btcadastraracg.Size = new System.Drawing.Size(257, 59);
            this.btcadastraracg.TabIndex = 3;
            this.btcadastraracg.Text = "CADASTRAR ACG";
            this.btcadastraracg.UseVisualStyleBackColor = false;
            this.btcadastraracg.Click += new System.EventHandler(this.btcadastraracg_Click);
            // 
            // btverificarsituacao
            // 
            this.btverificarsituacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btverificarsituacao.BackColor = System.Drawing.Color.SteelBlue;
            this.btverificarsituacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btverificarsituacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btverificarsituacao.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btverificarsituacao.ForeColor = System.Drawing.Color.White;
            this.btverificarsituacao.Location = new System.Drawing.Point(51, 153);
            this.btverificarsituacao.Margin = new System.Windows.Forms.Padding(2);
            this.btverificarsituacao.Name = "btverificarsituacao";
            this.btverificarsituacao.Size = new System.Drawing.Size(257, 59);
            this.btverificarsituacao.TabIndex = 2;
            this.btverificarsituacao.Text = "VERIFICAR SITUAÇÃO";
            this.btverificarsituacao.UseVisualStyleBackColor = false;
            this.btverificarsituacao.Click += new System.EventHandler(this.btverificarsituacao_Click);
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
            this.lbsair.TabIndex = 6;
            this.lbsair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbsair.Click += new System.EventHandler(this.lbsair_Click);
            // 
            // btAlterarSenha
            // 
            this.btAlterarSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAlterarSenha.BackColor = System.Drawing.Color.SteelBlue;
            this.btAlterarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterarSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btAlterarSenha.ForeColor = System.Drawing.Color.White;
            this.btAlterarSenha.Image = ((System.Drawing.Image)(resources.GetObject("btAlterarSenha.Image")));
            this.btAlterarSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlterarSenha.Location = new System.Drawing.Point(249, 357);
            this.btAlterarSenha.Margin = new System.Windows.Forms.Padding(2);
            this.btAlterarSenha.Name = "btAlterarSenha";
            this.btAlterarSenha.Size = new System.Drawing.Size(126, 33);
            this.btAlterarSenha.TabIndex = 6;
            this.btAlterarSenha.Text = "ALTERAR SENHA";
            this.btAlterarSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAlterarSenha.UseVisualStyleBackColor = false;
            this.btAlterarSenha.Click += new System.EventHandler(this.btAlterarSenha_Click);
            // 
            // btRevisar
            // 
            this.btRevisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btRevisar.BackColor = System.Drawing.Color.SteelBlue;
            this.btRevisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRevisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRevisar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btRevisar.ForeColor = System.Drawing.Color.White;
            this.btRevisar.Location = new System.Drawing.Point(51, 289);
            this.btRevisar.Margin = new System.Windows.Forms.Padding(2);
            this.btRevisar.Name = "btRevisar";
            this.btRevisar.Size = new System.Drawing.Size(257, 59);
            this.btRevisar.TabIndex = 19;
            this.btRevisar.Text = "VALIDAR ENVIOS";
            this.btRevisar.UseVisualStyleBackColor = false;
            this.btRevisar.Click += new System.EventHandler(this.btRevisar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 540);
            this.Controls.Add(this.btRevisar);
            this.Controls.Add(this.btAlterarSenha);
            this.Controls.Add(this.lbsair);
            this.Controls.Add(this.btverificarsituacao);
            this.Controls.Add(this.btcadastraracg);
            this.Controls.Add(this.bteditaracg);
            this.Controls.Add(this.bteditaraluno);
            this.Controls.Add(this.btenviaracg);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1100, 579);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox1;
        internal Button btenviaracg;
        internal Button bteditaraluno;
        internal Button bteditaracg;
        internal Button btcadastraracg;
        internal Button btverificarsituacao;
        private Label lbsair;
        internal Button btAlterarSenha;
        internal Button btRevisar;
    }
}