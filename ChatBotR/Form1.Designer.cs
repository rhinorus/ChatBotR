namespace ChatBotR
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
            this.label1 = new System.Windows.Forms.Label();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.MessagesTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обучитьБотаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.плохойОтветБотаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.возможностиБотаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.очиститьЧатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Чат-бот";
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionTextBox.Location = new System.Drawing.Point(19, 348);
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(233, 22);
            this.QuestionTextBox.TabIndex = 2;
            this.QuestionTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuestionTextBox_KeyDown);
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSend.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnSend.Location = new System.Drawing.Point(258, 346);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(73, 23);
            this.BtnSend.TabIndex = 3;
            this.BtnSend.Text = "Сказать";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // MessagesTextBox
            // 
            this.MessagesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessagesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessagesTextBox.Location = new System.Drawing.Point(19, 44);
            this.MessagesTextBox.Name = "MessagesTextBox";
            this.MessagesTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.MessagesTextBox.Size = new System.Drawing.Size(312, 296);
            this.MessagesTextBox.TabIndex = 8;
            this.MessagesTextBox.Text = "";
            this.MessagesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MessagesTextBox_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(348, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обучитьБотаToolStripMenuItem,
            this.плохойОтветБотаToolStripMenuItem,
            this.возможностиБотаToolStripMenuItem,
            this.очиститьЧатToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // обучитьБотаToolStripMenuItem
            // 
            this.обучитьБотаToolStripMenuItem.Name = "обучитьБотаToolStripMenuItem";
            this.обучитьБотаToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.обучитьБотаToolStripMenuItem.Text = "Обучить бота";
            this.обучитьБотаToolStripMenuItem.Click += new System.EventHandler(this.обучитьБотаToolStripMenuItem_Click);
            // 
            // плохойОтветБотаToolStripMenuItem
            // 
            this.плохойОтветБотаToolStripMenuItem.Name = "плохойОтветБотаToolStripMenuItem";
            this.плохойОтветБотаToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.плохойОтветБотаToolStripMenuItem.Text = "Плохой ответ бота!";
            this.плохойОтветБотаToolStripMenuItem.Click += new System.EventHandler(this.плохойОтветБотаToolStripMenuItem_Click);
            // 
            // возможностиБотаToolStripMenuItem
            // 
            this.возможностиБотаToolStripMenuItem.Name = "возможностиБотаToolStripMenuItem";
            this.возможностиБотаToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.возможностиБотаToolStripMenuItem.Text = "Возможности бота";
            this.возможностиБотаToolStripMenuItem.Click += new System.EventHandler(this.возможностиБотаToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(187, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(205, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "-Bot";
            // 
            // очиститьЧатToolStripMenuItem
            // 
            this.очиститьЧатToolStripMenuItem.Name = "очиститьЧатToolStripMenuItem";
            this.очиститьЧатToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.очиститьЧатToolStripMenuItem.Text = "Очистить чат";
            this.очиститьЧатToolStripMenuItem.Click += new System.EventHandler(this.очиститьЧатToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 398);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MessagesTextBox);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R-Bot";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.RichTextBox MessagesTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обучитьБотаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem плохойОтветБотаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem возможностиБотаToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem очиститьЧатToolStripMenuItem;
    }
}

