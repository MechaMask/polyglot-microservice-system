using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.Sqlite;
using FeedbackDashboard.Models;

namespace FeedbackDashboard.Pages;

public class IndexModel : PageModel
{
    public List<FeedbackItem> FeedbackList { get; set; } = new();

    public void OnGet()
    {
        string rootPath = Directory.GetCurrentDirectory();
        string dbPath = Path.Combine(rootPath, "feedback.db");

        using (var connection = new SqliteConnection($"Data Source={dbPath}"))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT Id, User, Message, Timestamp FROM Feedback ORDER BY Id DESC";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    FeedbackList.Add(new FeedbackItem
                    {
                        Id = reader.GetInt32(0),
                        User = reader.GetString(1),
                        Message = reader.GetString(2),
                        Timestamp = reader.GetDateTime(3)
                    });
                }
            }
        }
    }
}