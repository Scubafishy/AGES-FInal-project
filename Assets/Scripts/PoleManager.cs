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


    public bool Clicked = false;

    public bool canBeClicked = false;

    public bool Activated = false;
    

    


    public bool alreadyClicked = false;

    public LayerMask Poles;
    public bool startPole;


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
        if (canBeClicked == true && alreadyClicked == false)
        {
            Clicked = true;
            if(neighborNorth.GetComponent<PoleManager>().Activated == true)
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

            turnOnNeighbors();


        }

        else if (Clicked == true && canBeClicked == true)
        {
            if (neighborNorth.GetComponent<PoleManager>().Activated == true)
            {
                neighborNorth.GetComponent<PoleManager>().turnOffNeighbors();
                wireNorth.SetActive(false);
                neighborNorth.GetComponent<PoleManager>().alreadyClicked = false;
                neighborNorth.GetComponent<PoleManager>().Clicked = false;
                Activated = true;
                turnOnNeighbors();

                neighborNorth.GetComponent<PoleManager>().Activated = false;
                neighborSouth.GetComponent<PoleManager>().Activated = false;
                neighborWest.GetComponent<PoleManager>().Activated = false;
                neighborEast.GetComponent<PoleManager>().Activated = false;

            }
            else if (neighborSouth.GetComponent<PoleManager>().Activated == true)
            {
                neighborSouth.GetComponent<PoleManager>().turnOffNeighbors();
                wireSouth.SetActive(false);
                neighborSouth.GetComponent<PoleManager>().alreadyClicked = false;
                neighborSouth.GetComponent<PoleManager>().Clicked = false;
                Activated = true;
                turnOnNeighbors();

                neighborNorth.GetComponent<PoleManager>().Activated = false;
                neighborSouth.GetComponent<PoleManager>().Activated = false;
                neighborWest.GetComponent<PoleManager>().Activated = false;
                neighborEast.GetComponent<PoleManager>().Activated = false;
            }
            else if (neighborWest.GetComponent<PoleManager>().Activated == true)
            {
                neighborWest.GetComponent<PoleManager>().turnOffNeighbors();
                wireWest.SetActive(false);
                neighborWest.GetComponent<PoleManager>().alreadyClicked = false;
                neighborWest.GetComponent<PoleManager>().Clicked = false;
                Activated = true;
                turnOnNeighbors();

                neighborNorth.GetComponent<PoleManager>().Activated = false;
                neighborSouth.GetComponent<PoleManager>().Activated = false;
                neighborWest.GetComponent<PoleManager>().Activated = false;
                neighborEast.GetComponent<PoleManager>().Activated = false;
            }
            else if (neighborEast.GetComponent<PoleManager>().Activated == true)
            {
                neighborEast.GetComponent<PoleManager>().turnOffNeighbors();
                wireEast.SetActive(false);
                neighborEast.GetComponent<PoleManager>().alreadyClicked = false;
                neighborEast.GetComponent<PoleManager>().Clicked = false;
                Activated = true;
                turnOnNeighbors();

                neighborNorth.GetComponent<PoleManager>().Activated = false;
                neighborSouth.GetComponent<PoleManager>().Activated = false;
                neighborWest.GetComponent<PoleManager>().Activated = false;
                neighborEast.GetComponent<PoleManager>().Activated = false;
            }

            else
            {
                Debug.Log("Boo");
            }
           

        }




        else if (canBeClicked == false)
        {
            Debug.Log("im out of range");
        }

    }

   
}
