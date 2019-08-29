
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    public Transform playerPosition;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = playerPosition.position + offset;
    }
}
