using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class puantablosu : MonoBehaviour
{
    public Text tak�m1skoru, tak�m2skoru; 
    void Start()
    {
        tak�m1skoru.text = "" + PlayerPrefs.GetInt("skor1");
        tak�m2skoru.text = "" + PlayerPrefs.GetInt("skor2");
    }

  public void tekrarOyna()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(1);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
