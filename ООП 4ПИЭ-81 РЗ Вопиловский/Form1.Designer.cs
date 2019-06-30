namespace ООП_4ПИЭ_81_РЗ_Вопиловский
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewPorts = new System.Windows.Forms.ListView();
            this.PortN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PortName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PortDock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PortDockFree = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PortX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PortY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PortType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewPortAirs = new System.Windows.Forms.ListView();
            this.PortAN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PortAName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PortAModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PortAType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PortAMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PortAStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listViewFlights = new System.Windows.Forms.ListView();
            this.FlN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FlAir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FlX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FlY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FlTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FlTarget = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FLCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.labelPortInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.FlRange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FLLeft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listViewCrash = new System.Windows.Forms.ListView();
            this.CrN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CrBort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CrX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CrY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CrTarget = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CrTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CrCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewPorts);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список Аэропортов";
            // 
            // listViewPorts
            // 
            this.listViewPorts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PortN,
            this.PortName,
            this.PortDock,
            this.PortDockFree,
            this.PortX,
            this.PortY,
            this.PortType});
            this.listViewPorts.Location = new System.Drawing.Point(7, 20);
            this.listViewPorts.Name = "listViewPorts";
            this.listViewPorts.Size = new System.Drawing.Size(403, 201);
            this.listViewPorts.TabIndex = 0;
            this.listViewPorts.UseCompatibleStateImageBehavior = false;
            this.listViewPorts.View = System.Windows.Forms.View.Details;
            this.listViewPorts.Click += new System.EventHandler(this.ListViewPorts_Click);
            // 
            // PortN
            // 
            this.PortN.Text = "№";
            this.PortN.Width = 30;
            // 
            // PortName
            // 
            this.PortName.Text = "Наименование";
            this.PortName.Width = 93;
            // 
            // PortDock
            // 
            this.PortDock.Text = "Доков";
            this.PortDock.Width = 45;
            // 
            // PortDockFree
            // 
            this.PortDockFree.Text = "Свободных";
            this.PortDockFree.Width = 74;
            // 
            // PortX
            // 
            this.PortX.Text = "Кор. X";
            this.PortX.Width = 48;
            // 
            // PortY
            // 
            this.PortY.Text = "Кор. Y";
            this.PortY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PortY.Width = 44;
            // 
            // PortType
            // 
            this.PortType.Text = "Тип";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewPortAirs);
            this.groupBox2.Location = new System.Drawing.Point(14, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "^^^ Самолеты в аэропарту ^^^";
            // 
            // listViewPortAirs
            // 
            this.listViewPortAirs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PortAN,
            this.PortAName,
            this.PortAModel,
            this.PortAType,
            this.PortAMax,
            this.PortAStatus});
            this.listViewPortAirs.Location = new System.Drawing.Point(6, 15);
            this.listViewPortAirs.Name = "listViewPortAirs";
            this.listViewPortAirs.Size = new System.Drawing.Size(403, 208);
            this.listViewPortAirs.TabIndex = 0;
            this.listViewPortAirs.UseCompatibleStateImageBehavior = false;
            this.listViewPortAirs.View = System.Windows.Forms.View.Details;
            // 
            // PortAN
            // 
            this.PortAN.Text = "№";
            this.PortAN.Width = 28;
            // 
            // PortAName
            // 
            this.PortAName.Text = "Наименование";
            this.PortAName.Width = 94;
            // 
            // PortAModel
            // 
            this.PortAModel.Text = "Модель";
            // 
            // PortAType
            // 
            this.PortAType.Text = "Тип";
            this.PortAType.Width = 42;
            // 
            // PortAMax
            // 
            this.PortAMax.Text = "макс пасс/груз";
            this.PortAMax.Width = 96;
            // 
            // PortAStatus
            // 
            this.PortAStatus.Text = "Готовность";
            this.PortAStatus.Width = 75;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewFlights);
            this.groupBox3.Location = new System.Drawing.Point(441, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(530, 377);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Текушие рейсы самолетов";
            // 
            // listViewFlights
            // 
            this.listViewFlights.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FlN,
            this.FlAir,
            this.FlX,
            this.FlY,
            this.FlRange,
            this.FLLeft,
            this.FlTime,
            this.FlTarget,
            this.FLCargo});
            this.listViewFlights.Location = new System.Drawing.Point(7, 20);
            this.listViewFlights.Name = "listViewFlights";
            this.listViewFlights.Size = new System.Drawing.Size(507, 345);
            this.listViewFlights.TabIndex = 0;
            this.listViewFlights.UseCompatibleStateImageBehavior = false;
            this.listViewFlights.View = System.Windows.Forms.View.Details;
            // 
            // FlN
            // 
            this.FlN.Text = "№";
            this.FlN.Width = 30;
            // 
            // FlAir
            // 
            this.FlAir.Text = "Борт";
            this.FlAir.Width = 72;
            // 
            // FlX
            // 
            this.FlX.Text = "КорX";
            this.FlX.Width = 41;
            // 
            // FlY
            // 
            this.FlY.Text = "КорY";
            this.FlY.Width = 45;
            // 
            // FlTime
            // 
            this.FlTime.Text = "Время";
            this.FlTime.Width = 47;
            // 
            // FlTarget
            // 
            this.FlTarget.Text = "Маршрут";
            this.FlTarget.Width = 77;
            // 
            // FLCargo
            // 
            this.FLCargo.Text = "Везет";
            this.FLCargo.Width = 55;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelPortInfo
            // 
            this.labelPortInfo.AutoSize = true;
            this.labelPortInfo.Location = new System.Drawing.Point(13, 278);
            this.labelPortInfo.Name = "labelPortInfo";
            this.labelPortInfo.Size = new System.Drawing.Size(16, 13);
            this.labelPortInfo.TabIndex = 5;
            this.labelPortInfo.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Аэропорт:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 529);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 529);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(101, 247);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPort.TabIndex = 9;
            this.comboBoxPort.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPort_SelectedIndexChanged);
            // 
            // FlRange
            // 
            this.FlRange.Text = "Дал.км";
            // 
            // FLLeft
            // 
            this.FLLeft.Text = "остал. км";
            this.FLLeft.Width = 68;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listViewCrash);
            this.groupBox4.Location = new System.Drawing.Point(442, 397);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(529, 196);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Катастрофы";
            // 
            // listViewCrash
            // 
            this.listViewCrash.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CrN,
            this.CrBort,
            this.CrX,
            this.CrY,
            this.CrTarget,
            this.CrTime,
            this.CrCargo});
            this.listViewCrash.Location = new System.Drawing.Point(7, 20);
            this.listViewCrash.Name = "listViewCrash";
            this.listViewCrash.Size = new System.Drawing.Size(506, 170);
            this.listViewCrash.TabIndex = 0;
            this.listViewCrash.UseCompatibleStateImageBehavior = false;
            this.listViewCrash.View = System.Windows.Forms.View.Details;
            // 
            // CrN
            // 
            this.CrN.Text = "№";
            this.CrN.Width = 29;
            // 
            // CrBort
            // 
            this.CrBort.Text = "Борт";
            // 
            // CrX
            // 
            this.CrX.Text = "X";
            this.CrX.Width = 40;
            // 
            // CrY
            // 
            this.CrY.Text = "Y";
            this.CrY.Width = 40;
            // 
            // CrTarget
            // 
            this.CrTarget.Text = "Маршрут";
            // 
            // CrTime
            // 
            this.CrTime.Text = "Время";
            // 
            // CrCargo
            // 
            this.CrCargo.Text = "Потери";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 614);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelPortInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ООП 4ПИЭ-81 РЗ Вопиловский";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewPorts;
        private System.Windows.Forms.ColumnHeader PortN;
        private System.Windows.Forms.ColumnHeader PortName;
        private System.Windows.Forms.ColumnHeader PortDock;
        private System.Windows.Forms.ColumnHeader PortDockFree;
        private System.Windows.Forms.ColumnHeader PortX;
        private System.Windows.Forms.ColumnHeader PortY;
        private System.Windows.Forms.ColumnHeader PortType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewPortAirs;
        private System.Windows.Forms.ColumnHeader PortAN;
        private System.Windows.Forms.ColumnHeader PortAName;
        private System.Windows.Forms.ColumnHeader PortAModel;
        private System.Windows.Forms.ColumnHeader PortAType;
        private System.Windows.Forms.ColumnHeader PortAMax;
        private System.Windows.Forms.ColumnHeader PortAStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listViewFlights;
        private System.Windows.Forms.ColumnHeader FlN;
        private System.Windows.Forms.ColumnHeader FlAir;
        private System.Windows.Forms.ColumnHeader FlX;
        private System.Windows.Forms.ColumnHeader FlY;
        private System.Windows.Forms.ColumnHeader FlTime;
        private System.Windows.Forms.ColumnHeader FlTarget;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPortInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader FLCargo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.ColumnHeader FlRange;
        private System.Windows.Forms.ColumnHeader FLLeft;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listViewCrash;
        private System.Windows.Forms.ColumnHeader CrN;
        private System.Windows.Forms.ColumnHeader CrBort;
        private System.Windows.Forms.ColumnHeader CrX;
        private System.Windows.Forms.ColumnHeader CrY;
        private System.Windows.Forms.ColumnHeader CrTarget;
        private System.Windows.Forms.ColumnHeader CrTime;
        private System.Windows.Forms.ColumnHeader CrCargo;
    }
}

