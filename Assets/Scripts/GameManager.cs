using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  private Player _player;

  public Score PlayerScore => _player.CurrentScore;

  public event EventHandler PlayerScoreChanged;

  private void Start()
  {
    _player = new Player();
    _player.ScoreChanged += _player_ScoreChanged;
  }

  private void _player_ScoreChanged(object sender, EventArgs e)
  {
    PlayerScoreChanged?.Invoke(this, EventArgs.Empty);
  }

  public void SimulateClick()
  {
    _player.SimulateClick();
  }
}
