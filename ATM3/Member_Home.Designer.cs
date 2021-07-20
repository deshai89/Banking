
namespace ATM3
{
    partial class Member_Home
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
            this.components = new System.ComponentModel.Container();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.availablefundsLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Account_summary = new System.Windows.Forms.TabPage();
            this.summaryListView = new System.Windows.Forms.ListView();
            this.k = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Transaction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Withdraw = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.errorText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.withdrawText = new System.Windows.Forms.TextBox();
            this.Deposit = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.depositTextbox = new System.Windows.Forms.TextBox();
            this.summaryListbox = new System.Windows.Forms.ListBox();
            this.lastloginLabel = new System.Windows.Forms.Label();
            this.newest_Members_DataDataSet = new ATM3.Newest_Members_DataDataSet();
            this.memberLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberLogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.members_DataDataSet = new ATM3.Members_DataDataSet();
            this.membersLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.members_LogTableAdapter = new ATM3.Members_DataDataSetTableAdapters.Members_LogTableAdapter();
            this.tabControl1.SuspendLayout();
            this.Account_summary.SuspendLayout();
            this.Withdraw.SuspendLayout();
            this.Deposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newest_Members_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberLogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.members_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(193, 82);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(115, 29);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 637);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Withdraw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(337, 621);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(207, 66);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // availablefundsLabel
            // 
            this.availablefundsLabel.AutoSize = true;
            this.availablefundsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.availablefundsLabel.Location = new System.Drawing.Point(1259, 101);
            this.availablefundsLabel.Name = "availablefundsLabel";
            this.availablefundsLabel.Size = new System.Drawing.Size(79, 29);
            this.availablefundsLabel.TabIndex = 3;
            this.availablefundsLabel.Text = "label2";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Account_summary);
            this.tabControl1.Controls.Add(this.Withdraw);
            this.tabControl1.Controls.Add(this.Deposit);
            this.tabControl1.Location = new System.Drawing.Point(243, 132);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1118, 1118);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // Account_summary
            // 
            this.Account_summary.Controls.Add(this.summaryListView);
            this.Account_summary.Location = new System.Drawing.Point(10, 47);
            this.Account_summary.Name = "Account_summary";
            this.Account_summary.Padding = new System.Windows.Forms.Padding(3);
            this.Account_summary.Size = new System.Drawing.Size(1098, 1061);
            this.Account_summary.TabIndex = 2;
            this.Account_summary.Text = "Summary";
            this.Account_summary.UseVisualStyleBackColor = true;
            // 
            // summaryListView
            // 
            this.summaryListView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.summaryListView.AllowColumnReorder = true;
            this.summaryListView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.summaryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.k,
            this.Transaction,
            this.Date});
            this.summaryListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryListView.FullRowSelect = true;
            this.summaryListView.HideSelection = false;
            this.summaryListView.Location = new System.Drawing.Point(56, 45);
            this.summaryListView.Name = "summaryListView";
            this.summaryListView.Size = new System.Drawing.Size(993, 1000);
            this.summaryListView.TabIndex = 7;
            this.summaryListView.UseCompatibleStateImageBehavior = false;
            this.summaryListView.View = System.Windows.Forms.View.Details;
            // 
            // k
            // 
            this.k.Text = "";
            this.k.Width = 1;
            // 
            // Transaction
            // 
            this.Transaction.Text = "Transaction";
            this.Transaction.Width = 250;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 100;
            // 
            // Withdraw
            // 
            this.Withdraw.Controls.Add(this.label4);
            this.Withdraw.Controls.Add(this.errorText);
            this.Withdraw.Controls.Add(this.label3);
            this.Withdraw.Controls.Add(this.withdrawText);
            this.Withdraw.Controls.Add(this.button1);
            this.Withdraw.Location = new System.Drawing.Point(10, 47);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Padding = new System.Windows.Forms.Padding(3);
            this.Withdraw.Size = new System.Drawing.Size(1098, 1061);
            this.Withdraw.TabIndex = 0;
            this.Withdraw.Text = "Withdraw";
            this.Withdraw.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 55);
            this.label4.TabIndex = 5;
            this.label4.Text = "$";
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Location = new System.Drawing.Point(276, 237);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(0, 29);
            this.errorText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(425, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "How much would you like to withdraw?";
            // 
            // withdrawText
            // 
            this.withdrawText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawText.Location = new System.Drawing.Point(281, 382);
            this.withdrawText.Name = "withdrawText";
            this.withdrawText.Size = new System.Drawing.Size(287, 62);
            this.withdrawText.TabIndex = 2;
            this.withdrawText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbersonly_keypress);
            // 
            // Deposit
            // 
            this.Deposit.Controls.Add(this.label2);
            this.Deposit.Controls.Add(this.label1);
            this.Deposit.Controls.Add(this.depositTextbox);
            this.Deposit.Controls.Add(this.depositButton);
            this.Deposit.Location = new System.Drawing.Point(10, 47);
            this.Deposit.Name = "Deposit";
            this.Deposit.Padding = new System.Windows.Forms.Padding(3);
            this.Deposit.Size = new System.Drawing.Size(1098, 1061);
            this.Deposit.TabIndex = 1;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 55);
            this.label2.TabIndex = 6;
            this.label2.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "How much would you like to deposit?";
            // 
            // depositTextbox
            // 
            this.depositTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositTextbox.Location = new System.Drawing.Point(339, 309);
            this.depositTextbox.Name = "depositTextbox";
            this.depositTextbox.Size = new System.Drawing.Size(191, 62);
            this.depositTextbox.TabIndex = 3;
            this.depositTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbersonly_keypress);
            // 
            // summaryListbox
            // 
            this.summaryListbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.summaryListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryListbox.FormattingEnabled = true;
            this.summaryListbox.ItemHeight = 48;
            this.summaryListbox.Location = new System.Drawing.Point(1626, 189);
            this.summaryListbox.Name = "summaryListbox";
            this.summaryListbox.Size = new System.Drawing.Size(82, 100);
            this.summaryListbox.TabIndex = 0;
            // 
            // lastloginLabel
            // 
            this.lastloginLabel.AutoSize = true;
            this.lastloginLabel.Location = new System.Drawing.Point(1367, 1086);
            this.lastloginLabel.Name = "lastloginLabel";
            this.lastloginLabel.Size = new System.Drawing.Size(123, 29);
            this.lastloginLabel.TabIndex = 6;
            this.lastloginLabel.Text = "Last Login";
            // 
            // newest_Members_DataDataSet
            // 
            this.newest_Members_DataDataSet.DataSetName = "Newest_Members_DataDataSet";
            this.newest_Members_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberLogBindingSource
            // 
            this.memberLogBindingSource.DataMember = "Member_Log";
            this.memberLogBindingSource.DataSource = this.newest_Members_DataDataSet;
            // 
            // memberLogBindingSource1
            // 
            this.memberLogBindingSource1.DataMember = "Member_Log";
            this.memberLogBindingSource1.DataSource = this.newest_Members_DataDataSet;
            // 
            // members_DataDataSet
            // 
            this.members_DataDataSet.DataSetName = "Members_DataDataSet";
            this.members_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membersLogBindingSource
            // 
            this.membersLogBindingSource.DataMember = "Members_Log";
            this.membersLogBindingSource.DataSource = this.members_DataDataSet;
            // 
            // members_LogTableAdapter
            // 
            this.members_LogTableAdapter.ClearBeforeFill = true;
            // 
            // Member_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1829, 1406);
            this.Controls.Add(this.lastloginLabel);
            this.Controls.Add(this.summaryListbox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.availablefundsLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Member_Home";
            this.Text = "Member_Home";
            this.Load += new System.EventHandler(this.Member_Home_Load);
            this.tabControl1.ResumeLayout(false);
            this.Account_summary.ResumeLayout(false);
            this.Withdraw.ResumeLayout(false);
            this.Withdraw.PerformLayout();
            this.Deposit.ResumeLayout(false);
            this.Deposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newest_Members_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberLogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.members_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersLogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Label availablefundsLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Withdraw;
        private System.Windows.Forms.TabPage Deposit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox withdrawText;
        private System.Windows.Forms.TabPage Account_summary;
        private System.Windows.Forms.ListBox summaryListbox;
        private System.Windows.Forms.Label lastloginLabel;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource memberLogBindingSource;
        private Newest_Members_DataDataSet newest_Members_DataDataSet;
        private System.Windows.Forms.BindingSource memberLogBindingSource1;
        private Members_DataDataSet members_DataDataSet;
        private System.Windows.Forms.BindingSource membersLogBindingSource;
        private Members_DataDataSetTableAdapters.Members_LogTableAdapter members_LogTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox depositTextbox;
        private System.Windows.Forms.ListView summaryListView;
        private System.Windows.Forms.ColumnHeader k;
        private System.Windows.Forms.ColumnHeader Transaction;
        private System.Windows.Forms.ColumnHeader Date;
    }
}