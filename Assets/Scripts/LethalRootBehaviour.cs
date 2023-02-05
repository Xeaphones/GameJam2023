using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LethalRootBehaviour : MonoBehaviour
{
    private RootBehavior rootObject;
    public Vector3 TargetPosition;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        rootObject = GameObject.Find("RootObject").GetComponent<RootBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rootObject.isDone)
        {
            transform.position = Vector3.MoveTowards(transform.position, TargetPosition, Speed);
        }
    }
}
