using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetButtonDown("Jump");
        bool held = Input.GetButton("Jump");
        bool up = Input.GetButtonUp("Jump");

        if (down)
        {
            Debug.Log("Get button down is " + down);

        }
        else if (held)
        {
            Debug.Log("Get button held is " + held);
        }
        else if (up)
        {
            Debug.Log("Get button up "+ up);
        }
        else
        {
            Debug.Log("Get button down is " + down);
            Debug.Log("Get button held is " + held);
            Debug.Log("Get button up " + up);
        }
    }
}
