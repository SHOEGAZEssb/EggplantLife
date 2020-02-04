using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Score
{
  public int Thousands;

  public int Hundreds
  {
    get => _hundreds;
    set
    {
      int thousands = 0;
      while (value >= 10)
      {
        value -= 10;
        thousands++;
      }

      _hundreds = value;
      if (thousands != 0)
        Thousands += thousands;
    }
  }
  private int _hundreds;

  public int Tens
  {
    get => _tens;
    set
    {
      int hundreds = 0;
      while(value >= 10)
      {
        value -= 10;
        hundreds++;
      }

      _tens = value;
      if (hundreds != 0)
        Hundreds += hundreds;
    }
  }
  private int _tens;

  public int Ones
  {
    get => _ones;
    set
    {
      int tens = 0;
      while(value >= 10)
      {
        value -= 10;
        tens++;
      }

      _ones = value;

      if(tens != 0)
        Tens += tens;
    }
  }
  private int _ones;

  public static Score operator +(Score a, Score b)
  {
    var newScore = new Score();
    newScore.Ones += a.Ones + b.Ones;
    newScore.Tens += a.Tens + b.Tens;
    newScore.Hundreds += a.Hundreds + b.Hundreds;
    newScore.Thousands += a.Thousands + b.Thousands;

    return newScore;
  }

  public override string ToString()
  {
    return string.Format("{0}{1}{2}{3}", Thousands, Hundreds, Tens, Ones);
  }
}