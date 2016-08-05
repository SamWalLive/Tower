using UnityEngine;
using System.Collections;

public class LanguageController : MonoBehaviour {

    public Language currentLanguage;
    public Language newLanguage;

    public Language engb;
    public Language nlnl;

	void Start ()
    {
        if (!currentLanguage)
        {
            currentLanguage = engb;
        }
        currentLanguage.Generate();
    }

    public void ChangeLanguage(Language newLanguage)
    {
        currentLanguage = newLanguage;
        currentLanguage.Generate();
        LanguageRequest[] languageRequests = FindObjectsOfType<LanguageRequest>();
        foreach (LanguageRequest request in languageRequests)
        {
            request.SetText();
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

    void Update()
    {
        if (newLanguage)
        {
            if (currentLanguage != newLanguage)
            {
                ChangeLanguage(newLanguage);
            }
        }
    }

}
