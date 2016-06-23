using UnityEngine;
using System.Collections;

public class LanguageController : MonoBehaviour {

    private Language currentLanguage;

    public Language engb;
    public Language nlnl;

	void Start ()
    {
        currentLanguage = engb;
	}
	
    public string GetString(string input)
    {
        string output;
        output = currentLanguage.GetString(input);
        if (output == string.Empty)
        {
            Debug.Log("String does not exist: " + input);
            return "";
        }
        return output;
    }
}
