using UnityEngine;
using System.Collections;

[System.Serializable]
public class Language : MonoBehaviour{

    public Phrase[] text;

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
