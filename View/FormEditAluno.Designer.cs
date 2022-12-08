using System.Windows.Forms;

namespace projeto_acg
{
    partial class FormEditAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditAluno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btcancelar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.lbid = new System.Windows.Forms.Label();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.lbnome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbsenha = new System.Windows.Forms.TextBox();
            this.lbsenha = new System.Windows.Forms.Label();
            this.mtbmatricula = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.bteditar = new System.Windows.Forms.Button();
            this.dgalunos = new System.Windows.Forms.DataGridView();
            this.lbtodos = new System.Windows.Forms.Label();
            this.lbsair = new System.Windows.Forms.Label();
            this.lbbuscar = new System.Windows.Forms.Label();
            this.tbbusca = new System.Windows.Forms.TextBox();
            this.btrelatorio = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgalunos)).BeginInit();
            this.SuspendLayout();
            // 
            // btcancelar
            // 
            this.btcancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btcancelar.BackColor = System.Drawing.Color.GhostWhite;
            this.btcancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btcancelar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btcancelar.Location = new System.Drawing.Point(157, 380);
            this.btcancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(213, 32);
            this.btcancelar.TabIndex = 7;
            this.btcancelar.Text = "CANCELAR";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabControl1.Location = new System.Drawing.Point(45, 108);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(329, 248);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.tbemail);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbid);
            this.tabPage1.Controls.Add(this.lbid);
            this.tabPage1.Controls.Add(this.tbnome);
            this.tabPage1.Controls.Add(this.lbnome);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(321, 214);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            // 
            // tbemail
            // 
            this.tbemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbemail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbemail.Location = new System.Drawing.Point(21, 170);
            this.tbemail.Margin = new System.Windows.Forms.Padding(2);
            this.tbemail.MaxLength = 50;
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(279, 29);
            this.tbemail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(22, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-mail Institucional";
            // 
            // tbid
            // 
            this.tbid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbid.Enabled = false;
            this.tbid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbid.Location = new System.Drawing.Point(145, 34);
            this.tbid.Margin = new System.Windows.Forms.Padding(2);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(30, 29);
            this.tbid.TabIndex = 2;
            this.tbid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbid
            // 
            this.lbid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbid.ForeColor = System.Drawing.Color.DimGray;
            this.lbid.Location = new System.Drawing.Point(149, 11);
            this.lbid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(26, 21);
            this.lbid.TabIndex = 3;
            this.lbid.Text = "ID";
            // 
            // tbnome
            // 
            this.tbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbnome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbnome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbnome.Location = new System.Drawing.Point(21, 102);
            this.tbnome.Margin = new System.Windows.Forms.Padding(2);
            this.tbnome.MaxLength = 50;
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(279, 29);
            this.tbnome.TabIndex = 1;
            // 
            // lbnome
            // 
            this.lbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbnome.ForeColor = System.Drawing.Color.DimGray;
            this.lbnome.Location = new System.Drawing.Point(22, 79);
            this.lbnome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(55, 21);
            this.lbnome.TabIndex = 0;
            this.lbnome.Text = "Nome";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Controls.Add(this.tbsenha);
            this.tabPage2.Controls.Add(this.lbsenha);
            this.tabPage2.Controls.Add(this.mtbmatricula);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(321, 214);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Institucional";
            // 
            // tbsenha
            // 
            this.tbsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbsenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbsenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbsenha.Location = new System.Drawing.Point(21, 136);
            this.tbsenha.Margin = new System.Windows.Forms.Padding(2);
            this.tbsenha.MaxLength = 30;
            this.tbsenha.Name = "tbsenha";
            this.tbsenha.Size = new System.Drawing.Size(279, 29);
            this.tbsenha.TabIndex = 4;
            this.tbsenha.UseSystemPasswordChar = true;
            // 
            // lbsenha
            // 
            this.lbsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbsenha.AutoSize = true;
            this.lbsenha.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbsenha.ForeColor = System.Drawing.Color.DimGray;
            this.lbsenha.Location = new System.Drawing.Point(22, 114);
            this.lbsenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbsenha.Name = "lbsenha";
            this.lbsenha.Size = new System.Drawing.Size(54, 21);
            this.lbsenha.TabIndex = 8;
            this.lbsenha.Text = "Senha";
            // 
            // mtbmatricula
            // 
            this.mtbmatricula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbmatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbmatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtbmatricula.Location = new System.Drawing.Point(21, 68);
            this.mtbmatricula.Margin = new System.Windows.Forms.Padding(2);
            this.mtbmatricula.Mask = "00-00000";
            this.mtbmatricula.Name = "mtbmatricula";
            this.mtbmatricula.Size = new System.Drawing.Size(105, 29);
            this.mtbmatricula.TabIndex = 3;
            this.mtbmatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbmatricula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbmatricula.Enter += new System.EventHandler(this.mtbmatricula_Enter);
            this.mtbmatricula.Leave += new System.EventHandler(this.mtbmatricula_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Matrícula";
            // 
            // btexcluir
            // 
            this.btexcluir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btexcluir.BackColor = System.Drawing.Color.GhostWhite;
            this.btexcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btexcluir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btexcluir.ForeColor = System.Drawing.Color.SteelBlue;
            this.btexcluir.Image = ((System.Drawing.Image)(resources.GetObject("btexcluir.Image")));
            this.btexcluir.Location = new System.Drawing.Point(49, 380);
            this.btexcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(50, 68);
            this.btexcluir.TabIndex = 5;
            this.btexcluir.UseVisualStyleBackColor = false;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btsalvar.BackColor = System.Drawing.Color.SteelBlue;
            this.btsalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btsalvar.ForeColor = System.Drawing.Color.White;
            this.btsalvar.Location = new System.Drawing.Point(157, 416);
            this.btsalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(213, 32);
            this.btsalvar.TabIndex = 9;
            this.btsalvar.Text = "SALVAR";
            this.btsalvar.UseVisualStyleBackColor = false;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // bteditar
            // 
            this.bteditar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bteditar.BackColor = System.Drawing.Color.GhostWhite;
            this.bteditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bteditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bteditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bteditar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.bteditar.ForeColor = System.Drawing.Color.SteelBlue;
            this.bteditar.Image = ((System.Drawing.Image)(resources.GetObject("bteditar.Image")));
            this.bteditar.Location = new System.Drawing.Point(103, 380);
            this.bteditar.Margin = new System.Windows.Forms.Padding(2);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(50, 68);
            this.bteditar.TabIndex = 6;
            this.bteditar.UseVisualStyleBackColor = false;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click_1);
            // 
            // dgalunos
            // 
            this.dgalunos.AllowUserToAddRows = false;
            this.dgalunos.AllowUserToDeleteRows = false;
            this.dgalunos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgalunos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgalunos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgalunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgalunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgalunos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgalunos.Location = new System.Drawing.Point(403, 143);
            this.dgalunos.Margin = new System.Windows.Forms.Padding(2);
            this.dgalunos.MultiSelect = false;
            this.dgalunos.Name = "dgalunos";
            this.dgalunos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgalunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgalunos.RowHeadersVisible = false;
            this.dgalunos.RowHeadersWidth = 51;
            this.dgalunos.RowTemplate.Height = 29;
            this.dgalunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgalunos.Size = new System.Drawing.Size(628, 341);
            this.dgalunos.TabIndex = 11;
            this.dgalunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgalunos_CellClick);
            // 
            // lbtodos
            // 
            this.lbtodos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbtodos.AutoSize = true;
            this.lbtodos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbtodos.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbtodos.Location = new System.Drawing.Point(560, 49);
            this.lbtodos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtodos.Name = "lbtodos";
            this.lbtodos.Size = new System.Drawing.Size(315, 37);
            this.lbtodos.TabIndex = 27;
            this.lbtodos.Text = "TODOS OS CADASTROS";
            this.lbtodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lbsair.TabIndex = 9;
            this.lbsair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbsair.Click += new System.EventHandler(this.lbsair_Click);
            // 
            // lbbuscar
            // 
            this.lbbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbbuscar.AutoSize = true;
            this.lbbuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbbuscar.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbbuscar.Location = new System.Drawing.Point(404, 111);
            this.lbbuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbbuscar.Name = "lbbuscar";
            this.lbbuscar.Size = new System.Drawing.Size(52, 21);
            this.lbbuscar.TabIndex = 59;
            this.lbbuscar.Text = "Busca";
            // 
            // tbbusca
            // 
            this.tbbusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbbusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbbusca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbbusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbbusca.Location = new System.Drawing.Point(461, 108);
            this.tbbusca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbbusca.MaxLength = 100;
            this.tbbusca.Name = "tbbusca";
            this.tbbusca.Size = new System.Drawing.Size(570, 29);
            this.tbbusca.TabIndex = 10;
            this.tbbusca.TextChanged += new System.EventHandler(this.tbbusca_TextChanged);
            // 
            // btrelatorio
            // 
            this.btrelatorio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btrelatorio.BackColor = System.Drawing.Color.SteelBlue;
            this.btrelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btrelatorio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btrelatorio.ForeColor = System.Drawing.Color.White;
            this.btrelatorio.Location = new System.Drawing.Point(49, 452);
            this.btrelatorio.Margin = new System.Windows.Forms.Padding(2);
            this.btrelatorio.Name = "btrelatorio";
            this.btrelatorio.Size = new System.Drawing.Size(321, 32);
            this.btrelatorio.TabIndex = 8;
            this.btrelatorio.Text = "GERAR RELATÓRIO";
            this.btrelatorio.UseVisualStyleBackColor = false;
            this.btrelatorio.Click += new System.EventHandler(this.btRelatorio_Click);
            // 
            // FormEditAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 540);
            this.Controls.Add(this.btrelatorio);
            this.Controls.Add(this.lbbuscar);
            this.Controls.Add(this.tbbusca);
            this.Controls.Add(this.lbsair);
            this.Controls.Add(this.lbtodos);
            this.Controls.Add(this.dgalunos);
            this.Controls.Add(this.bteditar);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btsalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1100, 579);
            this.Name = "FormEditAluno";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes";
            this.Load += new System.EventHandler(this.FormEditAluno_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgalunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox tbnome;
        private Label lbnome;
        private TabPage tabPage2;
        private TextBox tbsenha;
        private Label lbsenha;
        private MaskedTextBox mtbmatricula;
        private Label label1;
        private DataGridView dgalunos;
        private Label lbtodos;
        private TextBox tbid;
        private Label lbid;
        internal Button btcancelar;
        internal Button btexcluir;
        internal Button btsalvar;
        internal Button bteditar;
        private TextBox tbemail;
        private Label label3;
        private Label lbsair;
        private Label lbbuscar;
        private TextBox tbbusca;
        internal Button btrelatorio;
    }
}