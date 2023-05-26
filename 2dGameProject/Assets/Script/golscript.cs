using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class golscript : MonoBehaviour
{

    
    public Transform player1spawner;
    public Transform player2spawner;
    public Transform topspawner;   
    public GameObject player1prefabs;
    public GameObject player2prefabs;
    public GameObject Topprefabs;
    public Text tak�m1skortext, tak�m2skortext;
    AudioSource audiosource;
    int tak�m1skor, tak�m2skor;

    public ParticleSystem particleSystem;
   

     void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D top)
    {
        if (top.tag == "top" && gameObject.name=="kale1" ) 
        {
            tak�m2skor++;
            tak�m2skortext.text = "" + tak�m2skor;
            PlayerPrefs.SetInt("skor2", tak�m2skor);

            Destroy(GameObject.FindGameObjectWithTag("player1"));
            Destroy(GameObject.FindGameObjectWithTag("player2"));
            Destroy(GameObject.FindGameObjectWithTag("top"));
           
            Spawner();
            audiosource.Play();

            particleSystem.Play();
            Invoke("StopParticle", 2f);


        }

       else if (top.tag == "top" && gameObject.name == "kale2")
        {
            Destroy(GameObject.FindGameObjectWithTag("player1"));
            Destroy(GameObject.FindGameObjectWithTag("player2"));
            Destroy(GameObject.FindGameObjectWithTag("top"));
            tak�m1skor++;
            tak�m1skortext.text = "" + tak�m1skor;
            //
            PlayerPrefs.SetInt("skor1", tak�m1skor);
            
            audiosource.Play();
            particleSystem.Play();
            Invoke("StopParticle", 2f);




            Spawner();
        }

       
    }
    

   
    void Spawner()
    {
        Instantiate(player1prefabs, player1spawner.position, player1spawner.rotation);
        Instantiate(player2prefabs, player2spawner.position, player2spawner.rotation);
        Instantiate(Topprefabs, topspawner.position, topspawner.rotation);
       
    }
    void StopParticle()
    {
        particleSystem.Stop();
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("kale") && gameObject.CompareTag("top"))
    //    {
    //        particleSystem.Play();
    //    }
    //}


}






























//int tak�m2puan = 0;
//int tak�m1puan = 0;
//public Text tak�m2puantext, tak�m1puantext;
//AudioSource AudioSource;

//private void OnCollisionEnter2D(Collision2D collision)
//{


//    if (collision.gameObject.name == "kale1")
//    {
//        tak�m2skor++;
//        tak�m2skortext.text = "" + tak�m2skor;
//        PlayerPrefs.SetInt("tak�m2skor", tak�m2skor);


//    }
//    if (collision.gameObject.name == "kale2")
//    {
//        tak�m1skor++;
//        tak�m1skortext.text = "" + tak�m1skor;
//        PlayerPrefs.SetInt("tak�m1puan", tak�m1skor);


//    }

//}

//////////////////////////////////////////////////// yukar�daki kodlar hocayla derste yap�lan gol kodlar�.
