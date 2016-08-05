using UnityEngine;
using System.Collections;

public class CommercialLevelController : MonoBehaviour {

    public Product[] products = new Product[2];
    public GameObject[] workers = new GameObject[2];

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
