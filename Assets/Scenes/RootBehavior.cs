using UnityEngine;
public class RootBehavior : MonoBehaviour
{
    [Range(0, 100)]
    public float Progression = 0;
    public float ProgressionSpeed = 1;
    public int InitialScale = 20;
    public bool Reduce;
    
    // Start is called before the first frame update
    void Start()
    {
        Reduce = true;
    }

    // Update is called once per frame
    void Update()
    { 
        if (Progression >= 99) 
        {
            Reduce = false;
        }

        if (Reduce)
        {
            Progression+=ProgressionSpeed * 1;        
            transform.localScale = new Vector3(InitialScale - InitialScale * Progression * 0.01f,InitialScale - InitialScale * Progression * 0.01f, 1);
        }
    }
}
