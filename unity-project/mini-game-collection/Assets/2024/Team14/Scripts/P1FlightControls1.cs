using UnityEngine;

public class P1FlightControls : MonoBehaviour
{
    public float speed = 10f;              // Speed for X-Y movement
    public float rotationSpeed = 100f;    // Rotation speed
   // public string verticalInput = "Player1_Vertical";
  //  public string horizontalInput = "Player1_Horizontal";
    public string verticalInput = "P1_AxisY";
    public string horizontalInput = "P1_AxisX";

    // public string playerPrefix = "Player1"; // "Player1" or "Player2"

    void Update()
    {
        float vertical = Input.GetAxis(verticalInput);   // Up/down movement
        float horizontal = Input.GetAxis(horizontalInput); // Left/right movement

        Vector3 movement = new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);

        float rotation = horizontal * -rotationSpeed * Time.deltaTime;
        transform.Rotate(0, 0, rotation);
    }
}