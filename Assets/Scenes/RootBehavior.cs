using UnityEngine;

public class RootBehavior : MonoBehaviour
{
    [Range(0, 100)]
    public float Progression = 0;
    public float ProgressionSpeed = 0.1f;
    public int InitialScale = 20;
    // Start is called before the first frame update
    void Start(){
        transform.localScale = new Vector3(InitialScale, InitialScale, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Progression < 100) {
            Progression += ProgressionSpeed;
            transform.localScale = new Vector3(InitialScale - InitialScale * Progression * 0.01f,InitialScale - InitialScale * Progression * 0.01f, 1);
        }

        if (Progression >= 100) {
            transform.localScale = Vector3.zero;
            Progression = 100;
        }
    }
}
