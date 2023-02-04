using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootBehavior : MonoBehaviour
{
    // public Slider slider;
    private Animator animator;
    public Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        scaleChange = new Vector3(-0.002f, -0.002f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += scaleChange;
    }
}
