using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeStartUpdate : MonoBehaviour
{
    private void Awake()
    {
        //Debug.Log("this will be called first");
    }

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("this will be called after Awake");



        numberOne = 10;

        anObject.Translate(Vector3.forward * numberOne);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("this will be called again and again");

        
    }

    public Transform anObject;
    public Transform Cube2;

    public int numberOne;
    public int numberTwo;
}
