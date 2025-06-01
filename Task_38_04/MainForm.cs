using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Task_38_04
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    [Serializable]
    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Group { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {MiddleName}, {Group}, {Gender}, {BirthDate:dd.MM.yyyy}";
        }
    }

    public partial class MainForm : Form
    {
        private List<Student> students = new List<Student>();
        private const string DataFileName = "students.dat";

        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private TextBox middleNameTextBox;
        private TextBox groupTextBox;
        private ComboBox genderComboBox;
        private DateTimePicker birthDatePicker;
        private Button saveButton;
        private ListBox studentsListBox;

        public MainForm()
        {
            InitializeCustomComponents();
            LoadData();
            UpdateListBox();
        }

        private void InitializeCustomComponents()
        {
            // Настройка основной формы
            this.Text = "Информация о студентах";
            this.Size = new System.Drawing.Size(650, 400);
            this.FormClosing += MainForm_FormClosing;

            // Создание и настройка элементов управления
            lastNameTextBox = new TextBox { Location = new System.Drawing.Point(10, 30), Width = 200 };
            firstNameTextBox = new TextBox { Location = new System.Drawing.Point(10, 80), Width = 200 };
            middleNameTextBox = new TextBox { Location = new System.Drawing.Point(10, 130), Width = 200 };
            groupTextBox = new TextBox { Location = new System.Drawing.Point(10, 180), Width = 200 };
            genderComboBox = new ComboBox { Location = new System.Drawing.Point(10, 230), Width = 200 };
            birthDatePicker = new DateTimePicker { Location = new System.Drawing.Point(10, 280), Width = 200 };
            saveButton = new Button { Text = "Сохранить", Location = new System.Drawing.Point(10, 320), Width = 200 };
            studentsListBox = new ListBox { Dock = DockStyle.Fill };

            // Настройка ComboBox
            genderComboBox.Items.AddRange(new object[] { "Мужской", "Женский", "Другой" });
            genderComboBox.SelectedIndex = 0;

            // Подписка на события
            saveButton.Click += SaveButton_Click;

            // Создание панелей
            var inputPanel = new Panel { Dock = DockStyle.Left, Width = 250, Padding = new Padding(10) };
            var listPanel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(10) };

            // Добавление элементов на панель ввода
            inputPanel.Controls.Add(new Label { Text = "Фамилия:", Location = new System.Drawing.Point(10, 10) });
            inputPanel.Controls.Add(lastNameTextBox);
            inputPanel.Controls.Add(new Label { Text = "Имя:", Location = new System.Drawing.Point(10, 60) });
            inputPanel.Controls.Add(firstNameTextBox);
            inputPanel.Controls.Add(new Label { Text = "Отчество:", Location = new System.Drawing.Point(10, 110) });
            inputPanel.Controls.Add(middleNameTextBox);
            inputPanel.Controls.Add(new Label { Text = "Группа:", Location = new System.Drawing.Point(10, 160) });
            inputPanel.Controls.Add(groupTextBox);
            inputPanel.Controls.Add(new Label { Text = "Пол:", Location = new System.Drawing.Point(10, 210) });
            inputPanel.Controls.Add(genderComboBox);
            inputPanel.Controls.Add(new Label { Text = "Дата рождения:", Location = new System.Drawing.Point(10, 260) });
            inputPanel.Controls.Add(birthDatePicker);
            inputPanel.Controls.Add(saveButton);

            // Настройка панели списка
            listPanel.Controls.Add(new Label { Text = "Список студентов:", Dock = DockStyle.Top });
            listPanel.Controls.Add(studentsListBox);

            // Добавление панелей на форму
            this.Controls.Add(listPanel);
            this.Controls.Add(inputPanel);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(groupTextBox.Text))
            {
                MessageBox.Show("Заполните обязательные поля (Фамилия, Имя, Группа)");
                return;
            }

            var student = new Student
            {
                LastName = lastNameTextBox.Text,
                FirstName = firstNameTextBox.Text,
                MiddleName = middleNameTextBox.Text,
                Group = groupTextBox.Text,
                Gender = (Gender)genderComboBox.SelectedIndex,
                BirthDate = birthDatePicker.Value
            };

            students.Add(student);
            UpdateListBox();
            ClearInputFields();
        }

        private void UpdateListBox()
        {
            studentsListBox.DataSource = null;
            studentsListBox.DataSource = students;
        }

        private void ClearInputFields()
        {
            lastNameTextBox.Text = "";
            firstNameTextBox.Text = "";
            middleNameTextBox.Text = "";
            groupTextBox.Text = "";
            genderComboBox.SelectedIndex = 0;
            birthDatePicker.Value = DateTime.Now;
        }

        private void LoadData()
        {
            if (File.Exists(DataFileName))
            {
                try
                {
                    using (FileStream fs = new FileStream(DataFileName, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        students = (List<Student>)formatter.Deserialize(fs);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
                }
            }
        }

        private void SaveData()
        {
            try
            {
                using (FileStream fs = new FileStream(DataFileName, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, students);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }
    }
}