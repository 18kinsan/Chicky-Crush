using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float timeLeft = 3;
    public Text timeLeftText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(IeTimeLeft());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Time Left : "+timeLeft);
        timeLeftText.text = "" + timeLeft;
    }

    IEnumerator IeTimeLeft(){
        while (true){
            yield return new WaitForSeconds(1f);
            timeLeft--;
        }
    }
}
