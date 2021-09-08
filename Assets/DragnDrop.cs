using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragnDrop : MonoBehaviour
{

    // allows for a click and hold input via the mouse click //
    private void OnMouseDrag()
    {
        // Sets value/location relative to mouse position cordinates //
        transform.position = GetMousePos();
    }

    Vector3 GetMousePos() {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
        
        // The above line converts mouse position into cordinates on the canvas //
        mousePos.z = 0;
        return mousePos;
    }
}
