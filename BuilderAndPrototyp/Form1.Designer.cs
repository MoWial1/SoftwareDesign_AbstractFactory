namespace BuilderAndPrototyp
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
            this.rbClassicPizza = new System.Windows.Forms.RadioButton();
            this.rbVeggiePizza = new System.Windows.Forms.RadioButton();
            this.rbHawaiianPizza = new System.Windows.Forms.RadioButton();
            this.rbMeatPizza = new System.Windows.Forms.RadioButton();
            this.btnCreatePizza = new System.Windows.Forms.Button();
            this.btnClonePizza = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbClassicPizza
            // 
            this.rbClassicPizza.AutoSize = true;
            this.rbClassicPizza.Location = new System.Drawing.Point(87, 97);
            this.rbClassicPizza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbClassicPizza.Name = "rbClassicPizza";
            this.rbClassicPizza.Size = new System.Drawing.Size(150, 29);
            this.rbClassicPizza.TabIndex = 0;
            this.rbClassicPizza.TabStop = true;
            this.rbClassicPizza.Text = "Classic Pizza";
            this.rbClassicPizza.UseVisualStyleBackColor = true;
            // 
            // rbVeggiePizza
            // 
            this.rbVeggiePizza.AutoSize = true;
            this.rbVeggiePizza.Location = new System.Drawing.Point(87, 136);
            this.rbVeggiePizza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbVeggiePizza.Name = "rbVeggiePizza";
            this.rbVeggiePizza.Size = new System.Drawing.Size(148, 29);
            this.rbVeggiePizza.TabIndex = 1;
            this.rbVeggiePizza.TabStop = true;
            this.rbVeggiePizza.Text = "Veggie Pizza";
            this.rbVeggiePizza.UseVisualStyleBackColor = true;
            // 
            // rbHawaiianPizza
            // 
            this.rbHawaiianPizza.AutoSize = true;
            this.rbHawaiianPizza.Location = new System.Drawing.Point(87, 175);
            this.rbHawaiianPizza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbHawaiianPizza.Name = "rbHawaiianPizza";
            this.rbHawaiianPizza.Size = new System.Drawing.Size(166, 29);
            this.rbHawaiianPizza.TabIndex = 2;
            this.rbHawaiianPizza.TabStop = true;
            this.rbHawaiianPizza.Text = "Hawaiian Pizza";
            this.rbHawaiianPizza.UseVisualStyleBackColor = true;
            // 
            // rbMeatPizza
            // 
            this.rbMeatPizza.AutoSize = true;
            this.rbMeatPizza.Location = new System.Drawing.Point(87, 214);
            this.rbMeatPizza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbMeatPizza.Name = "rbMeatPizza";
            this.rbMeatPizza.Size = new System.Drawing.Size(130, 29);
            this.rbMeatPizza.TabIndex = 3;
            this.rbMeatPizza.TabStop = true;
            this.rbMeatPizza.Text = "Meat Pizza";
            this.rbMeatPizza.UseVisualStyleBackColor = true;
            // 
            // btnCreatePizza
            // 
            this.btnCreatePizza.Location = new System.Drawing.Point(87, 303);
            this.btnCreatePizza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreatePizza.Name = "btnCreatePizza";
            this.btnCreatePizza.Size = new System.Drawing.Size(178, 36);
            this.btnCreatePizza.TabIndex = 4;
            this.btnCreatePizza.Text = "Create Pizza";
            this.btnCreatePizza.UseVisualStyleBackColor = true;
            this.btnCreatePizza.Click += new System.EventHandler(this.btnCreatePizza_Click);
            // 
            // btnClonePizza
            // 
            this.btnClonePizza.Location = new System.Drawing.Point(87, 366);
            this.btnClonePizza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClonePizza.Name = "btnClonePizza";
            this.btnClonePizza.Size = new System.Drawing.Size(178, 36);
            this.btnClonePizza.TabIndex = 5;
            this.btnClonePizza.Text = "Clone Pizza";
            this.btnClonePizza.UseVisualStyleBackColor = true;
            this.btnClonePizza.Click += new System.EventHandler(this.btnClonePizza_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(414, 97);
            this.tbResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(323, 242);
            this.tbResult.TabIndex = 6;
            this.tbResult.Text = "Створи піцу";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 425);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnClonePizza);
            this.Controls.Add(this.btnCreatePizza);
            this.Controls.Add(this.rbMeatPizza);
            this.Controls.Add(this.rbHawaiianPizza);
            this.Controls.Add(this.rbVeggiePizza);
            this.Controls.Add(this.rbClassicPizza);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbClassicPizza;
        private System.Windows.Forms.RadioButton rbVeggiePizza;
        private System.Windows.Forms.RadioButton rbHawaiianPizza;
        private System.Windows.Forms.RadioButton rbMeatPizza;
        private System.Windows.Forms.Button btnCreatePizza;
        private System.Windows.Forms.Button btnClonePizza;
        private System.Windows.Forms.TextBox tbResult;
    }
}

