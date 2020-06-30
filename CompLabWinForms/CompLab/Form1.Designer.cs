namespace CompLab
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
            this.dropDownRooms = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.labelRoom = new System.Windows.Forms.Label();
            this.listComputers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCompCount = new System.Windows.Forms.Label();
            this.labelSumPrice = new System.Windows.Forms.Label();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnEditRoom = new System.Windows.Forms.Button();
            this.btnAddComputer = new System.Windows.Forms.Button();
            this.btnEditComputer = new System.Windows.Forms.Button();
            this.btnDeleteComputer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dropDownRooms
            // 
            this.dropDownRooms.FormattingEnabled = true;
            this.dropDownRooms.Location = new System.Drawing.Point(157, 71);
            this.dropDownRooms.Name = "dropDownRooms";
            this.dropDownRooms.Size = new System.Drawing.Size(350, 21);
            this.dropDownRooms.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(513, 68);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(48, 74);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(49, 13);
            this.labelRoom.TabIndex = 2;
            this.labelRoom.Text = "Кабинет";
            // 
            // listComputers
            // 
            this.listComputers.FormattingEnabled = true;
            this.listComputers.Location = new System.Drawing.Point(51, 127);
            this.listComputers.Name = "listComputers";
            this.listComputers.Size = new System.Drawing.Size(537, 303);
            this.listComputers.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Кол-во компьютеров : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Суммарная баланс. ст. :";
            // 
            // labelCompCount
            // 
            this.labelCompCount.AutoSize = true;
            this.labelCompCount.Location = new System.Drawing.Point(176, 101);
            this.labelCompCount.Name = "labelCompCount";
            this.labelCompCount.Size = new System.Drawing.Size(0, 13);
            this.labelCompCount.TabIndex = 6;
            // 
            // labelSumPrice
            // 
            this.labelSumPrice.AutoSize = true;
            this.labelSumPrice.Location = new System.Drawing.Point(435, 101);
            this.labelSumPrice.Name = "labelSumPrice";
            this.labelSumPrice.Size = new System.Drawing.Size(0, 13);
            this.labelSumPrice.TabIndex = 7;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(14, 24);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(75, 23);
            this.btnAddRoom.TabIndex = 8;
            this.btnAddRoom.Text = "Добавить";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.Location = new System.Drawing.Point(95, 24);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(75, 23);
            this.btnEditRoom.TabIndex = 9;
            this.btnEditRoom.Text = "Изменить";
            this.btnEditRoom.UseVisualStyleBackColor = true;
            this.btnEditRoom.Click += new System.EventHandler(this.btnEditRoom_Click);
            // 
            // btnAddComputer
            // 
            this.btnAddComputer.Location = new System.Drawing.Point(341, 460);
            this.btnAddComputer.Name = "btnAddComputer";
            this.btnAddComputer.Size = new System.Drawing.Size(75, 23);
            this.btnAddComputer.TabIndex = 10;
            this.btnAddComputer.Text = "Добавить";
            this.btnAddComputer.UseVisualStyleBackColor = true;
            this.btnAddComputer.Click += new System.EventHandler(this.btnAddComputer_Click);
            // 
            // btnEditComputer
            // 
            this.btnEditComputer.Location = new System.Drawing.Point(422, 460);
            this.btnEditComputer.Name = "btnEditComputer";
            this.btnEditComputer.Size = new System.Drawing.Size(75, 23);
            this.btnEditComputer.TabIndex = 11;
            this.btnEditComputer.Text = "Изменить";
            this.btnEditComputer.UseVisualStyleBackColor = true;
            this.btnEditComputer.Click += new System.EventHandler(this.btnEditComputer_Click);
            // 
            // btnDeleteComputer
            // 
            this.btnDeleteComputer.Location = new System.Drawing.Point(503, 460);
            this.btnDeleteComputer.Name = "btnDeleteComputer";
            this.btnDeleteComputer.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteComputer.TabIndex = 12;
            this.btnDeleteComputer.Text = "Удалить";
            this.btnDeleteComputer.UseVisualStyleBackColor = true;
            this.btnDeleteComputer.Click += new System.EventHandler(this.btnDeleteComputer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteRoom);
            this.groupBox1.Controls.Add(this.btnEditRoom);
            this.groupBox1.Controls.Add(this.btnAddRoom);
            this.groupBox1.Location = new System.Drawing.Point(51, 436);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 58);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Кабинет";
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Location = new System.Drawing.Point(176, 24);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRoom.TabIndex = 15;
            this.btnDeleteRoom.Text = "Удалить";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(329, 436);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 58);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Компьютер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Путь до данных";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(513, 32);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 16;
            this.btnPath.Text = "Указать";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(157, 32);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(350, 20);
            this.tbPath.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 510);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnDeleteComputer);
            this.Controls.Add(this.btnEditComputer);
            this.Controls.Add(this.btnAddComputer);
            this.Controls.Add(this.labelSumPrice);
            this.Controls.Add(this.labelCompCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listComputers);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dropDownRooms);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dropDownRooms;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.ListBox listComputers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCompCount;
        private System.Windows.Forms.Label labelSumPrice;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnEditRoom;
        private System.Windows.Forms.Button btnAddComputer;
        private System.Windows.Forms.Button btnEditComputer;
        private System.Windows.Forms.Button btnDeleteComputer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tbPath;
    }
}

