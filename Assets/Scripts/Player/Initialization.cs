using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initialization : MonoBehaviour
{
    public static float defaulQuantityHealth = 1000;
    public static float defaulQuantityHunger = 1000;
    public static float defaulQuantityThirst = 1000;
    public static float defaulQuantityMind = 1000;

    public static float getDefailtQuantityHealth()
    {
        return defaulQuantityHealth;
    }

    public static float getDefailtQuantityHunger()
    {
        return defaulQuantityHunger;
    }

    public static float getDefailtQuantityThirst()
    {
        return defaulQuantityThirst;
    }

    public static float getDefailtQuantityMind()
    {
        return defaulQuantityMind;
    }

    public static void getStartValues()
    {
        Stats.Health = getDefailtQuantityHealth();
        Stats.Hunger = getDefailtQuantityHunger();
        Stats.Thirst = getDefailtQuantityThirst();
        Stats.Mind = getDefailtQuantityMind();
    }

    // Start is called before the first frame update
    void Start()
    {
        getStartValues();
    }

    // Update is called once per frame
    void Update() { }
}
