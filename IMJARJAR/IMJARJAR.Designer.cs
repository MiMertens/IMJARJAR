namespace IMJARJAR
{
    partial class IMJARJAR
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
            this.dgv_Klant = new System.Windows.Forms.DataGridView();
            this.btn_vull = new System.Windows.Forms.Button();
            this.Cursus_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cursus_naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cursus_omschrijving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cursus_aantal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Toevoegen = new System.Windows.Forms.Button();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Naam = new System.Windows.Forms.TextBox();
            this.tb_Om = new System.Windows.Forms.TextBox();
            this.tb_Aantal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Klant)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Klant
            // 
            this.dgv_Klant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Klant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cursus_ID,
            this.Cursus_naam,
            this.Cursus_omschrijving,
            this.Cursus_aantal});
            this.dgv_Klant.Location = new System.Drawing.Point(13, 13);
            this.dgv_Klant.Name = "dgv_Klant";
            this.dgv_Klant.Size = new System.Drawing.Size(508, 346);
            this.dgv_Klant.TabIndex = 0;
            // 
            // btn_vull
            // 
            this.btn_vull.Location = new System.Drawing.Point(527, 12);
            this.btn_vull.Name = "btn_vull";
            this.btn_vull.Size = new System.Drawing.Size(40, 28);
            this.btn_vull.TabIndex = 1;
            this.btn_vull.Text = "Vull";
            this.btn_vull.UseVisualStyleBackColor = true;
            this.btn_vull.Click += new System.EventHandler(this.btn_vull_Click);
            // 
            // Cursus_ID
            // 
            this.Cursus_ID.HeaderText = "ID";
            this.Cursus_ID.Name = "Cursus_ID";
            // 
            // Cursus_naam
            // 
            this.Cursus_naam.HeaderText = "Naam";
            this.Cursus_naam.Name = "Cursus_naam";
            // 
            // Cursus_omschrijving
            // 
            this.Cursus_omschrijving.HeaderText = "Omschrijving";
            this.Cursus_omschrijving.Name = "Cursus_omschrijving";
            // 
            // Cursus_aantal
            // 
            this.Cursus_aantal.HeaderText = "Aantal";
            this.Cursus_aantal.Name = "Cursus_aantal";
            // 
            // btn_Toevoegen
            // 
            this.btn_Toevoegen.Location = new System.Drawing.Point(573, 12);
            this.btn_Toevoegen.Name = "btn_Toevoegen";
            this.btn_Toevoegen.Size = new System.Drawing.Size(95, 28);
            this.btn_Toevoegen.TabIndex = 2;
            this.btn_Toevoegen.Text = "Toevoegen";
            this.btn_Toevoegen.UseVisualStyleBackColor = true;
            this.btn_Toevoegen.Click += new System.EventHandler(this.btn_Toevoegen_Click);
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(527, 76);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(140, 20);
            this.tb_ID.TabIndex = 3;
            // 
            // tb_Naam
            // 
            this.tb_Naam.Location = new System.Drawing.Point(527, 118);
            this.tb_Naam.Name = "tb_Naam";
            this.tb_Naam.Size = new System.Drawing.Size(140, 20);
            this.tb_Naam.TabIndex = 4;
            // 
            // tb_Om
            // 
            this.tb_Om.Location = new System.Drawing.Point(527, 162);
            this.tb_Om.Name = "tb_Om";
            this.tb_Om.Size = new System.Drawing.Size(140, 20);
            this.tb_Om.TabIndex = 5;
            // 
            // tb_Aantal
            // 
            this.tb_Aantal.Location = new System.Drawing.Point(527, 204);
            this.tb_Aantal.Name = "tb_Aantal";
            this.tb_Aantal.Size = new System.Drawing.Size(140, 20);
            this.tb_Aantal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Omschrijving";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Aantal";
            // 
            // IMJARJAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 371);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Aantal);
            this.Controls.Add(this.tb_Om);
            this.Controls.Add(this.tb_Naam);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.btn_Toevoegen);
            this.Controls.Add(this.btn_vull);
            this.Controls.Add(this.dgv_Klant);
            this.Name = "IMJARJAR";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Klant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Klant;
        private System.Windows.Forms.Button btn_vull;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cursus_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cursus_naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cursus_omschrijving;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cursus_aantal;
        private System.Windows.Forms.Button btn_Toevoegen;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_Naam;
        private System.Windows.Forms.TextBox tb_Om;
        private System.Windows.Forms.TextBox tb_Aantal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

