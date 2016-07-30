using UnityEngine;
using System.Collections;

public class LanguageController : MonoBehaviour {

    public Language currentLanguage;

    public Language engb;
    public Language nlnl;

	void Start ()
    {
        Language newTest = new Language();
        if (currentLanguage == newTest)
        {
            currentLanguage = engb;
        }
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
