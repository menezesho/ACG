namespace projeto_acg
{
    partial class FormRevisao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRevisao));
            this.dgenvio = new System.Windows.Forms.DataGridView();
            this.tbAluno = new System.Windows.Forms.TextBox();
            this.lbnome = new System.Windows.Forms.Label();
            this.tbAcg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbsair = new System.Windows.Forms.Label();
            this.btAceitar = new System.Windows.Forms.Button();
            this.btRecusar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbtodos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgenvio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgenvio
            // 
            this.dgenvio.AllowUserToAddRows = false;
            this.dgenvio.AllowUserToDeleteRows = false;
            this.dgenvio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgenvio.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgenvio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgenvio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgenvio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgenvio.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgenvio.Location = new System.Drawing.Point(99, 62);
            this.dgenvio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgenvio.MultiSelect = false;
            this.dgenvio.Name = "dgenvio";
            this.dgenvio.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgenvio.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgenvio.RowHeadersVisible = false;
            this.dgenvio.RowHeadersWidth = 51;
            this.dgenvio.RowTemplate.Height = 29;
            this.dgenvio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgenvio.Size = new System.Drawing.Size(859, 539);
            this.dgenvio.TabIndex = 12;
            this.dgenvio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgenvio_CellClick);
            // 
            // tbAluno
            // 
            this.tbAluno.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbAluno.BackColor = System.Drawing.Color.White;
            this.tbAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAluno.Enabled = false;
            this.tbAluno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbAluno.Location = new System.Drawing.Point(1025, 358);
            this.tbAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAluno.MaxLength = 50;
            this.tbAluno.Name = "tbAluno";
            this.tbAluno.Size = new System.Drawing.Size(309, 29);
            this.tbAluno.TabIndex = 51;
            // 
            // lbnome
            // 
            this.lbnome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbnome.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbnome.Location = new System.Drawing.Point(1028, 330);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(53, 21);
            this.lbnome.TabIndex = 53;
            this.lbnome.Text = "Aluno";
            // 
            // tbAcg
            // 
            this.tbAcg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbAcg.BackColor = System.Drawing.Color.White;
            this.tbAcg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAcg.Enabled = false;
            this.tbAcg.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbAcg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbAcg.Location = new System.Drawing.Point(1025, 442);
            this.tbAcg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAcg.MaxLength = 50;
            this.tbAcg.Name = "tbAcg";
            this.tbAcg.Size = new System.Drawing.Size(309, 29);
            this.tbAcg.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(1028, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 56;
            this.label1.Text = "ACG";
            // 
            // lbsair
            // 
            this.lbsair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbsair.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.lbsair.ForeColor = System.Drawing.SystemColors.Control;
            this.lbsair.Image = ((System.Drawing.Image)(resources.GetObject("lbsair.Image")));
            this.lbsair.Location = new System.Drawing.Point(1377, 604);
            this.lbsair.Name = "lbsair";
            this.lbsair.Size = new System.Drawing.Size(53, 49);
            this.lbsair.TabIndex = 57;
            this.lbsair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbsair.Click += new System.EventHandler(this.lbsair_Click);
            // 
            // btAceitar
            // 
            this.btAceitar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btAceitar.BackColor = System.Drawing.Color.SteelBlue;
            this.btAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAceitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAceitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAceitar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btAceitar.ForeColor = System.Drawing.Color.White;
            this.btAceitar.Image = ((System.Drawing.Image)(resources.GetObject("btAceitar.Image")));
            this.btAceitar.Location = new System.Drawing.Point(1184, 506);
            this.btAceitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAceitar.Name = "btAceitar";
            this.btAceitar.Size = new System.Drawing.Size(151, 58);
            this.btAceitar.TabIndex = 60;
            this.btAceitar.UseVisualStyleBackColor = false;
            this.btAceitar.Click += new System.EventHandler(this.btAceitar_Click);
            // 
            // btRecusar
            // 
            this.btRecusar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btRecusar.BackColor = System.Drawing.Color.GhostWhite;
            this.btRecusar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRecusar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRecusar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btRecusar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btRecusar.Image = ((System.Drawing.Image)(resources.GetObject("btRecusar.Image")));
            this.btRecusar.Location = new System.Drawing.Point(1025, 506);
            this.btRecusar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRecusar.Name = "btRecusar";
            this.btRecusar.Size = new System.Drawing.Size(151, 58);
            this.btRecusar.TabIndex = 59;
            this.btRecusar.UseVisualStyleBackColor = false;
            this.btRecusar.Click += new System.EventHandler(this.btRecusar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1025, 156);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // lbtodos
            // 
            this.lbtodos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbtodos.AutoSize = true;
            this.lbtodos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbtodos.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbtodos.Location = new System.Drawing.Point(1025, 98);
            this.lbtodos.Name = "lbtodos";
            this.lbtodos.Size = new System.Drawing.Size(232, 37);
            this.lbtodos.TabIndex = 70;
            this.lbtodos.Text = "REVISAR ENVIOS";
            this.lbtodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormRevisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 665);
            this.Controls.Add(this.lbtodos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btAceitar);
            this.Controls.Add(this.btRecusar);
            this.Controls.Add(this.lbsair);
            this.Controls.Add(this.tbAcg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAluno);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.dgenvio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRevisao";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revisão";
            this.Load += new System.EventHandler(this.FormRevisao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgenvio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgenvio;
        private System.Windows.Forms.TextBox tbAluno;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.TextBox tbAcg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbsair;
        internal System.Windows.Forms.Button btAceitar;
        internal System.Windows.Forms.Button btRecusar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbtodos;
    }
}