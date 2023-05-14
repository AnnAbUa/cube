using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PylaIzPyshki : MonoBehaviour
{
   public GameObject effect;
   
  private void OnTriggerEnter2D(Collider2D collision)
      {
        if (collision.gameObject.tag == "Finish")
        {
          Instantiate(effect, transform.position, Quaternion.identity);
        }
      }
}
