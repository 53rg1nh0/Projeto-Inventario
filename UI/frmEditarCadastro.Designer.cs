namespace UI
{
    partial class frmEditarCadastro
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
            this.ucsCadastro1 = new UI.ucsCadastro();
            this.SuspendLayout();
            // 
            // ucsCadastro1
            // 
            this.ucsCadastro1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucsCadastro1.Location = new System.Drawing.Point(0, 0);
            this.ucsCadastro1.Name = "ucsCadastro1";
            this.ucsCadastro1.Size = new System.Drawing.Size(898, 267);
            this.ucsCadastro1.TabIndex = 0;
            this.ucsCadastro1.Unidades = null;
            // 
            // frmEditarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 267);
            this.Controls.Add(this.ucsCadastro1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarCadastro";
            this.Text = "frmEditarCadastro";
            this.Load += new System.EventHandler(this.frmEditarCadastro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucsCadastro ucsCadastro1;
    }
}