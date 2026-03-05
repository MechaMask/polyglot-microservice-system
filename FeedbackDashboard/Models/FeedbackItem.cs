namespace FeedbackDashboard.Models;

public class FeedbackItem
{
    public int Id { get; set; }
    public string User { get; set; }
    public string Message { get; set; }
    public DateTime Timestamp { get; set; }
    public bool IsUrgent => Message.Contains("error", StringComparison.OrdinalIgnoreCase) ||
                            Message.Contains("help", StringComparison.OrdinalIgnoreCase);
}