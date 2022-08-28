namespace UI
{
    partial class frmCadastro
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
            this.ucsCadastro = new UI.ucsCadastro();
            this.SuspendLayout();
            // 
            // ucsCadastro
            // 
            this.ucsCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucsCadastro.Location = new System.Drawing.Point(0, 0);
            this.ucsCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.ucsCadastro.Name = "ucsCadastro";
            this.ucsCadastro.Size = new System.Drawing.Size(301, 335);
            this.ucsCadastro.TabIndex = 0;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 335);
            this.Controls.Add(this.ucsCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastro";
            this.Text = "frmCadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public ucsCadastro ucsCadastro;
    }
}