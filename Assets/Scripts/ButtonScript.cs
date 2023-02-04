using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public Sprite ButtonIdle;
    public Sprite ButtonPressed;
    public GameObject[] Doors;
    public float Cooldown = 1f;
    public float CooldownTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<SpriteRenderer>().sprite = ButtonIdle;
    }

    // Update is called once per frame
    void Update()
    {
        if (CooldownTimer > 0f)
        {
            CooldownTimer -= Time.deltaTime;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && CooldownTimer <= 0f)
        {
            Debug.Log("Player has entered the button");
            for (int i = 0; i < Doors.Length; i++)
            {
                Doors[i].GetComponent<DoorScript>().isActive = !Doors[i].GetComponent<DoorScript>().isActive;
            }
        }
    }

    void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.tag == "Player" && CooldownTimer <= 0f)
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
            if (CooldownTimer <= 0f)
            {
                CooldownTimer = Cooldown;
            }
        }
    }
}
