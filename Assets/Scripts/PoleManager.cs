using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleManager : MonoBehaviour
{

    public bool Clicked = false;

    public  bool canBeClicked = false;

    private bool alreadyClciked = false;

    public LayerMask Poles;


    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Collider[] colliders=Physics.OverlapSphere(transform.position, Poles);
        for (int i = 0; i < colliders.Length; i++)
        {
            Rigidbody targetRidgidbody = colliders[i].GetComponent<Rigidbody>();
            if (!targetRidgidbody)
                continue;

            PoleManager inRangePole = targetRidgidbody.GetComponent<PoleManager>();

            if (!inRangePole)
                continue;

            inRangePole.Acivate();
        }
    }

    public void Acivate()
    {
        canBeClicked = true;
    }

    private void OnMouseDown()
    {
        if (canBeClicked == true && alreadyClciked == false)
        {
            Debug.Log("I was clicked");
        }

       if(canBeClicked == false)
        {
            Debug.Log("im out of range");
        }
        
    }
}
