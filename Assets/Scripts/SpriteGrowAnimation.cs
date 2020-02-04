using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteGrowAnimation : MonoBehaviour
{
  public float GrowFactor = 0.001f;
  public int NumGrowFrames = 100;

  // Start is called before the first frame update
  void Start()
  {

  }

  int i = 0;
  // Update is called once per frame
  void Update()
  {
    i++;
    if (i <= NumGrowFrames)
    {
      transform.localScale = new Vector3(transform.localScale.x + GrowFactor,
                                         transform.localScale.y + GrowFactor,
                                         transform.localScale.z);
    }
    else if (i <= NumGrowFrames * 2)
    {
      transform.localScale = new Vector3(transform.localScale.x - GrowFactor,
                                         transform.localScale.y - GrowFactor,
                                         transform.localScale.z);
    }
    else
      i = 0;
  }
}
