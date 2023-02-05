using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAudoController : MonoBehaviour
{
    public Fade Fade;
    bool hasStarted = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Fade.isDone && !hasStarted)
        {
            GetComponent<AudioSource>().Play();
            hasStarted = true;
        }
    }
}
