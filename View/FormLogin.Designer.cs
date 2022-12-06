using System.Windows.Forms;

namespace projeto_acg
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.tbsenha = new System.Windows.Forms.TextBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.lbsenha = new System.Windows.Forms.Label();
            this.lbmatricula = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtbmatricula = new System.Windows.Forms.MaskedTextBox();
            this.lbinfo = new System.Windows.Forms.Label();
            this.lbprimeiroacesso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbsenha
            // 
            this.tbsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbsenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbsenha.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.tbsenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbsenha.Location = new System.Drawing.Point(114, 288);
            this.tbsenha.Margin = new System.Windows.Forms.Padding(2);
            this.tbsenha.MaxLength = 30;
            this.tbsenha.Name = "tbsenha";
            this.tbsenha.Size = new System.Drawing.Size(237, 32);
            this.tbsenha.TabIndex = 2;
            this.tbsenha.UseSystemPasswordChar = true;
            // 
            // btlogin
            // 
            this.btlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btlogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlogin.FlatAppearance.BorderSize = 2;
            this.btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogin.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btlogin.ForeColor = System.Drawing.Color.GhostWhite;
            this.btlogin.Location = new System.Drawing.Point(114, 344);
            this.btlogin.Margin = new System.Windows.Forms.Padding(2);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(237, 40);
            this.btlogin.TabIndex = 0;
            this.btlogin.Text = "LOGIN";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // lbsenha
            // 
            this.lbsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbsenha.AutoSize = true;
            this.lbsenha.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbsenha.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbsenha.Location = new System.Drawing.Point(114, 261);
            this.lbsenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbsenha.Name = "lbsenha";
            this.lbsenha.Size = new System.Drawing.Size(64, 25);
            this.lbsenha.TabIndex = 10;
            this.lbsenha.Text = "Senha";
            // 
            // lbmatricula
            // 
            this.lbmatricula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbmatricula.AutoSize = true;
            this.lbmatricula.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbmatricula.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbmatricula.Location = new System.Drawing.Point(114, 200);
            this.lbmatricula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmatricula.Name = "lbmatricula";
            this.lbmatricula.Size = new System.Drawing.Size(94, 25);
            this.lbmatricula.TabIndex = 8;
            this.lbmatricula.Text = "Matrícula";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // mtbmatricula
            // 
            this.mtbmatricula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbmatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbmatricula.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mtbmatricula.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.mtbmatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtbmatricula.Location = new System.Drawing.Point(114, 227);
            this.mtbmatricula.Margin = new System.Windows.Forms.Padding(2);
            this.mtbmatricula.Mask = "00-00000";
            this.mtbmatricula.Name = "mtbmatricula";
            this.mtbmatricula.Size = new System.Drawing.Size(237, 32);
            this.mtbmatricula.TabIndex = 1;
            this.mtbmatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbmatricula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbmatricula.Enter += new System.EventHandler(this.mtbmatricula_Enter);
            this.mtbmatricula.Leave += new System.EventHandler(this.mtbmatricula_Leave);
            // 
            // lbinfo
            // 
            this.lbinfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbinfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbinfo.Location = new System.Drawing.Point(114, 396);
            this.lbinfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbinfo.Name = "lbinfo";
            this.lbinfo.Size = new System.Drawing.Size(237, 18);
            this.lbinfo.TabIndex = 18;
            this.lbinfo.Text = "Ainda não possui um cadastro?";
            this.lbinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbprimeiroacesso
            // 
            this.lbprimeiroacesso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbprimeiroacesso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbprimeiroacesso.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbprimeiroacesso.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbprimeiroacesso.Location = new System.Drawing.Point(114, 416);
            this.lbprimeiroacesso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbprimeiroacesso.Name = "lbprimeiroacesso";
            this.lbprimeiroacesso.Size = new System.Drawing.Size(237, 27);
            this.lbprimeiroacesso.TabIndex = 1;
            this.lbprimeiroacesso.Text = "Primeiro acesso!";
            this.lbprimeiroacesso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbprimeiroacesso.Click += new System.EventHandler(this.btprimeiroacesso_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 540);
            this.Controls.Add(this.lbinfo);
            this.Controls.Add(this.lbprimeiroacesso);
            this.Controls.Add(this.mtbmatricula);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbsenha);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.lbsenha);
            this.Controls.Add(this.lbmatricula);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(483, 579);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbsenha;
        private Button btlogin;
        private Label lbsenha;
        private Label lbmatricula;
        private PictureBox pictureBox1;
        private MaskedTextBox mtbmatricula;
        private Label lbinfo;
        private Label lbprimeiroacesso;
    }
}