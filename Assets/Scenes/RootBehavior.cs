using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            transform.localScale = new Vector2 (Random.Range(0.2f, 1), 1);
        }
    }
}
