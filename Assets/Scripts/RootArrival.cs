using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootArrival : MonoBehaviour
{
    public AudioSource trackA;
    public AudioSource trackB;
    public float delay = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (delay > 0)
       {
           delay -= Time.deltaTime;
       }
       if (delay <= 0)
       {
           trackA.mute = true;
           trackB.mute = false;
       }
    }
    // IEnumerator MoveBack()
    // {
    //     yield return new WaitForSeconds(5f);
    //     trackA.mute = false;
    //     trackB.mute = true;
    // }
}
