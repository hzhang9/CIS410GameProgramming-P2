using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeChaseSpeed : MonoBehaviour
{
    public Transform player;
    public WaypointPatrol waypointPatrol;

    void Update()
    {
        Vector3 ghostDirection = transform.TransformDirection(Vector3.forward);
        Vector3 playerPosition = player.position - transform.position;
        float cos = Vector3.Dot(ghostDirection, playerPosition);
        float angle = Mathf.Acos(Vector3.Dot(ghostDirection.normalized, playerPosition.normalized)) * Mathf.Rad2Deg;
        //Debug.Log("angle" + angle);
        if (cos>0 && angle<25)
        {
            waypointPatrol.IncreaseSpeed();
        }
        else
        {
            waypointPatrol.DecreaseSpeed();
        }
    }
}
