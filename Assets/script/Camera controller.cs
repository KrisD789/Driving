using UnityEngine;

public class Camera : MonoBehaviour
{
    GameObject player;
    Vector3 offset;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        // Move camera to follow the player
        transform.position = player.transform.position + offset;

        // Rotate camera to match the player's rotation
        //transform.rotation = player.transform.rotation;
    }
}
