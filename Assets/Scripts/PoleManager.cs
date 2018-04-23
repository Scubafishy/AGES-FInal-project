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
    public  bool wire1 = false;
    public  bool wire2 = false;

    public bool wiresFull = false;

    





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

        if(Activated == true)
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
        if (alreadyClicked == false)
        {
            canBeClicked = true;
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
            neighborNorth.GetComponent<PoleManager>().Activated = false;
            neighborSouth.GetComponent<PoleManager>().Activated = false;
            neighborWest.GetComponent<PoleManager>().Activated = false;
            neighborEast.GetComponent<PoleManager>().Activated = false;

            alreadyClicked = true;

            canBeClicked = false;

            turnOnNeighbors();


            neighborNorth.GetComponent<PoleManager>().turnOffNeighbors();

            neighborSouth.GetComponent<PoleManager>().turnOffNeighbors();
            neighborWest.GetComponent<PoleManager>().turnOffNeighbors();
            neighborEast.GetComponent<PoleManager>().turnOffNeighbors();


        }

        else if (Clicked == true && canBeClicked == true)
        {
            Debug.Log("I'm already active");


        }




        else if (canBeClicked == false)
        {
            Debug.Log("im out of range");
        }

    }

    
}
