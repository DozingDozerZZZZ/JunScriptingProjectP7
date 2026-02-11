using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    Camera m_Camera;
    // Start is called before the first frame update
    void Awake()
    {
        m_Camera = Camera.main; 
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetMouseButtonDown(0)) 
        {
            Vector3 mousePosition = Input.mousePosition;
            Ray ray = m_Camera.ScreenPointToRay(mousePosition);
            if(Physics.Raycast(ray,out RaycastHit hit))
            {
                Debug.Log("Cube was clicked");
            }
        }
    }
}
