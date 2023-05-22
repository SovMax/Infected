using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public static float Health { get; set; }
    public static float Hunger { get; set; }
    public static float Thirst { get; set; }
    public static float Mind { get; set; }

    public static float DefaulQuantityHealth { get; set; } = 2000;
    public static float DefaulQuantityHunger { get; set; } = 3000;
    public static float DefaulQuantityThirst { get; set; } = 4000;
    public static float DefaulQuantityMind { get; set; } = 5000;
}
