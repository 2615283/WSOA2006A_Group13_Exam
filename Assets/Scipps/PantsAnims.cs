using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantsAnims : MonoBehaviour
{
    public int pantsNum;
    public Pants[] pantsBackIdle;
    public Pants[] pantsFrontIdle;
    public Pants[] pantsLeftIdle;
    public Pants[] pantsRightIdle;
    public Pants[] pantsBackWalk;
    public Pants[] pantsFrontWalk;
    public Pants[] pantsLeftWalk;
    public Pants[] pantsRightWalk;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void LateUpdate()
    {
        IdlePantsBackOptions();
        IdlePantsFrontOptions();
        IdlePantsLeftOptions();
        IdlePantsRightOptions();
        WalkPantsBackOptions();
        WalkPantsFrontOptions();
        WalkPantsLeftOptions();
        WalkPantsRightOptions();
    }

    private void IdlePantsBackOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Beige_Idle_Back"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Beige_Idle_Back_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = pantsBackIdle[pantsNum].sprites[spriteNr];
        }
    }

    private void IdlePantsFrontOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Beige_Idle_Forward"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Beige_Idle_Forward_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = pantsFrontIdle[pantsNum].sprites[spriteNr];
        }
    }

    private void IdlePantsLeftOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Beige_Idle_Left"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Beige_Idle_Left_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = pantsLeftIdle[pantsNum].sprites[spriteNr];
        }
    }

    private void IdlePantsRightOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Beige_Idle_Right"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Beige_Idle_Right_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = pantsRightIdle[pantsNum].sprites[spriteNr];
        }
    }

    private void WalkPantsBackOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Beige_Pants_Walk_Back"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Beige_Pants_Walk_Back_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = pantsBackWalk[pantsNum].sprites[spriteNr];
        }
    }

    private void WalkPantsFrontOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Beige_Pants_Walk_Forward"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Beige_Pants_Walk_Forward_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = pantsFrontWalk[pantsNum].sprites[spriteNr];
        }
    }

    private void WalkPantsLeftOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Beige_Pants_Walk_Left"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Beige_Pants_Walk_Left_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = pantsLeftWalk[pantsNum].sprites[spriteNr];
        }
    }

    private void WalkPantsRightOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Beige_Pants_Walk_Right"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Beige_Pants_Walk_Right_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = pantsRightWalk[pantsNum].sprites[spriteNr];
        }
    }
}

[System.Serializable]
public struct Pants
{
    public Sprite[] sprites;
}
