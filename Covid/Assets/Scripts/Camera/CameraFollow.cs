using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject player;
    [Range(0, 100)]
    public float cameraDistance;

    private void Start()
    {
        player = GameManager.instance.selectedPlayer;
    }


    private void Update()
    {
        transform.position = new Vector3(
            player.transform.position.x,
            player.transform.position.y,
            cameraDistance * - 1); // -1 is to ensure camera variable is negative
    }
}
