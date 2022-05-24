namespace Tabuada
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
            this.lst_tabuada = new System.Windows.Forms.ListBox();
            this.btn_processar = new System.Windows.Forms.Button();
            this.lbl_n = new System.Windows.Forms.Label();
            this.txt_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lst_tabuada
            // 
            this.lst_tabuada.FormattingEnabled = true;
            this.lst_tabuada.Location = new System.Drawing.Point(568, 77);
            this.lst_tabuada.Name = "lst_tabuada";
            this.lst_tabuada.Size = new System.Drawing.Size(189, 186);
            this.lst_tabuada.TabIndex = 0;
            this.lst_tabuada.SelectedIndexChanged += new System.EventHandler(this.Tabuada_SelectedIndexChanged);
            // 
            // btn_processar
            // 
            this.btn_processar.Location = new System.Drawing.Point(274, 160);
            this.btn_processar.Name = "btn_processar";
            this.btn_processar.Size = new System.Drawing.Size(228, 53);
            this.btn_processar.TabIndex = 1;
            this.btn_processar.Text = "Processar";
            this.btn_processar.UseVisualStyleBackColor = true;
            this.btn_processar.Click += new System.EventHandler(this.btn_processar_Click);
            // 
            // lbl_n
            // 
            this.lbl_n.AutoSize = true;
            this.lbl_n.Location = new System.Drawing.Point(277, 87);
            this.lbl_n.Name = "lbl_n";
            this.lbl_n.Size = new System.Drawing.Size(92, 13);
            this.lbl_n.TabIndex = 2;
            this.lbl_n.Text = "Digite um número ";
            // 
            // txt_box
            // 
            this.txt_box.Location = new System.Drawing.Point(411, 80);
            this.txt_box.Name = "txt_box";
            this.txt_box.Size = new System.Drawing.Size(120, 20);
            this.txt_box.TabIndex = 3;
            this.txt_box.TextChanged += new System.EventHandler(this.txt_box_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 444);
            this.Controls.Add(this.txt_box);
            this.Controls.Add(this.lbl_n);
            this.Controls.Add(this.btn_processar);
            this.Controls.Add(this.lst_tabuada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_tabuada;
        private System.Windows.Forms.Button btn_processar;
        private System.Windows.Forms.Label lbl_n;
        private System.Windows.Forms.TextBox txt_box;
    }
}

