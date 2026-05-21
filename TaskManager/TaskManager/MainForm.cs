using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TaskManager
{
    /// Главная форма приложения TaskManager.
    public partial class MainForm : Form
    {
        // Хранилище всех задач
        private List<Task> tasks = new List<Task>();

        // Счётчик для генерации ID
        private int nextId = 1;

        /// Конструктор главной формы.
        public MainForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        /// Настройка формы при загрузке.
        private void InitializeForm()
        {
            // Настройка ComboBox приоритетов
            priorityComboBox.Items.Clear();
            priorityComboBox.Items.AddRange(Enum.GetNames(typeof(TaskPriority)));
            priorityComboBox.SelectedIndex = 0;

            // Подписка на событие DrawItem для цветовой индикации
            taskListBox.DrawMode = DrawMode.OwnerDrawFixed;
            taskListBox.DrawItem += TaskListBox_DrawItem;

            // Подписка на события кнопок
            addButton.Click += AddButton_Click;
            editButton.Click += EditButton_Click;
            deleteButton.Click += DeleteButton_Click;
            applyFilterButton.Click += ApplyFilterButton_Click;

            // Подписка на выбор задачи в списке
            taskListBox.SelectedIndexChanged += TaskListBox_SelectedIndexChanged;
        }

        /// Отрисовка элемента списка с цветовой индикацией просроченных задач.
        private void TaskListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= taskListBox.Items.Count) return;

            Task task = (Task)taskListBox.Items[e.Index];
            Color textColor = SystemColors.WindowText;

            // Если задача не выполнена и просрочена — красный цвет
            if (!task.IsDone && task.DueDate < DateTime.Today)
            {
                textColor = Color.Red;
            }

            e.DrawBackground();
            using (SolidBrush brush = new SolidBrush(textColor))
            {
                e.Graphics.DrawString(task.ToString(), e.Font, brush, e.Bounds);
            }
            e.DrawFocusRectangle();
        }

        /// Обновление списка задач в ListBox.
        private void RefreshTaskList()
        {
            taskListBox.Items.Clear();
            foreach (var task in tasks)
            {
                taskListBox.Items.Add(task);
            }
        }

        /// Очистка полей ввода.
        private void ClearInputFields()
        {
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            dueDatePicker.Value = DateTime.Today;
            priorityComboBox.SelectedIndex = 0;
            isDoneCheckBox.Checked = false;
        }

        /// Заполнение полей формы данными выбранной задачи.
        private void LoadTaskToForm(Task task)
        {
            if (task == null) return;
            titleTextBox.Text = task.Title;
            descriptionTextBox.Text = task.Description;
            dueDatePicker.Value = task.DueDate;
            priorityComboBox.SelectedItem = task.Priority.ToString();
            isDoneCheckBox.Checked = task.IsDone;
        }

        /// Получение задачи из данных формы.
        private Task GetTaskFromForm(int id)
        {
            return new Task
            {
                Id = id,
                Title = titleTextBox.Text,
                Description = descriptionTextBox.Text,
                DueDate = dueDatePicker.Value,
                Priority = (TaskPriority)Enum.Parse(typeof(TaskPriority), priorityComboBox.SelectedItem.ToString()),
                IsDone = isDoneCheckBox.Checked
            };
        }

        /// Проверка корректности введённых данных.
        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text))
            {
                MessageBox.Show("Введите название задачи!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// Добавление новой задачи.
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!IsInputValid()) return;

            Task newTask = GetTaskFromForm(nextId);
            tasks.Add(newTask);
            nextId++;

            RefreshTaskList();
            ClearInputFields();

            MessageBox.Show("Задача успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// Редактирование выбранной задачи.
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedItem == null)
            {
                MessageBox.Show("Не выбрана задача для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsInputValid()) return;

            Task oldTask = (Task)taskListBox.SelectedItem;
            Task updatedTask = GetTaskFromForm(oldTask.Id);

            int index = tasks.FindIndex(t => t.Id == oldTask.Id);
            if (index != -1)
            {
                tasks[index] = updatedTask;
            }

            RefreshTaskList();
            ClearInputFields();

            MessageBox.Show("Задача успешно отредактирована!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// Удаление выбранных задач.
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Не выбрана задача для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Удалить выбранные задачи ({taskListBox.SelectedItems.Count})?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var selectedTasks = taskListBox.SelectedItems.Cast<Task>().ToList();
                foreach (var task in selectedTasks)
                {
                    tasks.RemoveAll(t => t.Id == task.Id);
                }

                RefreshTaskList();
                ClearInputFields();

                MessageBox.Show("Задачи успешно удалены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// Загрузка данных выбранной задачи в поля формы.
        private void TaskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (taskListBox.SelectedItem != null)
            {
                Task selectedTask = (Task)taskListBox.SelectedItem;
                LoadTaskToForm(selectedTask);
            }
        }

        /// Применение сортировки и фильтрации.
        private void ApplyFilterButton_Click(object sender, EventArgs e)
        {
            IEnumerable<Task> filteredTasks = tasks;

            // Фильтрация
            string filter = filterComboBox.SelectedItem?.ToString();
            if (filter == "Невыполненные")
            {
                filteredTasks = filteredTasks.Where(t => !t.IsDone);
            }
            else if (filter == "Выполненные")
            {
                filteredTasks = filteredTasks.Where(t => t.IsDone);
            }

            // Сортировка
            string sort = sortComboBox.SelectedItem?.ToString();
            if (sort == "По дате")
            {
                filteredTasks = filteredTasks.OrderBy(t => t.DueDate);
            }
            else if (sort == "По приоритету")
            {
                filteredTasks = filteredTasks.OrderBy(t => t.Priority);
            }

            taskListBox.Items.Clear();
            foreach (var task in filteredTasks)
            {
                taskListBox.Items.Add(task);
            }
        }

    }
}