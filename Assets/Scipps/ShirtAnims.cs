using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShirtAnims : MonoBehaviour
{
    public int shirtsNum;
    public Shirts[] shirtsBackIdle;
    public Shirts[] shirtsFrontIdle;
    public Shirts[] shirtsLeftIdle;
    public Shirts[] shirtsRightIdle;
    public Shirts[] shirtsBackWalk;
    public Shirts[] shirtsFrontWalk;
    public Shirts[] shirtsLeftWalk;
    public Shirts[] shirtsRightWalk;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void LateUpdate()
    {
        IdleShirtsBackOptions();
        IdleShirtsFrontOptions();
        IdleShirtsLeftOptions();
        IdleShirtsRightOptions();
        WalkShirtsBackOptions();
        WalkShirtsFrontOptions();
        WalkShirtsLeftOptions();
        WalkShirtsRightOptions();
    }

    private void IdleShirtsBackOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Shirt_0_Idle_Back"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Shirt_0_Idle_Back_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = shirtsBackIdle[shirtsNum].sprites[spriteNr];
        }
    }

    private void IdleShirtsFrontOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Shirt_0_Idle_Forward"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Shirt_0_Idle_Forward_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = shirtsFrontIdle[shirtsNum].sprites[spriteNr];
        }
    }

    private void IdleShirtsLeftOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Shirt_0_Idle_Left"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Shirt_0_Idle_Left_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = shirtsLeftIdle[shirtsNum].sprites[spriteNr];
        }
    }

    private void IdleShirtsRightOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Shirt_0_Idle_Right"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Shirt_0_Idle_Right_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = shirtsRightIdle[shirtsNum].sprites[spriteNr];
        }
    }

    private void WalkShirtsBackOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Shirt_0_Walk_Back"))
        { 
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Shirt_0_Walk_Back_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = shirtsBackWalk[shirtsNum].sprites[spriteNr];
        }
    }

    private void WalkShirtsFrontOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Shirt_0_Walk_Forward"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Shirt_0_Walk_Forward_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = shirtsFrontWalk[shirtsNum].sprites[spriteNr];
        }
    }

    private void WalkShirtsLeftOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Shirt_0_Walk_Left"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Shirt_0_Walk_Left_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = shirtsLeftWalk[shirtsNum].sprites[spriteNr];
        }
    }

    private void WalkShirtsRightOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Shirt_0_Walk_Right"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Shirt_0_Walk_Right_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = shirtsRightWalk[shirtsNum].sprites[spriteNr];
        }
    }
}

[System.Serializable]
public struct Shirts
{
    public Sprite[] sprites;
}
