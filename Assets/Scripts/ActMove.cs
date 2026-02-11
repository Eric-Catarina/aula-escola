using UnityEngine;

public class ActMove : ActuatorMove
{
    public float speed;
    public Transform target;
    public override void UpdateDirection()
    {
        if (true) {
            dir = target.position - transform.position;
            dir = dir.normalized * speed;
            target.hasChanged = false;
        }

    }

}
