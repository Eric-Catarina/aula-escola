using UnityEngine;
using System;

public abstract class ActuatorMove : MonoBehaviour {
    public Vector3 dir;
    public Action<Vector3> applyMove;
    public abstract void UpdateDirection();
    public void FixedUpdate() {
        UpdateDirection();
        if (dir.magnitude == 0) return;
        Rotate();
        applyMove?.Invoke(dir);
    }

    void Rotate() {
        transform.rotation = Quaternion.LookRotation(dir);
    }
}
