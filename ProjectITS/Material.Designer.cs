namespace ProjectITS
{
    partial class Material
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Material));
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartMaterial = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAlegebraMat = new System.Windows.Forms.Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.btnArithmeticMat = new System.Windows.Forms.Button();
            this.btnGeoMat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1609, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Learning Material";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStartMaterial
            // 
            this.btnStartMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStartMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMaterial.Location = new System.Drawing.Point(167, 912);
            this.btnStartMaterial.Name = "btnStartMaterial";
            this.btnStartMaterial.Size = new System.Drawing.Size(165, 83);
            this.btnStartMaterial.TabIndex = 19;
            this.btnStartMaterial.Text = "Start Tutorial";
            this.btnStartMaterial.UseVisualStyleBackColor = false;
            this.btnStartMaterial.Click += new System.EventHandler(this.btnStartMaterial_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(379, 912);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 83);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAlegebraMat
            // 
            this.btnAlegebraMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlegebraMat.Location = new System.Drawing.Point(126, 80);
            this.btnAlegebraMat.Name = "btnAlegebraMat";
            this.btnAlegebraMat.Size = new System.Drawing.Size(204, 81);
            this.btnAlegebraMat.TabIndex = 21;
            this.btnAlegebraMat.Text = "Algebra";
            this.btnAlegebraMat.UseVisualStyleBackColor = true;
            this.btnAlegebraMat.Click += new System.EventHandler(this.button1_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(126, 119);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(1120, 458);
            this.axAcroPDF1.TabIndex = 22;
            // 
            // btnArithmeticMat
            // 
            this.btnArithmeticMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArithmeticMat.Location = new System.Drawing.Point(418, 80);
            this.btnArithmeticMat.Name = "btnArithmeticMat";
            this.btnArithmeticMat.Size = new System.Drawing.Size(204, 81);
            this.btnArithmeticMat.TabIndex = 23;
            this.btnArithmeticMat.Text = "Arithmetic";
            this.btnArithmeticMat.UseVisualStyleBackColor = true;
            this.btnArithmeticMat.Click += new System.EventHandler(this.btnArithmeticMat_Click);
            // 
            // btnGeoMat
            // 
            this.btnGeoMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeoMat.Location = new System.Drawing.Point(699, 80);
            this.btnGeoMat.Name = "btnGeoMat";
            this.btnGeoMat.Size = new System.Drawing.Size(204, 81);
            this.btnGeoMat.TabIndex = 24;
            this.btnGeoMat.Text = "Geometry";
            this.btnGeoMat.UseVisualStyleBackColor = true;
            this.btnGeoMat.Click += new System.EventHandler(this.btnGeoMat_Click);
            // 
            // Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 1007);
            this.Controls.Add(this.btnGeoMat);
            this.Controls.Add(this.btnArithmeticMat);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.btnAlegebraMat);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStartMaterial);
            this.Controls.Add(this.label1);
            this.Name = "Material";
            this.Text = "Material";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Material_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartMaterial;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAlegebraMat;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button btnArithmeticMat;
        private System.Windows.Forms.Button btnGeoMat;
    }
}