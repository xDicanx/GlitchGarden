using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Resources : MonoBehaviour
{
    [SerializeField] int starCounter;


    // Always put zero on the start so whatever is loaded a level you will have 0 star
    void Start()
    {
        starCounter = 0;
    }

    //These receive when clicking a star-sunshine whatever animation you put there
    private void AddingStars(int moneyRecolector)
    {
        starCounter += moneyRecolector;
    }

    //These spends the stars you have AFTER you drop a unit
    private void SpendingStars(int moneyWaster)
    {
        starCounter -= moneyWaster;
    }
}
