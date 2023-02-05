using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool isActive = false;
    // Update is called once 
    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            this.GetComponentInChildren<Animator>().Play("DoorOpen");
            this.GetComponentInChildren<Animator>().SetBool("IsOpen", true);
        }
        else
        {
            this.GetComponentInChildren<Animator>().Play("DoorClose");
            this.GetComponentInChildren<Animator>().SetBool("IsOpen", false);
        }
    }
}
