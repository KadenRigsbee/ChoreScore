namespace ChoreScore.Controllers;

[ApiController]
[Route("api/chores")]
public class ChoreController : ControllerBase
{
  private readonly ChoreService choreService;
  public ChoreController(ChoreService choreService)
  {
    this.choreService = choreService;
  }

[HttpPost]
public ActionResult<Chore> CreateChore([FromBody] Chore choreData){
  try{
    Chore chore = choreService.CreateChore(choreData);
    return Ok(chore);
  }
  catch (Exception error)
  {
    return BadRequest(error.Message);
  }
}

[HttpGet("{choreId}")]
public ActionResult<Chore> GetById(string choreId){
  try
  {
    Chore chore = choreService.GetById(choreId);
    return Ok(chore);
  }
catch (Exception error)
  {
    return BadRequest(error.Message);
  }
}

  [HttpGet]
  public ActionResult<List<Chore>> GetChores(){
  try
  {
  List<Chore> chores = choreService.GetChores();
  return Ok(chores);
  }
  catch (Exception error)
  {
    return BadRequest(error.Message);
  }
}

[HttpDelete("{choreId}")]
public ActionResult<string> RemoveChore(string choreId){
  try
  {
    string message = choreService.RemoveChore(choreId);
    return Ok(message);
  }
  catch (Exception error)
  {
    return BadRequest(error.Message);
  }
}
}
