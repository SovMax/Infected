using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour
{
    private static float health;
    private static float hunger;
    private static float thirst;
    private static float mind;

    public static float getHealth()
    {
        return health;
    }

    public static float getHunger()
    {
        return hunger;
    }

    public static float getThirst()
    {
        return thirst;
    }

    public static float getMind()
    {
        return mind;
    }

    void Start() { }

    void Update() { }
}
