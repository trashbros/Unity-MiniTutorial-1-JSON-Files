using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;
using System;

/// Scripts for loading and storing and reading json data for items
namespace UnityTutorials
{
	[Serializable]
    public class ItemDatabase
    {
        public Item[] items;
        public static ItemDatabase CreateFromJSON(string jsonString)
        {
        	return JsonUtility.FromJson<ItemDatabase>(jsonString);
        }
    }
    
	[Serializable]
    public class Item
    {
        public string name = "";
        public string desc = "";
        public string sprite = "";
        public string action = "";
    }
}