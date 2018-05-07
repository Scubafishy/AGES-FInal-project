using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backToLevelSelect : MonoBehaviour {


    [SerializeField]
    GameObject level;

    [SerializeField]
    GameObject endPole;

    [SerializeField]
    GameObject levelSelect;
    [SerializeField]
    GameObject nextButton;

    [SerializeField]
    Text text1;
    [SerializeField]
    Text text2;
    [SerializeField]
    Text text3;
    [SerializeField]
    Text text4;
    private void OnMouseDown()
    {
        levelSelect.SetActive(true);
        level.SetActive(false);

        text1.text = "";
        text2.text = "";
        text3.text = "";
        text4.text = "";

        if(endPole.GetComponent<LevelEnd>().levelBeat == true)
        {
            nextButton.SetActive(true);
        }
    }
}
