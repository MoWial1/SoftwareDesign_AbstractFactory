namespace FlatFigures
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.LeftToolsPanel = new System.Windows.Forms.Panel();
            this.btnAddRectangle = new System.Windows.Forms.Button();
            this.btnAddCircle = new System.Windows.Forms.Button();
            this.btnAddSquare = new System.Windows.Forms.Button();
            this.pbPenColor = new System.Windows.Forms.PictureBox();
            this.pbBrushColor = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.LeftToolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPenColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrushColor)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.pictureBoxCanvas);
            this.leftPanel.Controls.Add(this.LeftToolsPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(1162, 535);
            this.leftPanel.TabIndex = 1;
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxCanvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCanvas.Location = new System.Drawing.Point(0, 75);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(1162, 460);
            this.pictureBoxCanvas.TabIndex = 1;
            this.pictureBoxCanvas.TabStop = false;
            this.pictureBoxCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseDown);
            this.pictureBoxCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseMove);
            this.pictureBoxCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseUp);
            // 
            // LeftToolsPanel
            // 
            this.LeftToolsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftToolsPanel.Controls.Add(this.pbBrushColor);
            this.LeftToolsPanel.Controls.Add(this.pbPenColor);
            this.LeftToolsPanel.Controls.Add(this.btnAddSquare);
            this.LeftToolsPanel.Controls.Add(this.btnAddCircle);
            this.LeftToolsPanel.Controls.Add(this.btnAddRectangle);
            this.LeftToolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeftToolsPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolsPanel.Name = "LeftToolsPanel";
            this.LeftToolsPanel.Size = new System.Drawing.Size(1162, 75);
            this.LeftToolsPanel.TabIndex = 0;
            // 
            // btnAddRectangle
            // 
            this.btnAddRectangle.Location = new System.Drawing.Point(28, 11);
            this.btnAddRectangle.Name = "btnAddRectangle";
            this.btnAddRectangle.Size = new System.Drawing.Size(88, 45);
            this.btnAddRectangle.TabIndex = 0;
            this.btnAddRectangle.Text = "Rectangle";
            this.btnAddRectangle.UseVisualStyleBackColor = true;
            this.btnAddRectangle.Click += new System.EventHandler(this.btnAddRectangle_Click);
            // 
            // btnAddCircle
            // 
            this.btnAddCircle.Location = new System.Drawing.Point(213, 11);
            this.btnAddCircle.Name = "btnAddCircle";
            this.btnAddCircle.Size = new System.Drawing.Size(88, 45);
            this.btnAddCircle.TabIndex = 1;
            this.btnAddCircle.Text = "Circle";
            this.btnAddCircle.UseVisualStyleBackColor = true;
            this.btnAddCircle.Click += new System.EventHandler(this.btnAddCircle_Click);
            // 
            // btnAddSquare
            // 
            this.btnAddSquare.Location = new System.Drawing.Point(122, 11);
            this.btnAddSquare.Name = "btnAddSquare";
            this.btnAddSquare.Size = new System.Drawing.Size(85, 45);
            this.btnAddSquare.TabIndex = 2;
            this.btnAddSquare.Text = "Square";
            this.btnAddSquare.UseVisualStyleBackColor = true;
            this.btnAddSquare.Click += new System.EventHandler(this.btnAddSquare_Click);
            // 
            // pbPenColor
            // 
            this.pbPenColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPenColor.Location = new System.Drawing.Point(407, 11);
            this.pbPenColor.Name = "pbPenColor";
            this.pbPenColor.Size = new System.Drawing.Size(100, 45);
            this.pbPenColor.TabIndex = 3;
            this.pbPenColor.TabStop = false;
            this.pbPenColor.Click += new System.EventHandler(this.pbPenColor_Click);
            // 
            // pbBrushColor
            // 
            this.pbBrushColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBrushColor.Location = new System.Drawing.Point(530, 14);
            this.pbBrushColor.Name = "pbBrushColor";
            this.pbBrushColor.Size = new System.Drawing.Size(100, 45);
            this.pbBrushColor.TabIndex = 4;
            this.pbBrushColor.TabStop = false;
            this.pbBrushColor.Click += new System.EventHandler(this.pbBrushColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 535);
            this.Controls.Add(this.leftPanel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.LeftToolsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPenColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrushColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.Panel LeftToolsPanel;
        private System.Windows.Forms.Button btnAddSquare;
        private System.Windows.Forms.Button btnAddCircle;
        private System.Windows.Forms.Button btnAddRectangle;
        private System.Windows.Forms.PictureBox pbBrushColor;
        private System.Windows.Forms.PictureBox pbPenColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

