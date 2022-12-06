using System.Windows.Forms;

namespace projeto_acg
{
    partial class FormVerificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerificar));
            this.lbcadastro = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbsituacao = new System.Windows.Forms.Label();
            this.lbhorasfaltantes = new System.Windows.Forms.Label();
            this.lbhorastotais = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.tbhorastotais = new System.Windows.Forms.TextBox();
            this.tbhorasfaltantes = new System.Windows.Forms.TextBox();
            this.btFechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbcadastro
            // 
            this.lbcadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcadastro.AutoSize = true;
            this.lbcadastro.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbcadastro.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbcadastro.Location = new System.Drawing.Point(122, 82);
            this.lbcadastro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcadastro.Name = "lbcadastro";
            this.lbcadastro.Size = new System.Drawing.Size(260, 32);
            this.lbcadastro.TabIndex = 25;
            this.lbcadastro.Text = "VERIFICAR SITUAÇÃO";
            this.lbcadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNome.BackColor = System.Drawing.Color.White;
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNome.Enabled = false;
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNome.Location = new System.Drawing.Point(104, 161);
            this.tbNome.Margin = new System.Windows.Forms.Padding(2);
            this.tbNome.MaxLength = 50;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(297, 29);
            this.tbNome.TabIndex = 0;
            this.tbNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbsituacao
            // 
            this.lbsituacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbsituacao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbsituacao.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbsituacao.Location = new System.Drawing.Point(79, 270);
            this.lbsituacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbsituacao.Name = "lbsituacao";
            this.lbsituacao.Size = new System.Drawing.Size(347, 33);
            this.lbsituacao.TabIndex = 33;
            this.lbsituacao.Text = "Situação: ";
            this.lbsituacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbhorasfaltantes
            // 
            this.lbhorasfaltantes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbhorasfaltantes.AutoSize = true;
            this.lbhorasfaltantes.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lbhorasfaltantes.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbhorasfaltantes.Location = new System.Drawing.Point(308, 202);
            this.lbhorasfaltantes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbhorasfaltantes.Name = "lbhorasfaltantes";
            this.lbhorasfaltantes.Size = new System.Drawing.Size(81, 25);
            this.lbhorasfaltantes.TabIndex = 34;
            this.lbhorasfaltantes.Text = "Faltante";
            // 
            // lbhorastotais
            // 
            this.lbhorastotais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbhorastotais.AutoSize = true;
            this.lbhorastotais.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lbhorastotais.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbhorastotais.Location = new System.Drawing.Point(130, 202);
            this.lbhorastotais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbhorastotais.Name = "lbhorastotais";
            this.lbhorastotais.Size = new System.Drawing.Size(53, 25);
            this.lbhorastotais.TabIndex = 35;
            this.lbhorastotais.Text = "Total";
            // 
            // lbnome
            // 
            this.lbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lbnome.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbnome.Location = new System.Drawing.Point(220, 134);
            this.lbnome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(65, 25);
            this.lbnome.TabIndex = 36;
            this.lbnome.Text = "Nome";
            // 
            // tbhorastotais
            // 
            this.tbhorastotais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbhorastotais.BackColor = System.Drawing.Color.White;
            this.tbhorastotais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbhorastotais.Enabled = false;
            this.tbhorastotais.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbhorastotais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbhorastotais.Location = new System.Drawing.Point(104, 229);
            this.tbhorastotais.Margin = new System.Windows.Forms.Padding(2);
            this.tbhorastotais.Name = "tbhorastotais";
            this.tbhorastotais.Size = new System.Drawing.Size(105, 29);
            this.tbhorastotais.TabIndex = 1;
            this.tbhorastotais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbhorasfaltantes
            // 
            this.tbhorasfaltantes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbhorasfaltantes.BackColor = System.Drawing.Color.White;
            this.tbhorasfaltantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbhorasfaltantes.Enabled = false;
            this.tbhorasfaltantes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbhorasfaltantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbhorasfaltantes.Location = new System.Drawing.Point(296, 229);
            this.tbhorasfaltantes.Margin = new System.Windows.Forms.Padding(2);
            this.tbhorasfaltantes.Name = "tbhorasfaltantes";
            this.tbhorasfaltantes.Size = new System.Drawing.Size(105, 29);
            this.tbhorasfaltantes.TabIndex = 2;
            this.tbhorasfaltantes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btFechar
            // 
            this.btFechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btFechar.BackColor = System.Drawing.Color.SteelBlue;
            this.btFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btFechar.ForeColor = System.Drawing.Color.White;
            this.btFechar.Location = new System.Drawing.Point(104, 354);
            this.btFechar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(297, 32);
            this.btFechar.TabIndex = 3;
            this.btFechar.Text = "FECHAR";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(445, 82);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btGerarRelatorio.BackColor = System.Drawing.Color.GhostWhite;
            this.btGerarRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGerarRelatorio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btGerarRelatorio.ForeColor = System.Drawing.Color.SteelBlue;
            this.btGerarRelatorio.Location = new System.Drawing.Point(104, 316);
            this.btGerarRelatorio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Size = new System.Drawing.Size(297, 32);
            this.btGerarRelatorio.TabIndex = 38;
            this.btGerarRelatorio.Text = "GERAR RELATÓRIO";
            this.btGerarRelatorio.UseVisualStyleBackColor = false;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // FormVerificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 468);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btGerarRelatorio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbhorasfaltantes);
            this.Controls.Add(this.tbhorastotais);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.lbhorastotais);
            this.Controls.Add(this.lbhorasfaltantes);
            this.Controls.Add(this.lbsituacao);
            this.Controls.Add(this.lbcadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(945, 507);
            this.Name = "FormVerificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Situação";
            this.Load += new System.EventHandler(this.FormVerificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbcadastro;
        private TextBox tbNome;
        private Label lbsituacao;
        private Label lbhorasfaltantes;
        private Label lbhorastotais;
        private Label lbnome;
        private TextBox tbhorastotais;
        private TextBox tbhorasfaltantes;
        private Button btFechar;
        private PictureBox pictureBox1;
        private Button btGerarRelatorio;
    }
}