using System.Collections;
using UnityEngine;

public class Face : Align
{
    protected GameObject targetAux;

    // Start is called before the first frame update
    public override void Awake()
    {
        base.Awake();
        targetAux = target;
        target = new GameObject();
        target.AddComponent<Agent>();
    }

    void OnDestroy()
    {
        Destroy(target);
    }

    public override Steering GetSteering()
    {
        Vector3 direction = targetAux.transform.position - transform.position;

        if (direction.magnitude >0.0f)
        {
            float targetOrientation = Mathf.Atan2(direction.x, direction.z);
            targetOrientation *= Mathf.Rad2Deg;
            targetOrientation.GetComponent<Agent>().orientation = targetOrientation;
        }
        return base.GetSteering();
    }
}
