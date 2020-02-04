using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlargeOnMouseOver : MonoBehaviour
{
  public float GrowFactor = 0.1f;

  void OnMouseEnter()
  {
    transform.localScale = new Vector3(transform.localScale.x + GrowFactor,
                                       transform.localScale.y + GrowFactor,
                                       transform.localScale.z);
  }

  void OnMouseExit()
  {
    transform.localScale = new Vector3(transform.localScale.x - GrowFactor,
                                   transform.localScale.y - GrowFactor,
                                   transform.localScale.z);
  }
}
