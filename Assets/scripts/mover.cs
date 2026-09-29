using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xValue = moveSpeed * (Input.GetAxis("Horizontal") * Time.deltaTime);
        float yValue = 0f;
        float zValue = moveSpeed * (Input.GetAxis("Vertical") * Time.deltaTime);
        transform.Translate(xValue, yValue, zValue);
    }
}
