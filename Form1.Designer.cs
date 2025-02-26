namespace FormPractica
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
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.apellidosLabel = new System.Windows.Forms.Label();
            this.apellidosBox = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(228, 89);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(100, 20);
            this.nombreBox.TabIndex = 0;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(125, 96);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(44, 13);
            this.nombreLabel.TabIndex = 1;
            this.nombreLabel.Text = "Nombre";
            // 
            // apellidosLabel
            // 
            this.apellidosLabel.AutoSize = true;
            this.apellidosLabel.Location = new System.Drawing.Point(125, 177);
            this.apellidosLabel.Name = "apellidosLabel";
            this.apellidosLabel.Size = new System.Drawing.Size(49, 13);
            this.apellidosLabel.TabIndex = 2;
            this.apellidosLabel.Text = "Apellidos";
            // 
            // apellidosBox
            // 
            this.apellidosBox.Location = new System.Drawing.Point(228, 170);
            this.apellidosBox.Name = "apellidosBox";
            this.apellidosBox.Size = new System.Drawing.Size(100, 20);
            this.apellidosBox.TabIndex = 3;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(436, 358);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 4;
            this.acceptButton.Text = "Aceptar";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.apellidosBox);
            this.Controls.Add(this.apellidosLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.nombreBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label apellidosLabel;
        private System.Windows.Forms.TextBox apellidosBox;
        private System.Windows.Forms.Button acceptButton;
    }
}

