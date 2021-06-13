
namespace primeraclase
{
    partial class Calculador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculador));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_valorUno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_valorDos = new System.Windows.Forms.TextBox();
            this.txt_respuesta = new System.Windows.Forms.TextBox();
            this.btn_sumar = new System.Windows.Forms.Button();
            this.btn_restar = new System.Windows.Forms.Button();
            this.txt_respuesta1 = new System.Windows.Forms.TextBox();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.txt_respuesta2 = new System.Windows.Forms.TextBox();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.txt_respuesta3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_raiz = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_potencia = new System.Windows.Forms.Button();
            this.txt_respuesta5 = new System.Windows.Forms.TextBox();
            this.txt_respuesta4 = new System.Windows.Forms.TextBox();
            this.txt_valorRaiz = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor uno";
            // 
            // txt_valorUno
            // 
            this.txt_valorUno.Location = new System.Drawing.Point(116, 50);
            this.txt_valorUno.Name = "txt_valorUno";
            this.txt_valorUno.Size = new System.Drawing.Size(54, 20);
            this.txt_valorUno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor Dos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_valorDos
            // 
            this.txt_valorDos.Location = new System.Drawing.Point(116, 76);
            this.txt_valorDos.Name = "txt_valorDos";
            this.txt_valorDos.Size = new System.Drawing.Size(54, 20);
            this.txt_valorDos.TabIndex = 3;
            // 
            // txt_respuesta
            // 
            this.txt_respuesta.Location = new System.Drawing.Point(133, 21);
            this.txt_respuesta.Name = "txt_respuesta";
            this.txt_respuesta.Size = new System.Drawing.Size(100, 20);
            this.txt_respuesta.TabIndex = 5;
            this.txt_respuesta.TextChanged += new System.EventHandler(this.txt_respuesta_TextChanged);
            // 
            // btn_sumar
            // 
            this.btn_sumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sumar.Location = new System.Drawing.Point(13, 19);
            this.btn_sumar.Name = "btn_sumar";
            this.btn_sumar.Size = new System.Drawing.Size(114, 23);
            this.btn_sumar.TabIndex = 6;
            this.btn_sumar.Text = "Sumar";
            this.btn_sumar.UseVisualStyleBackColor = true;
            this.btn_sumar.Click += new System.EventHandler(this.btn_sumar_Click);
            // 
            // btn_restar
            // 
            this.btn_restar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restar.Location = new System.Drawing.Point(13, 48);
            this.btn_restar.Name = "btn_restar";
            this.btn_restar.Size = new System.Drawing.Size(114, 23);
            this.btn_restar.TabIndex = 8;
            this.btn_restar.Text = "Restar";
            this.btn_restar.UseVisualStyleBackColor = true;
            this.btn_restar.Click += new System.EventHandler(this.btn_restar_Click);
            // 
            // txt_respuesta1
            // 
            this.txt_respuesta1.Location = new System.Drawing.Point(133, 50);
            this.txt_respuesta1.Name = "txt_respuesta1";
            this.txt_respuesta1.Size = new System.Drawing.Size(100, 20);
            this.txt_respuesta1.TabIndex = 7;
            this.txt_respuesta1.TextChanged += new System.EventHandler(this.txt_respuesta1_TextChanged);
            // 
            // btn_dividir
            // 
            this.btn_dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dividir.Location = new System.Drawing.Point(13, 78);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(114, 23);
            this.btn_dividir.TabIndex = 10;
            this.btn_dividir.Text = "Dividir";
            this.btn_dividir.UseVisualStyleBackColor = true;
            this.btn_dividir.Click += new System.EventHandler(this.btn_dividir_Click);
            // 
            // txt_respuesta2
            // 
            this.txt_respuesta2.Location = new System.Drawing.Point(133, 78);
            this.txt_respuesta2.Name = "txt_respuesta2";
            this.txt_respuesta2.Size = new System.Drawing.Size(100, 20);
            this.txt_respuesta2.TabIndex = 9;
            this.txt_respuesta2.TextChanged += new System.EventHandler(this.txt_respuesta2_TextChanged);
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplicar.Location = new System.Drawing.Point(13, 106);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(114, 23);
            this.btn_multiplicar.TabIndex = 12;
            this.btn_multiplicar.Text = "Multiplicar";
            this.btn_multiplicar.UseVisualStyleBackColor = true;
            this.btn_multiplicar.Click += new System.EventHandler(this.btn_multiplicar_Click);
            // 
            // txt_respuesta3
            // 
            this.txt_respuesta3.Location = new System.Drawing.Point(133, 106);
            this.txt_respuesta3.Name = "txt_respuesta3";
            this.txt_respuesta3.Size = new System.Drawing.Size(100, 20);
            this.txt_respuesta3.TabIndex = 11;
            this.txt_respuesta3.TextChanged += new System.EventHandler(this.txt_respuesta3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "CALCULADORA";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Limpiar pantalla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.btn_raiz);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.btn_potencia);
            this.panel1.Controls.Add(this.txt_respuesta5);
            this.panel1.Controls.Add(this.txt_respuesta4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_respuesta);
            this.panel1.Controls.Add(this.btn_dividir);
            this.panel1.Controls.Add(this.btn_sumar);
            this.panel1.Controls.Add(this.btn_multiplicar);
            this.panel1.Controls.Add(this.txt_respuesta1);
            this.panel1.Controls.Add(this.txt_respuesta3);
            this.panel1.Controls.Add(this.btn_restar);
            this.panel1.Controls.Add(this.txt_respuesta2);
            this.panel1.Location = new System.Drawing.Point(25, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 241);
            this.panel1.TabIndex = 15;
            // 
            // btn_raiz
            // 
            this.btn_raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_raiz.Location = new System.Drawing.Point(13, 165);
            this.btn_raiz.Name = "btn_raiz";
            this.btn_raiz.Size = new System.Drawing.Size(114, 22);
            this.btn_raiz.TabIndex = 21;
            this.btn_raiz.Text = "Raiz Cuadrada";
            this.btn_raiz.UseVisualStyleBackColor = true;
            this.btn_raiz.Click += new System.EventHandler(this.btn_raiz_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(174, 206);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(59, 23);
            this.btn_salir.TabIndex = 20;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_potencia
            // 
            this.btn_potencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_potencia.Location = new System.Drawing.Point(13, 137);
            this.btn_potencia.Name = "btn_potencia";
            this.btn_potencia.Size = new System.Drawing.Size(114, 22);
            this.btn_potencia.TabIndex = 18;
            this.btn_potencia.Text = "Potencia";
            this.btn_potencia.UseVisualStyleBackColor = true;
            this.btn_potencia.Click += new System.EventHandler(this.btn_potencia_Click);
            // 
            // txt_respuesta5
            // 
            this.txt_respuesta5.Location = new System.Drawing.Point(133, 165);
            this.txt_respuesta5.Name = "txt_respuesta5";
            this.txt_respuesta5.Size = new System.Drawing.Size(100, 20);
            this.txt_respuesta5.TabIndex = 17;
            // 
            // txt_respuesta4
            // 
            this.txt_respuesta4.Location = new System.Drawing.Point(133, 137);
            this.txt_respuesta4.Name = "txt_respuesta4";
            this.txt_respuesta4.Size = new System.Drawing.Size(100, 20);
            this.txt_respuesta4.TabIndex = 15;
            // 
            // txt_valorRaiz
            // 
            this.txt_valorRaiz.Location = new System.Drawing.Point(177, 76);
            this.txt_valorRaiz.Name = "txt_valorRaiz";
            this.txt_valorRaiz.Size = new System.Drawing.Size(54, 20);
            this.txt_valorRaiz.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Valor Raiz";
            // 
            // Calculador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(296, 365);
            this.Controls.Add(this.txt_valorRaiz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_valorDos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_valorUno);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_valorUno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_valorDos;
        private System.Windows.Forms.TextBox txt_respuesta;
        private System.Windows.Forms.Button btn_sumar;
        private System.Windows.Forms.Button btn_restar;
        private System.Windows.Forms.TextBox txt_respuesta1;
        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.TextBox txt_respuesta2;
        private System.Windows.Forms.Button btn_multiplicar;
        private System.Windows.Forms.TextBox txt_respuesta3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_respuesta4;
        private System.Windows.Forms.Button btn_potencia;
        private System.Windows.Forms.TextBox txt_respuesta5;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_raiz;
        private System.Windows.Forms.TextBox txt_valorRaiz;
        private System.Windows.Forms.Label label4;
    }
}

