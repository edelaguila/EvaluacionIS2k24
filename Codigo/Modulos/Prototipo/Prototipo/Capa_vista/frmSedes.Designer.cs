
namespace Vista_PrototipoMenu
{
    partial class frmSedes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDire = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaVista.Navegador();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(103, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(843, 148);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.Tag = "sedes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Status de sede";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre de sede";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Código de sede";
            // 
            // txtDire
            // 
            this.txtDire.Location = new System.Drawing.Point(353, 222);
            this.txtDire.Name = "txtDire";
            this.txtDire.Size = new System.Drawing.Size(240, 22);
            this.txtDire.TabIndex = 18;
            this.txtDire.Tag = "estatus_sede";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(353, 194);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(240, 22);
            this.txtNombre.TabIndex = 17;
            this.txtNombre.Tag = "nombre_sede";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(353, 166);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(240, 22);
            this.txtId.TabIndex = 16;
            this.txtId.Tag = "codigo_sede";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(22, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1001, 96);
            this.navegador1.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(813, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 70);
            this.button1.TabIndex = 30;
            this.button1.Text = "Ayuda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDire);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Name = "frmSedes";
            this.Text = "frmSedes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDire;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private CapaVista.Navegador navegador1;
        private System.Windows.Forms.Button button1;
    }
}