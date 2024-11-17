using UnityEngine;

public class FlightControls : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 50f;
    public string playerPrefix = "Player1"; // "Player1" or "Player2"

    void Update()
    {
        // Movement controls
        float moveVertical = Input.GetAxis(playerPrefix + "_Vertical");
        float moveHorizontal = Input.GetAxis(playerPrefix + "_Horizontal");

        // Forward movement
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Rotation controls
        transform.Rotate(Vector3.up, moveHorizontal * rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.right, -moveVertical * rotationSpeed * Time.deltaTime);
    }
}