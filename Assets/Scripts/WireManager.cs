using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireManager : MonoBehaviour
{
    [SerializeField]
    GameObject Pole1;

    [SerializeField]
    GameObject Pole2;

    private Renderer myRender;

    // Use this for initialization
    void Start ()
    {
         myRender = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        activateWire();
    }

    private void activateWire()
    {
        if(Pole1.GetComponent<PoleManager>().Clicked ==true && Pole2.GetComponent<PoleManager>().Clicked == true)
        {

            //f (Pole1.GetComponent<PoleManager>().alreadyClicked == false && Pole2.GetComponent<PoleManager>().alreadyClicked == false)
                myRender.enabled = true;
            
        }
    }

   
}
