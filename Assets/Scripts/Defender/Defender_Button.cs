using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender_Button : MonoBehaviour
{

    [Header("Misc")]
    [SerializeField] Defender _defender;
    [SerializeField] CoreGame _cg;



    float _xScale = 0.1459117f;
    float _yScale = 0.9215211f;

    [Header("Scale Test")]
     float _scale = .01f;

    Color col;
    private void Start()
    {
        col = GetComponent<SpriteRenderer>().material.color;
    }
    /// <summary>
    /// Called when the mouse enters the GUIElement or Collider.
    /// </summary>
    void OnMouseEnter()
    {
        transform.localScale = new Vector3(_xScale + _scale, _yScale + _scale, 1);
        col.a = 2f;
        GetComponent<SpriteRenderer>().material.color = col;
    }

    private void OnMouseExit()
    {
        transform.localScale = new Vector3(_xScale, _yScale, 1);
        col.a = 1f;
        GetComponent<SpriteRenderer>().material.color = col;
    }

    private void OnMouseDown()
    {
        _cg.SetSelectedDefender(_defender);
    }
}
