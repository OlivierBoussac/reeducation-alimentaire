using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

[Serializable]
public class NutritionData
{
    public List<Nutrition> Nutritions;

    public NutritionData()
    {
        Nutritions = new List<Nutrition>();
    }
}
