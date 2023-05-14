using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public int hp;

    public Text hpT;

    public int hpDMG;

    void Start()
    {
      hpT.text = hp.ToString();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.gameObject.tag == "Enemy")
      {
        hp = hp - hpDMG;
        hpT.text = hp.ToString();
      }
    }

}
