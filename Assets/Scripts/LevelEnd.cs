using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelEnd : MonoBehaviour
{
    [SerializeField]
    Text endLevelText;
	
	// Update is called once per frame
	void Update ()
    {
        endgame();

    }

    private void endgame()
    {
        if (gameObject.GetComponent<PoleManager>().Clicked == true)
        {
            endLevelText.text = "Level Complete";
        }
    }
}
