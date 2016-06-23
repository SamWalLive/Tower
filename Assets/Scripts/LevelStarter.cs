using UnityEngine;
using System.Collections;

public class LevelStarter : MonoBehaviour {

    public float spacer;
    public GameObject arrivals;
    public GameObject[] residential;
    public GameObject[] imperial;
    public int minimumNumberOfLevels;
    public int maximumNumberOfLevels;


	void Start () {

        Instantiate(arrivals);
        int count = 1;
        int numberOfExtraLevels = Random.Range(minimumNumberOfLevels, maximumNumberOfLevels + 1);
        for (int i = 0; i < numberOfExtraLevels; i++, count++)
        {
            Instantiate(residential[Random.Range(0, residential.Length)], new Vector3(0f, count * spacer), arrivals.transform.rotation);
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
