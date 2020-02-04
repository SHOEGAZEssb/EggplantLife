using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChangeOnClick : MonoBehaviour
{
  public float SizeChange = 0.01f;

  private void OnMouseDown()
  {
    transform.localScale = new Vector3(transform.localScale.x - SizeChange,
                                       transform.localScale.y - SizeChange,
                                       transform.localScale.z);
  }

  private void OnMouseUp()
  {
    transform.localScale = new Vector3(transform.localScale.x + SizeChange,
                                       transform.localScale.y + SizeChange,
                                       transform.localScale.z);
  }
}
