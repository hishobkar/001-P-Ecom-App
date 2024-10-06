namespace WinFormsCRUD_WebAPI
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
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            btnDeleteItem = new Button();
            btnEditItem = new Button();
            btnAddItem = new Button();
            btnViewList = new Button();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            button1 = new Button();
            lblHeader = new Label();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(btnDeleteItem);
            splitContainer1.Panel1.Controls.Add(btnEditItem);
            splitContainer1.Panel1.Controls.Add(btnAddItem);
            splitContainer1.Panel1.Controls.Add(btnViewList);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1561, 806);
            splitContainer1.SplitterDistance = 198;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 17);
            label1.Name = "label1";
            label1.Size = new Size(195, 33);
            label1.TabIndex = 4;
            label1.Text = "Menu Options";
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new Point(12, 167);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(228, 29);
            btnDeleteItem.TabIndex = 3;
            btnDeleteItem.Text = "Delete Selected Item";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // btnEditItem
            // 
            btnEditItem.Location = new Point(12, 132);
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new Size(228, 29);
            btnEditItem.TabIndex = 2;
            btnEditItem.Text = "Edit slected item";
            btnEditItem.UseVisualStyleBackColor = true;
            btnEditItem.Click += btnEditItem_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(12, 97);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(228, 29);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "Add Item to List";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnViewList
            // 
            btnViewList.Location = new Point(12, 62);
            btnViewList.Name = "btnViewList";
            btnViewList.Size = new Size(228, 29);
            btnViewList.TabIndex = 0;
            btnViewList.Text = "View List - Load Products";
            btnViewList.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer3);
            splitContainer2.Size = new Size(1359, 806);
            splitContainer2.SplitterDistance = 646;
            splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(button1);
            splitContainer3.Panel1.Controls.Add(lblHeader);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(listView1);
            splitContainer3.Size = new Size(1359, 646);
            splitContainer3.SplitterDistance = 107;
            splitContainer3.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(1173, 12);
            button1.Name = "button1";
            button1.Size = new Size(174, 29);
            button1.TabIndex = 5;
            button1.Text = "Checkout as Buyer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(863, 52);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Ecommerce Shopping App - Admin Screen";
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.OwnerDraw = true;
            listView1.Size = new Size(1359, 535);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1561, 806);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Ecommerce";
            WindowState = FormWindowState.Maximized;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Button btnDeleteItem;
        private Button btnEditItem;
        private Button btnAddItem;
        private Button btnViewList;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private Label lblHeader;
        private ListView listView1;
        private Button button1;
    }
}
