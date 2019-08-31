using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; //Player Transform
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
