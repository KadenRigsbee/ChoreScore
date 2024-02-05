namespace ChoreScore.Repositories;

public class ChoreRepository
{
  private readonly List<Chore> FAKEDB =[
    new Chore("eat hot chip", "just one will do", false, 3),
  ];

  internal Chore CreateChore(Chore choreData)
  {
    FAKEDB.Add(choreData);
    return choreData;
  }

  internal Chore GetById(string choreId)
  {
    Chore chore = FAKEDB.Find(chore => chore.Id == choreId);
    return chore;
  }
  internal List<Chore> GetChores()
  {
    return FAKEDB;
  }

  internal void RemoveChore(string choreId)
    {
      int indexToRemove = FAKEDB.FindIndex(chore => chore.Id == choreId);
      FAKEDB.RemoveAt(indexToRemove);
    }
}

