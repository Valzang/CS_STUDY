using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : VelocityMatch
{
    public JumpPoint jumpPoint;
    public float maxYVelocity;
    public Vector3 gravity = new Vector3(0, -9.8f, 0);
    bool canArchieve = false;

    public void SetJumpPoint(Transform jumpPad, Transform landingPad)
    {
        jumpPoint = new JumpPoint(jumpPad.position, landingPad.position);
    }

    protected void CalculateTarget()
    {
        target = new GameObject();
        target.AddComponent<Agent>();
        target.transform.position = jumpPoint.jumpLocation;

        float sqrtTerm = Mathf.Sqrt(2f * gravity.y * jumpPoint.deltaPosition.y + maxYVelocity * agent.maxSpeed);
        float time = (maxYVelocity - sqrtTerm) / gravity.y;

        if(!CheckJumpTime(time))
        {
            time = (maxYVelocity + sqrtTerm) / gravity.y;
        }
    }

    private bool CheckJumpTime(float time)
    {
        float vx = jumpPoint.deltaPosition.x / time;
        float vz = jumpPoint.deltaPosition.z / time;
        float speedSq = vx * vx + vz * vz;

        if (speedSq < agent.maxSpeed * agent.maxSpeed)
        {
            target.GetComponent<Agent>().velocity = new Vector3(vx, 0f, vz);
            canAchieve = true;
            return true;
        }
        return false;
    }

    public override Steering GetSteering()
    {
        Steering steering = new Steering();
        if (target == null)
            CalculateTarget();

        if (!canArchieve)
            return steering;

        if(Mathf.Approximately((transform.position - target.transform.position).magnitude, 0f)
            && Mathf.Approximately((agent.velocity - target.GetComponent<Agent>().velocity).magnitude, 0f))
        {
            return steering;
        }
        return base.GetSteering();
    }
}
