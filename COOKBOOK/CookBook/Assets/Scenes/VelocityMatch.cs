using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityMatch : AgentBehaviour
{
    public float timeToTarget = 0.1f;

    
    public override Steering GetSteering()
    {
        Steering steering = new Steering();
        steering.linear = timeToTarget.GetComponent<Agent>().velocity - agent.velocity;
        steering.linear /= timeToTarget;
        if (steering.linear.magnitude > agent.maxAccel)
            steering.linear = steering.linear.normalized * agent.maxAccel;
        steering.angular = 0.0f;
        return steering;
    }
}
