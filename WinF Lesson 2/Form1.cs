using System.Diagnostics.Metrics;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinF_Lesson_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void JSONSerializeMethod(DirectoryInfo directory, Person person)
        {
            var jsonString = System.Text.Json.JsonSerializer.Serialize(person);
            File.WriteAllText($@"{directory.FullName}\{person.Name}.json", jsonString);
        }

        private Person JSONDeserializeMethod(string path)
        {

            using FileStream fs = new FileStream($"{path}", FileMode.Open);
            Person person = System.Text.Json.JsonSerializer.Deserialize<Person>(fs);
            return person;
        }

        bool isLoaded = false;
        bool isSaved = false;

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            DirectoryInfo directory = new($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\WinForm2 Persons");

            if (!directory.Exists)
            {
                MessageBox.Show("Directory Not Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                MessageBox.Show("Search place must be written !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Person person = null;


            foreach (var file in directory.GetFiles())
            {
                if (file.Name.Contains(textBoxSearch.Text))
                    person = JSONDeserializeMethod(file.FullName);
            }
            if (person != null)
            {
                textBoxSurname.Text = person.Surname;
                textBoxName.Text = person.Name;
                textBoxFather.Text = person.FatherName;
                textBoxCountry.Text = person.Country;
                textBoxCity.Text = person.City;
                textBoxPhone.Text = person.Phone;

                if (person.Gender == "Male")
                    radioButtonMale.Checked = true;
                else
                    radioButtonFemale.Checked = true;

                dateTimePicker1.Value = person.BirthDate;

                btn_save.Text = "Clear";
                isLoaded = true;
                return;
            }

            MessageBox.Show("File Not Found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (isLoaded || isSaved)
            {
                foreach (var control in groupBoxForm.Controls)
                {

                    if (control is TextBox txtBox)
                        txtBox.Clear();
                    else if (control is DateTimePicker time)
                        time.ResetText();
                    else if (control is RadioButton radioButton)
                        radioButton.Checked = false;
                }

                btn_save.Text = "Save";
                isLoaded = false;
                return;
            }

            try
            {
                string? gendetType;

                if (radioButtonMale.Checked)
                    gendetType = radioButtonMale.Text;
                else
                    gendetType = radioButtonFemale.Text;

                Person person = new(textBoxSurname.Text, textBoxName.Text, textBoxFather.Text, textBoxCountry.Text, textBoxCity.Text, textBoxPhone.Text, dateTimePicker1.Value, gendetType);




            DirectoryInfo directory = new($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\WinForm2 Persons");

            if (!directory.Exists)
                Directory.CreateDirectory(directory.FullName);



            JSONSerializeMethod(directory, person);
            isSaved = true;
            btn_save.Text = "Clear";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }






        }
    }
}