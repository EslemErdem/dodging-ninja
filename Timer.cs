using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    private float sayac;
    private Slider zaman;
    public GameObject restartButton;
    public GameObject panel2;
    public GameObject panel;
    public GameObject restart_button;
    private void Awake()
    {
        zaman = GameObject.Find("Timer").GetComponent <Slider>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        zaman.maxValue = 60;
        zaman.minValue = 0;
        zaman.wholeNumbers = false;
        zaman.value = zaman.maxValue;
        sayac = zaman.value;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (zaman.value > zaman.minValue)
        {
            sayac -= Time.deltaTime;
            zaman.value = sayac;
           
            if (zaman.value == 0 && ninja.su_an_can!=0)
            {
                panel2.SetActive(true);
                restartButton.SetActive(true);
               
            }
            else
            {
                panel.SetActive(true);
                restart_button.SetActive(true);
               
            }
        }
       
    }
}
