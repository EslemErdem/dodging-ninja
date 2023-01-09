using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kure2 : MonoBehaviour
{
    
    public GameObject my_object;
    public float speed;
    Vector3 pos;

    void Update()
    {
        hareketEt();
        float xPosition = Mathf.Clamp(transform.position.x, -10.85f, 12.57f);
        transform.position = new Vector3(xPosition, transform.position.y, transform.position.z);
      


    }
    public void hareketEt()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);

    }

  
}

