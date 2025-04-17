using UnityEngine;

public class TransformController : MonoBehaviour
{
    private void Update()
    {
        // Move the GameObject up and down
        float x = Mathf.PingPong(Time.time, 3);
        Vector3 p = new Vector3(0, x, 0);
        transform.position = p; // Use transform instead of Transformcontroller

        // Rotate the GameObject
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime); // Fixed parentheses & added Time.deltaTime for smooth rotation
    }
}