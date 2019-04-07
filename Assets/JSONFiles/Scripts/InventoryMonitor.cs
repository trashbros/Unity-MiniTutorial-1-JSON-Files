using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityTutorials
{
    public class InventoryMonitor : MonoBehaviour
    {     
        [Header("Usables")]
        public string[] usableItemNames;
             
        [Header("Item References")]
        public TextAsset usableItems;

        private ItemDatabase usables;

        void Awake()
        {
            usables = ItemDatabase.CreateFromJSON(usableItems.text);   // Read in our Json file
            usableItemNames = new string[usables.items.Length];        // Instantiate our names array
            // Iterates through our items and populates the names array with the name of each item
            for (int i = 0; i < usables.items.Length; i++)
            {
                usableItemNames[i] = usables.items[i].name;
            }
        }
    }
}
