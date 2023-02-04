using UnityEngine;
public class RootBehavior : MonoBehaviour
{
    [Range(0, 100)]
    public float Progression = 0;
    public float ProgressionSpeed = 1;
    public int InitialScale = 10;

    // Start is called before the first frame update
    void Start(){}

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
