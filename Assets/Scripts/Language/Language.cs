using UnityEngine;
using System.Collections;

[System.Serializable]
public class Language : MonoBehaviour{

    public Phrase[] text;

    public void Generate()
    {
        int count = 0;
        text = new Phrase[transform.childCount];
        foreach (Transform child in transform)
        {
            text[count] = child.gameObject.GetComponent<Phrase>();
            count++;
        }
    }

    public string GetString(string input)
    {
        foreach(Phrase phr in text)
        {
            if(input == phr.label)
            {
                return phr.text;
            }
        }
        return "";
    }
    
}
