using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    public float Speed = 0.01f;
    public bool isDone = false;
    public float wait = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (wait > 0)
        {
            wait -= Time.deltaTime;
            return;
        }
        GetComponent<Renderer>().material.color -= new Color(0, 0, 0, Speed);
        if (GetComponent<Renderer>().material.color.a <= 0.5)
        {
            isDone = true;
        }
    }
}
