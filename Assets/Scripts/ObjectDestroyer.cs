using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    public int yDirection;
    public float destroyPoint; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(yDirection < 0 && transform.position.y <= destroyPoint){
            Destroy(this.gameObject);
        }
        else if(yDirection > 0 && transform.position.y >= destroyPoint){
            Destroy(this.gameObject);
        }
    }
}
