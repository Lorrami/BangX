using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;

public class RolesDistribution : MonoBehaviour
{
    private static readonly List<string> RolesListForFour = new List<string>() {"Шериф", "Мафия", "Ренегат", "Мирный"};
    private static readonly System.Random Rnd = new System.Random();
    private static int randomSize = 4;
    public static void RolesForFour(ref string role)
    {
        var t = Rnd.Next(0, randomSize);
        role = RolesListForFour[t];
        RolesListForFour.Remove(RolesListForFour[t]);
        randomSize--;
    }
}
