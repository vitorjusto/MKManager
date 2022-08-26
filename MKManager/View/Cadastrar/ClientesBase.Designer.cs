namespace MKManager.View.Cadastrar
{
    partial class ClientesBase
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
            this.pnBase = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnBase
            // 
            this.pnBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBase.Location = new System.Drawing.Point(0, 0);
            this.pnBase.Name = "pnBase";
            this.pnBase.Size = new System.Drawing.Size(584, 561);
            this.pnBase.TabIndex = 0;
            // 
            // ClientesBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.pnBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientesBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ClientesBase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnBase;
    }
}