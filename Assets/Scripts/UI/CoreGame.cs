using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreGame : MonoBehaviour
{
    // Start is called before the first frame update
    Defender defender;
    [SerializeField] private bool spaceIsOcuppied;

    private void OnMouseUp()
    {
        SpawnNewDefender(SnapToGrid(MousePosition()));
    }

    public void SetSelectedDefender(Defender _defender)
    {
        defender = _defender;
    }

    private void SpawnNewDefender(Vector2 spawnPosition)
    {
        if (defender)
        {
            Instantiate(defender, spawnPosition, Quaternion.identity);
            defender = null;
        }
    }

    private Vector2 SnapToGrid(Vector2 rawSpawnPosition)
    {
        float newX = Mathf.RoundToInt(rawSpawnPosition.x);
        float newY = Mathf.RoundToInt(rawSpawnPosition.y);
        Vector2 SnapedPos = new Vector2(newX, newY);
        return SnapedPos;
    }

    private Vector2 MousePosition()
    {
        Vector2 clickPosition = Input.mousePosition;
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(clickPosition);
        return worldPosition;
    }

    public void SpaceisOcuppied(bool _emptySpace)
    {
        spaceIsOcuppied = _emptySpace;
    }

    public bool GetSpaceIsOcuppied()
    {
        return spaceIsOcuppied;
    }
}
