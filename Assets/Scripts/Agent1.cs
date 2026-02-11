using UnityEngine;

public class Agent1 : MonoBehaviour
{
    ActuatorMove act;
    [SerializeField] Rigidbody rb;
    void Start()
    {
        act = GetComponent<ActuatorMove>();
        act.applyMove = Move;
    }

    void Move(Vector3 dir)
    {
        transform.Translate(Vector3.forward * Time.fixedDeltaTime);
   
        rb.linearVelocity = dir;
    }

}
