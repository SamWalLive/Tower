using UnityEngine;
using System.Collections;

public class Bitzen : MonoBehaviour {

    public GameObject jobLevel;

    public string firstName;
    public string lastName;

    private Names getName;

	void Start ()
    {
        getName = FindObjectOfType<Names>();
        firstName = getName.GetFirstName();
        lastName = getName.GetLastName();
	}

    public  string GetFirstName()
    {
        return firstName;
    }

    public string GetLastName()
    {
        return lastName;
    }
	
}
