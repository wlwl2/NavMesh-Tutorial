using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {

    public Camera cam;
    public NavMeshAgent agent;

    private void Start () {
        cam = FindObjectOfType<Camera>();
    }

    void Update () {
        // When left mouse button is pressed.
        if (Input.GetMouseButtonDown(0)) {
            // Send a ray to the point where the player pressed/clicked.
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            // Stores information about what the ray hits. 
            // To get the position of the destination click.
            RaycastHit hit;
            // Shoot out the ray. We don't want to move agent unless 
            // ray actually hits something. If we just click somewhere 
            // where there isn't an object, then we don't want our agent 
            // to do anything (false scenario).
            // Physics.Raycast() is true when we hit something, and false
            // if we didn't.
            if (Physics.Raycast(ray, out hit)) {
                // Move our agent.
                agent.SetDestination(hit.point);
            }
        }
	}
}
