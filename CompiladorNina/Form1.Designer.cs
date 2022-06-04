
namespace CompiladorNina
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.analizarbtn = new System.Windows.Forms.Button();
            this.codigofuente = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // analizarbtn
            // 
            this.analizarbtn.Location = new System.Drawing.Point(837, 543);
            this.analizarbtn.Name = "analizarbtn";
            this.analizarbtn.Size = new System.Drawing.Size(94, 29);
            this.analizarbtn.TabIndex = 1;
            this.analizarbtn.Text = "Analizar";
            this.analizarbtn.UseVisualStyleBackColor = true;
            this.analizarbtn.Click += new System.EventHandler(this.analizarbtn_Click);
            // 
            // codigofuente
            // 
            this.codigofuente.Location = new System.Drawing.Point(103, 12);
            this.codigofuente.Name = "codigofuente";
            this.codigofuente.Size = new System.Drawing.Size(747, 481);
            this.codigofuente.TabIndex = 2;
            this.codigofuente.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 643);
            this.Controls.Add(this.codigofuente);
            this.Controls.Add(this.analizarbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button analizarbtn;
        private System.Windows.Forms.RichTextBox codigofuente;
    }
}

