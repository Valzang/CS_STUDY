using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : Seek
{
    public Path path;
    public float pathOffset = 0.0f;
    float currentParam;

    public override void Awake()
    {
        base.Awake();
        target = new GameObject();
        currentParam = 0f;
    }

    public override Steering GetSteering()
    {
        currentParam = path.GetParam(transform.position, currentParam);

        float targetParam = currentParam + pathOffset;
        target.transform.position = path.GetPosition(targetParam);
        return base.GetSteering();
    }

    void OnDrawGizmos()
    {
        Vector3 direction;
        Color tmp = Gizmos.color;
        Gizmos.color = Color.magenta;

        for (int i =0; i<nodes.Count-1; ++i)
        {
            Vector3 src = nodes[i].transform.position;
            Vector3 dst = nodes[i + 1].transform.position;
            direction = dst - src;
            Gizmos.DrawRay(src, direction);
        }
        Gizmos.color = tmp;
    }
}
