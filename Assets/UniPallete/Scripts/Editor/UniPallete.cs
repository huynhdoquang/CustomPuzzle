﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using Enum = System.Enum;

public class UniPallete : EditorWindow
{
    Texture2D pallete;
    Color32 color1 = new Color32(204, 35, 19, 255);
    Color32 color2 = new Color32(242, 125, 0, 255);
    Color32 color3 = new Color32(240, 197, 23, 255);
    Color32 color4 = new Color32(189, 215, 6, 255);
    Color32 color5 = new Color32(99, 176, 181, 255);
    Color32 color6 = new Color32(222, 18, 138, 255);
    Vector2 position1 = new Vector2(187, 80);
    Vector2 position2 = new Vector2(96, 100);
    Vector2 position3 = new Vector2(33, 170);
    Vector2 position4 = new Vector2(47, 252);
    Vector2 position5 = new Vector2(126, 271);
    Vector2 position6 = new Vector2(202, 237);
    Vector2 size = new Vector2(60, 60);

    EnumColorPalettesAliases theme;
    int additionColorTitleY = 0;

    [MenuItem("Window/UniPallete")]
    public static void ShowWindow()
    {
        EditorWindow window = GetWindow<UniPallete>("UniPallete");
        window.minSize = new Vector2(315f, 520f);
    }

    void OnEnable()
    {
        if (EditorPrefs.GetBool("unipallete_loadAfter"))
        {
            Color32 load_color1;
            load_color1.r = (byte)EditorPrefs.GetInt("unipallete_r1");
            load_color1.g = (byte)EditorPrefs.GetInt("unipallete_g1");
            load_color1.b = (byte)EditorPrefs.GetInt("unipallete_b1");
            load_color1.a = (byte)EditorPrefs.GetInt("unipallete_a1");
            //color1 = load_color1;

            Color32 load_color2;
            load_color2.r = (byte)EditorPrefs.GetInt("unipallete_r2");
            load_color2.g = (byte)EditorPrefs.GetInt("unipallete_g2");
            load_color2.b = (byte)EditorPrefs.GetInt("unipallete_b2");
            load_color2.a = (byte)EditorPrefs.GetInt("unipallete_a2");
            //color2 = load_color2;

            Color32 load_color3;
            load_color3.r = (byte)EditorPrefs.GetInt("unipallete_r3");
            load_color3.g = (byte)EditorPrefs.GetInt("unipallete_g3");
            load_color3.b = (byte)EditorPrefs.GetInt("unipallete_b3");
            load_color3.a = (byte)EditorPrefs.GetInt("unipallete_a3");
            //color3 = load_color3;

            Color32 load_color4;
            load_color4.r = (byte)EditorPrefs.GetInt("unipallete_r4");
            load_color4.g = (byte)EditorPrefs.GetInt("unipallete_g4");
            load_color4.b = (byte)EditorPrefs.GetInt("unipallete_b4");
            load_color4.a = (byte)EditorPrefs.GetInt("unipallete_a4");
            //color4 = load_color4;

            Color32 load_color5;
            load_color5.r = (byte)EditorPrefs.GetInt("unipallete_r5");
            load_color5.g = (byte)EditorPrefs.GetInt("unipallete_g5");
            load_color5.b = (byte)EditorPrefs.GetInt("unipallete_b5");
            load_color5.a = (byte)EditorPrefs.GetInt("unipallete_a5");
            //color5 = load_color5;

            Color32 load_color6;
            load_color6.r = (byte)EditorPrefs.GetInt("unipallete_r6");
            load_color6.g = (byte)EditorPrefs.GetInt("unipallete_g6");
            load_color6.b = (byte)EditorPrefs.GetInt("unipallete_b6");
            load_color6.a = (byte)EditorPrefs.GetInt("unipallete_a6");
            //color6 = load_color6;
        }
    }

    void OnDisable()
    {
        EditorPrefs.SetBool("unipallete_loadAfter", true);

        EditorPrefs.SetInt("unipallete_r1", color1.r);
        EditorPrefs.SetInt("unipallete_g1", color1.g);
        EditorPrefs.SetInt("unipallete_b1", color1.b);
        EditorPrefs.SetInt("unipallete_a1", color1.a);

        EditorPrefs.SetInt("unipallete_r2", color2.r);
        EditorPrefs.SetInt("unipallete_g2", color2.g);
        EditorPrefs.SetInt("unipallete_b2", color2.b);
        EditorPrefs.SetInt("unipallete_a2", color2.a);

        EditorPrefs.SetInt("unipallete_r3", color3.r);
        EditorPrefs.SetInt("unipallete_g3", color3.g);
        EditorPrefs.SetInt("unipallete_b3", color3.b);
        EditorPrefs.SetInt("unipallete_a3", color3.a);

        EditorPrefs.SetInt("unipallete_r4", color4.r);
        EditorPrefs.SetInt("unipallete_g4", color4.g);
        EditorPrefs.SetInt("unipallete_b4", color4.b);
        EditorPrefs.SetInt("unipallete_a4", color4.a);

        EditorPrefs.SetInt("unipallete_r5", color5.r);
        EditorPrefs.SetInt("unipallete_g5", color5.g);
        EditorPrefs.SetInt("unipallete_b5", color5.b);
        EditorPrefs.SetInt("unipallete_a5", color5.a);

        EditorPrefs.SetInt("unipallete_r6", color6.r);
        EditorPrefs.SetInt("unipallete_g6", color6.g);
        EditorPrefs.SetInt("unipallete_b6", color6.b);
        EditorPrefs.SetInt("unipallete_a6", color6.a);
    }

