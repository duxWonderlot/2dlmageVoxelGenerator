using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    Vector3 Startpositon;
    [SerializeField]
    public float Fraction;
     

    private void Update()
    {
       
        transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y+ Mathf.Sin(Random.Range(Time.deltaTime, Time.timeSinceLevelLoad))*Time.deltaTime/4, this.gameObject.transform.position.z);
    }
}
