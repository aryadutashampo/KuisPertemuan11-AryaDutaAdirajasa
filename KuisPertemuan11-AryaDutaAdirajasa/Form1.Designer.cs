namespace KuisPertemuan11_AryaDutaAdirajasa
{
    partial class FormUtama
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
            this.panelTampilan = new System.Windows.Forms.Panel();
            this.labelPasim = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnUPD = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelTampilan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTampilan
            // 
            this.panelTampilan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTampilan.Controls.Add(this.dataGridView1);
            this.panelTampilan.Controls.Add(this.btnUPD);
            this.panelTampilan.Controls.Add(this.btnADD);
            this.panelTampilan.Controls.Add(this.labelPasim);
            this.panelTampilan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTampilan.Location = new System.Drawing.Point(0, 0);
            this.panelTampilan.Name = "panelTampilan";
            this.panelTampilan.Size = new System.Drawing.Size(667, 450);
            this.panelTampilan.TabIndex = 0;
            // 
            // labelPasim
            // 
            this.labelPasim.AutoSize = true;
            this.labelPasim.Font = new System.Drawing.Font("Montserrat ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasim.Location = new System.Drawing.Point(25, 62);
            this.labelPasim.Name = "labelPasim";
            this.labelPasim.Size = new System.Drawing.Size(367, 39);
            this.labelPasim.TabIndex = 1;
            this.labelPasim.Text = "Data Mahasiswa PASIM";
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.IndianRed;
            this.btnADD.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnADD.Location = new System.Drawing.Point(342, 123);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(106, 60);
            this.btnADD.TabIndex = 2;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnUPD
            // 
            this.btnUPD.BackColor = System.Drawing.Color.LightSalmon;
            this.btnUPD.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUPD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUPD.Location = new System.Drawing.Point(483, 123);
            this.btnUPD.Name = "btnUPD";
            this.btnUPD.Size = new System.Drawing.Size(106, 60);
            this.btnUPD.TabIndex = 3;
            this.btnUPD.Text = "UPDATE";
            this.btnUPD.UseVisualStyleBackColor = false;
            this.btnUPD.Click += new System.EventHandler(this.btnUPD_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(631, 244);
            this.dataGridView1.TabIndex = 4;
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.panelTampilan);
            this.MaximizeBox = false;
            this.Name = "FormUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz CRUD";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.panelTampilan.ResumeLayout(false);
            this.panelTampilan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTampilan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUPD;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label labelPasim;
    }
}

