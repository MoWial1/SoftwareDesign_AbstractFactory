namespace PaternDekorator
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnBasePizza = new System.Windows.Forms.Button();
            this.btnCheese = new System.Windows.Forms.Button();
            this.btnTomato = new System.Windows.Forms.Button();
            this.btnSalami = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnClearPizza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrice.Location = new System.Drawing.Point(374, 66);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(67, 25);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price: ";
            // 
            // btnBasePizza
            // 
            this.btnBasePizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBasePizza.Location = new System.Drawing.Point(44, 66);
            this.btnBasePizza.Name = "btnBasePizza";
            this.btnBasePizza.Size = new System.Drawing.Size(193, 40);
            this.btnBasePizza.TabIndex = 1;
            this.btnBasePizza.Text = "Create Basic Pizza";
            this.btnBasePizza.UseVisualStyleBackColor = true;
            this.btnBasePizza.Click += new System.EventHandler(this.btnBasePizza_Click);
            // 
            // btnCheese
            // 
            this.btnCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCheese.Location = new System.Drawing.Point(44, 112);
            this.btnCheese.Name = "btnCheese";
            this.btnCheese.Size = new System.Drawing.Size(193, 40);
            this.btnCheese.TabIndex = 2;
            this.btnCheese.Text = "More Cheese";
            this.btnCheese.UseVisualStyleBackColor = true;
            this.btnCheese.Click += new System.EventHandler(this.btnCheese_Click);
            // 
            // btnTomato
            // 
            this.btnTomato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTomato.Location = new System.Drawing.Point(44, 158);
            this.btnTomato.Name = "btnTomato";
            this.btnTomato.Size = new System.Drawing.Size(193, 40);
            this.btnTomato.TabIndex = 3;
            this.btnTomato.Text = "More Tomato";
            this.btnTomato.UseVisualStyleBackColor = true;
            this.btnTomato.Click += new System.EventHandler(this.btnTomato_Click);
            // 
            // btnSalami
            // 
            this.btnSalami.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalami.Location = new System.Drawing.Point(44, 206);
            this.btnSalami.Name = "btnSalami";
            this.btnSalami.Size = new System.Drawing.Size(193, 40);
            this.btnSalami.TabIndex = 4;
            this.btnSalami.Text = "More Salami";
            this.btnSalami.UseVisualStyleBackColor = true;
            this.btnSalami.Click += new System.EventHandler(this.btnSalami_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDescription.Location = new System.Drawing.Point(39, 308);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(164, 25);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Pizza do not exist";
            // 
            // btnClearPizza
            // 
            this.btnClearPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClearPizza.Location = new System.Drawing.Point(44, 252);
            this.btnClearPizza.Name = "btnClearPizza";
            this.btnClearPizza.Size = new System.Drawing.Size(193, 40);
            this.btnClearPizza.TabIndex = 6;
            this.btnClearPizza.Text = "Delete Pizza";
            this.btnClearPizza.UseVisualStyleBackColor = true;
            this.btnClearPizza.Click += new System.EventHandler(this.btnClearPizza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearPizza);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnSalami);
            this.Controls.Add(this.btnTomato);
            this.Controls.Add(this.btnCheese);
            this.Controls.Add(this.btnBasePizza);
            this.Controls.Add(this.lblPrice);
            this.Name = "Form1";
            this.Text = "PizzaDecorator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnBasePizza;
        private System.Windows.Forms.Button btnCheese;
        private System.Windows.Forms.Button btnTomato;
        private System.Windows.Forms.Button btnSalami;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnClearPizza;
    }
}

