using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCharacters : MonoBehaviour
{
    private int i;
    private int currectCharacter;

    public GameObject[] AllCharacters;

    public GameObject ButtonSelectedCharacter;
    public GameObject TextSelectedCharacter;

    private void Start()
    {
      if(PlayerPrefs.HasKey("CurrectCharacter"))
      {
        i = PlayerPrefs.GetInt("CurrectCharacter");
        currectCharacter  = PlayerPrefs.GetInt("CurrectCharacter");

        ButtonSelectedCharacter.SetActive(false);
        TextSelectedCharacter.SetActive(true);
      }
      else
      {
        PlayerPrefs.SetInt("CurrectCharacter", i);
      }
      AllCharacters[i].SetActive(true);

      if(currectCharacter == i)
      {
        ButtonSelectedCharacter.SetActive(false);
        TextSelectedCharacter.SetActive(true);
      }
      else
      {
        ButtonSelectedCharacter.SetActive(true);
        TextSelectedCharacter.SetActive(false);
      }
    }
}
