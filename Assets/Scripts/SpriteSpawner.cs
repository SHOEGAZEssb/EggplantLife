using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSpawner : MonoBehaviour
{
  public GameObject Prefab;
  public float MinYVelocity = 1f;
  public float MaxYVelocity = 1f;
  public float MinXVelocity = -1f;
  public float MaxXVelocity = 1f;

  public void Spawn()
  {
    var obj = Instantiate(Prefab, transform.position, Quaternion.identity);

    var rb = obj.GetComponent<Rigidbody2D>();
    rb.velocity = new Vector2(Random.Range(MinXVelocity, MaxXVelocity),
                              Random.Range(MinYVelocity, MaxYVelocity));
  }
}
