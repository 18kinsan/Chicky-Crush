using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public Vector3 objPos;

    public float posX;
    public float posY;
    public float posZ;

    public float speedX = 0.03f;
    public float speedY = 0.03f;
    public float speedZ = 0f;
    // Start is called before the first frame update
    void Start()
    {
        print("Start");
    }

    // Update is called once per frame
    void Update()
    {
    if (GlobalScript.Instance.isGameOver == false){


        objPos = transform.position;
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;
        posX -= speedX;
        transform.position = new Vector3(posX, posY, posZ);
    }
    }
}
