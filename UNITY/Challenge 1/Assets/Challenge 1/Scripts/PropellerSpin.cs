using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float propellorSpins = 1500;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, propellorSpins * Time.deltaTime);
    }
}
