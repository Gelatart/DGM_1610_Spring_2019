using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class UpdateBar : MonoBehaviour
{
    private Image BarImage;
    public FloatData FillNumber;
    public UnityEvent StartEvent, IncrementEvent, DecrementEvent;
    //public bool IsAffected;
    //public bool IsPositive;
    
    // Start is called before the first frame update
    void Start()
    {
        BarImage = GetComponent<Image>();
        StartEvent.Invoke();
        //BarImage.fillAmount = 1.0f; //Replacement for fillAmount not working in Update
    }

    // Update is called once per frame
    void Update()
    {
        BarImage.fillAmount = FillNumber.Value; 
        /*if (IsAffected)
        {
            EffectDeterminant();
            IsAffected = false;
        }*/
    }

    /*public void EffectDeterminant()
    {
        if (IsPositive)
        {
            IncrementEvent.Invoke();
        }
        else
        {
            DecrementEvent.Invoke();
        }
    }*/
    //Touch up this code that determines whether to increment or decrement a bar value? Move it somewhere else?
}
