using UnityEngine;

public class RingScoring : MonoBehaviour
{
    public int player1Score = 0;
    public int player2Score = 0;
    public bool player1InRing = false;
    public bool player2InRing = false;

    void Update()
    {
        if (player1InRing && player2InRing)
        {
            // Both players in the ring: Score a point
            player1Score++;
            player2Score++;
            Debug.Log("Both players scored a point!");

            player1InRing = false;
            player2InRing = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            player1InRing = true;
        }
        else if (other.CompareTag("Player2"))
        {
            player2InRing = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            player1InRing = false;
        }
        else if (other.CompareTag("Player2"))
        {
            player2InRing = false;
        }
    }
}