    void Update()
    {
        if (pallete == null)
        {
            pallete = Resources.Load("Pallete", typeof(Texture2D)) as Texture2D;
        }

        switch (theme)
        {
            case EnumColorPalettesAliases.mastersystem:
                if (pallete.name != "Pallete")
                {
                    pallete = Resources.Load("Pallete", typeof(Texture2D)) as Texture2D;
                    additionColorTitleY = 0;
                }
                break;
            case EnumColorPalettesAliases.gameboycolour:
                if (pallete.name != "Pallete2")
                {
                    pallete = Resources.Load("Pallete2", typeof(Texture2D)) as Texture2D;
                    additionColorTitleY = 8;
                }
                break;
            case EnumColorPalettesAliases.famicom:
                if (pallete.name != "Pallete3")
                {
                    pallete = Resources.Load("Pallete3", typeof(Texture2D)) as Texture2D;
                    additionColorTitleY = 8;
                }
                break;
        }
    }

    void OnGUI()
    {
        GUILayout.Label("UniPallete - version v1.0", EditorStyles.boldLabel);
        GUILayout.Space(20f);
        //DrawBox(new Rect(position1, size), Color.white);
        //DrawBox(new Rect(position2, size), Color.white);
        //DrawBox(new Rect(position3, size), Color.white);
        //DrawBox(new Rect(position4, size), Color.white);
        //DrawBox(new Rect(position5, size), Color.white);
        //DrawBox(new Rect(position6, size), Color.white);

        //DrawBox(new Rect(position1, size), color1);
        //DrawBox(new Rect(position2, size), color2);
        //DrawBox(new Rect(position3, size), color3);
        //DrawBox(new Rect(position4, size), color4);
        //DrawBox(new Rect(position5, size), color5);
        //DrawBox(new Rect(position6, size), color6);
        //DrawPallete();

        //DrawColorTitles();
        GUILayout.Space(20f);
        GUILayout.BeginVertical();

        string[] PieceTypeNames = System.Enum.GetNames(typeof(EnumColor));
        for (int i = 0; i < PieceTypeNames.Length; i++)
        {
            DrawColorLine((EnumColor)i);
        }

        GUILayout.EndVertical();

        GUILayout.BeginHorizontal();
        if (GUILayout.Button(EnumColorPalettesAliases.mastersystem.ToString(), EditorStyles.miniButtonLeft))
        {
            theme = EnumColorPalettesAliases.mastersystem;
        }
        if (GUILayout.Button(EnumColorPalettesAliases.gameboycolour.ToString(), EditorStyles.miniButtonMid))
        {
            theme = EnumColorPalettesAliases.gameboycolour;
        }
        if (GUILayout.Button(EnumColorPalettesAliases.famicom.ToString(), EditorStyles.miniButtonRight))
        {
            theme = EnumColorPalettesAliases.famicom;
        }
        GUILayout.EndHorizontal();
    }

    void DrawColorLine(EnumColor color)
    {
        GUILayout.BeginHorizontal();
        GUILayout.Label(color.ToString());
        color6 = EditorGUILayout.ColorField(GetColor(color));
        if (GUILayout.Button("Colorize"))
        {
            Colorize(color6);
        }
        GUILayout.EndHorizontal();
    }

    void DrawColorTitles()
    {
        GUI.Label(new Rect(new Vector2(position1.x + 10, position1.y + 56 + additionColorTitleY), size), "Color 1", EditorStyles.miniBoldLabel);
        GUI.Label(new Rect(new Vector2(position2.x + 10, position2.y + 56 + additionColorTitleY), size), "Color 2", EditorStyles.miniBoldLabel);
        GUI.Label(new Rect(new Vector2(position3.x + 10, position3.y + 56 + additionColorTitleY), size), "Color 3", EditorStyles.miniBoldLabel);
        GUI.Label(new Rect(new Vector2(position4.x + 10, position4.y + 56 + additionColorTitleY), size), "Color 4", EditorStyles.miniBoldLabel);
        GUI.Label(new Rect(new Vector2(position5.x + 10, position5.y + 56 + additionColorTitleY), size), "Color 5", EditorStyles.miniBoldLabel);
        GUI.Label(new Rect(new Vector2(position6.x + 10, position6.y + 56 + additionColorTitleY), size), "Color 6", EditorStyles.miniBoldLabel);
    }

    void DrawBox(Rect position, Color color)
    {
        Color oldColor = GUI.color;

        GUI.color = color;
        GUI.Box(position, "");


        GUI.color = oldColor;
    }

    void DrawPallete()
    {
        GUILayout.Label(pallete);
    }

    void Colorize(Color color)
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            Camera camera = obj.GetComponent<Camera>();
            Renderer renderer = obj.GetComponent<Renderer>();
            Light light = obj.GetComponent<Light>();
            Text text = obj.GetComponent<Text>();
            Image image = obj.GetComponent<Image>();
            RawImage rawImage = obj.GetComponent<RawImage>();

            if (camera != null)
            {
                camera.backgroundColor = color;
            }
            if (renderer != null)
            {
                renderer.sharedMaterial.color = color;
            }
            if (light != null)
            {
                light.color = color;
            }
            if (text != null)
            {
                text.color = color;
            }
            if (image != null)
            {
                image.color = color;
            }
            if (rawImage != null)
            {
                rawImage.color = color;
            }
        }
    }

    Color black = new Color(1, 1, 0, 1);
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
