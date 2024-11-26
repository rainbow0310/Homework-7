using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    float waitTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        PrintWaypointName();
        StartCoroutine(FollowPath()); //startcoroutine calls the follow path method over and over, its so that it looks good visually
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator FollowPath(){
        foreach(Waypoint waypoint in path) {
            Vector3 startPosition = transform.position;
            Vector3 endPosition = waypoint.transform.position;
            float travelPercentage = 0;

            transform.LookAt(endPosition); //enemy will look at end position as it moves

            while(travelPercentage < 1f) {
                travelPercentage = travelPercentage + Time.deltaTime;
                transform.position = Vector3.Lerp(startPosition, endPosition, travelPercentage);
                yield return new WaitForEndOfFrame();
            }
            
            //transform.position = waypoint.transform.position; 
            
        }
    }

     void PrintWaypointName(){
        foreach(Waypoint waypoint in path) {
            Debug.Log(waypoint.name);
        }
    }
}

