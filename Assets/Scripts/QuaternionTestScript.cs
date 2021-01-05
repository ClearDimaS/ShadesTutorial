using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionTestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Quaternion q = transform.rotation;
        Debug.Log($"{q.w}   {q.x}   {q.y}   {q.z}");
    }
}
