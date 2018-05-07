using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelect : MonoBehaviour {

    [SerializeField]
    GameObject level;

    [SerializeField]
    GameObject levelSelect;

    private void OnMouseDown()
    {
        levelSelect.SetActive(false);
        level.SetActive(true);

    }

}
