using UnityEngine;


public class ObjectHit : MonoBehaviour
{
    MeshRenderer meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player") return;

        meshRenderer.material.color = Color.seaGreen;
        gameObject.tag = "Hit";
    }

}