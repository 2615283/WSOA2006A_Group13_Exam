using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairAnims : MonoBehaviour
{
    public int hairNum;
    public Hair[] hairBackIdle;
    public Hair[] hairFrontIdle;
    public Hair[] hairLeftIdle;
    public Hair[] hairRightIdle;
    public Hair[] hairBackWalk;
    public Hair[] hairFrontWalk;
    public Hair[] hairLeftWalk;
    public Hair[] hairRightWalk;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void LateUpdate()
    {
        IdleHairBackOptions();
        IdleHairFrontOptions();
        IdleHairLeftOptions();
        IdleHairRightOptions();
        WalkHairBackOptions();
        WalkHairFrontOptions();
        WalkHairLeftOptions();
        WalkHairRightOptions();
    }

    private void IdleHairBackOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Black_Hair_1_Back"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Black_Hair_1_Back_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = hairBackIdle[hairNum].sprites[spriteNr];
        }
    }

    private void IdleHairFrontOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Black_Hair_1_Forward"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Black_Hair_1_Forward_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = hairFrontIdle[hairNum].sprites[spriteNr];
        }
    }

    private void IdleHairLeftOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Black_Hair_1_Left"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Black_Hair_1_Left_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = hairLeftIdle[hairNum].sprites[spriteNr];
        }
    }

    private void IdleHairRightOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Black_Hair_1_Right"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Black_Hair_1_Right_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = hairRightIdle[hairNum].sprites[spriteNr];
        }
    }

    private void WalkHairBackOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Black_Hair_1_Back"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Black_Hair_1_Back_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = hairBackWalk[hairNum].sprites[spriteNr];
        }
    }

    private void WalkHairFrontOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Black_Hair_1_Forward"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Black_Hair_1_Forward_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = hairFrontWalk[hairNum].sprites[spriteNr];
        }
    }

    private void WalkHairLeftOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Black_Hair_1_Left"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Black_Hair_1_Left_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = hairLeftWalk[hairNum].sprites[spriteNr];
        }
    }

    private void WalkHairRightOptions()
    {
        if (spriteRenderer.sprite.name.Contains("Black_Hair_1_Right"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("Black_Hair_1_Right_", "");
            int spriteNr = int.Parse(spriteName);

            spriteRenderer.sprite = hairRightWalk[hairNum].sprites[spriteNr];
        }
    }
}

[System.Serializable]
public struct Hair
{
    public Sprite[] sprites;
}
