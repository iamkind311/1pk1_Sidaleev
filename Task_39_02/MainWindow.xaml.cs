using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace Task_39_02
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> shoppingItems = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            ShoppingListBox.ItemsSource = shoppingItems;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NewItemTextBox.Text))
            {
                shoppingItems.Add(NewItemTextBox.Text);
                NewItemTextBox.Clear();
                UpdateStatus($"Добавлено: {shoppingItems[shoppingItems.Count - 1]}");
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (ShoppingListBox.SelectedItem != null)
            {
                string removedItem = (string)ShoppingListBox.SelectedItem;
                shoppingItems.Remove(removedItem);
                UpdateStatus($"Удалено: {removedItem}");
            }
            else
            {
                MessageBox.Show("Выберите элемент для удаления", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (shoppingItems.Count == 0)
            {
                MessageBox.Show("Список покупок пуст", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                DefaultExt = ".txt",
                Title = "Сохранить список покупок"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    File.WriteAllLines(saveFileDialog.FileName, shoppingItems);
                    UpdateStatus($"Список сохранен в файл: {saveFileDialog.FileName}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                Title = "Загрузить список покупок"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    shoppingItems.Clear();
                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                            shoppingItems.Add(line);
                    }
                    UpdateStatus($"Загружено {shoppingItems.Count} элементов из файла: {openFileDialog.FileName}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void UpdateStatus(string message)
        {
            StatusTextBlock.Text = $"{DateTime.Now:T}: {message}";
        }
    }
}
