using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class puantablosu : MonoBehaviour
{
    public Text takým1skoru, takým2skoru; 
    void Start()
    {
        takým1skoru.text = "" + PlayerPrefs.GetInt("skor1");
        takým2skoru.text = "" + PlayerPrefs.GetInt("skor2");
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
