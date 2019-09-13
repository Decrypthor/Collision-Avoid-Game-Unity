
using UnityEngine;

public class CollisionObject : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collisioninfo)
    {
        
        if (collisioninfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }
}
