using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Char_select : MonoBehaviour
{
    public GameObject PinkSkin;
    public GameObject BlueSkin;
    public GameObject PurpleSkin;
    public GameObject AlienSkin;

    private Vector3 charPosition;
    private Vector3 charOutside;

    private int charInt = 1;

    private SpriteRenderer PinkRen, BlueRen, PurpleRen, AlienRen;

    private readonly string charSelected = "charSelected";

    private void Awake()
    {
      charPosition = PinkSkin.transform.position;
      charOutside = BlueSkin.transform.position;

      PinkRen = PinkSkin.GetComponent<SpriteRenderer>();
      BlueRen = BlueSkin.GetComponent<SpriteRenderer>();
      PurpleRen = PurpleSkin.GetComponent<SpriteRenderer>();
    }

    public void Next()
    {
      switch (charInt)
      {
        case 1:
          PlayerPrefs.SetInt(charSelected, 1);
          PinkRen.enabled = false;
          PinkSkin.transform.position = charOutside;
          BlueSkin.transform.position = charPosition;
          BlueRen.enabled = true;
          charInt++;
          break;
        case 2:
          PlayerPrefs.SetInt(charSelected, 2);
          BlueRen.enabled = false;
          BlueSkin.transform.position = charOutside;
          PurpleSkin.transform.position = charPosition;
          PurpleRen.enabled = true;
          charInt++;
          break;
        case 3:
          PlayerPrefs.SetInt(charSelected, 4);
          PurpleRen.enabled = false;
          BlueSkin.transform.position = charOutside;
          PurpleSkin.transform.position = charOutside;
          PinkSkin.transform.position = charPosition;
          PinkRen.enabled = true;
          charInt++;
          Loop();
          break;
        default:
          Loop();
          break;
      }
    }

    private void Loop()
    {
      if (charInt >= 4)
      {
        charInt = 1;
      }
    }

    public void Manager()
    {
      SceneManager.LoadScene(1);
    }
}
