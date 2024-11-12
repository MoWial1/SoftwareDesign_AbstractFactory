namespace SoftwareDesign
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
            this.btnBoeingFactory = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.btnAirbusFactory = new System.Windows.Forms.Button();
            this.btnLockheedFactory = new System.Windows.Forms.Button();
            this.btnCreatePassenger = new System.Windows.Forms.Button();
            this.btnCreateCargo = new System.Windows.Forms.Button();
            this.btnCreateMilitary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBoeingFactory
            // 
            this.btnBoeingFactory.Location = new System.Drawing.Point(175, 89);
            this.btnBoeingFactory.Name = "btnBoeingFactory";
            this.btnBoeingFactory.Size = new System.Drawing.Size(75, 32);
            this.btnBoeingFactory.TabIndex = 0;
            this.btnBoeingFactory.Text = "Boeing";
            this.btnBoeingFactory.UseVisualStyleBackColor = true;
            this.btnBoeingFactory.Click += new System.EventHandler(this.btnBoeingFactory_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(175, 292);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(511, 22);
            this.textBoxResult.TabIndex = 1;
            // 
            // btnAirbusFactory
            // 
            this.btnAirbusFactory.Location = new System.Drawing.Point(383, 89);
            this.btnAirbusFactory.Name = "btnAirbusFactory";
            this.btnAirbusFactory.Size = new System.Drawing.Size(75, 32);
            this.btnAirbusFactory.TabIndex = 2;
            this.btnAirbusFactory.Text = "Airbus";
            this.btnAirbusFactory.UseVisualStyleBackColor = true;
            this.btnAirbusFactory.Click += new System.EventHandler(this.btnAirbusFactory_Click);
            // 
            // btnLockheedFactory
            // 
            this.btnLockheedFactory.Location = new System.Drawing.Point(611, 89);
            this.btnLockheedFactory.Name = "btnLockheedFactory";
            this.btnLockheedFactory.Size = new System.Drawing.Size(75, 32);
            this.btnLockheedFactory.TabIndex = 3;
            this.btnLockheedFactory.Text = "Lockheed";
            this.btnLockheedFactory.UseVisualStyleBackColor = true;
            this.btnLockheedFactory.Click += new System.EventHandler(this.btnLockheedFactory_Click);
            // 
            // btnCreatePassenger
            // 
            this.btnCreatePassenger.Location = new System.Drawing.Point(175, 238);
            this.btnCreatePassenger.Name = "btnCreatePassenger";
            this.btnCreatePassenger.Size = new System.Drawing.Size(137, 33);
            this.btnCreatePassenger.TabIndex = 4;
            this.btnCreatePassenger.Text = "Passenger plane";
            this.btnCreatePassenger.UseVisualStyleBackColor = true;
            this.btnCreatePassenger.Click += new System.EventHandler(this.btnCreatePassenger_Click);
            // 
            // btnCreateCargo
            // 
            this.btnCreateCargo.Location = new System.Drawing.Point(358, 238);
            this.btnCreateCargo.Name = "btnCreateCargo";
            this.btnCreateCargo.Size = new System.Drawing.Size(127, 33);
            this.btnCreateCargo.TabIndex = 5;
            this.btnCreateCargo.Text = "Cargo plane";
            this.btnCreateCargo.UseVisualStyleBackColor = true;
            this.btnCreateCargo.Click += new System.EventHandler(this.btnCreateCargo_Click);
            // 
            // btnCreateMilitary
            // 
            this.btnCreateMilitary.Location = new System.Drawing.Point(548, 238);
            this.btnCreateMilitary.Name = "btnCreateMilitary";
            this.btnCreateMilitary.Size = new System.Drawing.Size(138, 33);
            this.btnCreateMilitary.TabIndex = 6;
            this.btnCreateMilitary.Text = "Military plane";
            this.btnCreateMilitary.UseVisualStyleBackColor = true;
            this.btnCreateMilitary.Click += new System.EventHandler(this.btnCreateMilitary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateMilitary);
            this.Controls.Add(this.btnCreateCargo);
            this.Controls.Add(this.btnCreatePassenger);
            this.Controls.Add(this.btnLockheedFactory);
            this.Controls.Add(this.btnAirbusFactory);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.btnBoeingFactory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoeingFactory;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button btnAirbusFactory;
        private System.Windows.Forms.Button btnLockheedFactory;
        private System.Windows.Forms.Button btnCreatePassenger;
        private System.Windows.Forms.Button btnCreateCargo;
        private System.Windows.Forms.Button btnCreateMilitary;
    }
}

