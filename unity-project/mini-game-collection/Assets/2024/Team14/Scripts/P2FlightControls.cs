using UnityEngine;

public class P2FlightControls : MonoBehaviour
{
    public float p2speed = 10f;              // Speed for X-Y movement
    public float p2rotationSpeed = 100f;    // Rotation speed
   // public string verticalInput = "Player1_Vertical";
  //  public string horizontalInput = "Player1_Horizontal";
    public string p2verticalInput = "P2_AxisY";
    public string p2horizontalInput = "P2_AxisX";

    // public string playerPrefix = "Player1"; // "Player1" or "Player2"

    void Update()
    {
        float p2vertical = Input.GetAxis(p2verticalInput);   // Up/down movement
        float p2horizontal = Input.GetAxis(p2horizontalInput); // Left/right movement

        Vector3 movement = new Vector3(p2horizontal, p2vertical, 0) * p2speed * Time.deltaTime;
        transform.Translate(movement, Space.World);

        float rotation = p2horizontal * -p2rotationSpeed * Time.deltaTime;
        transform.Rotate(0, 0, rotation);
    }
}