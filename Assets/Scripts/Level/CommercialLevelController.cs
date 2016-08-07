using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CommercialLevelController : MonoBehaviour {

    public List<Product> products;
    public List<GameObject> workers;

    private Transform startPosition;

	void Start ()
    {
        startPosition = this.transform.Find("Elevetor Exit").transform;
    }
	
    public Transform GetElevatorExit()
    {
        return startPosition;
    }

	void Update ()
    {
	    
	}
}
