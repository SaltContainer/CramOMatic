namespace CramOMatic
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabsMain = new System.Windows.Forms.TabControl();
            this.tabsMainTabCalculate = new System.Windows.Forms.TabPage();
            this.btnRegen = new System.Windows.Forms.Button();
            this.numRecipeAmount = new System.Windows.Forms.NumericUpDown();
            this.lbRecipeAmount = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbRecipes = new System.Windows.Forms.Label();
            this.dataRecipes = new System.Windows.Forms.DataGridView();
            this.comboOutput = new System.Windows.Forms.ComboBox();
            this.lbOutput = new System.Windows.Forms.Label();
            this.tabsMainTabResult = new System.Windows.Forms.TabPage();
            this.lbCalculatorSpecial = new System.Windows.Forms.Label();
            this.lbAccuracy = new System.Windows.Forms.Label();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lbResultName = new System.Windows.Forms.Label();
            this.lbResultInfo = new System.Windows.Forms.Label();
            this.lbInput4 = new System.Windows.Forms.Label();
            this.lbInput3 = new System.Windows.Forms.Label();
            this.lbInput2 = new System.Windows.Forms.Label();
            this.lbInput1 = new System.Windows.Forms.Label();
            this.comboInput4 = new System.Windows.Forms.ComboBox();
            this.comboInput3 = new System.Windows.Forms.ComboBox();
            this.comboInput2 = new System.Windows.Forms.ComboBox();
            this.comboInput1 = new System.Windows.Forms.ComboBox();
            this.tabSpecialRecipes = new System.Windows.Forms.TabPage();
            this.dataSpecialRecipes = new System.Windows.Forms.DataGridView();
            this.tabApricornRecipes = new System.Windows.Forms.TabPage();
            this.comboApricorn4 = new System.Windows.Forms.ComboBox();
            this.comboApricorn3 = new System.Windows.Forms.ComboBox();
            this.comboApricorn2 = new System.Windows.Forms.ComboBox();
            this.comboApricorn1 = new System.Windows.Forms.ComboBox();
            this.dataApricornRecipes = new System.Windows.Forms.DataGridView();
            this.grpApricorn = new System.Windows.Forms.GroupBox();
            this.tabInputInfo = new System.Windows.Forms.TabPage();
            this.dataInputData = new System.Windows.Forms.DataGridView();
            this.tabsMain.SuspendLayout();
            this.tabsMainTabCalculate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRecipeAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRecipes)).BeginInit();
            this.tabsMainTabResult.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.tabSpecialRecipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpecialRecipes)).BeginInit();
            this.tabApricornRecipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataApricornRecipes)).BeginInit();
            this.grpApricorn.SuspendLayout();
            this.tabInputInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInputData)).BeginInit();
            this.SuspendLayout();
            // 
            // tabsMain
            // 
            this.tabsMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsMain.Controls.Add(this.tabsMainTabCalculate);
            this.tabsMain.Controls.Add(this.tabsMainTabResult);
            this.tabsMain.Controls.Add(this.tabInputInfo);
            this.tabsMain.Controls.Add(this.tabSpecialRecipes);
            this.tabsMain.Controls.Add(this.tabApricornRecipes);
            this.tabsMain.Location = new System.Drawing.Point(12, 12);
            this.tabsMain.Name = "tabsMain";
            this.tabsMain.SelectedIndex = 0;
            this.tabsMain.Size = new System.Drawing.Size(783, 459);
            this.tabsMain.TabIndex = 0;
            // 
            // tabsMainTabCalculate
            // 
            this.tabsMainTabCalculate.Controls.Add(this.btnRegen);
            this.tabsMainTabCalculate.Controls.Add(this.numRecipeAmount);
            this.tabsMainTabCalculate.Controls.Add(this.lbRecipeAmount);
            this.tabsMainTabCalculate.Controls.Add(this.lbInfo);
            this.tabsMainTabCalculate.Controls.Add(this.lbRecipes);
            this.tabsMainTabCalculate.Controls.Add(this.dataRecipes);
            this.tabsMainTabCalculate.Controls.Add(this.comboOutput);
            this.tabsMainTabCalculate.Controls.Add(this.lbOutput);
            this.tabsMainTabCalculate.Location = new System.Drawing.Point(4, 25);
            this.tabsMainTabCalculate.Name = "tabsMainTabCalculate";
            this.tabsMainTabCalculate.Padding = new System.Windows.Forms.Padding(3);
            this.tabsMainTabCalculate.Size = new System.Drawing.Size(775, 430);
            this.tabsMainTabCalculate.TabIndex = 0;
            this.tabsMainTabCalculate.Text = "Recipe Generator";
            this.tabsMainTabCalculate.UseVisualStyleBackColor = true;
            // 
            // btnRegen
            // 
            this.btnRegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegen.Location = new System.Drawing.Point(6, 387);
            this.btnRegen.Name = "btnRegen";
            this.btnRegen.Size = new System.Drawing.Size(179, 37);
            this.btnRegen.TabIndex = 3;
            this.btnRegen.Text = "Generate New Recipes";
            this.btnRegen.UseVisualStyleBackColor = true;
            this.btnRegen.Click += new System.EventHandler(this.comboOutput_SelectedIndexChanged);
            // 
            // numRecipeAmount
            // 
            this.numRecipeAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numRecipeAmount.Location = new System.Drawing.Point(689, 395);
            this.numRecipeAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numRecipeAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRecipeAmount.Name = "numRecipeAmount";
            this.numRecipeAmount.Size = new System.Drawing.Size(80, 22);
            this.numRecipeAmount.TabIndex = 4;
            this.numRecipeAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lbRecipeAmount
            // 
            this.lbRecipeAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRecipeAmount.AutoSize = true;
            this.lbRecipeAmount.Location = new System.Drawing.Point(543, 397);
            this.lbRecipeAmount.Name = "lbRecipeAmount";
            this.lbRecipeAmount.Size = new System.Drawing.Size(140, 17);
            this.lbRecipeAmount.TabIndex = 5;
            this.lbRecipeAmount.Text = "Recipes to generate:";
            // 
            // lbInfo
            // 
            this.lbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(366, 3);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(341, 54);
            this.lbInfo.TabIndex = 4;
            this.lbInfo.Text = "TYPE 000-000";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbRecipes
            // 
            this.lbRecipes.AutoSize = true;
            this.lbRecipes.Location = new System.Drawing.Point(16, 53);
            this.lbRecipes.Name = "lbRecipes";
            this.lbRecipes.Size = new System.Drawing.Size(199, 17);
            this.lbRecipes.TabIndex = 3;
            this.lbRecipes.Text = "Showing 100 possible recipes:";
            // 
            // dataRecipes
            // 
            this.dataRecipes.AllowUserToAddRows = false;
            this.dataRecipes.AllowUserToDeleteRows = false;
            this.dataRecipes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRecipes.Location = new System.Drawing.Point(6, 73);
            this.dataRecipes.Name = "dataRecipes";
            this.dataRecipes.ReadOnly = true;
            this.dataRecipes.RowHeadersVisible = false;
            this.dataRecipes.RowHeadersWidth = 51;
            this.dataRecipes.RowTemplate.Height = 24;
            this.dataRecipes.Size = new System.Drawing.Size(763, 308);
            this.dataRecipes.TabIndex = 2;
            // 
            // comboOutput
            // 
            this.comboOutput.FormattingEnabled = true;
            this.comboOutput.Location = new System.Drawing.Point(77, 17);
            this.comboOutput.Name = "comboOutput";
            this.comboOutput.Size = new System.Drawing.Size(283, 24);
            this.comboOutput.TabIndex = 1;
            this.comboOutput.SelectedIndexChanged += new System.EventHandler(this.comboOutput_SelectedIndexChanged);
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Location = new System.Drawing.Point(16, 20);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(55, 17);
            this.lbOutput.TabIndex = 0;
            this.lbOutput.Text = "Output:";
            // 
            // tabsMainTabResult
            // 
            this.tabsMainTabResult.Controls.Add(this.lbCalculatorSpecial);
            this.tabsMainTabResult.Controls.Add(this.lbAccuracy);
            this.tabsMainTabResult.Controls.Add(this.grpResult);
            this.tabsMainTabResult.Controls.Add(this.lbInput4);
            this.tabsMainTabResult.Controls.Add(this.lbInput3);
            this.tabsMainTabResult.Controls.Add(this.lbInput2);
            this.tabsMainTabResult.Controls.Add(this.lbInput1);
            this.tabsMainTabResult.Controls.Add(this.comboInput4);
            this.tabsMainTabResult.Controls.Add(this.comboInput3);
            this.tabsMainTabResult.Controls.Add(this.comboInput2);
            this.tabsMainTabResult.Controls.Add(this.comboInput1);
            this.tabsMainTabResult.Location = new System.Drawing.Point(4, 25);
            this.tabsMainTabResult.Name = "tabsMainTabResult";
            this.tabsMainTabResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabsMainTabResult.Size = new System.Drawing.Size(775, 430);
            this.tabsMainTabResult.TabIndex = 1;
            this.tabsMainTabResult.Text = "Result Calculator";
            this.tabsMainTabResult.UseVisualStyleBackColor = true;
            // 
            // lbCalculatorSpecial
            // 
            this.lbCalculatorSpecial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCalculatorSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalculatorSpecial.Location = new System.Drawing.Point(19, 205);
            this.lbCalculatorSpecial.Name = "lbCalculatorSpecial";
            this.lbCalculatorSpecial.Size = new System.Drawing.Size(736, 102);
            this.lbCalculatorSpecial.TabIndex = 13;
            this.lbCalculatorSpecial.Text = resources.GetString("lbCalculatorSpecial.Text");
            this.lbCalculatorSpecial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbAccuracy
            // 
            this.lbAccuracy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAccuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccuracy.Location = new System.Drawing.Point(19, 317);
            this.lbAccuracy.Name = "lbAccuracy";
            this.lbAccuracy.Size = new System.Drawing.Size(736, 94);
            this.lbAccuracy.TabIndex = 12;
            this.lbAccuracy.Text = "This crafting recipe is inaccurate. One or more of the items selected do not have" +
    " a defined value. The full total is higher.";
            this.lbAccuracy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbAccuracy.Visible = false;
            // 
            // grpResult
            // 
            this.grpResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResult.Controls.Add(this.lbResultName);
            this.grpResult.Controls.Add(this.lbResultInfo);
            this.grpResult.Location = new System.Drawing.Point(462, 15);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(293, 174);
            this.grpResult.TabIndex = 11;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Result";
            // 
            // lbResultName
            // 
            this.lbResultName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultName.Location = new System.Drawing.Point(6, 36);
            this.lbResultName.Name = "lbResultName";
            this.lbResultName.Size = new System.Drawing.Size(281, 34);
            this.lbResultName.TabIndex = 10;
            this.lbResultName.Text = "Item Name";
            this.lbResultName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResultInfo
            // 
            this.lbResultInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultInfo.Location = new System.Drawing.Point(6, 95);
            this.lbResultInfo.Name = "lbResultInfo";
            this.lbResultInfo.Size = new System.Drawing.Size(281, 43);
            this.lbResultInfo.TabIndex = 9;
            this.lbResultInfo.Text = "TYPE 000";
            this.lbResultInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbInput4
            // 
            this.lbInput4.AutoSize = true;
            this.lbInput4.Location = new System.Drawing.Point(16, 168);
            this.lbInput4.Name = "lbInput4";
            this.lbInput4.Size = new System.Drawing.Size(83, 17);
            this.lbInput4.TabIndex = 7;
            this.lbInput4.Text = "Fourth Item:";
            // 
            // lbInput3
            // 
            this.lbInput3.AutoSize = true;
            this.lbInput3.Location = new System.Drawing.Point(24, 118);
            this.lbInput3.Name = "lbInput3";
            this.lbInput3.Size = new System.Drawing.Size(75, 17);
            this.lbInput3.TabIndex = 6;
            this.lbInput3.Text = "Third Item:";
            // 
            // lbInput2
            // 
            this.lbInput2.AutoSize = true;
            this.lbInput2.Location = new System.Drawing.Point(9, 68);
            this.lbInput2.Name = "lbInput2";
            this.lbInput2.Size = new System.Drawing.Size(90, 17);
            this.lbInput2.TabIndex = 5;
            this.lbInput2.Text = "Second Item:";
            // 
            // lbInput1
            // 
            this.lbInput1.AutoSize = true;
            this.lbInput1.Location = new System.Drawing.Point(30, 18);
            this.lbInput1.Name = "lbInput1";
            this.lbInput1.Size = new System.Drawing.Size(69, 17);
            this.lbInput1.TabIndex = 0;
            this.lbInput1.Text = "First Item:";
            // 
            // comboInput4
            // 
            this.comboInput4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboInput4.FormattingEnabled = true;
            this.comboInput4.Location = new System.Drawing.Point(105, 165);
            this.comboInput4.Name = "comboInput4";
            this.comboInput4.Size = new System.Drawing.Size(332, 24);
            this.comboInput4.TabIndex = 4;
            this.comboInput4.SelectedIndexChanged += new System.EventHandler(this.comboInputAll_SelectedIndexChanged);
            // 
            // comboInput3
            // 
            this.comboInput3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboInput3.FormattingEnabled = true;
            this.comboInput3.Location = new System.Drawing.Point(105, 115);
            this.comboInput3.Name = "comboInput3";
            this.comboInput3.Size = new System.Drawing.Size(332, 24);
            this.comboInput3.TabIndex = 3;
            this.comboInput3.SelectedIndexChanged += new System.EventHandler(this.comboInputAll_SelectedIndexChanged);
            // 
            // comboInput2
            // 
            this.comboInput2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboInput2.FormattingEnabled = true;
            this.comboInput2.Location = new System.Drawing.Point(105, 65);
            this.comboInput2.Name = "comboInput2";
            this.comboInput2.Size = new System.Drawing.Size(332, 24);
            this.comboInput2.TabIndex = 2;
            this.comboInput2.SelectedIndexChanged += new System.EventHandler(this.comboInputAll_SelectedIndexChanged);
            // 
            // comboInput1
            // 
            this.comboInput1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboInput1.FormattingEnabled = true;
            this.comboInput1.Location = new System.Drawing.Point(105, 15);
            this.comboInput1.Name = "comboInput1";
            this.comboInput1.Size = new System.Drawing.Size(332, 24);
            this.comboInput1.TabIndex = 1;
            this.comboInput1.SelectedIndexChanged += new System.EventHandler(this.comboInputAll_SelectedIndexChanged);
            // 
            // tabSpecialRecipes
            // 
            this.tabSpecialRecipes.Controls.Add(this.dataSpecialRecipes);
            this.tabSpecialRecipes.Location = new System.Drawing.Point(4, 25);
            this.tabSpecialRecipes.Name = "tabSpecialRecipes";
            this.tabSpecialRecipes.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpecialRecipes.Size = new System.Drawing.Size(775, 430);
            this.tabSpecialRecipes.TabIndex = 2;
            this.tabSpecialRecipes.Text = "Special Recipes";
            this.tabSpecialRecipes.UseVisualStyleBackColor = true;
            // 
            // dataSpecialRecipes
            // 
            this.dataSpecialRecipes.AllowUserToAddRows = false;
            this.dataSpecialRecipes.AllowUserToDeleteRows = false;
            this.dataSpecialRecipes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSpecialRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSpecialRecipes.Location = new System.Drawing.Point(6, 6);
            this.dataSpecialRecipes.Name = "dataSpecialRecipes";
            this.dataSpecialRecipes.ReadOnly = true;
            this.dataSpecialRecipes.RowHeadersVisible = false;
            this.dataSpecialRecipes.RowHeadersWidth = 51;
            this.dataSpecialRecipes.RowTemplate.Height = 24;
            this.dataSpecialRecipes.Size = new System.Drawing.Size(763, 418);
            this.dataSpecialRecipes.TabIndex = 0;
            // 
            // tabApricornRecipes
            // 
            this.tabApricornRecipes.Controls.Add(this.grpApricorn);
            this.tabApricornRecipes.Controls.Add(this.dataApricornRecipes);
            this.tabApricornRecipes.Location = new System.Drawing.Point(4, 25);
            this.tabApricornRecipes.Name = "tabApricornRecipes";
            this.tabApricornRecipes.Padding = new System.Windows.Forms.Padding(3);
            this.tabApricornRecipes.Size = new System.Drawing.Size(775, 430);
            this.tabApricornRecipes.TabIndex = 3;
            this.tabApricornRecipes.Text = "Pokéball Recipes";
            this.tabApricornRecipes.UseVisualStyleBackColor = true;
            // 
            // comboApricorn4
            // 
            this.comboApricorn4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboApricorn4.FormattingEnabled = true;
            this.comboApricorn4.Location = new System.Drawing.Point(61, 200);
            this.comboApricorn4.Name = "comboApricorn4";
            this.comboApricorn4.Size = new System.Drawing.Size(319, 24);
            this.comboApricorn4.TabIndex = 4;
            this.comboApricorn4.SelectedIndexChanged += new System.EventHandler(this.comboApricornAll_SelectedIndexChanged);
            // 
            // comboApricorn3
            // 
            this.comboApricorn3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboApricorn3.FormattingEnabled = true;
            this.comboApricorn3.Location = new System.Drawing.Point(61, 150);
            this.comboApricorn3.Name = "comboApricorn3";
            this.comboApricorn3.Size = new System.Drawing.Size(319, 24);
            this.comboApricorn3.TabIndex = 3;
            this.comboApricorn3.SelectedIndexChanged += new System.EventHandler(this.comboApricornAll_SelectedIndexChanged);
            // 
            // comboApricorn2
            // 
            this.comboApricorn2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboApricorn2.FormattingEnabled = true;
            this.comboApricorn2.Location = new System.Drawing.Point(61, 100);
            this.comboApricorn2.Name = "comboApricorn2";
            this.comboApricorn2.Size = new System.Drawing.Size(319, 24);
            this.comboApricorn2.TabIndex = 2;
            this.comboApricorn2.SelectedIndexChanged += new System.EventHandler(this.comboApricornAll_SelectedIndexChanged);
            // 
            // comboApricorn1
            // 
            this.comboApricorn1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboApricorn1.FormattingEnabled = true;
            this.comboApricorn1.Location = new System.Drawing.Point(61, 50);
            this.comboApricorn1.Name = "comboApricorn1";
            this.comboApricorn1.Size = new System.Drawing.Size(319, 24);
            this.comboApricorn1.TabIndex = 1;
            this.comboApricorn1.SelectedIndexChanged += new System.EventHandler(this.comboApricornAll_SelectedIndexChanged);
            // 
            // dataApricornRecipes
            // 
            this.dataApricornRecipes.AllowUserToAddRows = false;
            this.dataApricornRecipes.AllowUserToDeleteRows = false;
            this.dataApricornRecipes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataApricornRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataApricornRecipes.Location = new System.Drawing.Point(443, 3);
            this.dataApricornRecipes.Name = "dataApricornRecipes";
            this.dataApricornRecipes.ReadOnly = true;
            this.dataApricornRecipes.RowHeadersVisible = false;
            this.dataApricornRecipes.RowHeadersWidth = 51;
            this.dataApricornRecipes.RowTemplate.Height = 24;
            this.dataApricornRecipes.Size = new System.Drawing.Size(326, 421);
            this.dataApricornRecipes.TabIndex = 5;
            // 
            // grpApricorn
            // 
            this.grpApricorn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpApricorn.Controls.Add(this.comboApricorn1);
            this.grpApricorn.Controls.Add(this.comboApricorn4);
            this.grpApricorn.Controls.Add(this.comboApricorn2);
            this.grpApricorn.Controls.Add(this.comboApricorn3);
            this.grpApricorn.Location = new System.Drawing.Point(7, 7);
            this.grpApricorn.Name = "grpApricorn";
            this.grpApricorn.Size = new System.Drawing.Size(430, 266);
            this.grpApricorn.TabIndex = 6;
            this.grpApricorn.TabStop = false;
            this.grpApricorn.Text = "Apricorns";
            // 
            // tabInputInfo
            // 
            this.tabInputInfo.Controls.Add(this.dataInputData);
            this.tabInputInfo.Location = new System.Drawing.Point(4, 25);
            this.tabInputInfo.Name = "tabInputInfo";
            this.tabInputInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInputInfo.Size = new System.Drawing.Size(775, 430);
            this.tabInputInfo.TabIndex = 4;
            this.tabInputInfo.Text = "Input Items Data";
            this.tabInputInfo.UseVisualStyleBackColor = true;
            // 
            // dataInputData
            // 
            this.dataInputData.AllowUserToAddRows = false;
            this.dataInputData.AllowUserToDeleteRows = false;
            this.dataInputData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataInputData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInputData.Location = new System.Drawing.Point(6, 6);
            this.dataInputData.Name = "dataInputData";
            this.dataInputData.ReadOnly = true;
            this.dataInputData.RowHeadersVisible = false;
            this.dataInputData.RowHeadersWidth = 51;
            this.dataInputData.RowTemplate.Height = 24;
            this.dataInputData.Size = new System.Drawing.Size(763, 418);
            this.dataInputData.TabIndex = 0;
            this.dataInputData.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataInputData_RowsAdded);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 483);
            this.Controls.Add(this.tabsMain);
            this.MinimumSize = new System.Drawing.Size(825, 530);
            this.Name = "FormMain";
            this.Text = "Cram-o-matic";
            this.tabsMain.ResumeLayout(false);
            this.tabsMainTabCalculate.ResumeLayout(false);
            this.tabsMainTabCalculate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRecipeAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRecipes)).EndInit();
            this.tabsMainTabResult.ResumeLayout(false);
            this.tabsMainTabResult.PerformLayout();
            this.grpResult.ResumeLayout(false);
            this.tabSpecialRecipes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSpecialRecipes)).EndInit();
            this.tabApricornRecipes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataApricornRecipes)).EndInit();
            this.grpApricorn.ResumeLayout(false);
            this.tabInputInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataInputData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsMain;
        private System.Windows.Forms.TabPage tabsMainTabCalculate;
        private System.Windows.Forms.TabPage tabsMainTabResult;
        private System.Windows.Forms.Label lbRecipes;
        private System.Windows.Forms.DataGridView dataRecipes;
        private System.Windows.Forms.ComboBox comboOutput;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label lbResultName;
        private System.Windows.Forms.Label lbResultInfo;
        private System.Windows.Forms.Label lbInput4;
        private System.Windows.Forms.Label lbInput3;
        private System.Windows.Forms.Label lbInput2;
        private System.Windows.Forms.ComboBox comboInput4;
        private System.Windows.Forms.ComboBox comboInput3;
        private System.Windows.Forms.ComboBox comboInput2;
        private System.Windows.Forms.ComboBox comboInput1;
        private System.Windows.Forms.Label lbInput1;
        private System.Windows.Forms.Label lbAccuracy;
        private System.Windows.Forms.Button btnRegen;
        private System.Windows.Forms.NumericUpDown numRecipeAmount;
        private System.Windows.Forms.Label lbRecipeAmount;
        private System.Windows.Forms.TabPage tabSpecialRecipes;
        private System.Windows.Forms.Label lbCalculatorSpecial;
        private System.Windows.Forms.DataGridView dataSpecialRecipes;
        private System.Windows.Forms.TabPage tabApricornRecipes;
        private System.Windows.Forms.DataGridView dataApricornRecipes;
        private System.Windows.Forms.ComboBox comboApricorn4;
        private System.Windows.Forms.ComboBox comboApricorn3;
        private System.Windows.Forms.ComboBox comboApricorn2;
        private System.Windows.Forms.ComboBox comboApricorn1;
        private System.Windows.Forms.GroupBox grpApricorn;
        private System.Windows.Forms.TabPage tabInputInfo;
        private System.Windows.Forms.DataGridView dataInputData;
    }
}

