
namespace Mercancia
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
            System.Windows.Forms.Button btnmodificar;
            this.dtgmercancias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text4 = new System.Windows.Forms.RichTextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.text7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            btnmodificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgmercancias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmodificar
            // 
            btnmodificar.Location = new System.Drawing.Point(1106, 466);
            btnmodificar.Name = "btnmodificar";
            btnmodificar.Size = new System.Drawing.Size(187, 23);
            btnmodificar.TabIndex = 15;
            btnmodificar.Text = "Modificar\r\n";
            btnmodificar.UseVisualStyleBackColor = true;
            btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // dtgmercancias
            // 
            this.dtgmercancias.AllowUserToAddRows = false;
            this.dtgmercancias.AllowUserToDeleteRows = false;
            this.dtgmercancias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgmercancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgmercancias.Location = new System.Drawing.Point(5, 506);
            this.dtgmercancias.Name = "dtgmercancias";
            this.dtgmercancias.ReadOnly = true;
            this.dtgmercancias.RowHeadersWidth = 51;
            this.dtgmercancias.RowTemplate.Height = 24;
            this.dtgmercancias.Size = new System.Drawing.Size(1300, 304);
            this.dtgmercancias.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido del Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dirección";
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(189, 18);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(404, 22);
            this.text1.TabIndex = 6;
            this.text1.TextChanged += new System.EventHandler(this.text1_TextChanged);
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(189, 72);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(404, 22);
            this.text2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telefono";
            // 
            // text4
            // 
            this.text4.Location = new System.Drawing.Point(189, 179);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(404, 22);
            this.text4.TabIndex = 9;
            this.text4.Text = "";
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(189, 122);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(404, 22);
            this.text3.TabIndex = 10;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(5, 467);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(187, 23);
            this.btnguardar.TabIndex = 13;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(343, 466);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(187, 23);
            this.btneliminar.TabIndex = 14;
            this.btneliminar.Text = "Eliminar\r\n";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // text7
            // 
            this.text7.Location = new System.Drawing.Point(473, 402);
            this.text7.Name = "text7";
            this.text7.Size = new System.Drawing.Size(404, 22);
            this.text7.TabIndex = 18;
            this.text7.TextChanged += new System.EventHandler(this.text7_TextChanged);
            this.text7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.text7_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(628, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = " Buscar por";
            // 
            // text5
            // 
            this.text5.Location = new System.Drawing.Point(189, 234);
            this.text5.Name = "text5";
            this.text5.Size = new System.Drawing.Size(404, 22);
            this.text5.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 822);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text7);
            this.Controls.Add(btnmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgmercancias);
            this.Name = "Form1";
            this.Text = "Mercancias";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgmercancias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgmercancias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox text4;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox text7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text5;
        private System.Windows.Forms.Button button1;
    }
}

