namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nbSpeedRender = new System.Windows.Forms.NumericUpDown();
            this.btnRun = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nbCols = new System.Windows.Forms.NumericUpDown();
            this.nbRows = new System.Windows.Forms.NumericUpDown();
            this.lCols = new System.Windows.Forms.Label();
            this.lRows = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSpeedRender)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbRows)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 538);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(987, 538);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nbSpeedRender);
            this.panel2.Controls.Add(this.btnRun);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(813, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 538);
            this.panel2.TabIndex = 2;
            // 
            // nbSpeedRender
            // 
            this.nbSpeedRender.Location = new System.Drawing.Point(87, 86);
            this.nbSpeedRender.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nbSpeedRender.Name = "nbSpeedRender";
            this.nbSpeedRender.Size = new System.Drawing.Size(75, 20);
            this.nbSpeedRender.TabIndex = 2;
            this.nbSpeedRender.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nbSpeedRender.ValueChanged += new System.EventHandler(this.nbSpeedRender_ValueChanged);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(6, 83);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nbCols);
            this.groupBox1.Controls.Add(this.nbRows);
            this.groupBox1.Controls.Add(this.lCols);
            this.groupBox1.Controls.Add(this.lRows);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры матрицы";
            // 
            // nbCols
            // 
            this.nbCols.Location = new System.Drawing.Point(6, 45);
            this.nbCols.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nbCols.Name = "nbCols";
            this.nbCols.Size = new System.Drawing.Size(75, 20);
            this.nbCols.TabIndex = 5;
            this.nbCols.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nbRows
            // 
            this.nbRows.Location = new System.Drawing.Point(6, 19);
            this.nbRows.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nbRows.Name = "nbRows";
            this.nbRows.Size = new System.Drawing.Size(75, 20);
            this.nbRows.TabIndex = 4;
            this.nbRows.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lCols
            // 
            this.lCols.AutoSize = true;
            this.lCols.Location = new System.Drawing.Point(87, 47);
            this.lCols.Name = "lCols";
            this.lCols.Size = new System.Drawing.Size(27, 13);
            this.lCols.TabIndex = 3;
            this.lCols.Text = "Cols";
            // 
            // lRows
            // 
            this.lRows.AutoSize = true;
            this.lRows.Location = new System.Drawing.Point(87, 26);
            this.lRows.Name = "lRows";
            this.lRows.Size = new System.Drawing.Size(34, 13);
            this.lRows.TabIndex = 2;
            this.lRows.Text = "Rows";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbSpeedRender)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbRows)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lCols;
        private System.Windows.Forms.Label lRows;
        private System.Windows.Forms.NumericUpDown nbSpeedRender;
        private System.Windows.Forms.NumericUpDown nbCols;
        private System.Windows.Forms.NumericUpDown nbRows;
    }
}

