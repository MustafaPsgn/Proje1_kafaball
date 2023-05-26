using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    public Image countdown;
    public Text timerText;

    [SerializeField] private float currenTime;
    public float duration;
    void Start()
    {
        currenTime = duration;
    }

    // Update is called once per frame
    void Update()
    {
        if(currenTime > 1)
        {
            currenTime -= Time.deltaTime;
            timerText.text = ((int)currenTime).ToString();
            countdown.fillAmount = currenTime / duration;
        }
        else
        {
            SceneManager.LoadScene(2);
        }
      
    }
}
