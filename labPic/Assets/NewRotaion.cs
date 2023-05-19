using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRotaion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Vector3 rotationToAdd = new Vector3(0, 0, 90);
        //  transform.Rotate(rotationToAdd);
        transform.Rotate(new Vector3(0, 0, 30) * Time.deltaTime);
    }
}
