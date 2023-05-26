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
    public Text takým1skortext, takým2skortext;
    AudioSource audiosource;
    int takým1skor, takým2skor;

    public ParticleSystem particleSystem;
   

     void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D top)
    {
        if (top.tag == "top" && gameObject.name=="kale1" ) 
        {
            takým2skor++;
            takým2skortext.text = "" + takým2skor;
            PlayerPrefs.SetInt("skor2", takým2skor);

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
            takým1skor++;
            takým1skortext.text = "" + takým1skor;
            //
            PlayerPrefs.SetInt("skor1", takým1skor);
            
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






























//int takým2puan = 0;
//int takým1puan = 0;
//public Text takým2puantext, takým1puantext;
//AudioSource AudioSource;

//private void OnCollisionEnter2D(Collision2D collision)
//{


//    if (collision.gameObject.name == "kale1")
//    {
//        takým2skor++;
//        takým2skortext.text = "" + takým2skor;
//        PlayerPrefs.SetInt("takým2skor", takým2skor);


//    }
//    if (collision.gameObject.name == "kale2")
//    {
//        takým1skor++;
//        takým1skortext.text = "" + takým1skor;
//        PlayerPrefs.SetInt("takým1puan", takým1skor);


//    }

//}

//////////////////////////////////////////////////// yukarýdaki kodlar hocayla derste yapýlan gol kodlarý.
