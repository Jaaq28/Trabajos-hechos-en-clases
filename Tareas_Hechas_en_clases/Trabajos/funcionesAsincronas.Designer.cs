
namespace Trabajos
{
    partial class funcionesAsincronas
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
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.ResultadoLabel = new System.Windows.Forms.Label();
            this.SumarButton = new System.Windows.Forms.Button();
            this.ResultadoSumaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EjecutarButton.Location = new System.Drawing.Point(82, 48);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(170, 57);
            this.EjecutarButton.TabIndex = 0;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // ResultadoLabel
            // 
            this.ResultadoLabel.AutoSize = true;
            this.ResultadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoLabel.Location = new System.Drawing.Point(78, 203);
            this.ResultadoLabel.Name = "ResultadoLabel";
            this.ResultadoLabel.Size = new System.Drawing.Size(59, 20);
            this.ResultadoLabel.TabIndex = 1;
            this.ResultadoLabel.Text = "label1";
            this.ResultadoLabel.Click += new System.EventHandler(this.ResultadoLabel_Click);
            // 
            // SumarButton
            // 
            this.SumarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumarButton.Location = new System.Drawing.Point(338, 48);
            this.SumarButton.Name = "SumarButton";
            this.SumarButton.Size = new System.Drawing.Size(170, 57);
            this.SumarButton.TabIndex = 2;
            this.SumarButton.Text = "Sumar";
            this.SumarButton.UseVisualStyleBackColor = true;
            this.SumarButton.Click += new System.EventHandler(this.SumarButton_Click);
            // 
            // ResultadoSumaLabel
            // 
            this.ResultadoSumaLabel.AutoSize = true;
            this.ResultadoSumaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoSumaLabel.Location = new System.Drawing.Point(334, 203);
            this.ResultadoSumaLabel.Name = "ResultadoSumaLabel";
            this.ResultadoSumaLabel.Size = new System.Drawing.Size(59, 20);
            this.ResultadoSumaLabel.TabIndex = 3;
            this.ResultadoSumaLabel.Text = "label1";
            // 
            // funcionesAsincronas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 407);
            this.Controls.Add(this.ResultadoSumaLabel);
            this.Controls.Add(this.SumarButton);
            this.Controls.Add(this.ResultadoLabel);
            this.Controls.Add(this.EjecutarButton);
            this.Name = "funcionesAsincronas";
            this.Text = "funcionesAsincronas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.Label ResultadoLabel;
        private System.Windows.Forms.Button SumarButton;
        private System.Windows.Forms.Label ResultadoSumaLabel;
    }
}