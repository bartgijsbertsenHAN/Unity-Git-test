using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Vector3 offset;
    public Transform playerTransform;

    void Update()
    {
        // Go to the center of the player
        transform.position = playerTransform.position;
        transform.rotation = playerTransform.rotation;

        // Move out by the offset
        transform.Translate(-offset);

        // Reset rotation
        transform.LookAt(playerTransform);
    }
}
