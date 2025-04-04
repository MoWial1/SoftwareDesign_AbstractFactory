namespace StrategyPattern
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
            this.cmbStrategy = new System.Windows.Forms.ComboBox();
            this.txtCampaignName = new System.Windows.Forms.TextBox();
            this.nudBudget = new System.Windows.Forms.NumericUpDown();
            this.btnRunCampaign = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStrategy
            // 
            this.cmbStrategy.FormattingEnabled = true;
            this.cmbStrategy.Items.AddRange(new object[] {
            "Social Media",
            "Search Engines",
            "Email Marketing"});
            this.cmbStrategy.Location = new System.Drawing.Point(27, 25);
            this.cmbStrategy.Name = "cmbStrategy";
            this.cmbStrategy.Size = new System.Drawing.Size(231, 24);
            this.cmbStrategy.TabIndex = 0;
            // 
            // txtCampaignName
            // 
            this.txtCampaignName.Location = new System.Drawing.Point(276, 27);
            this.txtCampaignName.Name = "txtCampaignName";
            this.txtCampaignName.Size = new System.Drawing.Size(294, 22);
            this.txtCampaignName.TabIndex = 1;
            // 
            // nudBudget
            // 
            this.nudBudget.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudBudget.Location = new System.Drawing.Point(625, 28);
            this.nudBudget.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudBudget.Name = "nudBudget";
            this.nudBudget.Size = new System.Drawing.Size(117, 22);
            this.nudBudget.TabIndex = 2;
            // 
            // btnRunCampaign
            // 
            this.btnRunCampaign.Location = new System.Drawing.Point(27, 121);
            this.btnRunCampaign.Name = "btnRunCampaign";
            this.btnRunCampaign.Size = new System.Drawing.Size(231, 42);
            this.btnRunCampaign.TabIndex = 3;
            this.btnRunCampaign.Text = "Run Campaign";
            this.btnRunCampaign.UseVisualStyleBackColor = true;
            this.btnRunCampaign.Click += new System.EventHandler(this.btnRunCampaign_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(24, 195);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(57, 16);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "no result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnRunCampaign);
            this.Controls.Add(this.nudBudget);
            this.Controls.Add(this.txtCampaignName);
            this.Controls.Add(this.cmbStrategy);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudBudget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStrategy;
        private System.Windows.Forms.TextBox txtCampaignName;
        private System.Windows.Forms.NumericUpDown nudBudget;
        private System.Windows.Forms.Button btnRunCampaign;
        private System.Windows.Forms.Label lblResult;
    }
}

