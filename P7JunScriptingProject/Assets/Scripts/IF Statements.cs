using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }


    void TemperatureTest ()
    {
        //If the coffee temp is greater than the hottest drinking temp
        if(coffeeTemperature > hotLimitTemperature)
        {
            //do this.....
            print("Coffee is too hot!!");
        }
        //If coffe temp is less than the coldest drinking temp
        else if (coffeeTemperature < coldLimitTemperature)
        {
            //do this....
            print("coffee is too cold....");
        }
        //if neither..
        else
        {
            //do this....
            print("coffee is justtt right.");
        }
    }
}
