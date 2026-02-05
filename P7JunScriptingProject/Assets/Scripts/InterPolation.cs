using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterPolation : MonoBehaviour
{/*
    //In this case,result = 4
    // 4 is the between 3 and 5,,4 is 50% of the way between 3 and 5
    float result = Math.Lerp.(3f, 5f, 0.5f);


    Vector3 from = new Vector3(1f, 2f, 3f);


    Vector3 to = new Vector3(5f, 6f, 7f);

    // results in = (4,5,6)
    Vector3 result = Vector3.Lerp(from, to, 0.75);

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //If  the light intensity starts at 0 the next update will be set to 4
        // then gradully the rate of change would slow as it approaches 8.
        // light intensity would change to per second intsead of per frame with deltatime
        light.intensity = Math.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);
    }
}
