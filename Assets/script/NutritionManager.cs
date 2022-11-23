using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class NutritionManager : MonoBehaviour
{

    public TextAsset textJSON;
    private NutritionData nutritionData;

    //private void Awake()
    //{
    //    var json = PlayerPrefs.GetString("Nutritions", "{}");
    //    nutritionData = JsonUtility.FromJson<NutritionData>(json);
    //}



    public Nutrition GetNutrition(string Aliment)
    {
        getJSON();
        IEnumerable<Nutrition> nutritions = nutritionData.Nutritions.OrderByDescending(x => x.AlimentName);
        foreach(Nutrition nutrition in nutritions) 
        {
            //Debug.Log(nutrition.AlimentName);
            if(nutrition.AlimentName == Aliment)
            {
                return nutrition;
            }
        }
        return null;
    }

    //public void AddNutrition(Nutrition nutrition)
    //{
    //    nutritionData.Nutritions.Add(nutrition);
    //    SaveNutrition();
    //}

    //public void SaveNutrition()
    //{
    //    var json = JsonUtility.ToJson(nutritionData);
    //    string filePath = Application.persistentDataPath + "/Nutritions.json";
    //    Debug.Log(filePath);
    //    System.IO.File.WriteAllText(filePath, json);
    //}

    public void getJSON()
    {
        nutritionData = JsonUtility.FromJson<NutritionData>(textJSON.text);
    }
}
