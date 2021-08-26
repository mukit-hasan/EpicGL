using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{

    float second;
    int firstminute,lastminute;
    int _intfirstsec, _intlastsec;
    [SerializeField]
    TMP_Text _second;
    [SerializeField]
    TMP_Text _minute;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Simple timer Start
        second += Time.deltaTime;
        _intlastsec = Convert.ToInt32(second);
        
        if(_intlastsec > 9)
        {
            _intfirstsec += 1;
            second = 0;
        }

        if(_intfirstsec == 6)
        {
            lastminute += 1; 
            _intfirstsec = 0;
            _intlastsec = 0;
        }
        if(lastminute > 9)
        {
            lastminute = 0;
            firstminute += 1;
        }


        string minute = firstminute.ToString() + lastminute.ToString();

        string _intsec = _intfirstsec.ToString() + _intlastsec.ToString();

        _minute.text = minute;
        _second.text = _intsec;
    }
}
