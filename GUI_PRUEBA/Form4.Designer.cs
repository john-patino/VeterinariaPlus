namespace GUI_PRUEBA
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.visorPdf = new AxAcroPDFLib.AxAcroPDF();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visorPdf)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.visorPdf);
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 413);
            this.panel1.TabIndex = 0;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(26, 6);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(95, 35);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir Pdf";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // visorPdf
            // 
            this.visorPdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visorPdf.Enabled = true;
            this.visorPdf.Location = new System.Drawing.Point(0, 0);
            this.visorPdf.Name = "visorPdf";
            this.visorPdf.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("visorPdf.OcxState")));
            this.visorPdf.Size = new System.Drawing.Size(808, 413);
            this.visorPdf.TabIndex = 0;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visorPdf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AxAcroPDFLib.AxAcroPDF visorPdf;
        private System.Windows.Forms.Button btnAbrir;
    }
}