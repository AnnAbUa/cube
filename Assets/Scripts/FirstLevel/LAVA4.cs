﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LAVA4 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
      if(other.tag == "Respawn")
      {
        SceneManager.LoadScene(5);
      }
    }
}
