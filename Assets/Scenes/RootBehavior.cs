using UnityEngine;

public class RootBehavior : MonoBehaviour
{
    [Range(0, 100)]
    public int Progression = 0;
    public int InitialScale = 20;
    public Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(-0.001f, -0.001f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // transform.localScale += scaleChange;
        
        transform.localScale = new Vector3(InitialScale - InitialScale * Progression * 0.01f,InitialScale - InitialScale * Progression * 0.01f, 1);
    }
}
