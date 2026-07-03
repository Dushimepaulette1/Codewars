public static class Kata
{
  public static int Solution(int value)
  {
    int sum = 0;
    if (value < 0)
      {
      return 0;
    }
    for(int num = 1; num < value; num++ )
      {
      if(num % 3 == 0 || num % 5 == 0)
      {
          sum = sum + num;
      }
    }
    return sum;
  }
}