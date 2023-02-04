using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool isActive = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once 
    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            this.GetComponentInChildren<Animator>().Play("DoorOpen");
        }
        else
        {
            this.GetComponentInChildren<Animator>().Play("DoorClose");
        }
    }
}
