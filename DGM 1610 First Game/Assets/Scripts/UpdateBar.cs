using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateBar : MonoBehaviour
{
    private Image BarImage;
    public FloatData FillNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        BarImage = GetComponent<Image>();
        BarImage.fillAmount = 1.0f; //Replacement for fillAmount not working in Update
    }

    // Update is called once per frame
    void Update()
    {
        //BarImage.fillAmount; //Not complete?
    }
}
