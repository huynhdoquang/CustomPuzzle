using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPalletController  {

    public static ColorPalletController Ints;

    Color black = new Color (1,1,0,1);
    Color white;
    Color grey;
    Color darkgrey;
    Color lightgrey;
    Color gray;
    Color darkgray;
    Color lightgray;
    Color red;
    Color darkred;
    Color lightred;
    Color brown;
    Color darkbrown;
    Color lightbrown;
    Color orange;
    Color yellow;
    Color green;
    Color darkgreen;
    Color lightgreen;
    Color blue;
    Color lightblue;
    Color darkblue;
    Color purple;
    Color pink;

    private void Awake()
    {
        Ints = this;
    }

    void SelectPalletColor(EnumColorPalettesAliases enumColorPalettesAliases)
    {
        switch (enumColorPalettesAliases)
        {
            case EnumColorPalettesAliases.mastersystem:
                {

                    break;
                }
            case EnumColorPalettesAliases.gameboycolour:
                {
                    break;
                }
            case EnumColorPalettesAliases.famicom:
                {
                    break;
                }
            default:
                break;
        }
    }

    //đọc từ file sheet ra 
    public void ImportColorPallet()
    {
        //trong này sẽ foreach rồi xài hàm SetColor để đổi màu cơ bản
    }

    public void SetColor(Color color, string colorHex)
    {
        //https://docs.unity3d.com/ScriptReference/ColorUtility.TryParseHtmlString.html
        ColorUtility.TryParseHtmlString(colorHex, out color);
    }

    public Color GetColor(EnumColor color)
    {
        switch (color)
        {
            case EnumColor.black:
                    return black;
            case EnumColor.white:
                return white;
            case EnumColor.grey:
                return grey;
            case EnumColor.darkgrey:
                return darkgrey;
            case EnumColor.lightgrey:
                return lightgrey;
            case EnumColor.gray:
                return gray;
            case EnumColor.darkgray:
                return darkgray;
            case EnumColor.lightgray:
                return lightgray;
            case EnumColor.red:
                return red;
            case EnumColor.darkred:
                return darkred;
            case EnumColor.lightred:
                return lightred;
            case EnumColor.brown:
                return brown;
            case EnumColor.darkbrown:
                return darkbrown;
            case EnumColor.lightbrown:
                return lightbrown;
            case EnumColor.orange:
                return orange;
            case EnumColor.yellow:
                return yellow;
            case EnumColor.green:
                return green;
            case EnumColor.darkgreen:
                return darkgreen;
            case EnumColor.lightgreen:
                return lightgreen;
            case EnumColor.blue:
                return blue;
            case EnumColor.lightblue:
                return lightblue;
            case EnumColor.darkblue:
                return darkblue;
            case EnumColor.purple:
                return purple;
            case EnumColor.pink:
                return pink;
            default:
                return white;
        }
    }
}
