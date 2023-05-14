using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LAVA2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
      if(other.tag == "Respawn2")
      {
        SceneManager.LoadScene(3);
      }
    }
}
