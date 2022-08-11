using System.Collections;
using UnityEngine;

public class Evade : Flee
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
        // Persue와 동일하다고는 했지만, 방향 벡터를 바꿔봤음
        Vector3 direction = transform.position - targetAux.transform.position;
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
