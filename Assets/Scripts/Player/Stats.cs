using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
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

    public static float setHealth(float inputValues)
    {
        return health = inputValues;
    }

    public static float setHunger(float inputValues)
    {
        return hunger = inputValues;
    }

    public static float setThirst(float inputValues)
    {
        return thirst = inputValues;
    }

    public static float setMind(float inputValues)
    {
        return mind = inputValues;
    }

    void Start() { }

    void Update() { }
}
