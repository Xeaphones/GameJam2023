using UnityEngine;
public class RootBehavior : MonoBehaviour
{
    public float Speed = 1;
    public bool isDone = false; 
    public Roots_movement[] Roots;

    // Start is called before the first frame update
    void Start()
    {
        Roots = GetComponentsInChildren<Roots_movement>();
        foreach (Roots_movement root in Roots)
        {
            root.Speed = Speed * root.Speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Roots_movement root in Roots)
        {
            if (root.TargetPosition == root.transform.position)
            {
                continue;
            } else
            {
                isDone = false;
                return;
            }
        }
        isDone = true;
    }
}
