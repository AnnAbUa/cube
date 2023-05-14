using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    Image timerBar;
    public float maTime = 100f;
    float timeLeft;
    public GameObject effect;

    void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = maTime;
    }

    void Update()
    {
        if(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maTime;
        }
        else
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            SceneManager.LoadScene(1);
        }
    }
}
