
namespace Foarfeca__piatra_hartie
{
    partial class frmMain
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
            this.btnFoarfeca = new System.Windows.Forms.Button();
            this.btnPiatra = new System.Windows.Forms.Button();
            this.btnHartie = new System.Windows.Forms.Button();
            this.lblJoaca = new System.Windows.Forms.Label();
            this.lblScor = new System.Windows.Forms.Label();
            this.lblPunctaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFoarfeca
            // 
            this.btnFoarfeca.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFoarfeca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoarfeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoarfeca.ForeColor = System.Drawing.Color.White;
            this.btnFoarfeca.Location = new System.Drawing.Point(101, 155);
            this.btnFoarfeca.Margin = new System.Windows.Forms.Padding(0);
            this.btnFoarfeca.Name = "btnFoarfeca";
            this.btnFoarfeca.Size = new System.Drawing.Size(104, 69);
            this.btnFoarfeca.TabIndex = 0;
            this.btnFoarfeca.Text = "Foarfeca";
            this.btnFoarfeca.UseVisualStyleBackColor = false;
            this.btnFoarfeca.Click += new System.EventHandler(this.btnFoarfeca_Click);
            // 
            // btnPiatra
            // 
            this.btnPiatra.BackColor = System.Drawing.Color.LightBlue;
            this.btnPiatra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPiatra.ForeColor = System.Drawing.Color.Black;
            this.btnPiatra.Location = new System.Drawing.Point(331, 155);
            this.btnPiatra.Margin = new System.Windows.Forms.Padding(0);
            this.btnPiatra.Name = "btnPiatra";
            this.btnPiatra.Size = new System.Drawing.Size(104, 69);
            this.btnPiatra.TabIndex = 1;
            this.btnPiatra.Text = "Piatra";
            this.btnPiatra.UseVisualStyleBackColor = false;
            this.btnPiatra.Click += new System.EventHandler(this.btnPiatra_Click);
            // 
            // btnHartie
            // 
            this.btnHartie.Location = new System.Drawing.Point(558, 155);
            this.btnHartie.Name = "btnHartie";
            this.btnHartie.Size = new System.Drawing.Size(104, 69);
            this.btnHartie.TabIndex = 2;
            this.btnHartie.Text = "Hartie";
            this.btnHartie.UseVisualStyleBackColor = true;
            this.btnHartie.Click += new System.EventHandler(this.btnHartie_Click);
            // 
            // lblJoaca
            // 
            this.lblJoaca.AutoSize = true;
            this.lblJoaca.BackColor = System.Drawing.Color.SandyBrown;
            this.lblJoaca.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoaca.ForeColor = System.Drawing.Color.Red;
            this.lblJoaca.Location = new System.Drawing.Point(145, 30);
            this.lblJoaca.Name = "lblJoaca";
            this.lblJoaca.Size = new System.Drawing.Size(472, 30);
            this.lblJoaca.TabIndex = 3;
            this.lblJoaca.Text = "Joaca jocul | ACTIUNEA ORIENTALA MMORPG";
            // 
            // lblScor
            // 
            this.lblScor.AutoSize = true;
            this.lblScor.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScor.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblScor.Location = new System.Drawing.Point(12, 356);
            this.lblScor.Name = "lblScor";
            this.lblScor.Size = new System.Drawing.Size(81, 37);
            this.lblScor.TabIndex = 4;
            this.lblScor.Text = "Scor:";
            // 
            // lblPunctaj
            // 
            this.lblPunctaj.AutoSize = true;
            this.lblPunctaj.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunctaj.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblPunctaj.Location = new System.Drawing.Point(84, 358);
            this.lblPunctaj.Name = "lblPunctaj";
            this.lblPunctaj.Size = new System.Drawing.Size(33, 37);
            this.lblPunctaj.TabIndex = 5;
            this.lblPunctaj.Text = "0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.lblPunctaj);
            this.Controls.Add(this.lblScor);
            this.Controls.Add(this.lblJoaca);
            this.Controls.Add(this.btnHartie);
            this.Controls.Add(this.btnPiatra);
            this.Controls.Add(this.btnFoarfeca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(960, 540);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFoarfeca;
        private System.Windows.Forms.Button btnPiatra;
        private System.Windows.Forms.Button btnHartie;
        private System.Windows.Forms.Label lblJoaca;
        private System.Windows.Forms.Label lblScor;
        private System.Windows.Forms.Label lblPunctaj;
    }
}

