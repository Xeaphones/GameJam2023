using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeV2 : MonoBehaviour
{
    public RootBehavior rootBehavior;
    public bool Reverse = false;
    public float Speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rootBehavior.isDone == false)
        {
            return;
        }
        if (Reverse == false)
        {
            GetComponent<SpriteRenderer>().color -= new Color(0, 0, 0, Speed);
        } else
        {
            GetComponent<SpriteRenderer>().color += new Color(0, 0, 0, Speed);
        }
    }
}
