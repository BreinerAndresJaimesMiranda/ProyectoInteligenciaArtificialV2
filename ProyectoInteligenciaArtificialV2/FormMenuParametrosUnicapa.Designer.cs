
namespace ProyectoInteligenciaArtificialV2
{
    partial class FormMenuParametrosUnicapa
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxFuncionDeActivacion = new System.Windows.Forms.ListBox();
            this.listBoxAlgoritmoDeEntrenamiento = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonContinuar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxTipoDeRed = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPesos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUmbrales = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(198, 97);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(223, 22);
            this.numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown2.Location = new System.Drawing.Point(198, 135);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.ReadOnly = true;
            this.numericUpDown2.Size = new System.Drawing.Size(223, 22);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown3.Location = new System.Drawing.Point(198, 167);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.ReadOnly = true;
            this.numericUpDown3.Size = new System.Drawing.Size(223, 22);
            this.numericUpDown3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Iteraciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rata de aprendizaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Error Maximo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(667, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Algoritmo de entrenamiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(457, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Funcion de activacion";
            // 
            // listBoxFuncionDeActivacion
            // 
            this.listBoxFuncionDeActivacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBoxFuncionDeActivacion.FormattingEnabled = true;
            this.listBoxFuncionDeActivacion.ItemHeight = 16;
            this.listBoxFuncionDeActivacion.Items.AddRange(new object[] {
            "Lineal"});
            this.listBoxFuncionDeActivacion.Location = new System.Drawing.Point(470, 97);
            this.listBoxFuncionDeActivacion.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFuncionDeActivacion.Name = "listBoxFuncionDeActivacion";
            this.listBoxFuncionDeActivacion.Size = new System.Drawing.Size(159, 116);
            this.listBoxFuncionDeActivacion.TabIndex = 12;
            // 
            // listBoxAlgoritmoDeEntrenamiento
            // 
            this.listBoxAlgoritmoDeEntrenamiento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBoxAlgoritmoDeEntrenamiento.FormattingEnabled = true;
            this.listBoxAlgoritmoDeEntrenamiento.ItemHeight = 16;
            this.listBoxAlgoritmoDeEntrenamiento.Items.AddRange(new object[] {
            "Regla Delta"});
            this.listBoxAlgoritmoDeEntrenamiento.Location = new System.Drawing.Point(698, 97);
            this.listBoxAlgoritmoDeEntrenamiento.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAlgoritmoDeEntrenamiento.Name = "listBoxAlgoritmoDeEntrenamiento";
            this.listBoxAlgoritmoDeEntrenamiento.Size = new System.Drawing.Size(159, 116);
            this.listBoxAlgoritmoDeEntrenamiento.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Unicapa";
            // 
            // buttonContinuar
            // 
            this.buttonContinuar.Font = new System.Drawing.Font("Orbitron", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinuar.Location = new System.Drawing.Point(404, 453);
            this.buttonContinuar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonContinuar.Name = "buttonContinuar";
            this.buttonContinuar.Size = new System.Drawing.Size(171, 42);
            this.buttonContinuar.TabIndex = 16;
            this.buttonContinuar.Text = "Continuar";
            this.buttonContinuar.UseVisualStyleBackColor = true;
            this.buttonContinuar.Click += new System.EventHandler(this.buttonContinuar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tipo de red: ";
            // 
            // comboBoxTipoDeRed
            // 
            this.comboBoxTipoDeRed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoDeRed.FormattingEnabled = true;
            this.comboBoxTipoDeRed.Items.AddRange(new object[] {
            "Adaline",
            "Perceptron",
            "BackPropagation"});
            this.comboBoxTipoDeRed.Location = new System.Drawing.Point(198, 66);
            this.comboBoxTipoDeRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTipoDeRed.Name = "comboBoxTipoDeRed";
            this.comboBoxTipoDeRed.Size = new System.Drawing.Size(223, 24);
            this.comboBoxTipoDeRed.TabIndex = 18;
            this.comboBoxTipoDeRed.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoDeRed_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelPesos);
            this.panel1.Location = new System.Drawing.Point(319, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 158);
            this.panel1.TabIndex = 19;
            // 
            // labelPesos
            // 
            this.labelPesos.AutoSize = true;
            this.labelPesos.Location = new System.Drawing.Point(3, 9);
            this.labelPesos.Name = "labelPesos";
            this.labelPesos.Size = new System.Drawing.Size(0, 16);
            this.labelPesos.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelUmbrales);
            this.panel2.Location = new System.Drawing.Point(319, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 53);
            this.panel2.TabIndex = 20;
            // 
            // labelUmbrales
            // 
            this.labelUmbrales.AutoSize = true;
            this.labelUmbrales.Location = new System.Drawing.Point(3, 9);
            this.labelUmbrales.Name = "labelUmbrales";
            this.labelUmbrales.Size = new System.Drawing.Size(0, 16);
            this.labelUmbrales.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(151, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Pesos Sinapticos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(214, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Umbrales:";
            // 
            // FormMenuParametrosUnicapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(958, 506);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxTipoDeRed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonContinuar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxAlgoritmoDeEntrenamiento);
            this.Controls.Add(this.listBoxFuncionDeActivacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenuParametrosUnicapa";
            this.Text = "FormMenuParametros";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxFuncionDeActivacion;
        private System.Windows.Forms.ListBox listBoxAlgoritmoDeEntrenamiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonContinuar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxTipoDeRed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPesos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelUmbrales;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}