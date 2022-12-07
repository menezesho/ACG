namespace projeto_acg
{
    partial class FormRelatorioAluno
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioAluno));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bD_ACGDataSet = new projeto_acg.BD_ACGDataSet();
            this.aLUNOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLUNOTableAdapter = new projeto_acg.BD_ACGDataSetTableAdapters.ALUNOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ACGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUNOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.aLUNOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "projeto_acg.relatorio-alunos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1084, 540);
            this.reportViewer1.TabIndex = 0;
            // 
            // bD_ACGDataSet
            // 
            this.bD_ACGDataSet.DataSetName = "BD_ACGDataSet";
            this.bD_ACGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLUNOBindingSource
            // 
            this.aLUNOBindingSource.DataMember = "ALUNO";
            this.aLUNOBindingSource.DataSource = this.bD_ACGDataSet;
            // 
            // aLUNOTableAdapter
            // 
            this.aLUNOTableAdapter.ClearBeforeFill = true;
            // 
            // FormRelatorioAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 540);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 579);
            this.Name = "FormRelatorioAluno";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.FormRelatorioAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_ACGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUNOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BD_ACGDataSet bD_ACGDataSet;
        private System.Windows.Forms.BindingSource aLUNOBindingSource;
        private BD_ACGDataSetTableAdapters.ALUNOTableAdapter aLUNOTableAdapter;
    }
}