namespace Composite
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
            this.lbl_government = new System.Windows.Forms.Label();
            this.lst_laws = new System.Windows.Forms.ListBox();
            this.lbl_council = new System.Windows.Forms.Label();
            this.btn_adopt_law = new System.Windows.Forms.Button();
            this.txt_supreme_council = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_government
            // 
            this.lbl_government.AutoSize = true;
            this.lbl_government.Location = new System.Drawing.Point(12, 9);
            this.lbl_government.Name = "lbl_government";
            this.lbl_government.Size = new System.Drawing.Size(86, 17);
            this.lbl_government.TabIndex = 0;
            this.lbl_government.Text = "Government";
            // 
            // lst_laws
            // 
            this.lst_laws.FormattingEnabled = true;
            this.lst_laws.ItemHeight = 16;
            this.lst_laws.Location = new System.Drawing.Point(15, 41);
            this.lst_laws.Name = "lst_laws";
            this.lst_laws.Size = new System.Drawing.Size(120, 84);
            this.lst_laws.TabIndex = 1;
            this.lst_laws.SelectedIndexChanged += new System.EventHandler(this.lst_laws_SelectedIndexChanged);
            // 
            // lbl_council
            // 
            this.lbl_council.AutoSize = true;
            this.lbl_council.Location = new System.Drawing.Point(15, 216);
            this.lbl_council.Name = "lbl_council";
            this.lbl_council.Size = new System.Drawing.Size(144, 17);
            this.lbl_council.TabIndex = 2;
            this.lbl_council.Text = "The Supreme Council";
            // 
            // btn_adopt_law
            // 
            this.btn_adopt_law.BackColor = System.Drawing.Color.White;
            this.btn_adopt_law.ForeColor = System.Drawing.Color.Red;
            this.btn_adopt_law.Location = new System.Drawing.Point(15, 145);
            this.btn_adopt_law.Name = "btn_adopt_law";
            this.btn_adopt_law.Size = new System.Drawing.Size(120, 32);
            this.btn_adopt_law.TabIndex = 3;
            this.btn_adopt_law.Text = "adopt a law";
            this.btn_adopt_law.UseVisualStyleBackColor = false;
            this.btn_adopt_law.Click += new System.EventHandler(this.btn_adopt_law_Click);
            // 
            // txt_supreme_council
            // 
            this.txt_supreme_council.Location = new System.Drawing.Point(18, 237);
            this.txt_supreme_council.Name = "txt_supreme_council";
            this.txt_supreme_council.Size = new System.Drawing.Size(297, 22);
            this.txt_supreme_council.TabIndex = 4;
            this.txt_supreme_council.TextChanged += new System.EventHandler(this.txt_supreme_council_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_supreme_council);
            this.Controls.Add(this.btn_adopt_law);
            this.Controls.Add(this.lbl_council);
            this.Controls.Add(this.lst_laws);
            this.Controls.Add(this.lbl_government);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_government;
        private System.Windows.Forms.ListBox lst_laws;
        private System.Windows.Forms.Label lbl_council;
        private System.Windows.Forms.Button btn_adopt_law;
        private System.Windows.Forms.TextBox txt_supreme_council;
    }
}

