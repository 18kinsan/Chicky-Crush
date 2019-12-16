using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public Vector3 playerPos;
	public float posY;	
	public KeyCode atas,kanan, kiri;
    
    
    void Start()
    {
        //todo get rigidbody component	
		_rigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalScript.instance.gamestatus == GlobalScript.GameStatus.Wait) {
			_rigidbody2D.gravityScale = 0;
				
		} else {
			//todo gravity scale change physic of the bird in game
			_rigidbody2D.gravityScale = 2;
		}			
		
		// input for game keyboard or mouse tap
        if(gameObject.tag == "player1"){
            if (Input.GetKeyDown (KeyCode.UpArrow)) {
                if (GlobalScript.instance.gamestatus == GlobalScript.GameStatus.Wait)
                {
                    GlobalScript.instance.gamestatus = GlobalScript.GameStatus.Play;
                }

                if (GlobalScript.instance.gamestatus == GlobalScript.GameStatus.Play)
                {
                Jump();
                }

                if (GlobalScript.instance.gamestatus == GlobalScript.GameStatus.GameOver)
                {
                    SceneManager.LoadScene("Game");
                }
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow)) {
                if (GlobalScript.instance.gamestatus == GlobalScript.GameStatus.Play)
                {
                    Left();
                }
            }

            if (Input.GetKeyDown(KeyCode.RightArrow)) {
                if (GlobalScript.instance.gamestatus == GlobalScript.GameStatus.Play)
                {
                    Right();
                }
            }
        }

        if(gameObject.tag == "player2"){
            if (Input.GetKeyDown(KeyCode.W)) {
                if (GlobalScript.instance.gamestatus == GlobalScript.GameStatus.Wait)
                {
                    GlobalScript.instance.gamestatus = GlobalScript.GameStatus.Play;
                }

                if (GlobalScript.instance.gamestatus == GlobalScript.GameStatus.Play)
                {
                Jump();
                }

                if (GlobalScript.instance.gamestatus == GlobalScript.GameStatus.GameOver)
                {
                    SceneManager.LoadScene("Game");
                }
            }
        }
    }

    public void Jump ()
	{
		//todo made the bird jump 
		_rigidbody2D.velocity = new Vector2 (0, 10);
	}

    public void Left ()
	{
		_rigidbody2D.velocity = new Vector2 (-5, 0);
	}

    public void Right ()
	{
		_rigidbody2D.velocity = new Vector2 (5, 0);
	}
}
