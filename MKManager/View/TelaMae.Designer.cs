namespace MKManager.View
{
    partial class TelaMae
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
            this.panelSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAjuda = new Guna.UI2.WinForms.Guna2Button();
            this.btnRelatorios = new Guna.UI2.WinForms.Guna2Button();
            this.btnProdutos = new Guna.UI2.WinForms.Guna2Button();
            this.btnClientes = new Guna.UI2.WinForms.Guna2Button();
            this.btnPaginaInicial = new Guna.UI2.WinForms.Guna2Button();
            this.panelLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMKManager = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelFormAtual = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(94)))), ((int)(((byte)(166)))));
            this.panelSidebar.Controls.Add(this.btnAjuda);
            this.panelSidebar.Controls.Add(this.btnRelatorios);
            this.panelSidebar.Controls.Add(this.btnProdutos);
            this.panelSidebar.Controls.Add(this.btnClientes);
            this.panelSidebar.Controls.Add(this.btnPaginaInicial);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.MaximumSize = new System.Drawing.Size(200, 561);
            this.panelSidebar.MinimumSize = new System.Drawing.Size(200, 561);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 561);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnAjuda
            // 
            this.btnAjuda.BorderRadius = 10;
            this.btnAjuda.CheckedState.FillColor = System.Drawing.Color.Plum;
            this.btnAjuda.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAjuda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAjuda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAjuda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAjuda.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(94)))), ((int)(((byte)(166)))));
            this.btnAjuda.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAjuda.ForeColor = System.Drawing.Color.Black;
            this.btnAjuda.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(115)))), ((int)(((byte)(187)))));
            this.btnAjuda.Image = global::MKManager.Properties.Resources.help;
            this.btnAjuda.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAjuda.Location = new System.Drawing.Point(10, 504);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(180, 45);
            this.btnAjuda.TabIndex = 5;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BorderRadius = 10;
            this.btnRelatorios.CheckedState.FillColor = System.Drawing.Color.Plum;
            this.btnRelatorios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRelatorios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRelatorios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRelatorios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRelatorios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(94)))), ((int)(((byte)(166)))));
            this.btnRelatorios.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRelatorios.ForeColor = System.Drawing.Color.Black;
            this.btnRelatorios.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(115)))), ((int)(((byte)(187)))));
            this.btnRelatorios.Image = global::MKManager.Properties.Resources.chart;
            this.btnRelatorios.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRelatorios.Location = new System.Drawing.Point(10, 266);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(180, 45);
            this.btnRelatorios.TabIndex = 4;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BorderRadius = 10;
            this.btnProdutos.CheckedState.FillColor = System.Drawing.Color.Plum;
            this.btnProdutos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProdutos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProdutos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProdutos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProdutos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(94)))), ((int)(((byte)(166)))));
            this.btnProdutos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProdutos.ForeColor = System.Drawing.Color.Black;
            this.btnProdutos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(115)))), ((int)(((byte)(187)))));
            this.btnProdutos.Image = global::MKManager.Properties.Resources.product;
            this.btnProdutos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProdutos.Location = new System.Drawing.Point(10, 206);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(180, 45);
            this.btnProdutos.TabIndex = 3;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BorderRadius = 10;
            this.btnClientes.CheckedState.FillColor = System.Drawing.Color.Plum;
            this.btnClientes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClientes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClientes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClientes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClientes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(94)))), ((int)(((byte)(166)))));
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClientes.ForeColor = System.Drawing.Color.Black;
            this.btnClientes.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(115)))), ((int)(((byte)(187)))));
            this.btnClientes.Image = global::MKManager.Properties.Resources.customer;
            this.btnClientes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClientes.Location = new System.Drawing.Point(10, 146);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(180, 45);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnPaginaInicial
            // 
            this.btnPaginaInicial.BorderRadius = 10;
            this.btnPaginaInicial.Checked = true;
            this.btnPaginaInicial.CheckedState.FillColor = System.Drawing.Color.Plum;
            this.btnPaginaInicial.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPaginaInicial.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPaginaInicial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPaginaInicial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPaginaInicial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(94)))), ((int)(((byte)(166)))));
            this.btnPaginaInicial.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPaginaInicial.ForeColor = System.Drawing.Color.Black;
            this.btnPaginaInicial.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(115)))), ((int)(((byte)(187)))));
            this.btnPaginaInicial.Image = global::MKManager.Properties.Resources.home1;
            this.btnPaginaInicial.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPaginaInicial.Location = new System.Drawing.Point(10, 89);
            this.btnPaginaInicial.Name = "btnPaginaInicial";
            this.btnPaginaInicial.Size = new System.Drawing.Size(180, 45);
            this.btnPaginaInicial.TabIndex = 1;
            this.btnPaginaInicial.Text = "Início";
            this.btnPaginaInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPaginaInicial.Click += new System.EventHandler(this.btnPaginaInicial_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblMKManager);
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // lblMKManager
            // 
            this.lblMKManager.BackColor = System.Drawing.Color.Transparent;
            this.lblMKManager.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMKManager.Location = new System.Drawing.Point(53, 23);
            this.lblMKManager.Name = "lblMKManager";
            this.lblMKManager.Size = new System.Drawing.Size(126, 32);
            this.lblMKManager.TabIndex = 2;
            this.lblMKManager.Text = "MK Manager";
            this.lblMKManager.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::MKManager.Properties.Resources.beauty;
            this.pbLogo.ImageRotate = 0F;
            this.pbLogo.Location = new System.Drawing.Point(16, 24);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(30, 30);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // panelFormAtual
            // 
            this.panelFormAtual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormAtual.Location = new System.Drawing.Point(200, 0);
            this.panelFormAtual.Name = "panelFormAtual";
            this.panelFormAtual.Size = new System.Drawing.Size(584, 561);
            this.panelFormAtual.TabIndex = 1;
            // 
            // TelaMae
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelFormAtual);
            this.Controls.Add(this.panelSidebar);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "TelaMae";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Início";
            this.Load += new System.EventHandler(this.TelaMae_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelSidebar;
        private Guna.UI2.WinForms.Guna2Panel panelLogo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMKManager;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2Button btnRelatorios;
        private Guna.UI2.WinForms.Guna2Button btnProdutos;
        private Guna.UI2.WinForms.Guna2Button btnClientes;
        private Guna.UI2.WinForms.Guna2Button btnPaginaInicial;
        private Guna.UI2.WinForms.Guna2Panel panelFormAtual;
        private Guna.UI2.WinForms.Guna2Button btnAjuda;
    }
}