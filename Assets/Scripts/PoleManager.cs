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


    [SerializeField]
    GameObject wireNorth;
    [SerializeField]
    GameObject wireWest;
    [SerializeField]
    GameObject wireEast;
    [SerializeField]
    GameObject wireSouth;

    [SerializeField]
    GameObject activeCircle;

    [SerializeField]
    GameObject endPole;



    public bool Clicked = false;

    public bool canBeClicked = false;

    public bool Activated = false;
    

    


    public bool alreadyClicked = false;

   
    


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Activated == true)
        {
            activeCircle.SetActive(true);
        }
        else
        {
            activeCircle.SetActive(false);
        }

        

    }



    private void turnOnNeighbors()
    {

        neighborNorth.GetComponent<PoleManager>().turnOn();
        neighborSouth.GetComponent<PoleManager>().turnOn();
        neighborWest.GetComponent<PoleManager>().turnOn();
        neighborEast.GetComponent<PoleManager>().turnOn();

    }

    public void turnOn()
    {
        if(alreadyClicked == false)
        {

            canBeClicked = true;
        }

        else 
        {
            if(neighborNorth.GetComponent<PoleManager>().Activated == true && wireNorth.activeSelf == true)
            {
                canBeClicked = true;
            }

            else if (neighborSouth.GetComponent<PoleManager>().Activated == true && wireSouth.activeSelf == true)
            {
                canBeClicked = true;
            }
            else if (neighborEast.GetComponent<PoleManager>().Activated == true && wireEast.activeSelf == true)
            {
                canBeClicked = true;
            }
            else if (neighborWest.GetComponent<PoleManager>().Activated == true && wireWest.activeSelf == true)
            {
                canBeClicked = true;
            }
        }
        
    }

    private void turnOffNeighbors()
    {
        if (Activated == true)
        {
            
        }

        else
        {
            neighborNorth.GetComponent<PoleManager>().canBeClicked = false;

            neighborSouth.GetComponent<PoleManager>().canBeClicked = false;
            neighborWest.GetComponent<PoleManager>().canBeClicked = false;
            neighborEast.GetComponent<PoleManager>().canBeClicked = false;

    
        }

    }


    private void OnMouseDown()
    {
        if(endPole.GetComponent<LevelEnd>().remainingWire == 0)
        {
            Debug.Log("Out of wire");
        }


        else if (canBeClicked == true && alreadyClicked == false)
        {
            clickOnPole();

        }

        else if (Clicked == true && canBeClicked == true)
        {
            Debug.Log("backwords");
            goBack();

        }

        else if (canBeClicked == false)
        {
            Debug.Log("im out of range");
        }

    }

    private void goBack()
    {
        if (neighborNorth.GetComponent<PoleManager>().Activated == true)
        {
            endPole.GetComponent<LevelEnd>().addWire();
            wireNorth.SetActive(false);

            neighborNorth.GetComponent<PoleManager>().Activated = false;
            neighborNorth.GetComponent<PoleManager>().turnOffNeighbors();

            neighborNorth.GetComponent<PoleManager>().alreadyClicked = false;
            neighborNorth.GetComponent<PoleManager>().Clicked = false;
            Activated = true;
            turnOnNeighbors();
            neighborNorth.GetComponent<SetCharge>().reverseTheCharge();


        }
        else if (neighborSouth.GetComponent<PoleManager>().Activated == true)
        {
            endPole.GetComponent<LevelEnd>().addWire();
            wireSouth.SetActive(false);
            neighborSouth.GetComponent<PoleManager>().Activated = false;
            neighborSouth.GetComponent<PoleManager>().turnOffNeighbors();

            neighborSouth.GetComponent<PoleManager>().alreadyClicked = false;
            neighborSouth.GetComponent<PoleManager>().Clicked = false;
            Activated = true;
            turnOnNeighbors();
            neighborSouth.GetComponent<SetCharge>().reverseTheCharge();

        }
        else if (neighborWest.GetComponent<PoleManager>().Activated == true)
        {
            endPole.GetComponent<LevelEnd>().addWire();
            wireWest.SetActive(false);
            neighborWest.GetComponent<PoleManager>().Activated = false;
            neighborWest.GetComponent<PoleManager>().turnOffNeighbors();

            neighborWest.GetComponent<PoleManager>().alreadyClicked = false;
            neighborWest.GetComponent<PoleManager>().Clicked = false;
            Activated = true;
            turnOnNeighbors();
            neighborWest.GetComponent<SetCharge>().reverseTheCharge();

        }
        else if (neighborEast.GetComponent<PoleManager>().Activated == true)
        {
            endPole.GetComponent<LevelEnd>().addWire();
            wireEast.SetActive(false);
            neighborEast.GetComponent<PoleManager>().Activated = false;
            neighborEast.GetComponent<PoleManager>().turnOffNeighbors();

            neighborEast.GetComponent<PoleManager>().alreadyClicked = false;
            neighborEast.GetComponent<PoleManager>().Clicked = false;
            Activated = true;
            turnOnNeighbors();
            neighborEast.GetComponent<SetCharge>().reverseTheCharge();

        }

        else
        {
            Debug.Log("Boo");

        }
    }

    private void clickOnPole()
    {
        endPole.GetComponent<LevelEnd>().subtractWire();
        Clicked = true;
        if (neighborNorth.GetComponent<PoleManager>().Activated == true)
        {
            wireNorth.SetActive(true);
        }

        else if (neighborSouth.GetComponent<PoleManager>().Activated == true)
        {
            wireSouth.SetActive(true);
        }

        else if (neighborEast.GetComponent<PoleManager>().Activated == true)
        {
            wireEast.SetActive(true);
        }

        else if (neighborWest.GetComponent<PoleManager>().Activated == true)
        {
            wireWest.SetActive(true);
        }

        Activated = true;
        Debug.Log("I was clicked");

        turnOnNeighbors();


        neighborNorth.GetComponent<PoleManager>().Activated = false;
        neighborSouth.GetComponent<PoleManager>().Activated = false;
        neighborWest.GetComponent<PoleManager>().Activated = false;
        neighborEast.GetComponent<PoleManager>().Activated = false;

        alreadyClicked = true;

        canBeClicked = false;

        
        neighborNorth.GetComponent<PoleManager>().turnOffNeighbors();

        neighborSouth.GetComponent<PoleManager>().turnOffNeighbors();
        neighborWest.GetComponent<PoleManager>().turnOffNeighbors();
        neighborEast.GetComponent<PoleManager>().turnOffNeighbors();


        gameObject.GetComponent<SetCharge>().setTheCharge();
    }

}
