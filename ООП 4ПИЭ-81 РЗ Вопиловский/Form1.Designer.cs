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
      this.comBoxPortTyp = new System.Windows.Forms.ComboBox();
      this.label6 = new System.Windows.Forms.Label();
      this.listViewPortAirs = new System.Windows.Forms.ListView();
      this.PortAN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.PortAName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.PortAType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.PortAMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.PortAStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.labelFlightInfo = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.comBoxFlightTyp = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.tBoxFlightMaxT = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.listViewFlights = new System.Windows.Forms.ListView();
      this.FlN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.FlAir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.FlX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.FlY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.FlRange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.FLLeft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.FlTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.FlTarget = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.FLCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.labelPortInfo = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.comboBoxPort = new System.Windows.Forms.ComboBox();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.labelCrashInfo = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.listViewCrash = new System.Windows.Forms.ListView();
      this.CrN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.CrBort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.CrX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.CrY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.CrTarget = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.CrTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.CrCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.labelSTimeInfo = new System.Windows.Forms.Label();
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
      this.groupBox2.Controls.Add(this.comBoxPortTyp);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.listViewPortAirs);
      this.groupBox2.Location = new System.Drawing.Point(14, 294);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(421, 257);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "^^^ Самолеты в аэропарту ^^^";
      // 
      // comBoxPortTyp
      // 
      this.comBoxPortTyp.FormattingEnabled = true;
      this.comBoxPortTyp.Items.AddRange(new object[] {
            "Военные",
            "Прогулочные",
            "Грузовые",
            "Пассажирские",
            "Все"});
      this.comBoxPortTyp.Location = new System.Drawing.Point(252, 0);
      this.comBoxPortTyp.Name = "comBoxPortTyp";
      this.comBoxPortTyp.Size = new System.Drawing.Size(121, 21);
      this.comBoxPortTyp.TabIndex = 7;
      this.comBoxPortTyp.SelectedIndexChanged += new System.EventHandler(this.allUpdate);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(174, 4);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(72, 13);
      this.label6.TabIndex = 1;
      this.label6.Text = "Фильтр: Тип";
      // 
      // listViewPortAirs
      // 
      this.listViewPortAirs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PortAN,
            this.PortAName,
            this.PortAType,
            this.PortAMax,
            this.PortAStatus});
      this.listViewPortAirs.Location = new System.Drawing.Point(6, 27);
      this.listViewPortAirs.Name = "listViewPortAirs";
      this.listViewPortAirs.Size = new System.Drawing.Size(403, 224);
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
      this.PortAName.Width = 160;
      // 
      // PortAType
      // 
      this.PortAType.Text = "Тип";
      this.PortAType.Width = 42;
      // 
      // PortAMax
      // 
      this.PortAMax.Text = "макс пасс/груз";
      this.PortAMax.Width = 93;
      // 
      // PortAStatus
      // 
      this.PortAStatus.Text = "Готовность";
      this.PortAStatus.Width = 71;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.labelFlightInfo);
      this.groupBox3.Controls.Add(this.label4);
      this.groupBox3.Controls.Add(this.comBoxFlightTyp);
      this.groupBox3.Controls.Add(this.label3);
      this.groupBox3.Controls.Add(this.tBoxFlightMaxT);
      this.groupBox3.Controls.Add(this.label2);
      this.groupBox3.Controls.Add(this.listViewFlights);
      this.groupBox3.Location = new System.Drawing.Point(441, 13);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(690, 377);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Текушие рейсы самолетов";
      // 
      // labelFlightInfo
      // 
      this.labelFlightInfo.AutoSize = true;
      this.labelFlightInfo.Location = new System.Drawing.Point(67, 356);
      this.labelFlightInfo.Name = "labelFlightInfo";
      this.labelFlightInfo.Size = new System.Drawing.Size(16, 13);
      this.labelFlightInfo.TabIndex = 6;
      this.labelFlightInfo.Text = "---";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 356);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(55, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "В полете:";
      // 
      // comBoxFlightTyp
      // 
      this.comBoxFlightTyp.FormattingEnabled = true;
      this.comBoxFlightTyp.Items.AddRange(new object[] {
            "Военные",
            "Прогулочные",
            "Грузовые",
            "Пассажирские",
            "Все"});
      this.comBoxFlightTyp.Location = new System.Drawing.Point(416, 0);
      this.comBoxFlightTyp.Name = "comBoxFlightTyp";
      this.comBoxFlightTyp.Size = new System.Drawing.Size(121, 21);
      this.comBoxFlightTyp.TabIndex = 4;
      this.comBoxFlightTyp.SelectedIndexChanged += new System.EventHandler(this.allUpdate);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(378, 4);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(32, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "Тип: ";
      // 
      // tBoxFlightMaxT
      // 
      this.tBoxFlightMaxT.Location = new System.Drawing.Point(321, 0);
      this.tBoxFlightMaxT.Name = "tBoxFlightMaxT";
      this.tBoxFlightMaxT.Size = new System.Drawing.Size(51, 20);
      this.tBoxFlightMaxT.TabIndex = 2;
      this.tBoxFlightMaxT.Text = "100";
      this.tBoxFlightMaxT.TextChanged += new System.EventHandler(this.allUpdate);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(192, 4);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(123, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Фильтр: ост. время <=";
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
      this.listViewFlights.Location = new System.Drawing.Point(7, 26);
      this.listViewFlights.Name = "listViewFlights";
      this.listViewFlights.Size = new System.Drawing.Size(683, 327);
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
      this.FlAir.Width = 150;
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
      // FlRange
      // 
      this.FlRange.Text = "Дал.км";
      // 
      // FLLeft
      // 
      this.FLLeft.Text = "ост.км";
      this.FLLeft.Width = 50;
      // 
      // FlTime
      // 
      this.FlTime.Text = "Время";
      this.FlTime.Width = 50;
      // 
      // FlTarget
      // 
      this.FlTarget.Text = "Маршрут";
      this.FlTarget.Width = 160;
      // 
      // FLCargo
      // 
      this.FLCargo.Text = "Везет";
      this.FLCargo.Width = 55;
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
      this.button2.Location = new System.Drawing.Point(14, 600);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(106, 23);
      this.button2.TabIndex = 7;
      this.button2.Text = "Сделать шаг";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.Button2_Click);
      // 
      // comboBoxPort
      // 
      this.comboBoxPort.FormattingEnabled = true;
      this.comboBoxPort.Location = new System.Drawing.Point(101, 247);
      this.comboBoxPort.Name = "comboBoxPort";
      this.comboBoxPort.Size = new System.Drawing.Size(121, 21);
      this.comboBoxPort.TabIndex = 9;
      this.comboBoxPort.SelectedIndexChanged += new System.EventHandler(this.allUpdate);
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.labelCrashInfo);
      this.groupBox4.Controls.Add(this.label5);
      this.groupBox4.Controls.Add(this.listViewCrash);
      this.groupBox4.Location = new System.Drawing.Point(442, 397);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(689, 224);
      this.groupBox4.TabIndex = 10;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Катастрофы";
      // 
      // labelCrashInfo
      // 
      this.labelCrashInfo.AutoSize = true;
      this.labelCrashInfo.Location = new System.Drawing.Point(131, 197);
      this.labelCrashInfo.Name = "labelCrashInfo";
      this.labelCrashInfo.Size = new System.Drawing.Size(16, 13);
      this.labelCrashInfo.TabIndex = 2;
      this.labelCrashInfo.Text = "---";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(7, 197);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(117, 13);
      this.label5.TabIndex = 1;
      this.label5.Text = "Всего в катастрофах:";
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
      this.listViewCrash.Size = new System.Drawing.Size(676, 170);
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
      this.CrBort.Width = 150;
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
      this.CrTarget.Width = 160;
      // 
      // CrTime
      // 
      this.CrTime.Text = "Время";
      // 
      // CrCargo
      // 
      this.CrCargo.Text = "Потери";
      // 
      // labelSTimeInfo
      // 
      this.labelSTimeInfo.AutoSize = true;
      this.labelSTimeInfo.Location = new System.Drawing.Point(17, 574);
      this.labelSTimeInfo.Name = "labelSTimeInfo";
      this.labelSTimeInfo.Size = new System.Drawing.Size(76, 13);
      this.labelSTimeInfo.TabIndex = 11;
      this.labelSTimeInfo.Text = "Текуший шаг:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1138, 633);
      this.Controls.Add(this.labelSTimeInfo);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.comboBoxPort);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.labelPortInfo);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.Text = "ООП 4ПИЭ-81 РЗ Вопиловский";
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.Label labelPortInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader FLCargo;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.TextBox tBoxFlightMaxT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comBoxFlightTyp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFlightInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCrashInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comBoxPortTyp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSTimeInfo;
    }
}

