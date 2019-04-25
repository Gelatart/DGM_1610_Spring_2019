using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ChangeSprite : ScriptableObject
{
    public Color ObjColor = Color.red;

    public void ChangeColor(SpriteRenderer spriteObj)
    {
        spriteObj.color = ObjColor;
    }
}
