using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roots_movement : MonoBehaviour
{
    public bool OnMovement;
    public float Speed;
    public float FinalX;
    public float FinalY;

    public Vector3 TargetPosition;
    // Start is called before the first frame update
    void Start()
    {
        OnMovement = true;
        TargetPosition = new Vector3(FinalX, FinalY, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, TargetPosition, Speed);
    }

}
