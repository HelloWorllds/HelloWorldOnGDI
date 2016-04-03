namespace Penguin
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.будильникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.установитьВремяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сбросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьМелодиюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.будильникToolStripMenuItem,
            this.toolStripMenuItem1,
            this.обАвтореToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.toolStripMenuItem2,
            this.выходToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 126);
            // 
            // будильникToolStripMenuItem
            // 
            this.будильникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.установитьВремяToolStripMenuItem,
            this.сбросToolStripMenuItem,
            this.изменитьМелодиюToolStripMenuItem});
            this.будильникToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("будильникToolStripMenuItem.Image")));
            this.будильникToolStripMenuItem.Name = "будильникToolStripMenuItem";
            this.будильникToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.будильникToolStripMenuItem.Text = "Будильник";
            // 
            // установитьВремяToolStripMenuItem
            // 
            this.установитьВремяToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("установитьВремяToolStripMenuItem.Image")));
            this.установитьВремяToolStripMenuItem.Name = "установитьВремяToolStripMenuItem";
            this.установитьВремяToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.установитьВремяToolStripMenuItem.Text = "Установить время";
            this.установитьВремяToolStripMenuItem.Click += new System.EventHandler(this.установитьВремяToolStripMenuItem_Click);
            // 
            // сбросToolStripMenuItem
            // 
            this.сбросToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сбросToolStripMenuItem.Image")));
            this.сбросToolStripMenuItem.Name = "сбросToolStripMenuItem";
            this.сбросToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.сбросToolStripMenuItem.Text = "Сбросить будильник";
            this.сбросToolStripMenuItem.Click += new System.EventHandler(this.сбросToolStripMenuItem_Click);
            // 
            // изменитьМелодиюToolStripMenuItem
            // 
            this.изменитьМелодиюToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("изменитьМелодиюToolStripMenuItem.Image")));
            this.изменитьМелодиюToolStripMenuItem.Name = "изменитьМелодиюToolStripMenuItem";
            this.изменитьМелодиюToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.изменитьМелодиюToolStripMenuItem.Text = "Изменить мелодию";
            this.изменитьМелодиюToolStripMenuItem.Click += new System.EventHandler(this.изменитьМелодиюToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("обАвтореToolStripMenuItem.Image")));
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("оПрограммеToolStripMenuItem.Image")));
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Location = new System.Drawing.Point(98, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 18);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox2.Location = new System.Drawing.Point(157, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox3.Location = new System.Drawing.Point(82, 345);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(160, 120);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(360, 537);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Penguin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem будильникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem установитьВремяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сбросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьМелодиюToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

