using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LanguageRequest : MonoBehaviour {

    public LanguageController controller;
    public string textToRequest;

    private Text textArea;

	void Start () {
        controller = FindObjectOfType<LanguageController>();
        textArea = GetComponent<Text>();
        SetText();
	}

    void SetText()
    {
        textArea.text = controller.GetString(textToRequest);
    }

}
