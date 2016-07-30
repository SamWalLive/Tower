using UnityEngine;
using System.Collections;

public class ResidentialLevelController : MonoBehaviour {

    public GameObject bitzenPrefab;
    [HideInInspector]
    public GameObject[] bitzens = new GameObject[4];

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
	
	void Update ()
    {
	    
	}
}
