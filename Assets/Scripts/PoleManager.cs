using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleManager : MonoBehaviour
{

    [SerializeField]
    GameObject neighborNorth;
    [SerializeField]
    GameObject neighborWest;
    [SerializeField]
    GameObject neighborEast;
    [SerializeField]
    GameObject neighborSouth;

    public bool Clicked = false;

    public bool canBeClicked = false;

    public bool Activated = false;

    

    public bool alreadyClicked = false;

    public LayerMask Poles;


    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        turnOnNeighbors();

    }

   

    private void turnOnNeighbors()
    {
        if (Activated == true)
        {
            neighborNorth.GetComponent<PoleManager>().canBeClicked = true;
            neighborSouth.GetComponent<PoleManager>().canBeClicked = true;
            neighborWest.GetComponent<PoleManager>().canBeClicked = true;
            neighborEast.GetComponent<PoleManager>().canBeClicked = true;
        }


       

    }

    private void OnMouseDown()
    {
        if (canBeClicked == true && alreadyClicked == false)
        {
            Clicked = true;
            Activated = true;
            Debug.Log("I was clicked");
            neighborNorth.GetComponent<PoleManager>().Activated = false;
            neighborSouth.GetComponent<PoleManager>().Activated = false;
            neighborWest.GetComponent<PoleManager>().Activated = false;
            neighborEast.GetComponent<PoleManager>().Activated = false;

            alreadyClicked = true;

            neighborNorth.GetComponent<PoleManager>().canBeClicked = false;
            neighborSouth.GetComponent<PoleManager>().canBeClicked = false;
            neighborWest.GetComponent<PoleManager>().canBeClicked = false;
            neighborEast.GetComponent<PoleManager>().canBeClicked = false;
        }

        else if (alreadyClicked == true && canBeClicked == true)
        {
            Debug.Log("I'm already active");
        }

        else if (canBeClicked == false)
        {
            Debug.Log("im out of range");
        }

    }

    //private void boolCHeck()
    //{
    //    if(Clicked == true)
    //    {
    //        Debug.Log("I'm true now");
    //    }
    //}
}
