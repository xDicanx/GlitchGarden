using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    
    [SerializeField] Vector3 _mousePos;
    private Vector3 offset;
    // Update is called once per frame
    
    private void OnMouseUp() 
    {
        Destroy(gameObject);    
    
    }
    private void OnMouseDown()
    {
         _mousePos = Camera.main.ScreenToWorldPoint(transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _mousePos.z));
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _mousePos.z);
        Vector3 curPosition =  Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        
    }
    
}
