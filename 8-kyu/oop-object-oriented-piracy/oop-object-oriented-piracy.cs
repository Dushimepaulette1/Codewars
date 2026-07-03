public class Ship
{
  public int Draft;
  public int Crew;
  
  public Ship(int draft, int crew)
  {
    Draft = draft;
    Crew = crew;
  }
  public bool IsWorthIt()
    {
    int result = (int)(Crew*1.5);
    int weight = Draft - result;
    if(weight > 20)
      {
      return true;
    }
    return false;
    
  }
}