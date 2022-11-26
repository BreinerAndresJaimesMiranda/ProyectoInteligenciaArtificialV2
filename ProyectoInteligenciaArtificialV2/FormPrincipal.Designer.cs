
namespace ProyectoInteligenciaArtificialV2
{
    partial class FormPrincipal
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
            this.buttonBuscarArchivo = new System.Windows.Forms.Button();
            this.textDireccionArchivo = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonContinuar = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.comboBoxEstiloDeRed = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEntradas = new System.Windows.Forms.Label();
            this.labelSalidas = new System.Windows.Forms.Label();
            this.labelPatrones = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBuscarArchivo
            // 
            this.buttonBuscarArchivo.Location = new System.Drawing.Point(50, 148);
            this.buttonBuscarArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscarArchivo.Name = "buttonBuscarArchivo";
            this.buttonBuscarArchivo.Size = new System.Drawing.Size(523, 28);
            this.buttonBuscarArchivo.TabIndex = 0;
            this.buttonBuscarArchivo.Text = "Buscar Archivo";
            this.buttonBuscarArchivo.UseVisualStyleBackColor = true;
            this.buttonBuscarArchivo.Click += new System.EventHandler(this.buttonBuscarArchivo_Click);
            // 
            // textDireccionArchivo
            // 
            this.textDireccionArchivo.Location = new System.Drawing.Point(50, 184);
            this.textDireccionArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.textDireccionArchivo.Name = "textDireccionArchivo";
            this.textDireccionArchivo.Size = new System.Drawing.Size(521, 22);
            this.textDireccionArchivo.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // buttonContinuar
            // 
            this.buttonContinuar.Location = new System.Drawing.Point(283, 228);
            this.buttonContinuar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonContinuar.Name = "buttonContinuar";
            this.buttonContinuar.Size = new System.Drawing.Size(100, 28);
            this.buttonContinuar.TabIndex = 2;
            this.buttonContinuar.Text = "Continuar";
            this.buttonContinuar.UseVisualStyleBackColor = true;
            this.buttonContinuar.Visible = false;
            this.buttonContinuar.Click += new System.EventHandler(this.buttonContinuar_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPrincipal.Controls.Add(this.labelPatrones);
            this.panelPrincipal.Controls.Add(this.labelSalidas);
            this.panelPrincipal.Controls.Add(this.labelEntradas);
            this.panelPrincipal.Controls.Add(this.comboBoxEstiloDeRed);
            this.panelPrincipal.Controls.Add(this.buttonContinuar);
            this.panelPrincipal.Controls.Add(this.label1);
            this.panelPrincipal.Controls.Add(this.buttonBuscarArchivo);
            this.panelPrincipal.Controls.Add(this.textDireccionArchivo);
            this.panelPrincipal.Location = new System.Drawing.Point(0, -1);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(648, 292);
            this.panelPrincipal.TabIndex = 3;
            // 
            // comboBoxEstiloDeRed
            // 
            this.comboBoxEstiloDeRed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstiloDeRed.FormattingEnabled = true;
            this.comboBoxEstiloDeRed.Items.AddRange(new object[] {
            "Unicapa",
            "Multicapa"});
            this.comboBoxEstiloDeRed.Location = new System.Drawing.Point(168, 43);
            this.comboBoxEstiloDeRed.Name = "comboBoxEstiloDeRed";
            this.comboBoxEstiloDeRed.Size = new System.Drawing.Size(415, 24);
            this.comboBoxEstiloDeRed.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estilo de Red:";
            // 
            // labelEntradas
            // 
            this.labelEntradas.AutoSize = true;
            this.labelEntradas.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntradas.Location = new System.Drawing.Point(46, 105);
            this.labelEntradas.Name = "labelEntradas";
            this.labelEntradas.Size = new System.Drawing.Size(106, 20);
            this.labelEntradas.TabIndex = 4;
            this.labelEntradas.Text = "Entradas: ";
            // 
            // labelSalidas
            // 
            this.labelSalidas.AutoSize = true;
            this.labelSalidas.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalidas.Location = new System.Drawing.Point(260, 105);
            this.labelSalidas.Name = "labelSalidas";
            this.labelSalidas.Size = new System.Drawing.Size(89, 20);
            this.labelSalidas.TabIndex = 5;
            this.labelSalidas.Text = "Salidas: ";
            // 
            // labelPatrones
            // 
            this.labelPatrones.AutoSize = true;
            this.labelPatrones.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatrones.Location = new System.Drawing.Point(442, 105);
            this.labelPatrones.Name = "labelPatrones";
            this.labelPatrones.Size = new System.Drawing.Size(107, 20);
            this.labelPatrones.TabIndex = 6;
            this.labelPatrones.Text = "Patrones: ";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 289);
            this.Controls.Add(this.panelPrincipal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscarArchivo;
        private System.Windows.Forms.TextBox textDireccionArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonContinuar;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.ComboBox comboBoxEstiloDeRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPatrones;
        private System.Windows.Forms.Label labelSalidas;
        private System.Windows.Forms.Label labelEntradas;
    }
}

