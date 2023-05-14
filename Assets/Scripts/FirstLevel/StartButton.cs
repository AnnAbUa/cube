using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void SceneChanger()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SceneChanger2()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void SceneChanger3()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void SceneChanger4()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void SceneChanger5()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }

    public void SceneChanger6()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }

      public void Return()
      {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
      }

      public void Return1()
      {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
      }

      public void Return2()
      {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
      }

      public void Return4()
      {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
      }
      public void Return5()
      {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
      }


    public void ExitGame()
    {
      Debug.Log("GameOver");
      Application.Quit();
    }
}
