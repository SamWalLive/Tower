using UnityEngine;
using System.Collections;

public class LevelStarter : MonoBehaviour {

    public float spacer;
    public GameObject arrivals;
    public GameObject[] food;
    public GameObject[] recreation;
    public GameObject[] residential;
    public GameObject[] retail;
    public GameObject[] service;
    public GameObject[] imperial;
    public int minimumNumberOfResidentialLevels;
    public int maximumNumberOfResidentialLevels;
    public int minimumNumberOfFoodLevels;
    public int maximumNumberOfFoodLevels;
    public int minimumNumberOfRecreationLevels;
    public int maximumNumberOfRecreationLevels;
    public int minimumNumberOfRetailLevels;
    public int maximumNumberOfRetailLevels;
    public int minimumNumberOfServiceLevels;
    public int maximumNumberOfServiceLevels;

    private ClickCamera cameraScript;

    void Start ()
    {

        cameraScript = FindObjectOfType<ClickCamera>();

        cameraScript.bottomBand = -(spacer / 2);

        Instantiate(arrivals);
        int count = 1;
        int numberOfExtraResidentialLevels = Random.Range(minimumNumberOfResidentialLevels, maximumNumberOfResidentialLevels + 1);
        for (int i = 0; i < numberOfExtraResidentialLevels; i++, count++)
        {
            Instantiate(residential[Random.Range(0, residential.Length)], new Vector3(0f, count * spacer), arrivals.transform.rotation);
        }

        int numberOfExtraFoodLevels = Random.Range(minimumNumberOfFoodLevels, maximumNumberOfFoodLevels + 1);
        for (int i = 0; i < numberOfExtraFoodLevels; i++, count++)
        {
            Instantiate(food[Random.Range(0, food.Length)], new Vector3(0f, count * spacer), arrivals.transform.rotation);
        }

        int numberOfExtraRecreationLevels = Random.Range(minimumNumberOfRecreationLevels, maximumNumberOfRecreationLevels + 1);
        for (int i = 0; i < numberOfExtraRecreationLevels; i++, count++)
        {
            Instantiate(recreation[Random.Range(0, recreation.Length)], new Vector3(0f, count * spacer), arrivals.transform.rotation);
        }

        int numberOfExtraRetailLevels = Random.Range(minimumNumberOfRetailLevels, maximumNumberOfRetailLevels + 1);
        for (int i = 0; i < numberOfExtraRetailLevels; i++, count++)
        {
            Instantiate(retail[Random.Range(0, retail.Length)], new Vector3(0f, count * spacer), arrivals.transform.rotation);
        }

        int numberOfExtraServiceLevels = Random.Range(minimumNumberOfServiceLevels, maximumNumberOfServiceLevels + 1);
        for (int i = 0; i < numberOfExtraServiceLevels; i++, count++)
        {
            Instantiate(service[Random.Range(0, service.Length)], new Vector3(0f, count * spacer), arrivals.transform.rotation);
        }

        cameraScript.topBand = (count - 1) * spacer + spacer / 2;

	}
	
}
