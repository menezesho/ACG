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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbsair = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbcadastro
            // 
            this.lbcadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcadastro.AutoSize = true;
            this.lbcadastro.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbcadastro.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbcadastro.Location = new System.Drawing.Point(183, 106);
            this.lbcadastro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcadastro.Name = "lbcadastro";
            this.lbcadastro.Size = new System.Drawing.Size(294, 37);
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
            this.tbNome.ForeColor = System.Drawing.Color.DimGray;
            this.tbNome.Location = new System.Drawing.Point(182, 206);
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
            this.lbsituacao.Location = new System.Drawing.Point(133, 395);
            this.lbsituacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbsituacao.Name = "lbsituacao";
            this.lbsituacao.Size = new System.Drawing.Size(394, 33);
            this.lbsituacao.TabIndex = 33;
            this.lbsituacao.Text = "Situação: ";
            this.lbsituacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbhorasfaltantes
            // 
            this.lbhorasfaltantes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbhorasfaltantes.AutoSize = true;
            this.lbhorasfaltantes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbhorasfaltantes.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbhorasfaltantes.Location = new System.Drawing.Point(184, 319);
            this.lbhorasfaltantes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbhorasfaltantes.Name = "lbhorasfaltantes";
            this.lbhorasfaltantes.Size = new System.Drawing.Size(67, 21);
            this.lbhorasfaltantes.TabIndex = 34;
            this.lbhorasfaltantes.Text = "Faltante";
            // 
            // lbhorastotais
            // 
            this.lbhorastotais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbhorastotais.AutoSize = true;
            this.lbhorastotais.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbhorastotais.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbhorastotais.Location = new System.Drawing.Point(184, 251);
            this.lbhorastotais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbhorastotais.Name = "lbhorastotais";
            this.lbhorastotais.Size = new System.Drawing.Size(45, 21);
            this.lbhorastotais.TabIndex = 35;
            this.lbhorastotais.Text = "Total";
            // 
            // lbnome
            // 
            this.lbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbnome.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbnome.Location = new System.Drawing.Point(184, 183);
            this.lbnome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(55, 21);
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
            this.tbhorastotais.ForeColor = System.Drawing.Color.DimGray;
            this.tbhorastotais.Location = new System.Drawing.Point(182, 274);
            this.tbhorastotais.Margin = new System.Windows.Forms.Padding(2);
            this.tbhorastotais.Name = "tbhorastotais";
            this.tbhorastotais.Size = new System.Drawing.Size(297, 29);
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
            this.tbhorasfaltantes.ForeColor = System.Drawing.Color.DimGray;
            this.tbhorasfaltantes.Location = new System.Drawing.Point(182, 342);
            this.tbhorasfaltantes.Margin = new System.Windows.Forms.Padding(2);
            this.tbhorasfaltantes.Name = "tbhorasfaltantes";
            this.tbhorasfaltantes.Size = new System.Drawing.Size(297, 29);
            this.tbhorasfaltantes.TabIndex = 2;
            this.tbhorasfaltantes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(523, 106);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
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
            this.lbsair.TabIndex = 39;
            this.lbsair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbsair.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // FormVerificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 540);
            this.Controls.Add(this.lbsituacao);
            this.Controls.Add(this.lbsair);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbhorasfaltantes);
            this.Controls.Add(this.tbhorastotais);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.lbhorastotais);
            this.Controls.Add(this.lbhorasfaltantes);
            this.Controls.Add(this.lbcadastro);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1100, 579);
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
        private PictureBox pictureBox1;
        private Label lbsair;
    }
}