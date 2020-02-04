using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainEggplant : MonoBehaviour
{
  public SpriteSpawner EggplantSpriteSpawner;
  private GameManager _playerManager;

  private void Start()
  {
    _playerManager = FindObjectOfType<GameManager>();
  }

  private void OnMouseDown()
  {
    _playerManager.SimulateClick();
    EggplantSpriteSpawner.Spawn();
  }

  private void OnMouseEnter()
  {
    Cursor.visible = true;
    var tex = Resources.Load<Texture2D>("Sprites/ClickCursor");
    Cursor.SetCursor(tex, new Vector2(tex.width / 2, tex.height / 2), CursorMode.Auto);
  }

  private void OnMouseExit()
  {
    Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
  }
}
