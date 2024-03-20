namespace HotelManagementSystem
{
    partial class ViewBooking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.canccelbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.enddaytxt = new System.Windows.Forms.DateTimePicker();
            this.startdaytxt = new System.Windows.Forms.DateTimePicker();
            this.conditiontxt = new System.Windows.Forms.TextBox();
            this.roomnotxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customeridtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bookingnumbertxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 193);
            this.panel1.TabIndex = 27;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Red;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseBtn.Location = new System.Drawing.Point(1280, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(46, 36);
            this.CloseBtn.TabIndex = 22;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(426, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 83);
            this.label1.TabIndex = 13;
            this.label1.Text = "View Booking";
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchbtn.Location = new System.Drawing.Point(653, 240);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(139, 40);
            this.searchbtn.TabIndex = 30;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            // 
            // searchtxt
            // 
            this.searchtxt.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchtxt.Location = new System.Drawing.Point(288, 243);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(325, 36);
            this.searchtxt.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 30);
            this.label2.TabIndex = 28;
            this.label2.Text = "Booking Number";
            // 
            // canccelbtn
            // 
            this.canccelbtn.BackColor = System.Drawing.Color.ForestGreen;
            this.canccelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.canccelbtn.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.canccelbtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.canccelbtn.Location = new System.Drawing.Point(328, 492);
            this.canccelbtn.Name = "canccelbtn";
            this.canccelbtn.Size = new System.Drawing.Size(107, 47);
            this.canccelbtn.TabIndex = 80;
            this.canccelbtn.Text = "Cancel";
            this.canccelbtn.UseVisualStyleBackColor = false;
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.ForestGreen;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deletebtn.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletebtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.deletebtn.Location = new System.Drawing.Point(183, 492);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(113, 47);
            this.deletebtn.TabIndex = 79;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.ForestGreen;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updatebtn.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updatebtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.updatebtn.Location = new System.Drawing.Point(37, 492);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(111, 47);
            this.updatebtn.TabIndex = 67;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.enddaytxt);
            this.panel2.Controls.Add(this.startdaytxt);
            this.panel2.Controls.Add(this.conditiontxt);
            this.panel2.Controls.Add(this.canccelbtn);
            this.panel2.Controls.Add(this.roomnotxt);
            this.panel2.Controls.Add(this.deletebtn);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.updatebtn);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.customeridtxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.bookingnumbertxt);
            this.panel2.Location = new System.Drawing.Point(867, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 593);
            this.panel2.TabIndex = 31;
            // 
            // enddaytxt
            // 
            this.enddaytxt.Location = new System.Drawing.Point(194, 185);
            this.enddaytxt.Name = "enddaytxt";
            this.enddaytxt.Size = new System.Drawing.Size(240, 27);
            this.enddaytxt.TabIndex = 82;
            // 
            // startdaytxt
            // 
            this.startdaytxt.Location = new System.Drawing.Point(195, 122);
            this.startdaytxt.Name = "startdaytxt";
            this.startdaytxt.Size = new System.Drawing.Size(240, 27);
            this.startdaytxt.TabIndex = 81;
            // 
            // conditiontxt
            // 
            this.conditiontxt.BackColor = System.Drawing.Color.White;
            this.conditiontxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conditiontxt.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conditiontxt.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.conditiontxt.Location = new System.Drawing.Point(194, 325);
            this.conditiontxt.Name = "conditiontxt";
            this.conditiontxt.Size = new System.Drawing.Size(243, 25);
            this.conditiontxt.TabIndex = 78;
            // 
            // roomnotxt
            // 
            this.roomnotxt.BackColor = System.Drawing.Color.White;
            this.roomnotxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomnotxt.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomnotxt.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.roomnotxt.Location = new System.Drawing.Point(195, 250);
            this.roomnotxt.Name = "roomnotxt";
            this.roomnotxt.Size = new System.Drawing.Size(243, 25);
            this.roomnotxt.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(3, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 25);
            this.label12.TabIndex = 77;
            this.label12.Text = "Room Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(3, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 25);
            this.label11.TabIndex = 76;
            this.label11.Text = "Customer ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(3, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 25);
            this.label6.TabIndex = 67;
            this.label6.Text = "Booking Number";
            // 
            // customeridtxt
            // 
            this.customeridtxt.BackColor = System.Drawing.Color.White;
            this.customeridtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customeridtxt.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customeridtxt.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.customeridtxt.Location = new System.Drawing.Point(194, 398);
            this.customeridtxt.Name = "customeridtxt";
            this.customeridtxt.Size = new System.Drawing.Size(241, 25);
            this.customeridtxt.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 68;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(3, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 69;
            this.label4.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(3, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 70;
            this.label5.Text = "Condition";
            // 
            // bookingnumbertxt
            // 
            this.bookingnumbertxt.BackColor = System.Drawing.Color.White;
            this.bookingnumbertxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookingnumbertxt.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookingnumbertxt.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.bookingnumbertxt.Location = new System.Drawing.Point(194, 61);
            this.bookingnumbertxt.Name = "bookingnumbertxt";
            this.bookingnumbertxt.Size = new System.Drawing.Size(244, 25);
            this.bookingnumbertxt.TabIndex = 71;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 337);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(868, 520);
            this.dataGridView1.TabIndex = 32;
            // 
            // ViewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1323, 861);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBooking";
            this.Text = "ViewBooking";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button CloseBtn;
        private Label label1;
        private Button searchbtn;
        private TextBox searchtxt;
        private Label label2;
        private Button canccelbtn;
        private Button deletebtn;
        private Button updatebtn;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DateTimePicker enddaytxt;
        private DateTimePicker startdaytxt;
        private TextBox conditiontxt;
        private TextBox roomnotxt;
        private Label label12;
        private Label label11;
        private Label label6;
        private TextBox customeridtxt;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox bookingnumbertxt;
    }
}