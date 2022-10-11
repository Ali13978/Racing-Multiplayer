using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] CarController target;
    [SerializeField] float minDis, maxDis;
    [SerializeField] Transform startTargetOffset;

    private float activeDis;

    Vector3 offsetDir;

    // Start is called before the first frame update
    void Start()
    {
        offsetDir = transform.position - startTargetOffset.position;

        activeDis = minDis;
        offsetDir.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        activeDis = minDis + ((maxDis - minDis) * (target.theRB.velocity.magnitude / target.maxSpeed));
        transform.position = target.transform.position + (offsetDir * activeDis);
    }
}
