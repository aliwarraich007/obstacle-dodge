using UnityEngine;

public class spinner : MonoBehaviour
{

    [SerializeField] float yVal = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, yVal, 0);
    }
}
