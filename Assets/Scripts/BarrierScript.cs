using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour
{

    [SerializeField]
    GameObject Barrier;

    

    [SerializeField]
    private int Requriedcharge = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        barrierSwitch();

    }

    private void barrierSwitch()
    {
        if(LevelEnd.currentCharge == Requriedcharge)
        {
            Barrier.SetActive(false);
        }

        else
        {
            Barrier.SetActive(true);
        }
    }
}
