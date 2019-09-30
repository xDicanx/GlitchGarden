using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Star : MonoBehaviour
{
    [SerializeField] float starSpeed = 0;

    [SerializeField] int min_squares_to_travel;
    [SerializeField] int max_squares_to_travel;

    //Al parecer esto no funciona como deberia, pensar en una mejor opcion para solucionar este problema
    [SerializeField] GameObject core_game;

    private float square_to_stop;
    private void Start()
    {
        square_to_stop = Random.Range(min_squares_to_travel, max_squares_to_travel);
    }

    void Update()
    {
        if (transform.position.y >= square_to_stop)
            transform.Translate(Vector2.down * starSpeed * Time.deltaTime, Space.World);
    }

    //In case another object interacts with this one
    void SetMovementSpeed(float newSpeed)
    {
        starSpeed = newSpeed;
    }

    private void OnMouseDown()
    {
        Text x = core_game.transform.Find("UI").Find("Score").GetComponent<Text>();
         x.text = "1";
    }
}
