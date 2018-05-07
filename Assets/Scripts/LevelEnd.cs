using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelEnd : MonoBehaviour
{
    [SerializeField]
    Text endLevelText;

    [SerializeField]
    Text currentChargeText;

    [SerializeField]
    Text requiredChargeText;

    [SerializeField]
    Text remainingWireText;

    [SerializeField]
    private int requiredCharge = 0;

    [SerializeField]
    public  int remainingWire = 0;

  



   

    public  static int currentCharge = 0;

    public bool levelBeat = false;

   
    // Update is called once per frame
    void Update ()
    {
        endgame();
        VictoryScreen();

        currentChargeText.text = "Current charge = " + currentCharge;
        remainingWireText.text = remainingWire + (" feet of wire left");
        requiredChargeText.text = "Required charge = " + requiredCharge;


    }

    public void addWire()
    {
        remainingWire++;
    }
    public void subtractWire()
    {
        remainingWire--;
    }
    private void endgame()
    {
        if (gameObject.GetComponent<PoleManager>().Clicked == true && currentCharge  == requiredCharge)
        {
            levelBeat = true; 
            
        }
    }

    private void VictoryScreen()
    {
        if(levelBeat == true)
        {
            
            endLevelText.text = "Level beat!";
        }
    }
}
