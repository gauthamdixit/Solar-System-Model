using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System;
using AASharp;





public class solar : MonoBehaviour
{
    public TextAsset csvFile;
    public string[] fieldsDebug;

    private indexData[] indexArray;
    int i = 0;
    private char lineSeperater = '\n';
    private char fieldSeperator = ',';
    public string[] records;
    public struct indexData
    {
       public int index;
       public string name;
    }

    

    // Read data from CSV file
    private void readData()
    {
     
        records = csvFile.text.Split (lineSeperater);
        indexArray = new indexData[records.Length - 1];
        int x = 0;
        foreach (string record in records)
        {
            string[] fields = record.Split(fieldSeperator);
            indexData key = new indexData();
            key.index = x;
            key.name = fields[0];
            indexArray[x] = key;
            if(x!= record.Length-1)
                x++;
        }
        double q = AASElementsPlanetaryOrbit.EarthEccentricity(1);


    }
    public string getPlanetInfoString(string name)
    {
        string info = records[GetKey(name)];
        return info;
    }

    private static string getPath()
    {
       #if UNITY_EDITOR
       return Application.dataPath;
       #elif UNITY_ANDROID
       return Application.persistentDataPath;// +fileName;
       #elif UNITY_IPHONE
       return GetiPhoneDocumentsPath();// +"/"+fileName;
       #else
       return Application.dataPath;// +"/"+ fileName;
       #endif
    }
    public string GetName(int key)
    {
        //int x = int.Parse(input.text);
        //text.text = "\""+indexArray[key].name + "\"";
        return indexArray[key].name;
    }
    public int GetKey(string name)
    {
        //string nameField = input.text;
        foreach (indexData data in indexArray)
        {
            if (data.name == name)
            {
                //text.text = data.index.ToString();
                return data.index;
            }
        }
        return -1;
    }

    void Start()
    {
        readData();
    }
    void Update()
    {
        //if (Input.GetKeyDown("p"))
        //{
        //    Debug.Log(getPlanetInfoString("14 Her"));
        //}
    }

}