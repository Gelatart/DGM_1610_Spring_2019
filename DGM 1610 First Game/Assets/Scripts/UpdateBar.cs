using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateBar : MonoBehaviour
{
    private Image BarImage;
    public FloatData FillNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        BarImage = getComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        BarImage.fillAmount;
    }
}
