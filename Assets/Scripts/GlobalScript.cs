using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalScript : MonoBehaviour
{
    public static GlobalScript instance;
    public int score ;
    public Text scoreText;
    public GameStatus gamestatus;

    public int health =0;
    public Text healthText;
    public GameObject panelGameOver;
    public bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        gamestatus = GameStatus.Wait;
    }
     public void Restart(){
        SceneManager.LoadScene("Game");
    }

    // Update is called once per frame
    void Update()
    {
               instance = this;


    }

     public void AddScore(){
         score++ ;
         scoreText.text = "Score = "+score;
         
     }
     public void AddHealth(){
         health-- ;
         healthText.text = "Health = "+health;
         if(health == 0){
             isGameOver = true;
             panelGameOver.SetActive(true);
         }
         
     }
     public enum GameStatus
	{
		Wait,
		Play,
		GameOver		
	}
}
