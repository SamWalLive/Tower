using UnityEngine;
using System.Collections;

public class Bitzen : MonoBehaviour {

    public GameObject jobLevel;

    private string firstName;
    private string lastName;

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
