
namespace Juego_Millonario
{
    partial class Juego_Millonario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego_Millonario));
            this.Pregunta = new System.Windows.Forms.Label();
            this.R_1 = new System.Windows.Forms.Button();
            this.R_2 = new System.Windows.Forms.Button();
            this.R_3 = new System.Windows.Forms.Button();
            this.R_Correcta = new System.Windows.Forms.Button();
            this.Comodín = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Comodín)).BeginInit();
            this.SuspendLayout();
            // 
            // Pregunta
            // 
            this.Pregunta.AutoSize = true;
            this.Pregunta.BackColor = System.Drawing.Color.Transparent;
            this.Pregunta.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pregunta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pregunta.Location = new System.Drawing.Point(43, 240);
            this.Pregunta.Name = "Pregunta";
            this.Pregunta.Size = new System.Drawing.Size(496, 26);
            this.Pregunta.TabIndex = 0;
            this.Pregunta.Text = "¿Quién fue el primer hombre en pisar la Luna?";
            this.Pregunta.Click += new System.EventHandler(this.label1_Click);
            // 
            // R_1
            // 
            this.R_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.R_1.BackColor = System.Drawing.Color.Transparent;
            this.R_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.R_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.R_1.FlatAppearance.BorderSize = 0;
            this.R_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.R_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.R_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_1.ForeColor = System.Drawing.Color.Transparent;
            this.R_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.R_1.Location = new System.Drawing.Point(59, 304);
            this.R_1.Name = "R_1";
            this.R_1.Size = new System.Drawing.Size(206, 27);
            this.R_1.TabIndex = 1;
            this.R_1.Text = "A:  Yuri Gagarin";
            this.R_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.R_1.UseVisualStyleBackColor = false;
            this.R_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // R_2
            // 
            this.R_2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.R_2.BackColor = System.Drawing.Color.Transparent;
            this.R_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.R_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.R_2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.R_2.FlatAppearance.BorderSize = 0;
            this.R_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.R_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.R_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_2.ForeColor = System.Drawing.Color.Transparent;
            this.R_2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.R_2.Location = new System.Drawing.Point(329, 304);
            this.R_2.Name = "R_2";
            this.R_2.Size = new System.Drawing.Size(206, 27);
            this.R_2.TabIndex = 2;
            this.R_2.Text = "B: Buzz Aldrin";
            this.R_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.R_2.UseVisualStyleBackColor = false;
            this.R_2.Click += new System.EventHandler(this.button2_Click);
            // 
            // R_3
            // 
            this.R_3.BackColor = System.Drawing.Color.Transparent;
            this.R_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.R_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.R_3.FlatAppearance.BorderSize = 0;
            this.R_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_3.ForeColor = System.Drawing.Color.Transparent;
            this.R_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.R_3.Location = new System.Drawing.Point(59, 353);
            this.R_3.Name = "R_3";
            this.R_3.Size = new System.Drawing.Size(206, 27);
            this.R_3.TabIndex = 3;
            this.R_3.Text = "C:  Michael Collins";
            this.R_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.R_3.UseVisualStyleBackColor = false;
            this.R_3.Click += new System.EventHandler(this.button3_Click);
            // 
            // R_Correcta
            // 
            this.R_Correcta.BackColor = System.Drawing.Color.Transparent;
            this.R_Correcta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.R_Correcta.FlatAppearance.BorderSize = 0;
            this.R_Correcta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_Correcta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Correcta.ForeColor = System.Drawing.Color.Transparent;
            this.R_Correcta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.R_Correcta.Location = new System.Drawing.Point(329, 353);
            this.R_Correcta.Name = "R_Correcta";
            this.R_Correcta.Size = new System.Drawing.Size(206, 27);
            this.R_Correcta.TabIndex = 4;
            this.R_Correcta.Text = "D:  Neil Armstrong";
            this.R_Correcta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.R_Correcta.UseVisualStyleBackColor = false;
            this.R_Correcta.Click += new System.EventHandler(this.button4_Click);
            // 
            // Comodín
            // 
            this.Comodín.BackColor = System.Drawing.Color.Transparent;
            this.Comodín.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Comodín.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Comodín.Image = global::Juego_Millonario.Properties.Resources.Comodin;
            this.Comodín.Location = new System.Drawing.Point(12, 25);
            this.Comodín.Name = "Comodín";
            this.Comodín.Size = new System.Drawing.Size(100, 50);
            this.Comodín.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Comodín.TabIndex = 6;
            this.Comodín.TabStop = false;
            this.Comodín.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Juego_Millonario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Juego_Millonario.Properties.Resources.e0fb86bf89fdccec24f7c2c8e9c8dda6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 391);
            this.Controls.Add(this.Comodín);
            this.Controls.Add(this.Pregunta);
            this.Controls.Add(this.R_2);
            this.Controls.Add(this.R_1);
            this.Controls.Add(this.R_3);
            this.Controls.Add(this.R_Correcta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Juego_Millonario";
            this.Text = "Quien quiere ser Millonario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Comodín)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pregunta;
        private System.Windows.Forms.Button R_1;
        private System.Windows.Forms.Button R_3;
        private System.Windows.Forms.Button R_Correcta;
        private System.Windows.Forms.PictureBox Comodín;
        private System.Windows.Forms.Button R_2;
    }
}

