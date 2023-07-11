using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float rotationSpeed = 10f; // Speed of rotation
    public float minAngle = -45f; // Minimum rotation angle in degrees
    public float maxAngle = 45f; // Maximum rotation angle in degrees
    public Transform partToRotate;

    void Update()
    {
        // Calculate the direction from the object to the player
        Vector2 direction = player.position - transform.position;

        // Calculate the angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Clamp the angle within the specified range
        angle = Mathf.Clamp(angle, minAngle, maxAngle);

        // Create a quaternion rotation based on the angle
        Quaternion desiredRotation = Quaternion.AngleAxis(angle, Vector3.forward);

        // Smoothly rotate towards the desired rotation
        partToRotate.rotation = Quaternion.Lerp(transform.rotation, desiredRotation, rotationSpeed * Time.deltaTime);
    }

}
