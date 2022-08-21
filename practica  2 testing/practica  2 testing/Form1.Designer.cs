namespace practica__2_testing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CoordX = new System.Windows.Forms.ComboBox();
            this.Color = new System.Windows.Forms.ComboBox();
            this.CoordY = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uno = new System.Windows.Forms.Button();
            this.dos = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.cuatro = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.siete = new System.Windows.Forms.Button();
            this.ocho = new System.Windows.Forms.Button();
            this.nueve = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CoordX
            // 
            this.CoordX.BackColor = System.Drawing.SystemColors.MenuText;
            this.CoordX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CoordX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoordX.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoordX.ForeColor = System.Drawing.Color.Transparent;
            this.CoordX.FormattingEnabled = true;
            this.CoordX.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.CoordX.Location = new System.Drawing.Point(92, 63);
            this.CoordX.Margin = new System.Windows.Forms.Padding(2);
            this.CoordX.Name = "CoordX";
            this.CoordX.Size = new System.Drawing.Size(92, 27);
            this.CoordX.TabIndex = 0;
            // 
            // Color
            // 
            this.Color.BackColor = System.Drawing.SystemColors.MenuText;
            this.Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Color.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color.ForeColor = System.Drawing.Color.White;
            this.Color.FormattingEnabled = true;
            this.Color.Items.AddRange(new object[] {
            "Rojo",
            "Verde"});
            this.Color.Location = new System.Drawing.Point(358, 63);
            this.Color.Margin = new System.Windows.Forms.Padding(2);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(92, 27);
            this.Color.TabIndex = 2;
            // 
            // CoordY
            // 
            this.CoordY.BackColor = System.Drawing.SystemColors.MenuText;
            this.CoordY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CoordY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoordY.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoordY.ForeColor = System.Drawing.Color.White;
            this.CoordY.FormattingEnabled = true;
            this.CoordY.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.CoordY.Location = new System.Drawing.Point(224, 63);
            this.CoordY.Margin = new System.Windows.Forms.Padding(2);
            this.CoordY.Name = "CoordY";
            this.CoordY.Size = new System.Drawing.Size(92, 27);
            this.CoordY.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(90, 43);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(111, 17);
            this.label.TabIndex = 3;
            this.label.Text = "Coordenada X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Coordenada Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Color";
            // 
            // uno
            // 
            this.uno.BackColor = System.Drawing.Color.White;
            this.uno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uno.Enabled = false;
            this.uno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uno.Location = new System.Drawing.Point(199, 109);
            this.uno.Margin = new System.Windows.Forms.Padding(2);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(56, 50);
            this.uno.TabIndex = 6;
            this.uno.Text = "0,0";
            this.uno.UseVisualStyleBackColor = false;
            // 
            // dos
            // 
            this.dos.BackColor = System.Drawing.Color.White;
            this.dos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dos.Enabled = false;
            this.dos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dos.Location = new System.Drawing.Point(260, 109);
            this.dos.Margin = new System.Windows.Forms.Padding(2);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(56, 50);
            this.dos.TabIndex = 7;
            this.dos.Text = "0,1";
            this.dos.UseVisualStyleBackColor = false;
            // 
            // tres
            // 
            this.tres.BackColor = System.Drawing.Color.White;
            this.tres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tres.Enabled = false;
            this.tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tres.Location = new System.Drawing.Point(320, 109);
            this.tres.Margin = new System.Windows.Forms.Padding(2);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(56, 50);
            this.tres.TabIndex = 8;
            this.tres.Text = "0,2";
            this.tres.UseVisualStyleBackColor = false;
            // 
            // cuatro
            // 
            this.cuatro.BackColor = System.Drawing.Color.White;
            this.cuatro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuatro.Enabled = false;
            this.cuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuatro.Location = new System.Drawing.Point(199, 164);
            this.cuatro.Margin = new System.Windows.Forms.Padding(2);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(56, 50);
            this.cuatro.TabIndex = 9;
            this.cuatro.Text = "1,0";
            this.cuatro.UseVisualStyleBackColor = false;
            // 
            // cinco
            // 
            this.cinco.BackColor = System.Drawing.Color.White;
            this.cinco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cinco.Enabled = false;
            this.cinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinco.Location = new System.Drawing.Point(260, 164);
            this.cinco.Margin = new System.Windows.Forms.Padding(2);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(56, 50);
            this.cinco.TabIndex = 10;
            this.cinco.Text = "1,1";
            this.cinco.UseVisualStyleBackColor = false;
            // 
            // seis
            // 
            this.seis.BackColor = System.Drawing.Color.White;
            this.seis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seis.Enabled = false;
            this.seis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seis.Location = new System.Drawing.Point(320, 164);
            this.seis.Margin = new System.Windows.Forms.Padding(2);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(56, 50);
            this.seis.TabIndex = 11;
            this.seis.Text = "1,2";
            this.seis.UseVisualStyleBackColor = false;
            // 
            // siete
            // 
            this.siete.BackColor = System.Drawing.Color.White;
            this.siete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siete.Enabled = false;
            this.siete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siete.Location = new System.Drawing.Point(199, 219);
            this.siete.Margin = new System.Windows.Forms.Padding(2);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(56, 50);
            this.siete.TabIndex = 12;
            this.siete.Text = "2,0";
            this.siete.UseVisualStyleBackColor = false;
            // 
            // ocho
            // 
            this.ocho.BackColor = System.Drawing.Color.White;
            this.ocho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ocho.Enabled = false;
            this.ocho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocho.Location = new System.Drawing.Point(260, 219);
            this.ocho.Margin = new System.Windows.Forms.Padding(2);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(56, 50);
            this.ocho.TabIndex = 13;
            this.ocho.Text = "2,1";
            this.ocho.UseVisualStyleBackColor = false;
            // 
            // nueve
            // 
            this.nueve.BackColor = System.Drawing.Color.White;
            this.nueve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nueve.Enabled = false;
            this.nueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nueve.Location = new System.Drawing.Point(320, 219);
            this.nueve.Margin = new System.Windows.Forms.Padding(2);
            this.nueve.Name = "nueve";
            this.nueve.Size = new System.Drawing.Size(56, 50);
            this.nueve.TabIndex = 14;
            this.nueve.Text = "2,2";
            this.nueve.UseVisualStyleBackColor = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(248, 291);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(84, 64);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::practica__2_testing.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(609, 366);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.nueve);
            this.Controls.Add(this.ocho);
            this.Controls.Add(this.siete);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.cuatro);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dos);
            this.Controls.Add(this.uno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.CoordY);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.CoordX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coordenadas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CoordX;
        private System.Windows.Forms.ComboBox Color;
        private System.Windows.Forms.ComboBox CoordY;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uno;
        private System.Windows.Forms.Button dos;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button cuatro;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button siete;
        private System.Windows.Forms.Button ocho;
        private System.Windows.Forms.Button nueve;
        private System.Windows.Forms.Button btnIngresar;
    }
}

