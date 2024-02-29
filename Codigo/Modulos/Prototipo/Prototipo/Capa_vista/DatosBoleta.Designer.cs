
namespace Vista_PrototipoMenu
{
    partial class DatosBoleta
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
            this.txt_nocorrelativo = new System.Windows.Forms.TextBox();
            this.txtnoboleta = new System.Windows.Forms.TextBox();
            this.btnvalidarboleta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_nocorrelativo
            // 
            this.txt_nocorrelativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nocorrelativo.Location = new System.Drawing.Point(113, 331);
            this.txt_nocorrelativo.Name = "txt_nocorrelativo";
            this.txt_nocorrelativo.Size = new System.Drawing.Size(371, 30);
            this.txt_nocorrelativo.TabIndex = 16;
            // 
            // txtnoboleta
            // 
            this.txtnoboleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoboleta.Location = new System.Drawing.Point(113, 185);
            this.txtnoboleta.Name = "txtnoboleta";
            this.txtnoboleta.Size = new System.Drawing.Size(371, 30);
            this.txtnoboleta.TabIndex = 15;
            // 
            // btnvalidarboleta
            // 
            this.btnvalidarboleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalidarboleta.Location = new System.Drawing.Point(597, 349);
            this.btnvalidarboleta.Name = "btnvalidarboleta";
            this.btnvalidarboleta.Size = new System.Drawing.Size(186, 96);
            this.btnvalidarboleta.TabIndex = 14;
            this.btnvalidarboleta.Text = "Validar Boleta";
            this.btnvalidarboleta.UseVisualStyleBackColor = true;
            this.btnvalidarboleta.Click += new System.EventHandler(this.btnvalidarboleta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "No. Correlativo CGC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "No. Boleta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingresa los Datos de tu boleta";
            // 
            // DatosBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 485);
            this.Controls.Add(this.txt_nocorrelativo);
            this.Controls.Add(this.txtnoboleta);
            this.Controls.Add(this.btnvalidarboleta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "DatosBoleta";
            this.Text = "DatosBoleta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nocorrelativo;
        private System.Windows.Forms.TextBox txtnoboleta;
        private System.Windows.Forms.Button btnvalidarboleta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}