using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initialization : MonoBehaviour
{
    public static void setStartValues()
    {
        Stats.Health = Stats.DefaulQuantityHealth;
        Stats.Hunger = Stats.DefaulQuantityHunger;
        Stats.Thirst = Stats.DefaulQuantityThirst;
        Stats.Mind = Stats.DefaulQuantityMind;
    }

    // Start is called before the first frame update
    void Start()
    {
        setStartValues();
    }

    // Update is called once per frame
    void Update() { }
}
