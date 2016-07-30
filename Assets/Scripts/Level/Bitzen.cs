using UnityEngine;
using System.Collections;

public class Bitzen : MonoBehaviour {

    public string firstName;
    public string lastName;

    private Names getName;

	void Start ()
    {
        getName = FindObjectOfType<Names>();
        firstName = getName.GetFirstName();
        lastName = getName.GetLastName();
	}
	
}
