namespace IMportaciones
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back_panel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_file_veritrade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tubería de Cobre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_file_veritrade);
            this.panel1.Controls.Add(this.btn_back_panel);
            this.panel1.Location = new System.Drawing.Point(28, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 417);
            this.panel1.TabIndex = 1;
            // 
            // btn_back_panel
            // 
            this.btn_back_panel.Location = new System.Drawing.Point(14, 363);
            this.btn_back_panel.Name = "btn_back_panel";
            this.btn_back_panel.Size = new System.Drawing.Size(88, 39);
            this.btn_back_panel.TabIndex = 0;
            this.btn_back_panel.Text = "Volver al Panel Principal";
            this.btn_back_panel.UseVisualStyleBackColor = true;
            this.btn_back_panel.Click += new System.EventHandler(this.btn_back_panel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_file_veritrade
            // 
            this.btn_file_veritrade.Location = new System.Drawing.Point(14, 14);
            this.btn_file_veritrade.Name = "btn_file_veritrade";
            this.btn_file_veritrade.Size = new System.Drawing.Size(75, 45);
            this.btn_file_veritrade.TabIndex = 1;
            this.btn_file_veritrade.Text = "Archivo Veritrade";
            this.btn_file_veritrade.UseVisualStyleBackColor = true;
            this.btn_file_veritrade.Click += new System.EventHandler(this.btn_file_veritrade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back_panel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_file_veritrade;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

