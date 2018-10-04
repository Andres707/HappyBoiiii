namespace Proyecto
{
    partial class fLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLibros));
            this.picRegresar = new System.Windows.Forms.PictureBox();
            this.tabLibros = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.picLibros = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRegresar)).BeginInit();
            this.tabLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // picRegresar
            // 
            this.picRegresar.BackColor = System.Drawing.Color.Transparent;
            this.picRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRegresar.BackgroundImage")));
            this.picRegresar.Image = ((System.Drawing.Image)(resources.GetObject("picRegresar.Image")));
            this.picRegresar.Location = new System.Drawing.Point(12, 311);
            this.picRegresar.Name = "picRegresar";
            this.picRegresar.Size = new System.Drawing.Size(39, 38);
            this.picRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegresar.TabIndex = 4;
            this.picRegresar.TabStop = false;
            this.picRegresar.Click += new System.EventHandler(this.picRegresar_Click);
            // 
            // tabLibros
            // 
            this.tabLibros.Controls.Add(this.tabPage1);
            this.tabLibros.Controls.Add(this.tabPage2);
            this.tabLibros.Controls.Add(this.tabPage3);
            this.tabLibros.Controls.Add(this.tabPage4);
            this.tabLibros.Location = new System.Drawing.Point(0, 0);
            this.tabLibros.Name = "tabLibros";
            this.tabLibros.SelectedIndex = 0;
            this.tabLibros.Size = new System.Drawing.Size(433, 305);
            this.tabLibros.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(425, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Libro 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(425, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Libro 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(425, 279);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Libro 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(193, 311);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 38);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(425, 279);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Libro Agregado";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // picLibros
            // 
            this.picLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLibros.Image = ((System.Drawing.Image)(resources.GetObject("picLibros.Image")));
            this.picLibros.Location = new System.Drawing.Point(0, 0);
            this.picLibros.Name = "picLibros";
            this.picLibros.Size = new System.Drawing.Size(434, 361);
            this.picLibros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLibros.TabIndex = 9;
            this.picLibros.TabStop = false;
            // 
            // fLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tabLibros);
            this.Controls.Add(this.picRegresar);
            this.Controls.Add(this.picLibros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros";
            ((System.ComponentModel.ISupportInitialize)(this.picRegresar)).EndInit();
            this.tabLibros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picRegresar;
        private System.Windows.Forms.TabControl tabLibros;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox picLibros;
    }
}