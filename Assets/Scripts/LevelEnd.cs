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
    Text remainingWireText;

    [SerializeField]
    private int requiredCharge = 0;

    [SerializeField]
    public  int remainingWire = 0;



   

    public  static int currentCharge = 0;

    private bool levelBeat = false;

   
    // Update is called once per frame
    void Update ()
    {
        endgame();
        VictoryScreen();

        currentChargeText.text = "Current charge = " + currentCharge;
        remainingWireText.text = remainingWire + (" feet of wire left");
        
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
        if (gameObject.GetComponent<PoleManager>().Clicked == true && requiredCharge == currentCharge)
        {
            levelBeat = true;
        }
    }

    private void VictoryScreen()
    {
        if(levelBeat == true)
        {
            endLevelText.text = "You Win!";
        }
    }
}
