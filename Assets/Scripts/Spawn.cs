using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Sprite PinkSkin, BlueSkin, PurpleSkin, AlienSkin;

    private SpriteRenderer mainSprite;

    private readonly string charSelected = "charSelected";

    public void Awake()
    {
      mainSprite = this.GetComponent<SpriteRenderer>();
    }

    void Start()
    {
      int getChar;

      getChar = PlayerPrefs.GetInt(charSelected);

      switch (getChar)
      {
        case 1:
          mainSprite.sprite = BlueSkin;
          break;
        case 2:
          mainSprite.sprite = PurpleSkin;
          break;
        case 3:
          mainSprite.sprite = PinkSkin;
          break;
        default:
          mainSprite.sprite = PinkSkin;
          break;
      }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
