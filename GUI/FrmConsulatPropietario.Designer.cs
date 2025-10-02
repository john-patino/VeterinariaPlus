namespace GUI
{
    partial class FrmConsulatPropietario
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
            this.dgvPropieatrios = new System.Windows.Forms.DataGridView();
            this.grilla2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropieatrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPropieatrios
            // 
            this.dgvPropieatrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropieatrios.Location = new System.Drawing.Point(55, 34);
            this.dgvPropieatrios.Name = "dgvPropieatrios";
            this.dgvPropieatrios.RowHeadersWidth = 51;
            this.dgvPropieatrios.RowTemplate.Height = 24;
            this.dgvPropieatrios.Size = new System.Drawing.Size(652, 193);
            this.dgvPropieatrios.TabIndex = 0;
            // 
            // grilla2
            // 
            this.grilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.grilla2.Location = new System.Drawing.Point(55, 245);
            this.grilla2.Name = "grilla2";
            this.grilla2.RowHeadersWidth = 51;
            this.grilla2.RowTemplate.Height = 24;
            this.grilla2.Size = new System.Drawing.Size(652, 193);
            this.grilla2.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombres";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telefono";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // FrmConsulatPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grilla2);
            this.Controls.Add(this.dgvPropieatrios);
            this.Name = "FrmConsulatPropietario";
            this.Text = "FrmConsulatPropietario";
            this.Load += new System.EventHandler(this.FrmConsulatPropietario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropieatrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPropieatrios;
        private System.Windows.Forms.DataGridView grilla2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}