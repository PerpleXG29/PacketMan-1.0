using UnityEngine;

public class EndSceneTrigger : MonoBehaviour
{
    public GameObject targetObject; // Set this through the Unity Inspector
    public bool detected = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision's GameObject matches the targetObject
        if (collision.gameObject == targetObject)
        {
            detected = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Reset the detected variable if the targetObject exits the trigger
        if (collision.gameObject == targetObject)
        {
            detected = false;
        }
    }
}
