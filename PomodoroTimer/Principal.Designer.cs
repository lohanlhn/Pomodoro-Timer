namespace PomodoroTimer
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.prgPrincipal = new System.Windows.Forms.ProgressBar();
            this.tmrAtivo = new System.Windows.Forms.Timer(this.components);
            this.lblTemporizador = new System.Windows.Forms.Label();
            this.btnPlayPause = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnPlayPauseDescanso = new System.Windows.Forms.PictureBox();
            this.pnlMarcador4 = new System.Windows.Forms.Panel();
            this.pnlMarcador3 = new System.Windows.Forms.Panel();
            this.pnlMarcador2 = new System.Windows.Forms.Panel();
            this.pnlMarcador1 = new System.Windows.Forms.Panel();
            this.tmrDescanso = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnPlayPause)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlayPauseDescanso)).BeginInit();
            this.SuspendLayout();
            // 
            // prgPrincipal
            // 
            this.prgPrincipal.Location = new System.Drawing.Point(12, 304);
            this.prgPrincipal.Maximum = 70;
            this.prgPrincipal.Name = "prgPrincipal";
            this.prgPrincipal.Size = new System.Drawing.Size(326, 23);
            this.prgPrincipal.TabIndex = 0;
            // 
            // tmrAtivo
            // 
            this.tmrAtivo.Interval = 1000;
            this.tmrAtivo.Tick += new System.EventHandler(this.tmrAtivo_Tick);
            // 
            // lblTemporizador
            // 
            this.lblTemporizador.AutoSize = true;
            this.lblTemporizador.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTemporizador.ForeColor = System.Drawing.Color.Red;
            this.lblTemporizador.Location = new System.Drawing.Point(77, 97);
            this.lblTemporizador.Name = "lblTemporizador";
            this.lblTemporizador.Size = new System.Drawing.Size(196, 77);
            this.lblTemporizador.TabIndex = 1;
            this.lblTemporizador.Text = "00:00";
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayPause.Image")));
            this.btnPlayPause.Location = new System.Drawing.Point(145, 372);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(60, 45);
            this.btnPlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlayPause.TabIndex = 2;
            this.btnPlayPause.TabStop = false;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.White;
            this.pnlPrincipal.Controls.Add(this.btnPlayPauseDescanso);
            this.pnlPrincipal.Controls.Add(this.pnlMarcador4);
            this.pnlPrincipal.Controls.Add(this.pnlMarcador3);
            this.pnlPrincipal.Controls.Add(this.pnlMarcador2);
            this.pnlPrincipal.Controls.Add(this.pnlMarcador1);
            this.pnlPrincipal.Controls.Add(this.lblTemporizador);
            this.pnlPrincipal.Controls.Add(this.btnPlayPause);
            this.pnlPrincipal.Controls.Add(this.prgPrincipal);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(350, 450);
            this.pnlPrincipal.TabIndex = 4;
            // 
            // btnPlayPauseDescanso
            // 
            this.btnPlayPauseDescanso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayPauseDescanso.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayPauseDescanso.Image")));
            this.btnPlayPauseDescanso.Location = new System.Drawing.Point(145, 372);
            this.btnPlayPauseDescanso.Name = "btnPlayPauseDescanso";
            this.btnPlayPauseDescanso.Size = new System.Drawing.Size(60, 45);
            this.btnPlayPauseDescanso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlayPauseDescanso.TabIndex = 2;
            this.btnPlayPauseDescanso.TabStop = false;
            this.btnPlayPauseDescanso.Visible = false;
            this.btnPlayPauseDescanso.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // pnlMarcador4
            // 
            this.pnlMarcador4.BackColor = System.Drawing.Color.Silver;
            this.pnlMarcador4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlMarcador4.Location = new System.Drawing.Point(271, 278);
            this.pnlMarcador4.Name = "pnlMarcador4";
            this.pnlMarcador4.Size = new System.Drawing.Size(65, 20);
            this.pnlMarcador4.TabIndex = 3;
            // 
            // pnlMarcador3
            // 
            this.pnlMarcador3.BackColor = System.Drawing.Color.Silver;
            this.pnlMarcador3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlMarcador3.Location = new System.Drawing.Point(185, 278);
            this.pnlMarcador3.Name = "pnlMarcador3";
            this.pnlMarcador3.Size = new System.Drawing.Size(65, 20);
            this.pnlMarcador3.TabIndex = 3;
            // 
            // pnlMarcador2
            // 
            this.pnlMarcador2.BackColor = System.Drawing.Color.Silver;
            this.pnlMarcador2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlMarcador2.Location = new System.Drawing.Point(99, 278);
            this.pnlMarcador2.Name = "pnlMarcador2";
            this.pnlMarcador2.Size = new System.Drawing.Size(65, 20);
            this.pnlMarcador2.TabIndex = 3;
            // 
            // pnlMarcador1
            // 
            this.pnlMarcador1.BackColor = System.Drawing.Color.Silver;
            this.pnlMarcador1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlMarcador1.Location = new System.Drawing.Point(13, 278);
            this.pnlMarcador1.Name = "pnlMarcador1";
            this.pnlMarcador1.Size = new System.Drawing.Size(65, 20);
            this.pnlMarcador1.TabIndex = 3;
            // 
            // tmrDescanso
            // 
            this.tmrDescanso.Interval = 1000;
            this.tmrDescanso.Tick += new System.EventHandler(this.tmrDescanso_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "Pomodoro Timer";
            ((System.ComponentModel.ISupportInitialize)(this.btnPlayPause)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlayPauseDescanso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgPrincipal;
        private System.Windows.Forms.Timer tmrAtivo;
        private System.Windows.Forms.Label lblTemporizador;
        private System.Windows.Forms.PictureBox btnPlayPause;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlMarcador1;
        private System.Windows.Forms.Panel pnlMarcador4;
        private System.Windows.Forms.Panel pnlMarcador3;
        private System.Windows.Forms.Panel pnlMarcador2;
        private System.Windows.Forms.Timer tmrDescanso;
        private System.Windows.Forms.PictureBox btnPlayPauseDescanso;
    }
}