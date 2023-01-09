using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class kure_olusturma : MonoBehaviour
{


    public GameObject kure1;
    public GameObject kure2;
    Rigidbody rb1, rb2;
    public float random;
 
    void Start()
    {
        random = Random.Range(1f, 8f);
        InvokeRepeating("add_right_kure", 1f, random);
        InvokeRepeating("add_left_kure", 1f, random);
        InvokeRepeating("add_left_and_right_kure", 1f, random);

    }

    void add_right_kure()
    {

        GameObject new_kure;
        new_kure = Instantiate(kure1, new Vector3(12f, 0.94f, -6.949576f), Quaternion.identity);


        Destroy(new_kure, 6f);
    }
    void add_left_kure()
    {


        GameObject kr;
        kr = Instantiate(kure2, new Vector3(-10.78f, 0.94f, -6.949576f), Quaternion.identity);


        Destroy(kr, 6f);
    }
    void add_left_and_right_kure()
    {


        GameObject new_kure, kr;

        new_kure = Instantiate(kure1, new Vector3(12, 0.94f, -6.949576f), Quaternion.identity);
        kr = Instantiate(kure2, new Vector3(-10.78f, 0.94f, -6.949576f), Quaternion.identity);


        Destroy(kr, 6f);
        Destroy(new_kure, 6f);

    }


    

}