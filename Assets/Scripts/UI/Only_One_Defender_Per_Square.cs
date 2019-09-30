using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Only_One_Defender_Per_Square : MonoBehaviour
{
    [SerializeField] CoreGame cg;


    private void OnMouseOver()
    {
        Debug.Log(true);
        if (!cg.GetSpaceIsOcuppied())
            cg.SpaceisOcuppied(true);

    }

    private void OnMouseExit()
    {
        Debug.Log(false);
        cg.SpaceisOcuppied(false);
    }

}
