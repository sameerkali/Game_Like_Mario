using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollower : MonoBehaviour
{

    [SerializeField] private GameObject[] waypoint;
    private int currentWayPointIndex = 0;

    [SerializeField] private float speed = 2f;
    private void Update()
    {
        if (Vector2.Distance(waypoint[currentWayPointIndex].transform.position, transform.position) < .1f)
        {
            currentWayPointIndex++;
            if(currentWayPointIndex >= waypoint.Length) { currentWayPointIndex = 0; }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoint[currentWayPointIndex].transform.position, Time.deltaTime * speed);        
    }
}
