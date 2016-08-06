using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelsController : MonoBehaviour {

    public List<GameObject> levels;

    bool PresentInArray(Level level)
    {
        if (levels.Contains(level.gameObject))
        {
            return true;
        }
        return false;
    }

    void Update()
    {
        foreach (Level level in FindObjectsOfType<Level>())
        {
            if (!PresentInArray(level))
            {
                levels.Add(level.gameObject);
            }
        }
    }
}
