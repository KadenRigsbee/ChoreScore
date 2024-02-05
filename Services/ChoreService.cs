namespace ChoreScore.Services;

public class ChoreService(ChoreRepository repo){
  private readonly ChoreRepository repo = repo;

    internal Chore CreateChore(Chore choreData)
    {
      Chore chore = repo.CreateChore(choreData);
      return chore;
    }

    internal Chore GetById(string choreId)
    {
        Chore chore = repo.GetById(choreId);
        if(chore == null) throw new Exception($"bad id bro: {choreId}");
        return chore;
    }
    internal List<Chore> GetChores()
    {
        List<Chore> chores = repo.GetChores();
        return chores;
    }
    internal string RemoveChore(string choreId)
    {
      Chore choreToRemove = GetById(choreId);
      repo.RemoveChore(choreId);
      return $"{choreToRemove.ToDo} was removed.";
    }
}