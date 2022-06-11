namespace MKManager.View
{
    partial class TelaPrincipal
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
            this.barraDeProgressoVendas = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBomDiaBoaTardeBoaNoite = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraDeProgressoVendas
            // 
            this.barraDeProgressoVendas.AnimationSpeed = 5F;
            this.barraDeProgressoVendas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.barraDeProgressoVendas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.barraDeProgressoVendas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barraDeProgressoVendas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.barraDeProgressoVendas.Location = new System.Drawing.Point(67, 50);
            this.barraDeProgressoVendas.Minimum = 0;
            this.barraDeProgressoVendas.Name = "barraDeProgressoVendas";
            this.barraDeProgressoVendas.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.barraDeProgressoVendas.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.barraDeProgressoVendas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.barraDeProgressoVendas.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.barraDeProgressoVendas.Size = new System.Drawing.Size(135, 135);
            this.barraDeProgressoVendas.TabIndex = 1;
            this.barraDeProgressoVendas.Value = 40;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.barraDeProgressoVendas);
            this.guna2Panel1.Location = new System.Drawing.Point(15, 103);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(267, 200);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(18, 5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(228, 32);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Meta de Vendas no mês";
            // 
            // lblBomDiaBoaTardeBoaNoite
            // 
            this.lblBomDiaBoaTardeBoaNoite.BackColor = System.Drawing.Color.Transparent;
            this.lblBomDiaBoaTardeBoaNoite.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBomDiaBoaTardeBoaNoite.Location = new System.Drawing.Point(15, 45);
            this.lblBomDiaBoaTardeBoaNoite.Name = "lblBomDiaBoaTardeBoaNoite";
            this.lblBomDiaBoaTardeBoaNoite.Size = new System.Drawing.Size(21, 39);
            this.lblBomDiaBoaTardeBoaNoite.TabIndex = 3;
            this.lblBomDiaBoaTardeBoaNoite.Text = "...";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.lblBomDiaBoaTardeBoaNoite);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar barraDeProgressoVendas;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBomDiaBoaTardeBoaNoite;
    }
}