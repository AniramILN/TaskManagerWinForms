/// Представляет задачу с названием, описанием, датой, приоритетом и статусом выполнения.
public class Task
{
    /// Уникальный идентификатор задачи.
    public int Id { get; set; }

    /// Название задачи.
    public string Title { get; set; }

    /// Описание задачи.
    public string Description { get; set; }

    /// Дата выполнения задачи.
    public DateTime DueDate { get; set; }

    /// Приоритет задачи (Low, Medium, High).
    public TaskPriority Priority { get; set; }

    /// Статус выполнения задачи.
    public bool IsDone { get; set; }

    /// Возвращает строковое представление задачи для отображения в списке.
    /// <returns>Строка вида "[✔] 1: Купить молоко (12.05.2025, High)"</returns>
    public override string ToString()
    {
        string status = IsDone ? "[✔]" : "[ ]";
        return $"{status} {Id}: {Title} ({DueDate:dd.MM.yyyy}, {Priority})";
    }
}

/// Перечисление приоритетов задачи.
public enum TaskPriority
{
    /// Высокий приоритет
    High,
    /// Средний приоритет
    Medium,
    /// Низкий приоритет
    Low
}