using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suibian : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles += new Vector3(0, 100 * Time.deltaTime, 0);
    }
}
