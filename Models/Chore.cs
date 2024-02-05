namespace ChoreScore.Models;

public class Chore
{
  public string Id { get; set; }
  public string ToDo { get; set; }
  public string Description { get; set; }

  public bool IsDone { get; set; }
  public double MinutesToCompleteChore { get; set; }

  public Chore(string toDo, string description, bool isDone, double minutesToCompleteChore){
    ToDo = toDo;
    Description = description;
    IsDone = isDone;
    MinutesToCompleteChore = minutesToCompleteChore;
  }
}
