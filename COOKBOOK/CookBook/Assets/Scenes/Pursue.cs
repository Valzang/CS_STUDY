using System.Collections;
using UnityEngine;

public class Pursue : Seek
{
    public float maxPrediction;
    private GameObject targetAux;
    private Agent targetAgent;

    // Start is called before the first frame update
    public override void Awake()
    {
        base.Awake();
        targetAgent = target.GetComponent<Agent>();
        targetAux = target;
        target = new GameObject();
    }

    void OnDestroy()
    {
        Destroy(targetAux);
    }

    public override Steering GetSteering()
    {
        Vector3 direction = targetAux.transform.position - transform.position;
        float distance = direction.magnitude;
        float speed = agent.velocity.magnitude;
        float prediction;
        if (speed <= distance / maxPrediction)
            prediction = maxPrediction;
        else
            prediction = distance / speed;
        target.transform.position = targetAux.transform.position;
        target.transform.position += targetAux.velocity * prediction;

        return base.GetSteering();
    }

}
