using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    private static float health;
    private static float hunger;
    private static float thirst;
    private static float mind;

    public static float Health
    {
        get { return health; }
        set { health = value; }
    }
    public static float Hunger
    {
        get { return hunger; }
        set { hunger = value; }
    }
    public static float Thirst
    {
        get { return thirst; }
        set { thirst = value; }
    }
    public static float Mind
    {
        get { return mind; }
        set { mind = value; }
    }

    void Start() { }

    void Update() { }
}
