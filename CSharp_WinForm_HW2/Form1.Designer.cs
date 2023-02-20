namespace CSharp_WinForm_HW2
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.Save_Btn = new System.Windows.Forms.Button();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.Anket_L = new System.Windows.Forms.GroupBox();
            this.Gender_L = new System.Windows.Forms.Label();
            this.Date_L = new System.Windows.Forms.Label();
            this.Phone_L = new System.Windows.Forms.Label();
            this.City_L = new System.Windows.Forms.Label();
            this.Country_L = new System.Windows.Forms.Label();
            this.Name_L = new System.Windows.Forms.Label();
            this.Surname_L = new System.Windows.Forms.Label();
            this.FatherName_L = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.CountryBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.FatherNameBox = new System.Windows.Forms.TextBox();
            this.WomenRadio = new System.Windows.Forms.RadioButton();
            this.MenRadio = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Load_btn = new System.Windows.Forms.Button();
            this.SearchNameBox = new System.Windows.Forms.TextBox();
            this.Anket_L.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save_Btn
            // 
            this.Save_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Save_Btn.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Save_Btn.Location = new System.Drawing.Point(12, 461);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(350, 30);
            this.Save_Btn.TabIndex = 0;
            this.Save_Btn.Text = "SAVE";
            this.Save_Btn.UseVisualStyleBackColor = false;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(188, 194);
            // 
            // Anket_L
            // 
            this.Anket_L.Controls.Add(this.Gender_L);
            this.Anket_L.Controls.Add(this.Date_L);
            this.Anket_L.Controls.Add(this.Phone_L);
            this.Anket_L.Controls.Add(this.City_L);
            this.Anket_L.Controls.Add(this.Country_L);
            this.Anket_L.Controls.Add(this.Name_L);
            this.Anket_L.Controls.Add(this.Surname_L);
            this.Anket_L.Controls.Add(this.FatherName_L);
            this.Anket_L.Controls.Add(this.PhoneBox);
            this.Anket_L.Controls.Add(this.CityBox);
            this.Anket_L.Controls.Add(this.CountryBox);
            this.Anket_L.Controls.Add(this.NameBox);
            this.Anket_L.Controls.Add(this.SurnameBox);
            this.Anket_L.Controls.Add(this.FatherNameBox);
            this.Anket_L.Controls.Add(this.WomenRadio);
            this.Anket_L.Controls.Add(this.MenRadio);
            this.Anket_L.Controls.Add(this.dateTimePicker1);
            this.Anket_L.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Anket_L.Location = new System.Drawing.Point(12, 45);
            this.Anket_L.Name = "Anket_L";
            this.Anket_L.Size = new System.Drawing.Size(350, 400);
            this.Anket_L.TabIndex = 1;
            this.Anket_L.TabStop = false;
            this.Anket_L.Text = "Anket";
            // 
            // Gender_L
            // 
            this.Gender_L.AutoSize = true;
            this.Gender_L.Location = new System.Drawing.Point(6, 370);
            this.Gender_L.Name = "Gender_L";
            this.Gender_L.Size = new System.Drawing.Size(69, 20);
            this.Gender_L.TabIndex = 17;
            this.Gender_L.Text = "Gender";
            // 
            // Date_L
            // 
            this.Date_L.AutoSize = true;
            this.Date_L.Location = new System.Drawing.Point(6, 312);
            this.Date_L.Name = "Date_L";
            this.Date_L.Size = new System.Drawing.Size(49, 20);
            this.Date_L.TabIndex = 16;
            this.Date_L.Text = "Date";
            // 
            // Phone_L
            // 
            this.Phone_L.AutoSize = true;
            this.Phone_L.Location = new System.Drawing.Point(6, 248);
            this.Phone_L.Name = "Phone_L";
            this.Phone_L.Size = new System.Drawing.Size(59, 20);
            this.Phone_L.TabIndex = 15;
            this.Phone_L.Text = "Phone";
            // 
            // City_L
            // 
            this.City_L.AutoSize = true;
            this.City_L.Location = new System.Drawing.Point(6, 214);
            this.City_L.Name = "City_L";
            this.City_L.Size = new System.Drawing.Size(49, 20);
            this.City_L.TabIndex = 14;
            this.City_L.Text = "City";
            // 
            // Country_L
            // 
            this.Country_L.AutoSize = true;
            this.Country_L.Location = new System.Drawing.Point(6, 180);
            this.Country_L.Name = "Country_L";
            this.Country_L.Size = new System.Drawing.Size(79, 20);
            this.Country_L.TabIndex = 13;
            this.Country_L.Text = "Country";
            // 
            // Name_L
            // 
            this.Name_L.AutoSize = true;
            this.Name_L.Location = new System.Drawing.Point(6, 108);
            this.Name_L.Name = "Name_L";
            this.Name_L.Size = new System.Drawing.Size(49, 20);
            this.Name_L.TabIndex = 12;
            this.Name_L.Text = "Name";
            // 
            // Surname_L
            // 
            this.Surname_L.AutoSize = true;
            this.Surname_L.Location = new System.Drawing.Point(6, 79);
            this.Surname_L.Name = "Surname_L";
            this.Surname_L.Size = new System.Drawing.Size(79, 20);
            this.Surname_L.TabIndex = 11;
            this.Surname_L.Text = "Surname";
            // 
            // FatherName_L
            // 
            this.FatherName_L.AutoSize = true;
            this.FatherName_L.Location = new System.Drawing.Point(6, 45);
            this.FatherName_L.Name = "FatherName_L";
            this.FatherName_L.Size = new System.Drawing.Size(119, 20);
            this.FatherName_L.TabIndex = 10;
            this.FatherName_L.Text = "Father name";
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(133, 240);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(161, 28);
            this.PhoneBox.TabIndex = 9;
            this.PhoneBox.TextChanged += new System.EventHandler(this.PhoneBox_TextChanged);
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(133, 206);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(161, 28);
            this.CityBox.TabIndex = 8;
            this.CityBox.TextChanged += new System.EventHandler(this.CityBox_TextChanged);
            // 
            // CountryBox
            // 
            this.CountryBox.Location = new System.Drawing.Point(133, 172);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(161, 28);
            this.CountryBox.TabIndex = 7;
            this.CountryBox.TextChanged += new System.EventHandler(this.CountryBox_TextChanged);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(133, 105);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(161, 28);
            this.NameBox.TabIndex = 6;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(133, 71);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(161, 28);
            this.SurnameBox.TabIndex = 5;
            this.SurnameBox.TextChanged += new System.EventHandler(this.SurnameBox_TextChanged);
            // 
            // FatherNameBox
            // 
            this.FatherNameBox.Location = new System.Drawing.Point(133, 37);
            this.FatherNameBox.Name = "FatherNameBox";
            this.FatherNameBox.Size = new System.Drawing.Size(161, 28);
            this.FatherNameBox.TabIndex = 3;
            this.FatherNameBox.TextChanged += new System.EventHandler(this.FatherNameBox_TextChanged_1);
            // 
            // WomenRadio
            // 
            this.WomenRadio.AutoSize = true;
            this.WomenRadio.Location = new System.Drawing.Point(214, 366);
            this.WomenRadio.Name = "WomenRadio";
            this.WomenRadio.Size = new System.Drawing.Size(80, 24);
            this.WomenRadio.TabIndex = 2;
            this.WomenRadio.TabStop = true;
            this.WomenRadio.Text = "Women";
            this.WomenRadio.UseVisualStyleBackColor = true;
            this.WomenRadio.CheckedChanged += new System.EventHandler(this.WomenRadio_CheckedChanged);
            // 
            // MenRadio
            // 
            this.MenRadio.AutoSize = true;
            this.MenRadio.Location = new System.Drawing.Point(101, 366);
            this.MenRadio.Name = "MenRadio";
            this.MenRadio.Size = new System.Drawing.Size(60, 24);
            this.MenRadio.TabIndex = 1;
            this.MenRadio.TabStop = true;
            this.MenRadio.Text = "Men";
            this.MenRadio.UseVisualStyleBackColor = true;
            this.MenRadio.CheckedChanged += new System.EventHandler(this.MenRadio_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 306);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 28);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // Load_btn
            // 
            this.Load_btn.Font = new System.Drawing.Font("Unispace", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Load_btn.Location = new System.Drawing.Point(244, 12);
            this.Load_btn.Name = "Load_btn";
            this.Load_btn.Size = new System.Drawing.Size(95, 30);
            this.Load_btn.TabIndex = 10;
            this.Load_btn.Text = "Load";
            this.Load_btn.UseVisualStyleBackColor = true;
            this.Load_btn.Click += new System.EventHandler(this.Load_btn_Click);
            // 
            // SearchNameBox
            // 
            this.SearchNameBox.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchNameBox.Location = new System.Drawing.Point(113, 12);
            this.SearchNameBox.Name = "SearchNameBox";
            this.SearchNameBox.Size = new System.Drawing.Size(125, 31);
            this.SearchNameBox.TabIndex = 11;
            this.SearchNameBox.TextChanged += new System.EventHandler(this.SearchNameBox_TextChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(372, 503);
            this.Controls.Add(this.SearchNameBox);
            this.Controls.Add(this.Load_btn);
            this.Controls.Add(this.Anket_L);
            this.Controls.Add(this.Save_Btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 550);
            this.MinimumSize = new System.Drawing.Size(390, 500);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Anket_L.ResumeLayout(false);
            this.Anket_L.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Save_Btn;
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private GroupBox Anket_L;
        private DateTimePicker dateTimePicker1;
        private RadioButton WomenRadio;
        private RadioButton MenRadio;
        private TextBox CityBox;
        private TextBox CountryBox;
        private TextBox NameBox;
        private TextBox SurnameBox;
        private TextBox FatherNameBox;
        private TextBox PhoneBox;
        private Button Load_btn;
        private TextBox SearchNameBox;
        private Label Gender_L;
        private Label Date_L;
        private Label Phone_L;
        private Label City_L;
        private Label Country_L;
        private Label Name_L;
        private Label Surname_L;
        private Label FatherName_L;
    }
}