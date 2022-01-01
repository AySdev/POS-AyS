
namespace POS_AyS
{
    partial class frmAcerca
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.txtInfoOs = new System.Windows.Forms.TextBox();
            this.txtInfoCpu = new System.Windows.Forms.TextBox();
            this.txtInfoVid = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlPrincipal.Controls.Add(this.btnMostrar);
            this.pnlPrincipal.Controls.Add(this.txtInfoOs);
            this.pnlPrincipal.Controls.Add(this.txtInfoCpu);
            this.pnlPrincipal.Controls.Add(this.txtInfoVid);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(800, 402);
            this.pnlPrincipal.TabIndex = 11;
            // 
            // txtInfoOs
            // 
            this.txtInfoOs.Location = new System.Drawing.Point(544, 121);
            this.txtInfoOs.Multiline = true;
            this.txtInfoOs.Name = "txtInfoOs";
            this.txtInfoOs.Size = new System.Drawing.Size(203, 231);
            this.txtInfoOs.TabIndex = 14;
            // 
            // txtInfoCpu
            // 
            this.txtInfoCpu.Location = new System.Drawing.Point(296, 121);
            this.txtInfoCpu.Multiline = true;
            this.txtInfoCpu.Name = "txtInfoCpu";
            this.txtInfoCpu.Size = new System.Drawing.Size(203, 231);
            this.txtInfoCpu.TabIndex = 13;
            // 
            // txtInfoVid
            // 
            this.txtInfoVid.Location = new System.Drawing.Point(52, 121);
            this.txtInfoVid.Multiline = true;
            this.txtInfoVid.Name = "txtInfoVid";
            this.txtInfoVid.Size = new System.Drawing.Size(199, 237);
            this.txtInfoVid.TabIndex = 12;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMostrar.Location = new System.Drawing.Point(357, 36);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 30);
            this.btnMostrar.TabIndex = 15;
            this.btnMostrar.Text = "Acerca de";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // frmAcerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "frmAcerca";
            this.Text = "Acerca de";
            this.Load += new System.EventHandler(this.Acerca_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        public System.Windows.Forms.TextBox txtInfoOs;
        public System.Windows.Forms.TextBox txtInfoCpu;
        public System.Windows.Forms.TextBox txtInfoVid;
        private System.Windows.Forms.Button btnMostrar;
    }
}