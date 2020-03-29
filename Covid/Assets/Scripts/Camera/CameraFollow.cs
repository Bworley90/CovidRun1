using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    [Range(0, 100)]
    public float cameraDistance;


    private void Update()
    {
        transform.position = new Vector3(
            player.transform.position.x,
            player.transform.position.y,
            cameraDistance * - 1); // -1 is to ensure camera variable is negative
    }
}
