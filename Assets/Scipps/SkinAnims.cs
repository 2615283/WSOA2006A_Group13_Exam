using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinAnims : MonoBehaviour
{
    public int skinNum;
    public Skins[] skinsBack;
    public Skins[] skinsFront;
    public Skins[] skinsLeft;
    public Skins[] skinsRight;
    public Skins[] skinsBackWalk;
    public Skins[] skinsFrontWalk;
    public Skins[] skinsLeftWalk;
    public Skins[] skinsRightWalk;
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
        WalkSkinOptionsBack();
        WalkSkinOptionsFront();
        WalkSkinOptionsLeft();
        WalkSkinOptionsRight();
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

    private void WalkSkinOptionsBack()
    {
        if (spriteRenderer.sprite.name.Contains("Walk_Back_Skin_Color_1"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Walk_Back_Skin_Color_1_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = skinsBackWalk[skinNum].sprites[spriteNr];
        }
    }

    private void WalkSkinOptionsFront()
    {
        if (spriteRenderer.sprite.name.Contains("Walk_Forward_Skin_Color_1"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Walk_Forward_Skin_Color_1_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = skinsFrontWalk[skinNum].sprites[spriteNr];
        }
    }

    private void WalkSkinOptionsLeft()
    {
        if (spriteRenderer.sprite.name.Contains("Walk_Left_Skin_Color_1"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Walk_Left_Skin_Color_1_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = skinsLeftWalk[skinNum].sprites[spriteNr];
        }
    }

    private void WalkSkinOptionsRight()
    {
        if (spriteRenderer.sprite.name.Contains("Walk_Right_Skin_Color_1"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Walk_Right_Skin_Color_1_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = skinsRightWalk[skinNum].sprites[spriteNr];
        }
    }
}

[System.Serializable]
public struct Skins
{
    public Sprite[] sprites;
}

