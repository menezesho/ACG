namespace projeto_acg
{
    partial class FormRelatorioAcg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioAcg));
            this.aCGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_ACGDataSet = new projeto_acg.BD_ACGDataSet();
            this.aCGTableAdapter = new projeto_acg.BD_ACGDataSetTableAdapters.ACGTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ALUNOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLUNOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aLUNOTableAdapter = new projeto_acg.BD_ACGDataSetTableAdapters.ALUNOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.aCGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ACGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALUNOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUNOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // aCGBindingSource
            // 
            this.aCGBindingSource.DataMember = "ACG";
            this.aCGBindingSource.DataSource = this.bD_ACGDataSet;
            // 
            // bD_ACGDataSet
            // 
            this.bD_ACGDataSet.DataSetName = "BD_ACGDataSet";
            this.bD_ACGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCGTableAdapter
            // 
            this.aCGTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.aCGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "projeto_acg.relatorio-acgs.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1084, 540);
            this.reportViewer1.TabIndex = 0;
            // 
            // ALUNOBindingSource
            // 
            this.ALUNOBindingSource.DataMember = "ALUNO";
            this.ALUNOBindingSource.DataSource = this.bD_ACGDataSet;
            // 
            // aLUNOBindingSource1
            // 
            this.aLUNOBindingSource1.DataMember = "ALUNO";
            this.aLUNOBindingSource1.DataSource = this.bD_ACGDataSet;
            // 
            // aLUNOTableAdapter
            // 
            this.aLUNOTableAdapter.ClearBeforeFill = true;
            // 
            // FormRelatorioAcg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 540);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 579);
            this.Name = "FormRelatorioAcg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.FormRelatorioAcg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aCGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ACGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALUNOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUNOBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BD_ACGDataSet bD_ACGDataSet;
        private System.Windows.Forms.BindingSource aCGBindingSource;
        private BD_ACGDataSetTableAdapters.ACGTableAdapter aCGTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ALUNOBindingSource;
        private System.Windows.Forms.BindingSource aLUNOBindingSource1;
        private BD_ACGDataSetTableAdapters.ALUNOTableAdapter aLUNOTableAdapter;
    }
}