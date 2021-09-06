using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Hero : MonoBehaviour {
    public NavMeshAgent agent;
    public Animator animator;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray,out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
        //切换人物动画
        animator.SetFloat("speed", agent.velocity.magnitude);
    }
}
