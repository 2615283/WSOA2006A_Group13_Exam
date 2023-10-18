using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public int skinNum;
    public Skins[] skinsBack;
    public Skins[] skinsFront;
    public Skins[] skinsLeft;
    public Skins[] skinsRight;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void LateUpdate()
    {
        SkinOptionsBack();
        SkinOptionsFront();
        SkinOptionsLeft();
        SkinOptionsRight();
    }

    private void SkinOptionsBack()
    {
        if (spriteRenderer.sprite.name.Contains("Idle_Back_Skin_Color_1"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Idle_Back_Skin_Color_1_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = skinsBack[skinNum].sprites[spriteNr];
        }
    }

    private void SkinOptionsFront()
    {
        if (spriteRenderer.sprite.name.Contains("Idle_Forward_Skin_Color_1"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Idle_Forward_Skin_Color_1_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = skinsFront[skinNum].sprites[spriteNr];
        }
    }

    private void SkinOptionsLeft()
    {
        if (spriteRenderer.sprite.name.Contains("Idle_Left_Skin_Color_1"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Idle_Left_Skin_Color_1_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = skinsLeft[skinNum].sprites[spriteNr];
        }
    }

    private void SkinOptionsRight()
    {
        if (spriteRenderer.sprite.name.Contains("Idle_Right_Skin_Color_1"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Idle_Right_Skin_Color_1_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = skinsRight[skinNum].sprites[spriteNr];
        }
    }
}

[System.Serializable]
public struct Skins
{
    public Sprite[] sprites;
}
