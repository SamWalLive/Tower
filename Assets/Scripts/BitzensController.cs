using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BitzensController : MonoBehaviour {

    public List<GameObject> bitzens;
	
    bool PresentInArray(Bitzen bitz)
    {
        if (bitzens.Contains(bitz.gameObject))
        {
            return true;
        }
        return false;
    }

	void Update ()
    {
        foreach (Bitzen bit in FindObjectsOfType<Bitzen>())
        {
            if (!PresentInArray(bit))
            {
                bitzens.Add(bit.gameObject);
            }
        }
    }
}
