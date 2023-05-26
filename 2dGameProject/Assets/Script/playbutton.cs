using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class playbutton : MonoBehaviour
{
   
    void Start()
    {
        PlayerPrefs.DeleteAll();
    }

    public void play()
    {
        SceneManager.LoadScene(1);

    }

    public void BNvs()
    {
        SceneManager.LoadScene(3);
    }
   
}
