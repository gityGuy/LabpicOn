using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roation : MonoBehaviour
{
  // Transform target;
  // GameObject aj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, 10, 0));
    }
}
