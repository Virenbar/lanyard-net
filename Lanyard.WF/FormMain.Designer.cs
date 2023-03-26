namespace Lanyard.WF
{
    partial class FormMain
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
            PG_Data = new PropertyGrid();
            TB_UserID = new TextBox();
            TB_APIKey = new TextBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            B_User = new Button();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            B_DeleteKey = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label5 = new Label();
            TB_KVValue = new TextBox();
            label6 = new Label();
            TB_KVKey = new TextBox();
            B_SetKey = new Button();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            textBox1 = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // PG_Data
            // 
            PG_Data.Dock = DockStyle.Fill;
            PG_Data.Location = new Point(333, 0);
            PG_Data.Name = "PG_Data";
            PG_Data.Size = new Size(467, 450);
            PG_Data.TabIndex = 0;
            // 
            // TB_UserID
            // 
            TB_UserID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TB_UserID.Location = new Point(56, 3);
            TB_UserID.Name = "TB_UserID";
            TB_UserID.Size = new Size(268, 23);
            TB_UserID.TabIndex = 1;
            // 
            // TB_APIKey
            // 
            TB_APIKey.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TB_APIKey.Location = new Point(56, 32);
            TB_APIKey.Name = "TB_APIKey";
            TB_APIKey.PasswordChar = '*';
            TB_APIKey.Size = new Size(268, 23);
            TB_APIKey.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(6, 7);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "User ID";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(TB_APIKey, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(TB_UserID, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(327, 58);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "API Key";
            // 
            // B_User
            // 
            B_User.AutoSize = true;
            B_User.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            B_User.Location = new Point(3, 3);
            B_User.Name = "B_User";
            B_User.Size = new Size(72, 25);
            B_User.TabIndex = 4;
            B_User.Text = "Fetch User";
            B_User.UseVisualStyleBackColor = true;
            B_User.Click += B_User_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 450);
            panel1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(B_SetKey);
            flowLayoutPanel1.Controls.Add(B_DeleteKey);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(3, 77);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(327, 31);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // B_DeleteKey
            // 
            B_DeleteKey.AutoSize = true;
            B_DeleteKey.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            B_DeleteKey.Location = new Point(63, 3);
            B_DeleteKey.Name = "B_DeleteKey";
            B_DeleteKey.Size = new Size(71, 25);
            B_DeleteKey.TabIndex = 4;
            B_DeleteKey.Text = "Delete key";
            B_DeleteKey.UseVisualStyleBackColor = true;
            B_DeleteKey.Click += B_DeleteKey_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 149);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "KV Storage";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Controls.Add(TB_KVValue, 1, 1);
            tableLayoutPanel3.Controls.Add(label6, 0, 1);
            tableLayoutPanel3.Controls.Add(TB_KVKey, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(327, 58);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(12, 7);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 2;
            label5.Text = "Key";
            // 
            // TB_KVValue
            // 
            TB_KVValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TB_KVValue.Location = new Point(44, 32);
            TB_KVValue.Name = "TB_KVValue";
            TB_KVValue.Size = new Size(280, 23);
            TB_KVValue.TabIndex = 1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 36);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 2;
            label6.Text = "Value";
            // 
            // TB_KVKey
            // 
            TB_KVKey.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TB_KVKey.Location = new Point(44, 3);
            TB_KVKey.Name = "TB_KVKey";
            TB_KVKey.Size = new Size(280, 23);
            TB_KVKey.TabIndex = 1;
            // 
            // B_SetKey
            // 
            B_SetKey.AutoSize = true;
            B_SetKey.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            B_SetKey.Location = new Point(3, 3);
            B_SetKey.Name = "B_SetKey";
            B_SetKey.Size = new Size(54, 25);
            B_SetKey.TabIndex = 4;
            B_SetKey.Text = "Set key";
            B_SetKey.UseVisualStyleBackColor = true;
            B_SetKey.Click += B_SetKey_Click;
            // 
            // groupBox2
            // 
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(flowLayoutPanel2);
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(333, 145);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lanyard";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 42);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "User ID";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(53, 46);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(144, 23);
            textBox1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(B_User);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(3, 77);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(327, 31);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PG_Data);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PropertyGrid PG_Data;
        private TextBox TB_UserID;
        private TextBox TB_APIKey;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Button B_User;
        private Panel panel1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label5;
        private TextBox TB_KVValue;
        private Label label6;
        private TextBox TB_KVKey;
        private Button B_DeleteKey;
        private Button B_SetKey;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}