using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    public int apples = 20;
    public int bananas = 9;

    private int stapler;
    private int sellotape;

    public void FruitMachine(int a,int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("FruitMachine total: " + answer);
    }

    private void OfficeSort (int a,int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total: " + answer);
    }
}
