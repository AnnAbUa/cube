using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HpForBoss : MonoBehaviour
{
    public Image bar;
    public float fill;

    void Start()
    {
      fill = 1f;
    }

    void Update()
    {
      fill -= Time.deltaTime * 0.01f;
      bar.fillAmount = fill;

      if(fill == -0.1)
      {
        SceneManager.LoadScene(0);
      }
    }
}
