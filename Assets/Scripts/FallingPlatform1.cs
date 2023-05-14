using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform1 : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      Invoke("FallPlatform", 0.1f);
    }
    void FallPlatform()
    {
      rb.isKinematic = false;
    }
}
