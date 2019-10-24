using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
 public GameObject objectToSpawn;
    //posisi object di generate sebelah kanan kamera
    public float spawnPosY = 8; 
    public float spawnTime = 1;
    public float timer;

    public float RangeLeft;
    public float RangeRight;

    // Start is called before the first frame update
    void Start()
    {
        timer = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0){
            //Generate object dengan parent script ini sendiri
            GameObject obj = Instantiate(objectToSpawn, this.transform);
            //set posisi object agar berada di sebelah kanan kamera
            obj.transform.localPosition = new Vector3(Random.Range(RangeLeft, RangeRight),spawnPosY,0);
            timer = spawnTime;
        }
        
    }
}
