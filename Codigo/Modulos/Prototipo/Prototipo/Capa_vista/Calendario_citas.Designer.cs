namespace Vista_PrototipoMenu
{
    partial class Calendario_citas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendario_citas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdpi = new System.Windows.Forms.TextBox();
            this.txtcgc = new System.Windows.Forms.TextBox();
            this.txtboleta = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmuni = new System.Windows.Forms.TextBox();
            this.txtcitanum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboDept = new System.Windows.Forms.ComboBox();
            this.txtpais = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtdpi);
            this.panel1.Controls.Add(this.txtcgc);
            this.panel1.Controls.Add(this.txtboleta);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.txtfecha);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtmuni);
            this.panel1.Controls.Add(this.txtcitanum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboDept);
            this.panel1.Controls.Add(this.txtpais);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 469);
            this.panel1.TabIndex = 0;
            // 
            // txtdpi
            // 
            this.txtdpi.Location = new System.Drawing.Point(138, 3);
            this.txtdpi.Name = "txtdpi";
            this.txtdpi.ReadOnly = true;
            this.txtdpi.Size = new System.Drawing.Size(33, 23);
            this.txtdpi.TabIndex = 16;
            this.txtdpi.Tag = "tbl_boleta_Pk_id_boleta";
            this.txtdpi.Visible = false;
            // 
            // txtcgc
            // 
            this.txtcgc.Location = new System.Drawing.Point(99, 3);
            this.txtcgc.Name = "txtcgc";
            this.txtcgc.ReadOnly = true;
            this.txtcgc.Size = new System.Drawing.Size(33, 23);
            this.txtcgc.TabIndex = 15;
            this.txtcgc.Tag = "tbl_boleta_Pk_id_boleta";
            this.txtcgc.Visible = false;
            // 
            // txtboleta
            // 
            this.txtboleta.Location = new System.Drawing.Point(60, 3);
            this.txtboleta.Name = "txtboleta";
            this.txtboleta.ReadOnly = true;
            this.txtboleta.Size = new System.Drawing.Size(33, 23);
            this.txtboleta.TabIndex = 14;
            this.txtboleta.Tag = "tbl_boleta_Pk_id_boleta";
            this.txtboleta.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(18, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 45);
            this.button3.TabIndex = 13;
            this.button3.Text = "Seleccionar hora";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(18, 256);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(164, 23);
            this.txtfecha.TabIndex = 12;
            this.txtfecha.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de cita:";
            // 
            // txtmuni
            // 
            this.txtmuni.Location = new System.Drawing.Point(18, 210);
            this.txtmuni.Name = "txtmuni";
            this.txtmuni.Size = new System.Drawing.Size(164, 23);
            this.txtmuni.TabIndex = 10;
            this.txtmuni.Tag = "cit_municipio";
            // 
            // txtcitanum
            // 
            this.txtcitanum.Location = new System.Drawing.Point(11, 3);
            this.txtcitanum.Name = "txtcitanum";
            this.txtcitanum.ReadOnly = true;
            this.txtcitanum.Size = new System.Drawing.Size(33, 23);
            this.txtcitanum.TabIndex = 9;
            this.txtcitanum.Tag = "Pk_id_cita";
            this.txtcitanum.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Programar Cita";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(18, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Nueva Busqueda";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(18, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar Calendario";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboDept
            // 
            this.comboDept.FormattingEnabled = true;
            this.comboDept.Location = new System.Drawing.Point(18, 152);
            this.comboDept.Name = "comboDept";
            this.comboDept.Size = new System.Drawing.Size(164, 25);
            this.comboDept.TabIndex = 4;
            this.comboDept.Tag = "cit_dept";
            // 
            // txtpais
            // 
            this.txtpais.Location = new System.Drawing.Point(18, 95);
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(164, 23);
            this.txtpais.TabIndex = 3;
            this.txtpais.Tag = "cit_pais";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Municipio: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Depatamento: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "País: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Location = new System.Drawing.Point(258, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 469);
            this.panel2.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(36, 51);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged_1);
            // 
            // Calendario_citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 473);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Calendario_citas";
            this.Text = "Calendario_citas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboDept;
        private System.Windows.Forms.TextBox txtpais;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtcitanum;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtmuni;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtdpi;
        public System.Windows.Forms.TextBox txtcgc;
        public System.Windows.Forms.TextBox txtboleta;
    }
}