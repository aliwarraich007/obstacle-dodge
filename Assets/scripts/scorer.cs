using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int currentScore = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hit") return;
        currentScore++;
        Debug.Log("You've bumped into something: " + currentScore);
    }
}