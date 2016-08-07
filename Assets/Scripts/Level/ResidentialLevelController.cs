using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ResidentialLevelController : MonoBehaviour {

    public int maximumNumberOfBitzens;

    public GameObject bitzenPrefab;
    public List<GameObject> bitzens;

    private Transform startPosition;

	void Start ()
    {

        startPosition = this.transform.Find("Elevetor Exit").transform;

	    for(int i =  0; i < 5; i++)
        {
            bitzens[i] = Instantiate(bitzenPrefab);
            bitzens[i].transform.parent = this.transform;
            bitzens[i].transform.position = startPosition.position;
        }

	}
	
}
