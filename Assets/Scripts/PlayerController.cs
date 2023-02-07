using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private string direction = "down";
    public RootBehavior rootBehavior;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (rootBehavior.isDone == true)
        {
            return;
        }
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical);
        rb.velocity = movement * speed;

        if (horizontal == 0 && vertical == 0)
        {
            switch (direction)
            {
                case "up":
                    GetComponent<Animator>().Play("PlayerIdleUp");
                    break;
                case "down":
                    GetComponent<Animator>().Play("PlayerIdle");
                    break;
                case "right":
                    GetComponent<Animator>().Play("PlayerIdleRight");
                    break;
                case "left":
                    GetComponent<Animator>().Play("PlayerIdleLeft");
                    break;
            }
        }
        else if (vertical > 0)
        {
            // change animation to up
            GetComponent<Animator>().Play("PlayerWalkUp");
            direction = "up";
        }
        else if (vertical < 0)
        {
            // change animation to down
            GetComponent<Animator>().Play("PlayerWalkDown");
            direction = "down";
        }
        else if (horizontal > 0) 
        {
            // change animation to right
            GetComponent<Animator>().Play("PlayerWalkRight");
            direction = "right";
        }
        else if (horizontal < 0)
        {
            // change animation to left
            GetComponent<Animator>().Play("PlayerWalkLeft");
            direction = "left";
        }
    }
}