using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject otherGameOject;

    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxCol;

    // Start is called before the first frame update
    void Awake()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameOject.GetComponent<YetAnotherScript>();
        boxCol = otherGameOject.GetComponent<BoxCollider>();

    }

    // Update is called once per frame
    void Start()
    {
        boxCol.size = new Vector3 (3,3,3);
        Debug.Log("The player score is " + anotherScript.playerScore);
        Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + " times");

    }
}
