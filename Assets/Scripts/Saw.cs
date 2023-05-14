using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
  public float speed = 0.04f;

	void Update ()
  {
	  transform.Rotate (new Vector3 (0f, 0f, speed * Time.deltaTime));
  }
}
