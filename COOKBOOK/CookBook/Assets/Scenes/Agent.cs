using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Agent : MonoBehaviour
{
    public float maxSpeed;
    public float maxAccel;
    public float orientation;
    public float rotation;
    public Vector3 velocity;
    protected Steering steering;
    private Rigidbody aRigidBody;

    public float priorityThreshold = 0.2f;

    private Dictionary<int, List<Steering>> groups;

    // Start is called before the first frame update
    void Start()
    {
        velocity = Vector3.zero;
        steering = new Steering();
        aRigidBody = GetComponent<RigidBody>();
        groups = new Dictionary<int, List<Steering>>();
    }

    public Vector3 OriToVec(float orientation)
    {
        Vector3 vector = Vector3.zero;
        vector.x = Mathf.Sin(orientation * Mathf.Deg2Rad) * 1.0f;
        vector.y = Mathf.Cos(orientation * Mathf.Deg2Rad) * 1.0f;
        return vector.normalized;
    }

    public void SetSteering(Steering steering)
    {
        this.steering = steering;
    }

    public void SetSteering(Steering steering, float weight)
    {
        this.steering.linear += (weight * steering.linear);
        this.steering.angular += (weight * steering.angular);
    }

    public void SetSteering(Steering steering, int priority)
    {
        if(!groups.ContainsKey(priority))
        {
            groups.Add(priority, new List<Steering>());
        }
        groups[priority].Add(steering);
    }

    private Steering GetPrioritySteering()
    {
        Steering steering = new Steering();
        float sqrThreshold = priorityThreshold * priorityThreshold;

        foreach (List<Steering> group in groups.Values)
        {
            steering = new Steering();
            foreach (Steering singleSteering in group)
            {
                steering.linear += singleSteering.linear;// * weight;
                steering.angular += singleSteering.angular;// * weight;
            }
            if ( steering.linear.sqrMagnitude > sqrThreshold ||
                Mathf.Abs(steering.angular) > priorityThreshold)
            {
                return steering;
            }
        }
    }

    // Update is called once per frame
    public virtual void Update()
    {
        if (aRigidBody == null)
            return;

        Vector3 displacement = velocity * Time.deltaTime;
        orientation += rotation * Time.deltaTime;
        // 회전 값들의 범위를 0에서 360 사이로 제한해야함

        if (orientation < 0.0f)
            orientation += 360.0f;
        else if (orientation > 360.0f)
            orientation -= 360.0f;

        transform.Translate(displacement, Space.World);
        transform.rotation = new Quaternion();
        transform.Rotate(Vector3.up, orientation);
    }

    public virtual void FixedUpdate()
    {
        if (aRigidBody == null)
            return;

        // 책에서는 &로 나와있는데 오타 같아 보여서 *로 수정함
        Vector3 displacement = velocity * Time.deltaTime;
        orientation += rotation * Time.deltaTime;
        // 회전 값들의 범위를 0에서 360 사이로 제한해야함

        if (orientation < 0.0f)
            orientation += 360.0f;
        else if (orientation > 360.0f)
            orientation -= 360.0f;

        aRigidBody.AddForce(displacement, ForceMode.VelocityChange);
        Vector3 orientationVector = OriToVec(orientation);
        aRigidBody.rotation = Quaternion.LookRotation(orientationVector, Vector3.up);
    }

    public virtual void LateUpdate()
    {
        steering = GetPrioritySteering();
        groups.Clear();

        velocity += steering.linear * Time.deltaTime;
        rotation += steering.angular * Time.deltaTime;
        if(velocity.magnitude > maxSpeed)
        {
            velocity.Normalize();
            velocity = velocity * maxSpeed;
        }

        if(steering.angular == 0.0f)
        {
            rotation = 0.0f;
        }

        if(steering.linear.sqrMagnitude == 0.0f)
        {
            velocity = Vector3.zero;
        }

        steering = new Steering();
    }
}
