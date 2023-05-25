
namespace CRMUI
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.entitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tovarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTovarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSellerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.checksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entitiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // entitiesToolStripMenuItem
            // 
            this.entitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tovarToolStripMenuItem,
            this.sellerToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.checksToolStripMenuItem});
            this.entitiesToolStripMenuItem.Name = "entitiesToolStripMenuItem";
            this.entitiesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.entitiesToolStripMenuItem.Text = "Сущности";
            // 
            // tovarToolStripMenuItem
            // 
            this.tovarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTovarToolStripMenuItem});
            this.tovarToolStripMenuItem.Name = "tovarToolStripMenuItem";
            this.tovarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tovarToolStripMenuItem.Text = "Товар";
            this.tovarToolStripMenuItem.Click += new System.EventHandler(this.tovarToolStripMenuItem_Click);
            // 
            // addTovarToolStripMenuItem
            // 
            this.addTovarToolStripMenuItem.Name = "addTovarToolStripMenuItem";
            this.addTovarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addTovarToolStripMenuItem.Text = "Добавить";
            this.addTovarToolStripMenuItem.Click += new System.EventHandler(this.addTovarToolStripMenuItem_Click);
            // 
            // sellerToolStripMenuItem
            // 
            this.sellerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSellerToolStripMenuItem1});
            this.sellerToolStripMenuItem.Name = "sellerToolStripMenuItem";
            this.sellerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sellerToolStripMenuItem.Text = "Продавец";
            this.sellerToolStripMenuItem.Click += new System.EventHandler(this.sellerToolStripMenuItem_Click);
            // 
            // addSellerToolStripMenuItem1
            // 
            this.addSellerToolStripMenuItem1.Name = "addSellerToolStripMenuItem1";
            this.addSellerToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.addSellerToolStripMenuItem1.Text = "Добавить";
            this.addSellerToolStripMenuItem1.Click += new System.EventHandler(this.addSellerToolStripMenuItem1_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem2});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customerToolStripMenuItem.Text = "Покупатель";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // addCustomerToolStripMenuItem2
            // 
            this.addCustomerToolStripMenuItem2.Name = "addCustomerToolStripMenuItem2";
            this.addCustomerToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.addCustomerToolStripMenuItem2.Text = "Добавить";
            this.addCustomerToolStripMenuItem2.Click += new System.EventHandler(this.addCustomerToolStripMenuItem2_Click);
            // 
            // checksToolStripMenuItem
            // 
            this.checksToolStripMenuItem.Name = "checksToolStripMenuItem";
            this.checksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checksToolStripMenuItem.Text = "Чек";
            this.checksToolStripMenuItem.Click += new System.EventHandler(this.checksToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem entitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tovarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTovarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSellerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem2;
    }
}

