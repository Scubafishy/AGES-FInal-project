using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCharge : MonoBehaviour
{
    [SerializeField]
    int setCharge;

    

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void setTheCharge()
    {
        
           LevelEnd.currentCharge = LevelEnd.currentCharge + setCharge;
            
            
     
     
    }

    public void reverseTheCharge()
    {
        LevelEnd.currentCharge = LevelEnd.currentCharge - setCharge;
        
        
    }

}
