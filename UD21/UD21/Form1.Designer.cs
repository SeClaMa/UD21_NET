
namespace UD21
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
            this.label1 = new System.Windows.Forms.Label();
            this.operacion = new System.Windows.Forms.TextBox();
            this.var1 = new System.Windows.Forms.TextBox();
            this.var2 = new System.Windows.Forms.TextBox();
            this.var3 = new System.Windows.Forms.TextBox();
            this.realizarOperacion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Que operacion desea realizar?";
            // 
            // operacion
            // 
            this.operacion.Location = new System.Drawing.Point(337, 119);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(100, 22);
            this.operacion.TabIndex = 1;
            // 
            // var1
            // 
            this.var1.Location = new System.Drawing.Point(154, 220);
            this.var1.Name = "var1";
            this.var1.Size = new System.Drawing.Size(100, 22);
            this.var1.TabIndex = 2;
            // 
            // var2
            // 
            this.var2.Location = new System.Drawing.Point(337, 220);
            this.var2.Name = "var2";
            this.var2.Size = new System.Drawing.Size(100, 22);
            this.var2.TabIndex = 3;
            // 
            // var3
            // 
            this.var3.Location = new System.Drawing.Point(518, 220);
            this.var3.Name = "var3";
            this.var3.Size = new System.Drawing.Size(100, 22);
            this.var3.TabIndex = 4;
            // 
            // realizarOperacion
            // 
            this.realizarOperacion.Location = new System.Drawing.Point(350, 356);
            this.realizarOperacion.Name = "realizarOperacion";
            this.realizarOperacion.Size = new System.Drawing.Size(75, 31);
            this.realizarOperacion.TabIndex = 5;
            this.realizarOperacion.Text = "Aceptar";
            this.realizarOperacion.UseVisualStyleBackColor = true;
            this.realizarOperacion.Click += new System.EventHandler(this.realizarOperacion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre de la figura geometrica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Variable a Calcular 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Variable a Calcular 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Variable a Calcular 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(443, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "No es necesario introducir numeros en variables si solo necesita una";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.realizarOperacion);
            this.Controls.Add(this.var3);
            this.Controls.Add(this.var2);
            this.Controls.Add(this.var1);
            this.Controls.Add(this.operacion);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Figuras Geometricas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox operacion;
        private System.Windows.Forms.TextBox var1;
        private System.Windows.Forms.TextBox var2;
        private System.Windows.Forms.TextBox var3;
        private System.Windows.Forms.Button realizarOperacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

