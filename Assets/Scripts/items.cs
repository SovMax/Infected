using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item
{
    public static string title { get; set; }
    public float hp { get; set; }
}

public class Food : item
{
    public static float increaceHunger { get; set; }
    public static float increaceThirst { get; set; }
}

public class MidKit : item
{
    public static float increaceMind { get; set; }
    public static float increaceHp { get; set; }

    private static string[] effects = new string[] { };

    public static string getEffect(int index)
    {
        return effects[index];
    }

    public static void setEffect(int index, string inputEffect)
    {
        effects[index] = inputEffect;
    }
}

public class Weapon : item
{
    public static float damage { get; set; }
}

public class Other : item { }
