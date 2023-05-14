using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{

    public static int CoinCount;
    public Text CoinText;

    void Start()
    {
      CoinText = GetComponent<Text>();
    }

    void Update()
   {
      CoinText.text = "" + CoinCount;
   }
}
