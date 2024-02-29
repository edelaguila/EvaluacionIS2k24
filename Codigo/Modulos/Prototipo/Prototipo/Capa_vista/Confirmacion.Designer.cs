namespace Vista_PrototipoMenu
{
    partial class Confirmacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmacion));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_AgregarBoleta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(892, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_AgregarBoleta
            // 
            this.btn_AgregarBoleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarBoleta.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarBoleta.Image")));
            this.btn_AgregarBoleta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AgregarBoleta.Location = new System.Drawing.Point(33, 300);
            this.btn_AgregarBoleta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AgregarBoleta.Name = "btn_AgregarBoleta";
            this.btn_AgregarBoleta.Size = new System.Drawing.Size(182, 35);
            this.btn_AgregarBoleta.TabIndex = 1;
            this.btn_AgregarBoleta.Text = "  Agregar Boleta";
            this.btn_AgregarBoleta.UseVisualStyleBackColor = true;
            this.btn_AgregarBoleta.Click += new System.EventHandler(this.btn_AgregarBoleta_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(237, 300);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Agendar cita";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Confirmación de Información";
            // 
            // Confirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_AgregarBoleta);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Confirmacion";
            this.Text = "Confirmacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AgregarBoleta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}