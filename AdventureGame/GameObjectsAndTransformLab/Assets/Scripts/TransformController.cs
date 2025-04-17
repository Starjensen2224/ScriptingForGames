using UnityEngine;

public class TransformController : MonoBehaviour
{
    public Transform target; // This makes the "Target Transform" field appear in the Inspector

    private void Update()
    {
        if (target != null) // Ensure target is assigned before using it
        {
            // Move the assigned target GameObject up and down
            float x = Mathf.PingPong(Time.time, 5);
            Vector3 p = new Vector3(0, x, 0);
            target.position = p; // Move the target, not the parent object
        }

        // Rotate the ParentObject
        transform.Rotate(new Vector3(30, 60, 0) * Time.deltaTime);
    }
}
