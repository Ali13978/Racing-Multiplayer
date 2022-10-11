using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointChecker : MonoBehaviour
{
    [SerializeField] CarController theCar;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Checkpoint")
        {
            //Debug.Log("Hit cp: " + other.GetComponent<CheckPoint>().CpNumber.ToString());
            theCar.CheckpointHit(other.GetComponent<CheckPoint>().CpNumber);
        }
    }
}
