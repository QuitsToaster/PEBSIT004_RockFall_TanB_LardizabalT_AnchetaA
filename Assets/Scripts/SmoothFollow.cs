using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    public Transform target;
    public float distance = 10f;
    public float height = 5f;
    public float followSpeed = 100f; // 20x faster (try 100 or more!)

    void LateUpdate()
    {
        if (!target) return;

        // Desired position behind the ship
        Vector3 desiredPosition = target.position 
                                - target.forward * distance 
                                + Vector3.up * height;

        // Super fast catch-up movement
        transform.position = Vector3.MoveTowards(transform.position, desiredPosition, followSpeed * Time.deltaTime);

        // Always face the ship
        transform.LookAt(target);
    }
}
