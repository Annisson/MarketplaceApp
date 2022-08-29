
namespace MarketplaceApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelF1Header = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelSearchCategory = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSearchCategory = new System.Windows.Forms.ComboBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.groupBoxSearchResults = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelLoggedInAs = new System.Windows.Forms.Label();
            this.textBoxLoggedInAs = new System.Windows.Forms.TextBox();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxDetailsCategory = new System.Windows.Forms.ComboBox();
            this.buttonRemoveAD = new System.Windows.Forms.Button();
            this.buttonUpdateAD = new System.Windows.Forms.Button();
            this.buttonCreateAD = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDetailsCategory = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClearFields = new System.Windows.Forms.Label();
            this.buttonContactSeller = new System.Windows.Forms.Button();
            this.labelNewMember = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelF1Username = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelF1Password = new System.Windows.Forms.Label();
            this.groupBoxSearchResults.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.groupBoxDetails.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelF1Header
            // 
            this.labelF1Header.AutoSize = true;
            this.labelF1Header.BackColor = System.Drawing.Color.Transparent;
            this.labelF1Header.Font = new System.Drawing.Font("Ink Free", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelF1Header.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.labelF1Header.Location = new System.Drawing.Point(343, 73);
            this.labelF1Header.Name = "labelF1Header";
            this.labelF1Header.Size = new System.Drawing.Size(384, 79);
            this.labelF1Header.TabIndex = 0;
            this.labelF1Header.Text = "Marketplace";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.Transparent;
            this.labelSearch.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSearch.Location = new System.Drawing.Point(265, 154);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(55, 20);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Search";
            // 
            // labelSearchCategory
            // 
            this.labelSearchCategory.AutoSize = true;
            this.labelSearchCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchCategory.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSearchCategory.Location = new System.Drawing.Point(564, 154);
            this.labelSearchCategory.Name = "labelSearchCategory";
            this.labelSearchCategory.Size = new System.Drawing.Size(71, 20);
            this.labelSearchCategory.TabIndex = 2;
            this.labelSearchCategory.Text = "Category";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(265, 175);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(270, 22);
            this.textBoxSearch.TabIndex = 3;
            // 
            // comboBoxSearchCategory
            // 
            this.comboBoxSearchCategory.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSearchCategory.FormattingEnabled = true;
            this.comboBoxSearchCategory.Location = new System.Drawing.Point(564, 175);
            this.comboBoxSearchCategory.Name = "comboBoxSearchCategory";
            this.comboBoxSearchCategory.Size = new System.Drawing.Size(270, 23);
            this.comboBoxSearchCategory.TabIndex = 4;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.buttonLogin.Location = new System.Drawing.Point(1000, 23);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(72, 28);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.TabStop = false;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogout.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.buttonLogout.Location = new System.Drawing.Point(211, 24);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(72, 28);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.TabStop = false;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // groupBoxSearchResults
            // 
            this.groupBoxSearchResults.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSearchResults.Controls.Add(this.panel1);
            this.groupBoxSearchResults.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSearchResults.Location = new System.Drawing.Point(42, 228);
            this.groupBoxSearchResults.Name = "groupBoxSearchResults";
            this.groupBoxSearchResults.Size = new System.Drawing.Size(493, 431);
            this.groupBoxSearchResults.TabIndex = 7;
            this.groupBoxSearchResults.TabStop = false;
            this.groupBoxSearchResults.Text = "Search Results";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewResults);
            this.panel1.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 402);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.AllowUserToDeleteRows = false;
            this.dataGridViewResults.AllowUserToResizeColumns = false;
            this.dataGridViewResults.AllowUserToResizeRows = false;
            this.dataGridViewResults.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewResults.GridColor = System.Drawing.Color.PaleVioletRed;
            this.dataGridViewResults.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewResults.MultiSelect = false;
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.ReadOnly = true;
            this.dataGridViewResults.RowTemplate.Height = 25;
            this.dataGridViewResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResults.Size = new System.Drawing.Size(481, 377);
            this.dataGridViewResults.TabIndex = 0;
            this.dataGridViewResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResults_CellContentClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.buttonSearch.Location = new System.Drawing.Point(850, 169);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(82, 31);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelLoggedInAs
            // 
            this.labelLoggedInAs.AutoSize = true;
            this.labelLoggedInAs.BackColor = System.Drawing.Color.Transparent;
            this.labelLoggedInAs.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoggedInAs.Location = new System.Drawing.Point(12, 6);
            this.labelLoggedInAs.Name = "labelLoggedInAs";
            this.labelLoggedInAs.Size = new System.Drawing.Size(93, 20);
            this.labelLoggedInAs.TabIndex = 9;
            this.labelLoggedInAs.Text = "Logged in as";
            // 
            // textBoxLoggedInAs
            // 
            this.textBoxLoggedInAs.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoggedInAs.Location = new System.Drawing.Point(12, 27);
            this.textBoxLoggedInAs.Name = "textBoxLoggedInAs";
            this.textBoxLoggedInAs.ReadOnly = true;
            this.textBoxLoggedInAs.Size = new System.Drawing.Size(193, 22);
            this.textBoxLoggedInAs.TabIndex = 10;
            this.textBoxLoggedInAs.TabStop = false;
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDetails.Controls.Add(this.labelDate);
            this.groupBoxDetails.Controls.Add(this.textBoxPrice);
            this.groupBoxDetails.Controls.Add(this.comboBoxDetailsCategory);
            this.groupBoxDetails.Controls.Add(this.buttonRemoveAD);
            this.groupBoxDetails.Controls.Add(this.buttonUpdateAD);
            this.groupBoxDetails.Controls.Add(this.buttonCreateAD);
            this.groupBoxDetails.Controls.Add(this.labelDescription);
            this.groupBoxDetails.Controls.Add(this.textBoxDescription);
            this.groupBoxDetails.Controls.Add(this.textBoxDate);
            this.groupBoxDetails.Controls.Add(this.textBoxTitle);
            this.groupBoxDetails.Controls.Add(this.label2);
            this.groupBoxDetails.Controls.Add(this.labelPrice);
            this.groupBoxDetails.Controls.Add(this.labelDetailsCategory);
            this.groupBoxDetails.Controls.Add(this.labelTitle);
            this.groupBoxDetails.Controls.Add(this.panel2);
            this.groupBoxDetails.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxDetails.Location = new System.Drawing.Point(564, 228);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(480, 431);
            this.groupBoxDetails.TabIndex = 12;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "AD Details";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(251, 129);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 16);
            this.labelDate.TabIndex = 33;
            this.labelDate.Text = "Date";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrice.Location = new System.Drawing.Point(330, 163);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(129, 22);
            this.textBoxPrice.TabIndex = 33;
            // 
            // comboBoxDetailsCategory
            // 
            this.comboBoxDetailsCategory.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxDetailsCategory.FormattingEnabled = true;
            this.comboBoxDetailsCategory.Location = new System.Drawing.Point(189, 86);
            this.comboBoxDetailsCategory.Name = "comboBoxDetailsCategory";
            this.comboBoxDetailsCategory.Size = new System.Drawing.Size(270, 23);
            this.comboBoxDetailsCategory.TabIndex = 27;
            // 
            // buttonRemoveAD
            // 
            this.buttonRemoveAD.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRemoveAD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveAD.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveAD.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.buttonRemoveAD.Location = new System.Drawing.Point(377, 382);
            this.buttonRemoveAD.Name = "buttonRemoveAD";
            this.buttonRemoveAD.Size = new System.Drawing.Size(82, 28);
            this.buttonRemoveAD.TabIndex = 26;
            this.buttonRemoveAD.Text = "Remove";
            this.buttonRemoveAD.UseVisualStyleBackColor = false;
            this.buttonRemoveAD.Click += new System.EventHandler(this.buttonRemoveAD_Click);
            // 
            // buttonUpdateAD
            // 
            this.buttonUpdateAD.BackColor = System.Drawing.SystemColors.Control;
            this.buttonUpdateAD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateAD.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdateAD.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.buttonUpdateAD.Location = new System.Drawing.Point(286, 382);
            this.buttonUpdateAD.Name = "buttonUpdateAD";
            this.buttonUpdateAD.Size = new System.Drawing.Size(82, 28);
            this.buttonUpdateAD.TabIndex = 25;
            this.buttonUpdateAD.Text = "Update";
            this.buttonUpdateAD.UseVisualStyleBackColor = false;
            this.buttonUpdateAD.Click += new System.EventHandler(this.buttonUpdateAD_Click);
            // 
            // buttonCreateAD
            // 
            this.buttonCreateAD.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCreateAD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateAD.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateAD.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCreateAD.Location = new System.Drawing.Point(195, 382);
            this.buttonCreateAD.Name = "buttonCreateAD";
            this.buttonCreateAD.Size = new System.Drawing.Size(82, 28);
            this.buttonCreateAD.TabIndex = 24;
            this.buttonCreateAD.Text = "Create";
            this.buttonCreateAD.UseVisualStyleBackColor = false;
            this.buttonCreateAD.Click += new System.EventHandler(this.buttonCreateAD_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(37, 182);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(83, 16);
            this.labelDescription.TabIndex = 23;
            this.labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescription.Location = new System.Drawing.Point(37, 201);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(422, 120);
            this.textBoxDescription.TabIndex = 22;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDate.Location = new System.Drawing.Point(293, 125);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(166, 22);
            this.textBoxDate.TabIndex = 20;
            this.textBoxDate.TabStop = false;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTitle.Location = new System.Drawing.Point(189, 48);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(270, 22);
            this.textBoxTitle.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(104, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 16;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(285, 167);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(39, 16);
            this.labelPrice.TabIndex = 15;
            this.labelPrice.Text = "Price";
            // 
            // labelDetailsCategory
            // 
            this.labelDetailsCategory.AutoSize = true;
            this.labelDetailsCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelDetailsCategory.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDetailsCategory.Location = new System.Drawing.Point(118, 90);
            this.labelDetailsCategory.Name = "labelDetailsCategory";
            this.labelDetailsCategory.Size = new System.Drawing.Size(65, 16);
            this.labelDetailsCategory.TabIndex = 14;
            this.labelDetailsCategory.Text = "Category";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(147, 52);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(36, 16);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Title";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelClearFields);
            this.panel2.Controls.Add(this.buttonContactSeller);
            this.panel2.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 402);
            this.panel2.TabIndex = 33;
            // 
            // labelClearFields
            // 
            this.labelClearFields.AutoSize = true;
            this.labelClearFields.BackColor = System.Drawing.Color.Transparent;
            this.labelClearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClearFields.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClearFields.ForeColor = System.Drawing.Color.Blue;
            this.labelClearFields.Location = new System.Drawing.Point(388, 295);
            this.labelClearFields.Name = "labelClearFields";
            this.labelClearFields.Size = new System.Drawing.Size(71, 14);
            this.labelClearFields.TabIndex = 33;
            this.labelClearFields.Text = "Clear fields";
            this.labelClearFields.Click += new System.EventHandler(this.labelClearFields_Click);
            // 
            // buttonContactSeller
            // 
            this.buttonContactSeller.BackColor = System.Drawing.SystemColors.Control;
            this.buttonContactSeller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonContactSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContactSeller.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonContactSeller.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.buttonContactSeller.Location = new System.Drawing.Point(330, 319);
            this.buttonContactSeller.Name = "buttonContactSeller";
            this.buttonContactSeller.Size = new System.Drawing.Size(129, 28);
            this.buttonContactSeller.TabIndex = 13;
            this.buttonContactSeller.Text = "Contact Seller";
            this.buttonContactSeller.UseVisualStyleBackColor = false;
            this.buttonContactSeller.Click += new System.EventHandler(this.buttonContactSeller_Click);
            // 
            // labelNewMember
            // 
            this.labelNewMember.AutoSize = true;
            this.labelNewMember.BackColor = System.Drawing.Color.Transparent;
            this.labelNewMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNewMember.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNewMember.ForeColor = System.Drawing.Color.Blue;
            this.labelNewMember.Location = new System.Drawing.Point(834, 51);
            this.labelNewMember.Name = "labelNewMember";
            this.labelNewMember.Size = new System.Drawing.Size(159, 14);
            this.labelNewMember.TabIndex = 28;
            this.labelNewMember.Text = "New member? Sign up here!";
            this.labelNewMember.Click += new System.EventHandler(this.labelNewMember_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.Location = new System.Drawing.Point(599, 27);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(193, 22);
            this.textBoxUsername.TabIndex = 29;
            this.textBoxUsername.TabStop = false;
            // 
            // labelF1Username
            // 
            this.labelF1Username.AutoSize = true;
            this.labelF1Username.BackColor = System.Drawing.Color.Transparent;
            this.labelF1Username.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelF1Username.Location = new System.Drawing.Point(599, 7);
            this.labelF1Username.Name = "labelF1Username";
            this.labelF1Username.Size = new System.Drawing.Size(74, 20);
            this.labelF1Username.TabIndex = 30;
            this.labelF1Username.Text = "Username";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(800, 27);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(193, 22);
            this.textBoxPassword.TabIndex = 31;
            this.textBoxPassword.TabStop = false;
            // 
            // labelF1Password
            // 
            this.labelF1Password.AutoSize = true;
            this.labelF1Password.BackColor = System.Drawing.Color.Transparent;
            this.labelF1Password.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelF1Password.Location = new System.Drawing.Point(800, 7);
            this.labelF1Password.Name = "labelF1Password";
            this.labelF1Password.Size = new System.Drawing.Size(73, 20);
            this.labelF1Password.TabIndex = 32;
            this.labelF1Password.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MarketplaceApp.Properties.Resources.BackgroundClouds2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 694);
            this.Controls.Add(this.labelF1Password);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelF1Username);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelNewMember);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.textBoxLoggedInAs);
            this.Controls.Add(this.labelLoggedInAs);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.groupBoxSearchResults);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.comboBoxSearchCategory);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearchCategory);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelF1Header);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSearchResults.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelF1Header;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelSearchCategory;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSearchCategory;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.GroupBox groupBoxSearchResults;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelLoggedInAs;
        private System.Windows.Forms.TextBox textBoxLoggedInAs;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDetailsCategory;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonContactSeller;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonRemoveAD;
        private System.Windows.Forms.Button buttonUpdateAD;
        private System.Windows.Forms.Button buttonCreateAD;
        private System.Windows.Forms.Label labelNewMember;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelF1Username;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelF1Password;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox comboBoxDetailsCategory;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClearFields;
    }
}

