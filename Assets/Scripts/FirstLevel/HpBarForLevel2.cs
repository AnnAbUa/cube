using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HpBarForLevel2 : MonoBehaviour
{
        private float HP = 100f;
    public Image Bar;

    private void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.gameObject.tag == "Enemy")
      {
        HP -= 25;
        Bar.fillAmount = HP / 100;
      }

      if(collision.gameObject.tag == "Respawn")
      {
        HP = 0;
        Bar.fillAmount = HP / 100;
      }

      if(HP == 0)
      {
        SceneManager.LoadScene(3);
      }

    }
}

