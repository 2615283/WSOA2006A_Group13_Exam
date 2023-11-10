using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CustomazationScript : MonoBehaviour
{
    [Header("Skin Manager:")]
    public SkinAnims SkinNumber;
    public GameObject SkinCustomization;
    public TMP_Dropdown ChooseSkin;

    [Header("Hair Manager:")]
    public HairAnims HairNumber;
    public GameObject HairCustomization;
    public TMP_Dropdown ChooseHair;

    [Header("Shirt Manager:")]
    public ShirtAnims ShirtNumber;
    public GameObject ShirtCustomization;
    public TMP_Dropdown ChooseShirt;

    [Header("Pants Manager:")]
    public PantsAnims PantsNumber;
    public GameObject PantsCustomization;
    public TMP_Dropdown ChoosePants;

    void Start()
    {
        //instantiating SkinAnims
        SkinNumber = SkinCustomization.GetComponent<SkinAnims>();
        //instantiating HairAnims
        HairNumber = HairCustomization.GetComponent<HairAnims>(); 
        //instantiating ShirtAnims
        ShirtNumber = ShirtCustomization.GetComponent<ShirtAnims>();
        //instantiating PantsAnims
        PantsNumber = PantsCustomization.GetComponent<PantsAnims>();
    }

    void Update()
    {
        //Uses the dropdown value to select an integer in the list
        switch (ChooseSkin.value)
        {
            case 1:
                SkinNumber.skinNum = 0;
            break;
            case 2:
                SkinNumber.skinNum = 1;
            break;
            case 3:
                SkinNumber.skinNum = 2;
            break;
            case 4:
                SkinNumber.skinNum = 3;
            break;
            case 5:
                SkinNumber.skinNum = 4;
            break;
            case 6:
                SkinNumber.skinNum = 5;
            break;
            case 7:
                SkinNumber.skinNum = 6;
            break;
            case 8:
                SkinNumber.skinNum = 7;
            break;
        }

        switch (ChooseHair.value)
        {
            case 1:
                HairNumber.hairNum = 0;
                break;
            case 2:
                HairNumber.hairNum = 1;
                break;
            case 3:
                HairNumber.hairNum = 2;
                break;
            case 4:
                HairNumber.hairNum = 3;
                break;
            case 5:
                HairNumber.hairNum = 4;
                break;
            case 6:
                HairNumber.hairNum = 5;
                break;
            case 7:
                HairNumber.hairNum = 6;
                break;
            case 8:
                HairNumber.hairNum = 7;
                break;
            case 9:
                HairNumber.hairNum = 8;
                break;
            case 10:
                HairNumber.hairNum = 9;
                break;
            case 11:
                HairNumber.hairNum = 10;
                break;
            case 12:
                HairNumber.hairNum = 11;
                break;
            case 13:
                HairNumber.hairNum = 12;
                break;
            case 14:
                HairNumber.hairNum = 13;
                break;
            case 15:
                HairNumber.hairNum = 14;
                break;
            case 16:
                HairNumber.hairNum = 15;
                break;
            case 17:
                HairNumber.hairNum = 16;
                break;
            case 18:
                HairNumber.hairNum = 17;
                break;
            case 19:
                HairNumber.hairNum = 18;
                break;
            case 20:
                HairNumber.hairNum = 19;
                break;
            case 21:
                HairNumber.hairNum = 20;
                break;
            case 22:
                HairNumber.hairNum = 21;
                break;
            case 23:
                HairNumber.hairNum = 22;
                break;
            case 24:
                HairNumber.hairNum = 23;
                break;
            case 25:
                HairNumber.hairNum = 24;
                break;
            case 26:
                HairNumber.hairNum = 25;
                break;
            case 27:
                HairNumber.hairNum = 26;
                break;
            case 28:
                HairNumber.hairNum = 27;
                break;
            case 29:
                HairNumber.hairNum = 28;
                break;
            case 30:
                HairNumber.hairNum = 29;
                break;
            case 31:
                HairNumber.hairNum = 30;
                break;
            case 32:
                HairNumber.hairNum = 31;
                break;
            case 33:
                HairNumber.hairNum = 32;
                break;
            case 34:
                HairNumber.hairNum = 33;
                break;
            case 35:
                HairNumber.hairNum = 34;
                break;
            case 36:
                HairNumber.hairNum = 35;
                break;
            case 37:
                HairNumber.hairNum = 36;
                break;
            case 38:
                HairNumber.hairNum = 37;
                break;
            case 39:
                HairNumber.hairNum = 38;
                break;
            case 40:
                HairNumber.hairNum = 39;
                break;
            case 41:
                HairNumber.hairNum = 40;
                break;
            case 42:
                HairNumber.hairNum = 41;
                break;
            case 43:
                HairNumber.hairNum = 42;
                break;
            case 44:
                HairNumber.hairNum = 43;
                break;
            case 45:
                HairNumber.hairNum = 44;
                break;
            case 46:
                HairNumber.hairNum = 45;
                break;
            case 47:
                HairNumber.hairNum = 46;
                break;
            case 48:
                HairNumber.hairNum = 47;
                break;
            case 49:
                HairNumber.hairNum = 48;
                break;
            case 50:
                HairNumber.hairNum = 49;
                break;
            case 51:
                HairNumber.hairNum = 50;
                break;
            case 52:
                HairNumber.hairNum = 51;
                break;
            case 53:
                HairNumber.hairNum = 52;
                break;
            case 54:
                HairNumber.hairNum = 53;
                break;
            case 55:
                HairNumber.hairNum = 54;
                break;
            case 56:
                HairNumber.hairNum = 55;
                break;
            case 57:
                HairNumber.hairNum = 56;
                break;
            case 58:
                HairNumber.hairNum = 57;
                break;
            case 59:
                HairNumber.hairNum = 58;
                break;
            case 60:
                HairNumber.hairNum = 59;
                break;
            case 61:
                HairNumber.hairNum = 60;
                break;
            case 62:
                HairNumber.hairNum = 61;
                break;
            case 63:
                HairNumber.hairNum = 62;
                break;
            case 64:
                HairNumber.hairNum = 63;
                break;
        }

        switch (ChooseShirt.value)
        {
            case 1:
                ShirtNumber.shirtsNum = 0;
                break;
            case 2:
                ShirtNumber.shirtsNum = 1;
                break;
            case 3:
                ShirtNumber.shirtsNum = 2;
                break;
            case 4:
                ShirtNumber.shirtsNum = 3;
                break;
            case 5:
                ShirtNumber.shirtsNum = 4;
                break;
            case 6:
                ShirtNumber.shirtsNum = 5;
                break;
            case 7:
                ShirtNumber.shirtsNum = 6;
                break;
            case 8:
                ShirtNumber.shirtsNum = 7;
                break;
            case 9:
                ShirtNumber.shirtsNum = 8;
                break;
            case 10:
                ShirtNumber.shirtsNum = 9;
                break;
            case 11:
                ShirtNumber.shirtsNum = 10;
                break;
            case 12:
                ShirtNumber.shirtsNum = 11;
                break;
            case 13:
                ShirtNumber.shirtsNum = 12;
                break;
            case 14:
                ShirtNumber.shirtsNum = 13;
                break;
            case 15:
                ShirtNumber.shirtsNum = 14;
                break;
            case 16:
                ShirtNumber.shirtsNum = 15;
                break;
            case 17:
                ShirtNumber.shirtsNum = 16;
                break;
            case 18:
                ShirtNumber.shirtsNum = 17;
                break;
            case 19:
                ShirtNumber.shirtsNum = 18;
                break;
            case 20:
                ShirtNumber.shirtsNum = 19;
                break;
            case 21:
                ShirtNumber.shirtsNum = 20;
                break;
            case 22:
                ShirtNumber.shirtsNum = 21;
                break;
            case 23:
                ShirtNumber.shirtsNum = 22;
                break;
            case 24:
                ShirtNumber.shirtsNum = 23;
                break;
            case 25:
                ShirtNumber.shirtsNum = 24;
                break;
            case 26:
                ShirtNumber.shirtsNum = 25;
                break;
            case 27:
                ShirtNumber.shirtsNum = 26;
                break;
            case 28:
                ShirtNumber.shirtsNum = 27;
                break;
            case 29:
                ShirtNumber.shirtsNum = 28;
                break;
            case 30:
                ShirtNumber.shirtsNum = 29;
                break;
            case 31:
                ShirtNumber.shirtsNum = 30;
                break;
            case 32:
                ShirtNumber.shirtsNum = 31;
                break;
        }

        switch (ChoosePants.value)
        {
            case 1:
                PantsNumber.pantsNum = 0;
                break;
            case 2:
                PantsNumber.pantsNum = 1;
                break;
            case 3:
                PantsNumber.pantsNum = 2;
                break;
            case 4:
                PantsNumber.pantsNum = 3;
                break;
        }
    }
}
