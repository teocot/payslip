namespace PayslipDesktop
{
    partial class PayslipForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayslipForm));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageDesign = new System.Windows.Forms.TabPage();
            this.richTextBoxReademe = new System.Windows.Forms.RichTextBox();
            this.tabPageTestHarness = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonCalculatorTest = new System.Windows.Forms.Button();
            this.tabPagePayslip = new System.Windows.Forms.TabPage();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPaySlip = new System.Windows.Forms.Label();
            this.panelPaySlip = new System.Windows.Forms.Panel();
            this.labelSuperRatePayslip = new System.Windows.Forms.Label();
            this.labelSuper = new System.Windows.Forms.Label();
            this.labelAnnualSalaryValue = new System.Windows.Forms.Label();
            this.labelAnnualSalaryPayslip = new System.Windows.Forms.Label();
            this.labelSuperValue = new System.Windows.Forms.Label();
            this.labelSuperPayslip = new System.Windows.Forms.Label();
            this.labelNetIncomeValue = new System.Windows.Forms.Label();
            this.labelNetIncomePayslip = new System.Windows.Forms.Label();
            this.labelIncomeTaxValue = new System.Windows.Forms.Label();
            this.labelIncomeTaxPayslip = new System.Windows.Forms.Label();
            this.labelGrossIncomeValue = new System.Windows.Forms.Label();
            this.labelGrossIncomePayslip = new System.Windows.Forms.Label();
            this.labelPayPeriodValue = new System.Windows.Forms.Label();
            this.labelNameValue = new System.Windows.Forms.Label();
            this.labelPayPeriodPayslip = new System.Windows.Forms.Label();
            this.labelPayslipName = new System.Windows.Forms.Label();
            this.labelPaymentStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerPaysleepPeriod = new System.Windows.Forms.DateTimePicker();
            this.labelSuperRate = new System.Windows.Forms.Label();
            this.textBoxSuperRate = new System.Windows.Forms.TextBox();
            this.textBoxAnnualSalary = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelAnnualSalary = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGeneratePayslip = new System.Windows.Forms.Button();
            this.tabControlPayslip = new System.Windows.Forms.TabControl();
            this.menuStripMain.SuspendLayout();
            this.tabPageDesign.SuspendLayout();
            this.tabPageTestHarness.SuspendLayout();
            this.tabPagePayslip.SuspendLayout();
            this.panelPaySlip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControlPayslip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(566, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabPageDesign
            // 
            this.tabPageDesign.Controls.Add(this.richTextBoxReademe);
            this.tabPageDesign.Location = new System.Drawing.Point(4, 22);
            this.tabPageDesign.Name = "tabPageDesign";
            this.tabPageDesign.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDesign.Size = new System.Drawing.Size(558, 324);
            this.tabPageDesign.TabIndex = 3;
            this.tabPageDesign.Text = "Assumptions-Design";
            this.tabPageDesign.UseVisualStyleBackColor = true;
            // 
            // richTextBoxReademe
            // 
            this.richTextBoxReademe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxReademe.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxReademe.Name = "richTextBoxReademe";
            this.richTextBoxReademe.ReadOnly = true;
            this.richTextBoxReademe.Size = new System.Drawing.Size(562, 328);
            this.richTextBoxReademe.TabIndex = 0;
            this.richTextBoxReademe.Text = resources.GetString("richTextBoxReademe.Text");
            // 
            // tabPageTestHarness
            // 
            this.tabPageTestHarness.Controls.Add(this.textBox2);
            this.tabPageTestHarness.Controls.Add(this.buttonCalculatorTest);
            this.tabPageTestHarness.Location = new System.Drawing.Point(4, 22);
            this.tabPageTestHarness.Name = "tabPageTestHarness";
            this.tabPageTestHarness.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTestHarness.Size = new System.Drawing.Size(558, 324);
            this.tabPageTestHarness.TabIndex = 2;
            this.tabPageTestHarness.Text = "TestHarness";
            this.tabPageTestHarness.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(68, 97);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(460, 74);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "To start the tests, please click the button above.  \r\nThis will start nunit. You " +
    "will have to accept to run it.       \r\nOnce it\'s up and running you can run all " +
    "the tests or one by one";
            // 
            // buttonCalculatorTest
            // 
            this.buttonCalculatorTest.BackColor = System.Drawing.Color.Lime;
            this.buttonCalculatorTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculatorTest.Location = new System.Drawing.Point(176, 37);
            this.buttonCalculatorTest.Name = "buttonCalculatorTest";
            this.buttonCalculatorTest.Size = new System.Drawing.Size(255, 36);
            this.buttonCalculatorTest.TabIndex = 1;
            this.buttonCalculatorTest.Text = "Click me to run the tests";
            this.buttonCalculatorTest.UseVisualStyleBackColor = false;
            this.buttonCalculatorTest.Click += new System.EventHandler(this.buttonCalculatorTest_Click);
            // 
            // tabPagePayslip
            // 
            this.tabPagePayslip.Controls.Add(this.labelEmployee);
            this.tabPagePayslip.Controls.Add(this.label1);
            this.tabPagePayslip.Controls.Add(this.labelPaySlip);
            this.tabPagePayslip.Controls.Add(this.panelPaySlip);
            this.tabPagePayslip.Controls.Add(this.labelPaymentStartDate);
            this.tabPagePayslip.Controls.Add(this.dateTimePickerPaysleepPeriod);
            this.tabPagePayslip.Controls.Add(this.labelSuperRate);
            this.tabPagePayslip.Controls.Add(this.textBoxSuperRate);
            this.tabPagePayslip.Controls.Add(this.textBoxAnnualSalary);
            this.tabPagePayslip.Controls.Add(this.textBoxLastName);
            this.tabPagePayslip.Controls.Add(this.textBoxFirstName);
            this.tabPagePayslip.Controls.Add(this.labelAnnualSalary);
            this.tabPagePayslip.Controls.Add(this.labelLastName);
            this.tabPagePayslip.Controls.Add(this.labelFirstName);
            this.tabPagePayslip.Controls.Add(this.panel1);
            this.tabPagePayslip.Location = new System.Drawing.Point(4, 22);
            this.tabPagePayslip.Name = "tabPagePayslip";
            this.tabPagePayslip.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePayslip.Size = new System.Drawing.Size(558, 324);
            this.tabPagePayslip.TabIndex = 0;
            this.tabPagePayslip.Text = "Payslip application";
            this.tabPagePayslip.UseVisualStyleBackColor = true;
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployee.Location = new System.Drawing.Point(45, 19);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(78, 17);
            this.labelEmployee.TabIndex = 29;
            this.labelEmployee.Text = "Employee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "*Navigate between controls using the tab key. Click Generate Payslip to see the p" +
    "ayslip.";
            // 
            // labelPaySlip
            // 
            this.labelPaySlip.AutoSize = true;
            this.labelPaySlip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaySlip.Location = new System.Drawing.Point(346, 19);
            this.labelPaySlip.Name = "labelPaySlip";
            this.labelPaySlip.Size = new System.Drawing.Size(67, 17);
            this.labelPaySlip.TabIndex = 27;
            this.labelPaySlip.Text = "Pay Slip";
            // 
            // panelPaySlip
            // 
            this.panelPaySlip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPaySlip.Controls.Add(this.labelSuperRatePayslip);
            this.panelPaySlip.Controls.Add(this.labelSuper);
            this.panelPaySlip.Controls.Add(this.labelAnnualSalaryValue);
            this.panelPaySlip.Controls.Add(this.labelAnnualSalaryPayslip);
            this.panelPaySlip.Controls.Add(this.labelSuperValue);
            this.panelPaySlip.Controls.Add(this.labelSuperPayslip);
            this.panelPaySlip.Controls.Add(this.labelNetIncomeValue);
            this.panelPaySlip.Controls.Add(this.labelNetIncomePayslip);
            this.panelPaySlip.Controls.Add(this.labelIncomeTaxValue);
            this.panelPaySlip.Controls.Add(this.labelIncomeTaxPayslip);
            this.panelPaySlip.Controls.Add(this.labelGrossIncomeValue);
            this.panelPaySlip.Controls.Add(this.labelGrossIncomePayslip);
            this.panelPaySlip.Controls.Add(this.labelPayPeriodValue);
            this.panelPaySlip.Controls.Add(this.labelNameValue);
            this.panelPaySlip.Controls.Add(this.labelPayPeriodPayslip);
            this.panelPaySlip.Controls.Add(this.labelPayslipName);
            this.panelPaySlip.Location = new System.Drawing.Point(300, 49);
            this.panelPaySlip.Name = "panelPaySlip";
            this.panelPaySlip.Size = new System.Drawing.Size(237, 223);
            this.panelPaySlip.TabIndex = 26;
            // 
            // labelSuperRatePayslip
            // 
            this.labelSuperRatePayslip.AutoSize = true;
            this.labelSuperRatePayslip.Location = new System.Drawing.Point(121, 165);
            this.labelSuperRatePayslip.Name = "labelSuperRatePayslip";
            this.labelSuperRatePayslip.Size = new System.Drawing.Size(37, 13);
            this.labelSuperRatePayslip.TabIndex = 15;
            this.labelSuperRatePayslip.Text = "----------";
            this.labelSuperRatePayslip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSuper
            // 
            this.labelSuper.AutoSize = true;
            this.labelSuper.Location = new System.Drawing.Point(32, 160);
            this.labelSuper.Name = "labelSuper";
            this.labelSuper.Size = new System.Drawing.Size(47, 13);
            this.labelSuper.TabIndex = 14;
            this.labelSuper.Text = "Rate (%)";
            // 
            // labelAnnualSalaryValue
            // 
            this.labelAnnualSalaryValue.AutoSize = true;
            this.labelAnnualSalaryValue.Location = new System.Drawing.Point(121, 186);
            this.labelAnnualSalaryValue.Name = "labelAnnualSalaryValue";
            this.labelAnnualSalaryValue.Size = new System.Drawing.Size(37, 13);
            this.labelAnnualSalaryValue.TabIndex = 13;
            this.labelAnnualSalaryValue.Text = "----------";
            // 
            // labelAnnualSalaryPayslip
            // 
            this.labelAnnualSalaryPayslip.AutoSize = true;
            this.labelAnnualSalaryPayslip.Location = new System.Drawing.Point(32, 184);
            this.labelAnnualSalaryPayslip.Name = "labelAnnualSalaryPayslip";
            this.labelAnnualSalaryPayslip.Size = new System.Drawing.Size(72, 13);
            this.labelAnnualSalaryPayslip.TabIndex = 12;
            this.labelAnnualSalaryPayslip.Text = "Annual Salary";
            // 
            // labelSuperValue
            // 
            this.labelSuperValue.AutoSize = true;
            this.labelSuperValue.Location = new System.Drawing.Point(121, 141);
            this.labelSuperValue.Name = "labelSuperValue";
            this.labelSuperValue.Size = new System.Drawing.Size(37, 13);
            this.labelSuperValue.TabIndex = 11;
            this.labelSuperValue.Text = "----------";
            this.labelSuperValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSuperPayslip
            // 
            this.labelSuperPayslip.AutoSize = true;
            this.labelSuperPayslip.Location = new System.Drawing.Point(32, 136);
            this.labelSuperPayslip.Name = "labelSuperPayslip";
            this.labelSuperPayslip.Size = new System.Drawing.Size(35, 13);
            this.labelSuperPayslip.TabIndex = 10;
            this.labelSuperPayslip.Text = "Super";
            // 
            // labelNetIncomeValue
            // 
            this.labelNetIncomeValue.AutoSize = true;
            this.labelNetIncomeValue.Location = new System.Drawing.Point(121, 115);
            this.labelNetIncomeValue.Name = "labelNetIncomeValue";
            this.labelNetIncomeValue.Size = new System.Drawing.Size(37, 13);
            this.labelNetIncomeValue.TabIndex = 9;
            this.labelNetIncomeValue.Text = "----------";
            this.labelNetIncomeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNetIncomePayslip
            // 
            this.labelNetIncomePayslip.AutoSize = true;
            this.labelNetIncomePayslip.Location = new System.Drawing.Point(32, 112);
            this.labelNetIncomePayslip.Name = "labelNetIncomePayslip";
            this.labelNetIncomePayslip.Size = new System.Drawing.Size(62, 13);
            this.labelNetIncomePayslip.TabIndex = 8;
            this.labelNetIncomePayslip.Text = "Net Income";
            // 
            // labelIncomeTaxValue
            // 
            this.labelIncomeTaxValue.AutoSize = true;
            this.labelIncomeTaxValue.Location = new System.Drawing.Point(121, 87);
            this.labelIncomeTaxValue.Name = "labelIncomeTaxValue";
            this.labelIncomeTaxValue.Size = new System.Drawing.Size(37, 13);
            this.labelIncomeTaxValue.TabIndex = 7;
            this.labelIncomeTaxValue.Text = "----------";
            this.labelIncomeTaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelIncomeTaxPayslip
            // 
            this.labelIncomeTaxPayslip.AutoSize = true;
            this.labelIncomeTaxPayslip.Location = new System.Drawing.Point(32, 88);
            this.labelIncomeTaxPayslip.Name = "labelIncomeTaxPayslip";
            this.labelIncomeTaxPayslip.Size = new System.Drawing.Size(63, 13);
            this.labelIncomeTaxPayslip.TabIndex = 6;
            this.labelIncomeTaxPayslip.Text = "Income Tax";
            // 
            // labelGrossIncomeValue
            // 
            this.labelGrossIncomeValue.AutoSize = true;
            this.labelGrossIncomeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrossIncomeValue.Location = new System.Drawing.Point(121, 62);
            this.labelGrossIncomeValue.Name = "labelGrossIncomeValue";
            this.labelGrossIncomeValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGrossIncomeValue.Size = new System.Drawing.Size(37, 13);
            this.labelGrossIncomeValue.TabIndex = 5;
            this.labelGrossIncomeValue.Text = "----------";
            this.labelGrossIncomeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelGrossIncomePayslip
            // 
            this.labelGrossIncomePayslip.AutoSize = true;
            this.labelGrossIncomePayslip.Location = new System.Drawing.Point(32, 64);
            this.labelGrossIncomePayslip.Name = "labelGrossIncomePayslip";
            this.labelGrossIncomePayslip.Size = new System.Drawing.Size(72, 13);
            this.labelGrossIncomePayslip.TabIndex = 4;
            this.labelGrossIncomePayslip.Text = "Gross Income";
            // 
            // labelPayPeriodValue
            // 
            this.labelPayPeriodValue.AutoSize = true;
            this.labelPayPeriodValue.Location = new System.Drawing.Point(121, 38);
            this.labelPayPeriodValue.Name = "labelPayPeriodValue";
            this.labelPayPeriodValue.Size = new System.Drawing.Size(37, 13);
            this.labelPayPeriodValue.TabIndex = 3;
            this.labelPayPeriodValue.Text = "----------";
            // 
            // labelNameValue
            // 
            this.labelNameValue.AutoSize = true;
            this.labelNameValue.Location = new System.Drawing.Point(121, 16);
            this.labelNameValue.Name = "labelNameValue";
            this.labelNameValue.Size = new System.Drawing.Size(37, 13);
            this.labelNameValue.TabIndex = 2;
            this.labelNameValue.Text = "----------";
            // 
            // labelPayPeriodPayslip
            // 
            this.labelPayPeriodPayslip.AutoSize = true;
            this.labelPayPeriodPayslip.Location = new System.Drawing.Point(32, 40);
            this.labelPayPeriodPayslip.Name = "labelPayPeriodPayslip";
            this.labelPayPeriodPayslip.Size = new System.Drawing.Size(58, 13);
            this.labelPayPeriodPayslip.TabIndex = 1;
            this.labelPayPeriodPayslip.Text = "Pay Period";
            // 
            // labelPayslipName
            // 
            this.labelPayslipName.AutoSize = true;
            this.labelPayslipName.Location = new System.Drawing.Point(32, 16);
            this.labelPayslipName.Name = "labelPayslipName";
            this.labelPayslipName.Size = new System.Drawing.Size(35, 13);
            this.labelPayslipName.TabIndex = 0;
            this.labelPayslipName.Text = "Name";
            // 
            // labelPaymentStartDate
            // 
            this.labelPaymentStartDate.AutoSize = true;
            this.labelPaymentStartDate.Location = new System.Drawing.Point(45, 169);
            this.labelPaymentStartDate.Name = "labelPaymentStartDate";
            this.labelPaymentStartDate.Size = new System.Drawing.Size(76, 13);
            this.labelPaymentStartDate.TabIndex = 25;
            this.labelPaymentStartDate.Text = "Pay Start Date";
            // 
            // dateTimePickerPaysleepPeriod
            // 
            this.dateTimePickerPaysleepPeriod.AllowDrop = true;
            this.dateTimePickerPaysleepPeriod.CustomFormat = "MMM - yyyy";
            this.dateTimePickerPaysleepPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPaysleepPeriod.Location = new System.Drawing.Point(48, 185);
            this.dateTimePickerPaysleepPeriod.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerPaysleepPeriod.MinDate = new System.DateTime(2011, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerPaysleepPeriod.Name = "dateTimePickerPaysleepPeriod";
            this.dateTimePickerPaysleepPeriod.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerPaysleepPeriod.TabIndex = 5;
            // 
            // labelSuperRate
            // 
            this.labelSuperRate.AutoSize = true;
            this.labelSuperRate.Location = new System.Drawing.Point(167, 116);
            this.labelSuperRate.Name = "labelSuperRate";
            this.labelSuperRate.Size = new System.Drawing.Size(78, 13);
            this.labelSuperRate.TabIndex = 23;
            this.labelSuperRate.Text = "Super Rate (%)";
            // 
            // textBoxSuperRate
            // 
            this.textBoxSuperRate.Location = new System.Drawing.Point(167, 135);
            this.textBoxSuperRate.Name = "textBoxSuperRate";
            this.textBoxSuperRate.ShortcutsEnabled = false;
            this.textBoxSuperRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxSuperRate.TabIndex = 4;
            this.textBoxSuperRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSuperRate_KeyPress);
            // 
            // textBoxAnnualSalary
            // 
            this.textBoxAnnualSalary.Location = new System.Drawing.Point(48, 135);
            this.textBoxAnnualSalary.Name = "textBoxAnnualSalary";
            this.textBoxAnnualSalary.ShortcutsEnabled = false;
            this.textBoxAnnualSalary.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnnualSalary.TabIndex = 3;
            this.textBoxAnnualSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAnnualSalary_KeyPress);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(167, 78);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ShortcutsEnabled = false;
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 2;
            this.textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLastName_KeyPress);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(48, 78);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ShortcutsEnabled = false;
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstName_KeyPress);
            // 
            // labelAnnualSalary
            // 
            this.labelAnnualSalary.AutoSize = true;
            this.labelAnnualSalary.Location = new System.Drawing.Point(45, 119);
            this.labelAnnualSalary.Name = "labelAnnualSalary";
            this.labelAnnualSalary.Size = new System.Drawing.Size(72, 13);
            this.labelAnnualSalary.TabIndex = 20;
            this.labelAnnualSalary.Text = "Annual Salary";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(164, 62);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 19;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(45, 62);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 16;
            this.labelFirstName.Text = "First Name";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonGeneratePayslip);
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.Location = new System.Drawing.Point(31, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 179);
            this.panel1.TabIndex = 28;
            // 
            // buttonGeneratePayslip
            // 
            this.buttonGeneratePayslip.Location = new System.Drawing.Point(135, 132);
            this.buttonGeneratePayslip.Name = "buttonGeneratePayslip";
            this.buttonGeneratePayslip.Size = new System.Drawing.Size(100, 23);
            this.buttonGeneratePayslip.TabIndex = 6;
            this.buttonGeneratePayslip.Text = "Generate Payslip";
            this.buttonGeneratePayslip.UseVisualStyleBackColor = true;
            this.buttonGeneratePayslip.Click += new System.EventHandler(this.buttonGeneratePayslip_Click_1);
            // 
            // tabControlPayslip
            // 
            this.tabControlPayslip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlPayslip.Controls.Add(this.tabPagePayslip);
            this.tabControlPayslip.Controls.Add(this.tabPageTestHarness);
            this.tabControlPayslip.Controls.Add(this.tabPageDesign);
            this.tabControlPayslip.Location = new System.Drawing.Point(0, 27);
            this.tabControlPayslip.Name = "tabControlPayslip";
            this.tabControlPayslip.SelectedIndex = 0;
            this.tabControlPayslip.Size = new System.Drawing.Size(566, 350);
            this.tabControlPayslip.TabIndex = 17;
            // 
            // PayslipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(566, 380);
            this.Controls.Add(this.tabControlPayslip);
            this.Controls.Add(this.menuStripMain);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "PayslipForm";
            this.Text = "Payslip";
            this.Activated += new System.EventHandler(this.PayslipForm_Activated);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabPageDesign.ResumeLayout(false);
            this.tabPageTestHarness.ResumeLayout(false);
            this.tabPageTestHarness.PerformLayout();
            this.tabPagePayslip.ResumeLayout(false);
            this.tabPagePayslip.PerformLayout();
            this.panelPaySlip.ResumeLayout(false);
            this.panelPaySlip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControlPayslip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageDesign;
        private System.Windows.Forms.RichTextBox richTextBoxReademe;
        private System.Windows.Forms.TabPage tabPageTestHarness;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonCalculatorTest;
        private System.Windows.Forms.TabPage tabPagePayslip;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPaySlip;
        private System.Windows.Forms.Panel panelPaySlip;
        private System.Windows.Forms.Label labelSuperRatePayslip;
        private System.Windows.Forms.Label labelSuper;
        private System.Windows.Forms.Label labelAnnualSalaryValue;
        private System.Windows.Forms.Label labelAnnualSalaryPayslip;
        private System.Windows.Forms.Label labelSuperValue;
        private System.Windows.Forms.Label labelSuperPayslip;
        private System.Windows.Forms.Label labelNetIncomeValue;
        private System.Windows.Forms.Label labelNetIncomePayslip;
        private System.Windows.Forms.Label labelIncomeTaxValue;
        private System.Windows.Forms.Label labelIncomeTaxPayslip;
        private System.Windows.Forms.Label labelGrossIncomeValue;
        private System.Windows.Forms.Label labelGrossIncomePayslip;
        private System.Windows.Forms.Label labelPayPeriodValue;
        private System.Windows.Forms.Label labelNameValue;
        private System.Windows.Forms.Label labelPayPeriodPayslip;
        private System.Windows.Forms.Label labelPayslipName;
        private System.Windows.Forms.Label labelPaymentStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPaysleepPeriod;
        private System.Windows.Forms.Label labelSuperRate;
        private System.Windows.Forms.TextBox textBoxSuperRate;
        private System.Windows.Forms.TextBox textBoxAnnualSalary;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelAnnualSalary;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGeneratePayslip;
        private System.Windows.Forms.TabControl tabControlPayslip;
    }
}

