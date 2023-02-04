using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public Sprite ButtonIdle;
    public Sprite ButtonPressed;
    public GameObject[] Doors;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<SpriteRenderer>().sprite = ButtonIdle;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player has entered the button");
            for (int i = 0; i < Doors.Length; i++)
            {
                Doors[i].GetComponent<DoorScript>().isActive = !Doors[i].GetComponent<DoorScript>().isActive;
            }
        }
    }

    void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.tag == "Player")
        {
            this.GetComponent<SpriteRenderer>().sprite = ButtonPressed;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player has exited the button");
            this.GetComponent<SpriteRenderer>().sprite = ButtonIdle;
        }
    }
}
