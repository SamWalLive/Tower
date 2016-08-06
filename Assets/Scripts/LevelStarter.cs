using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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

    public GameObject[] levels;
    int numberOfLevels;

    private ClickCamera cameraScript;

    void Start ()
    {

        Debug.Log("<size=25><color=green>Level Generation</color></size>");

        //Number of levels RNG

        int numberOfExtraResidentialLevels = Random.Range(minimumNumberOfResidentialLevels, maximumNumberOfResidentialLevels + 1);
        int numberOfExtraFoodLevels = Random.Range(minimumNumberOfFoodLevels, maximumNumberOfFoodLevels + 1);
        int numberOfExtraRecreationLevels = Random.Range(minimumNumberOfRecreationLevels, maximumNumberOfRecreationLevels + 1);
        int numberOfExtraRetailLevels = Random.Range(minimumNumberOfRetailLevels, maximumNumberOfRetailLevels + 1);
        int numberOfExtraServiceLevels = Random.Range(minimumNumberOfServiceLevels, maximumNumberOfServiceLevels + 1);

        Debug.Log("Res/Foo/Rec/Ret/Ser: " + numberOfExtraResidentialLevels + "," + numberOfExtraFoodLevels + "," + numberOfExtraRecreationLevels + "," + numberOfExtraRetailLevels + "," + numberOfExtraServiceLevels);

        Debug.Log("Extra Levels: " + numberOfExtraResidentialLevels + numberOfExtraFoodLevels + numberOfExtraRecreationLevels + numberOfExtraRetailLevels + numberOfExtraServiceLevels);

        levels = new GameObject[1 + numberOfExtraResidentialLevels + numberOfExtraFoodLevels + numberOfExtraRecreationLevels + numberOfExtraRetailLevels + numberOfExtraServiceLevels];

        Debug.Log("Array.length: " + levels.Length);

        //Level Instantiation
        
        int count = 0;

        levels[count] = Instantiate(arrivals);
        levels[count].GetComponent<Level>().position = count;
        levels[count].GetComponent<Level>().type = "Arrivals";
        Debug.Log("Count integer: " + count.ToString());
        count++;

        for (int i = 0; i < numberOfExtraResidentialLevels; i++, count++)
        {
            levels[count] = (GameObject)Instantiate(residential[Random.Range(0, residential.Length)], new Vector3(0f, count * spacer), arrivals.transform.rotation);
            levels[count].GetComponent<Level>().position = count;
            levels[count].GetComponent<Level>().type = "Residential";
            Debug.Log(count.ToString());
        }

        
        for (int i = 0; i < numberOfExtraFoodLevels; i++, count++)
        {
            levels[count] = (GameObject)Instantiate(food[Random.Range(0, food.Length)], new Vector3(0f, count * spacer), arrivals.transform.rotation);
            levels[count].GetComponent<Level>().position = count;
            levels[count].GetComponent<Level>().type = "Food";
            Debug.Log(count.ToString());
        }

        
        for (int i = 0; i < numberOfExtraRecreationLevels; i++, count++)
        {
            levels[count] = (GameObject)Instantiate(recreation[Random.Range(0, recreation.Length)], new Vector3(0f, count * spacer), arrivals.transform.rotation);
            levels[count].GetComponent<Level>().position = count;
            levels[count].GetComponent<Level>().type = "Recreation";
            Debug.Log(count.ToString());
        }

        
        for (int i = 0; i < numberOfExtraRetailLevels; i++, count++)
        {
            levels[count] = (GameObject)Instantiate(retail[Random.Range(0, retail.Length)], new Vector3(0f, count * spacer), arrivals.transform.rotation);
            levels[count].GetComponent<Level>().position = count;
            levels[count].GetComponent<Level>().type = "Retail";
            Debug.Log(count.ToString());
        }

        
        for (int i = 0; i < numberOfExtraServiceLevels; i++, count++)
        {
            levels[count] = (GameObject)Instantiate(service[Random.Range(0, service.Length)], new Vector3(0f, count * spacer), arrivals.transform.rotation);
            levels[count].GetComponent<Level>().position = count;
            levels[count].GetComponent<Level>().type = "Service";
            Debug.Log(count.ToString());
        }

        numberOfLevels = count;
        Debug.Log(count.ToString());

        //Camera Banding
        cameraScript = FindObjectOfType<ClickCamera>();

        cameraScript.bottomBand = -(spacer / 2);

        cameraScript.topBand = (count - 1) * spacer + spacer / 2;

        //

        Debug.Log("<size=25>Spacer</size>");

        foreach (GameObject item in levels)
        {
            Debug.Log(item.name);
        }

        Debug.Log("Item 0: " + levels[0].name);

        Debug.Log("Item 1: " + levels[1].name);

        Debug.Log("Item 5: " + levels[5].name);

        Debug.Log("Biggest Item: " + levels[levels.Length - 1].name + (levels.Length - 1).ToString());

        Debug.Log("<size=25>----------</size>");


        Debug.Log("Unsorted: " + GetComponent<LevelsController>().levels.ToString());
        GetComponent<LevelsController>().levels.Sort((level2, level1) => level1.GetComponent<Level>().position.CompareTo(level2.GetComponent<Level>().position));

    }

}
