using System;
using UnityEngine;

public class Player
{
  public event EventHandler ScoreChanged;

  public Score CurrentScore
  {
    get => _currentScore;
    private set
    {
      _currentScore = value;
      ScoreChanged?.Invoke(this, EventArgs.Empty);
    }
  }
  private Score _currentScore;

  public void SimulateClick()
  {
    CurrentScore += new Score() { Ones = 1 };
  }
}