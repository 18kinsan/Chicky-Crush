using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RantingMove : MonoBehaviour
{
    
    public float speedX;
    public float speedY = 0.1f;
    public float speedZ;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   

        //transform.position = new Vector3(posX, posY, posZ);
        if(GlobalScript.instance.gamestatus == GlobalScript.GameStatus.Play)
            transform.Translate(-speedX, -speedY, 0);
    }
}
