using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManager : MonoBehaviour
{
  public Text EggplantCountText;
  private GameManager _gameManager;

  // Start is called before the first frame update
  void Start()
  {
    _gameManager = FindObjectOfType<GameManager>();
    _gameManager.PlayerScoreChanged += _gameManager_PlayerScoreChanged;
  }

  private void _gameManager_PlayerScoreChanged(object sender, System.EventArgs e)
  {
    EggplantCountText.text = _gameManager.PlayerScore.ToString();
  }

  // Update is called once per frame
  void Update()
  {

  }
}
