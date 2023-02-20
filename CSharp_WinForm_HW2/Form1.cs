using Newtonsoft.Json;
namespace CSharp_WinForm_HW2
{
    public partial class Form : System.Windows.Forms.Form
    {
        static bool count, count1, gender, result;
        string gender1;
        public Form()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            SurnameBox.Enabled = false;
            NameBox.Enabled = false;
            CountryBox.Enabled = false;
            CityBox.Enabled = false;
            PhoneBox.Enabled = false;
            dateTimePicker1.Enabled = false;
            MenRadio.Enabled = false;
            WomenRadio.Enabled = false;
            Save_Btn.Enabled = false;
            Load_btn.Enabled = false;
        }
        private bool TextBoxContainsNumber(TextBox textBox)
        {
            foreach (char c in textBox.Text)
            {
                if (!Char.IsLetter(c))
                {
                    return count = true;
                }
            }
            return count = false;
        }
        private bool IsNumeric(TextBox textBox)
        {
            foreach (char c in textBox.Text)
            {
                if (!Char.IsDigit(c))
                {
                    return count1 = true;
                }
            }
            return count1 = false;
        }
        private void FatherNameBox_TextChanged_1(object sender, EventArgs e)
        {
            TextBoxContainsNumber(FatherNameBox);
            if (FatherNameBox.Text.Length == 0 || count == true)
            {
                FatherNameBox.ForeColor = Color.Red;
                SurnameBox.Enabled = false;
            }
            else
            {
                FatherNameBox.ForeColor = Color.Green;
                SurnameBox.Enabled = true;
            }
        }
        private void SurnameBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxContainsNumber(SurnameBox);
            if (SurnameBox.Text.Length == 0 || count == true)
            {
                SurnameBox.ForeColor = Color.Red;
                NameBox.Enabled = false;
            }
            else
            {
                SurnameBox.ForeColor = Color.Green;
                NameBox.Enabled = true;
            }
        }
        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxContainsNumber(NameBox);
            if (NameBox.Text.Length == 0 || count == true)
            {
                NameBox.ForeColor = Color.Red;
                CountryBox.Enabled = false;
            }
            else
            {
                NameBox.ForeColor = Color.Green;
                CountryBox.Enabled = true;
            }
        }
        protected void CountryBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxContainsNumber(CountryBox);
            if (CountryBox.Text.Length == 0 || count == true)
            {
                CountryBox.ForeColor = Color.Red;
                CityBox.Enabled = false;
            }
            else
            {
                CountryBox.ForeColor = Color.Green;
                CityBox.Enabled = true;
            }
        }
        private void CityBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxContainsNumber(CityBox);
            if (CityBox.Text.Length == 0 || count == true)
            {
                CityBox.ForeColor = Color.Red;
                PhoneBox.Enabled = false;
            }
            else
            {
                CityBox.ForeColor = Color.Green;
                PhoneBox.Enabled = true;
            }
        }
        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {
            IsNumeric(PhoneBox);
            if (PhoneBox.Text.Length < 7 || PhoneBox.Text.Length > 15 || count1 == true)
            {
                PhoneBox.ForeColor = Color.Red;
                dateTimePicker1.Enabled = false;
                MenRadio.Enabled = false;
                WomenRadio.Enabled = false;
            }
            else
            {
                PhoneBox.ForeColor = Color.Green;
                dateTimePicker1.Enabled = true;
                MenRadio.Enabled = true;
                WomenRadio.Enabled = true;
            }
        }
        private void MenRadio_CheckedChanged(object sender, EventArgs e)
        {
            gender = true;
            Save_Btn.Enabled = true;
        }
        private void WomenRadio_CheckedChanged(object sender, EventArgs e)
        {
            gender = false;
            Save_Btn.Enabled = true;
        }
        private void Save_Btn_Click(object sender, EventArgs e)
        {
            if (gender == true)
            {
                gender1 = "Men";
            }
            else
            {
                gender1 = "Women";
            }
            if((FatherNameBox.Enabled == true && SurnameBox.Enabled == true && NameBox.Enabled == true && CountryBox.Enabled == true && CityBox.Enabled == true && PhoneBox.Enabled == true && dateTimePicker1.Enabled == true) && (MenRadio.Enabled == true || WomenRadio.Enabled == true))
            {
                DATA data = new DATA { FatherName = FatherNameBox.Text, SurName = SurnameBox.Text, Name = NameBox.Text, Country = CountryBox.Text, City = CityBox.Text, Phone = PhoneBox.Text, Gender = gender1, Date = dateTimePicker1.Text};
                string json = JsonConvert.SerializeObject(data);
                File.AppendAllText($"{NameBox.Text}.json", json);
            }
            else
            {
                MessageBox.Show("It's Empty!");
            }    
        }

        private void Load_btn_Click(object sender, EventArgs e)//?
        {
            try
            {
                if (SearchNameBox.Text != "")
                {
                    string json = File.ReadAllText($"{SearchNameBox.Text}.json");
                    DATA data = JsonConvert.DeserializeObject<DATA>(json);
                    FatherNameBox.Text = data.FatherName;
                    SurnameBox.Text = data.SurName;
                    NameBox.Text = data.Name;
                    CountryBox.Text = data.Country;
                    CityBox.Text = data.City;
                    PhoneBox.Text = data.Phone;
                    dateTimePicker1.Text = data.Date;
                    if (data.Gender == "Men")
                    {
                        MenRadio.Checked = true;
                    }
                    else
                    {
                        WomenRadio.Checked = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There is no such person!");
            }
        }
        private void SearchNameBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxContainsNumber(SearchNameBox);
            if (SearchNameBox.Text.Length == 0 || count == true)
            {
                SearchNameBox.ForeColor = Color.Red;
                Load_btn.Enabled = false;
            }
            else
            {
                SearchNameBox.ForeColor = Color.Green;
                Load_btn.Enabled = true;
            }
        }
    }
    class DATA
    {
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public string? FatherName { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Gender { get; set; }
        public string? Date { get; set; }
        public string? Phone { get; set; }
    }
}