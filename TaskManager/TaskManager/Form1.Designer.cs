namespace TaskManager
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
            taskListBox = new ListBox();
            groupBox1 = new GroupBox();
            isDoneCheckBox = new CheckBox();
            label4 = new Label();
            priorityComboBox = new ComboBox();
            label3 = new Label();
            dueDatePicker = new DateTimePicker();
            label2 = new Label();
            descriptionTextBox = new RichTextBox();
            label1 = new Label();
            titleTextBox = new TextBox();
            groupBox2 = new GroupBox();
            deleteButton = new Button();
            editButton = new Button();
            addButton = new Button();
            groupBox3 = new GroupBox();
            applyFilterButton = new Button();
            filterComboBox = new ComboBox();
            sortComboBox = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // taskListBox
            // 
            taskListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            taskListBox.DrawMode = DrawMode.OwnerDrawFixed;
            taskListBox.FormattingEnabled = true;
            taskListBox.Location = new Point(20, 20);
            taskListBox.Name = "taskListBox";
            taskListBox.Size = new Size(350, 508);
            taskListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(isDoneCheckBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(priorityComboBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dueDatePicker);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(descriptionTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(titleTextBox);
            groupBox1.Location = new Point(390, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 340);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Данные задачи";
            // 
            // isDoneCheckBox
            // 
            isDoneCheckBox.AutoSize = true;
            isDoneCheckBox.Location = new Point(15, 295);
            isDoneCheckBox.Name = "isDoneCheckBox";
            isDoneCheckBox.Size = new Size(131, 29);
            isDoneCheckBox.TabIndex = 7;
            isDoneCheckBox.Text = "Выполнено";
            isDoneCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 237);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 6;
            label4.Text = "Приоритет:";
            // 
            // priorityComboBox
            // 
            priorityComboBox.FormattingEnabled = true;
            priorityComboBox.Items.AddRange(new object[] { "Низкий", "Средний", "Высокий" });
            priorityComboBox.Location = new Point(180, 237);
            priorityComboBox.Name = "priorityComboBox";
            priorityComboBox.Size = new Size(150, 33);
            priorityComboBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 189);
            label3.Name = "label3";
            label3.Size = new Size(159, 25);
            label3.TabIndex = 5;
            label3.Text = "Дата выполнения:";
            // 
            // dueDatePicker
            // 
            dueDatePicker.Format = DateTimePickerFormat.Short;
            dueDatePicker.Location = new Point(180, 189);
            dueDatePicker.Name = "dueDatePicker";
            dueDatePicker.Size = new Size(150, 31);
            dueDatePicker.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 90);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 3;
            label2.Text = "Описание:";
            label2.Click += label2_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(137, 90);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(193, 80);
            descriptionTextBox.TabIndex = 2;
            descriptionTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 40);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 1;
            label1.Text = "Название:";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(137, 40);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(193, 31);
            titleTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(deleteButton);
            groupBox2.Controls.Add(editButton);
            groupBox2.Controls.Add(addButton);
            groupBox2.Location = new Point(390, 366);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(368, 166);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Действия";
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(255, 192, 192);
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Location = new Point(9, 118);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(141, 34);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            editButton.Location = new Point(9, 78);
            editButton.Name = "editButton";
            editButton.Size = new Size(141, 34);
            editButton.TabIndex = 1;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(192, 255, 192);
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Location = new Point(9, 38);
            addButton.Name = "addButton";
            addButton.Size = new Size(141, 34);
            addButton.TabIndex = 0;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(applyFilterButton);
            groupBox3.Controls.Add(filterComboBox);
            groupBox3.Controls.Add(sortComboBox);
            groupBox3.Location = new Point(20, 554);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(738, 150);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Сортировка и фильтры";
            // 
            // applyFilterButton
            // 
            applyFilterButton.Location = new Point(588, 43);
            applyFilterButton.Name = "applyFilterButton";
            applyFilterButton.Size = new Size(112, 34);
            applyFilterButton.TabIndex = 2;
            applyFilterButton.Text = "Применить";
            applyFilterButton.UseVisualStyleBackColor = true;
            // 
            // filterComboBox
            // 
            filterComboBox.FormattingEnabled = true;
            filterComboBox.Items.AddRange(new object[] { "Все", "Только невыполненные", "Только выполненные" });
            filterComboBox.Location = new Point(14, 101);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(182, 33);
            filterComboBox.TabIndex = 1;
            // 
            // sortComboBox
            // 
            sortComboBox.FormattingEnabled = true;
            sortComboBox.Items.AddRange(new object[] { "По дате", "По приоритету" });
            sortComboBox.Location = new Point(14, 43);
            sortComboBox.Name = "sortComboBox";
            sortComboBox.Size = new Size(182, 33);
            sortComboBox.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 797);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(taskListBox);
            Name = "Form1";
            Text = "TaskManager — Управление задачами";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox taskListBox;
        private GroupBox groupBox1;
        private RichTextBox descriptionTextBox;
        private Label label1;
        private TextBox titleTextBox;
        private Label label2;
        private ComboBox priorityComboBox;
        private Label label3;
        private DateTimePicker dueDatePicker;
        private CheckBox isDoneCheckBox;
        private Label label4;
        private GroupBox groupBox2;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private GroupBox groupBox3;
        private Button applyFilterButton;
        private ComboBox filterComboBox;
        private ComboBox sortComboBox;
    }
}
