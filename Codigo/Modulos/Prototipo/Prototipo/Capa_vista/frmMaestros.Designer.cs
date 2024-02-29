
namespace Vista_PrototipoMenu
{
    partial class frmAplicaciones
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDire = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaVista.Navegador();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(353, 149);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(240, 22);
            this.txtId.TabIndex = 1;
            this.txtId.Tag = " codigo_maestro";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(353, 177);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(240, 22);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Tag = "nombre_maestro";
            // 
            // txtDire
            // 
            this.txtDire.Location = new System.Drawing.Point(353, 205);
            this.txtDire.Name = "txtDire";
            this.txtDire.Size = new System.Drawing.Size(240, 22);
            this.txtDire.TabIndex = 3;
            this.txtDire.Tag = "direccion_maestro";
            this.txtDire.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(353, 233);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(240, 22);
            this.txttelefono.TabIndex = 4;
            this.txttelefono.Tag = "telefono_maetro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dirección";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefono";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(107, 339);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(843, 148);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Tag = "maestros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(353, 289);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(240, 22);
            this.txtStatus.TabIndex = 13;
            this.txtStatus.Tag = "estatus_maestro";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(353, 261);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(240, 22);
            this.txtemail.TabIndex = 12;
            this.txtemail.Tag = "email_maestro";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(23, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1001, 96);
            this.navegador1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(814, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 68);
            this.button1.TabIndex = 17;
            this.button1.Text = "Ayuda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // frmAplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtDire);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Name = "frmAplicaciones";
            this.Text = "1002 Mantenimiento Maestro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDire;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtemail;
        private CapaVista.Navegador navegador1;
        private System.Windows.Forms.Button button1;
    }
}