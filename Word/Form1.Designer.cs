namespace Word
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.словарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.созданиеСловаряToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновлениеСловаряToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьСловарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autocompleteMenu = new AutocompleteMenuNS.AutocompleteMenu();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.autocompleteMenu.SetAutocompleteMenu(this.textBox1, this.autocompleteMenu);
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(959, 744);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.словарьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(959, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // словарьToolStripMenuItem
            // 
            this.словарьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданиеСловаряToolStripMenuItem,
            this.обновлениеСловаряToolStripMenuItem,
            this.очиститьСловарьToolStripMenuItem});
            this.словарьToolStripMenuItem.Name = "словарьToolStripMenuItem";
            this.словарьToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.словарьToolStripMenuItem.Text = "Словарь";
            // 
            // созданиеСловаряToolStripMenuItem
            // 
            this.созданиеСловаряToolStripMenuItem.Name = "созданиеСловаряToolStripMenuItem";
            this.созданиеСловаряToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.созданиеСловаряToolStripMenuItem.Text = "Создание словаря";
            this.созданиеСловаряToolStripMenuItem.Click += new System.EventHandler(this.созданиеСловаряToolStripMenuItem_Click);
            // 
            // обновлениеСловаряToolStripMenuItem
            // 
            this.обновлениеСловаряToolStripMenuItem.Name = "обновлениеСловаряToolStripMenuItem";
            this.обновлениеСловаряToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.обновлениеСловаряToolStripMenuItem.Text = "Обновление словаря";
            this.обновлениеСловаряToolStripMenuItem.Click += new System.EventHandler(this.обновлениеСловаряToolStripMenuItem_Click);
            // 
            // очиститьСловарьToolStripMenuItem
            // 
            this.очиститьСловарьToolStripMenuItem.Name = "очиститьСловарьToolStripMenuItem";
            this.очиститьСловарьToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.очиститьСловарьToolStripMenuItem.Text = "Очистить словарь";
            this.очиститьСловарьToolStripMenuItem.Click += new System.EventHandler(this.очиститьСловарьToolStripMenuItem_Click);
            // 
            // autocompleteMenu
            // 
            this.autocompleteMenu.AllowsTabKey = true;
            this.autocompleteMenu.AppearInterval = 100;
            this.autocompleteMenu.AutoWidth = true;
            this.autocompleteMenu.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenu.Colors")));
            this.autocompleteMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.autocompleteMenu.ImageList = null;
            this.autocompleteMenu.Items = new string[] {
        "abc",
        "abcd",
        "abcdre"};
            this.autocompleteMenu.LeftPadding = 15;
            this.autocompleteMenu.MaximumSize = new System.Drawing.Size(300, 100);
            this.autocompleteMenu.MinFragmentLength = 1;
            this.autocompleteMenu.SearchPattern = "[\\w\\.@]";
            this.autocompleteMenu.TargetControlWrapper = null;
            this.autocompleteMenu.Selected += new System.EventHandler<AutocompleteMenuNS.SelectedEventArgs>(this.autocompleteMenu_Selected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 768);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текстовый процессор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem словарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem созданиеСловаряToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновлениеСловаряToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьСловарьToolStripMenuItem;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu;
    }
}

