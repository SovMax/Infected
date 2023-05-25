using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyBinds
{
    public static string[] defaultMovementKeys = new string[]
    {
        "w",
        "a",
        "s",
        "d",
        "shift",
        "ctrl"
    };

    public static string moveAhead { get; set; } = "w";
    public static string moveLeft { get; set; } = "a";
    public static string moveBack { get; set; } = "s";
    public static string moveRight { get; set; } = "d";
    public static string sprint { get; set; } = "shift";
    public static string sit { get; set; } = "ctrl";
}
