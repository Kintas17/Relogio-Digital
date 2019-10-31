namespace Relogio_Digital
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.horas = new System.Windows.Forms.Button();
            this.minutos = new System.Windows.Forms.Button();
            this.segundos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("LCD2", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 196);
            this.label1.TabIndex = 0;
            this.label1.Text = "00;00;00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("LCD2", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(205, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("LCD2", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(342, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Parar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("LCD2", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(478, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Recomecar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // horas
            // 
            this.horas.Font = new System.Drawing.Font("LCD2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horas.Location = new System.Drawing.Point(205, 132);
            this.horas.Name = "horas";
            this.horas.Size = new System.Drawing.Size(91, 41);
            this.horas.TabIndex = 4;
            this.horas.Text = "Horas";
            this.horas.UseVisualStyleBackColor = true;
            this.horas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Acerta_Relogio);
            // 
            // minutos
            // 
            this.minutos.Font = new System.Drawing.Font("LCD2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutos.Location = new System.Drawing.Point(342, 132);
            this.minutos.Name = "minutos";
            this.minutos.Size = new System.Drawing.Size(91, 41);
            this.minutos.TabIndex = 5;
            this.minutos.Text = "Minutos";
            this.minutos.UseVisualStyleBackColor = true;
            this.minutos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Acerta_Relogio);
            // 
            // segundos
            // 
            this.segundos.Font = new System.Drawing.Font("LCD2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundos.Location = new System.Drawing.Point(478, 132);
            this.segundos.Name = "segundos";
            this.segundos.Size = new System.Drawing.Size(91, 41);
            this.segundos.TabIndex = 6;
            this.segundos.Text = "Segundos";
            this.segundos.UseVisualStyleBackColor = true;
            this.segundos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Acerta_Relogio);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 589);
            this.Controls.Add(this.segundos);
            this.Controls.Add(this.minutos);
            this.Controls.Add(this.horas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button horas;
        private System.Windows.Forms.Button minutos;
        private System.Windows.Forms.Button segundos;
    }
}

