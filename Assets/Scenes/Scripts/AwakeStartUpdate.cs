using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeStartUpdate : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake: this is called at the very beginning");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start: this is called after awake");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update: this is called again and again");
        if(Input.GetKeyDown(KeyCode.S))
        {
            cube.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.H))
        {
            cube.SetActive(false);
        }

        // reset ball position to the default position
        if(Input.GetKeyDown(KeyCode.R))
        {
            ballTransform.position = ballDefaultPosition;
        }
    }

    public GameObject cube;
    public Transform ballTransform;

    public Vector3 ballDefaultPosition;
}
