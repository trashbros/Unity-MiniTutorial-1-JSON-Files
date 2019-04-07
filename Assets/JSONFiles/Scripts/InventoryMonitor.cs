using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityTutorials
{
    public class InventoryMonitor : MonoBehaviour
    {     
        [Header("Usables")]
        public string[] usableItemNames;
      
        [Header("Collectables")]
        public string[] collectableItemNames;
      
        [Header("Macguffins")]
        public string[] keyItemNames;
        
        [Header("Item References")]
        public TextAsset usableItems;
        public TextAsset collectableItems;
        public TextAsset keyItems;

        private ItemDatabase usables;
        private ItemDatabase collectables;
        private ItemDatabase keys;

        void Awake()
        {
            usables = ItemDatabase.CreateFromJSON(usableItems.text);
            usableItemNames = new string[usables.items.Length];
            collectables = ItemDatabase.CreateFromJSON(collectableItems.text);
            collectableItemNames = new string[collectables.items.Length];
            keys = ItemDatabase.CreateFromJSON(keyItems.text);
            keyItemNames = new string[keys.items.Length];
        }
      
        // Use this for initialization
        void Start()
        {
            for (int i = 0; i < usables.items.Length; i++)
            {
                usableItemNames[i] = usables.items[i].name;
            }

            for (int i = 0; i < collectables.items.Length; i++)
            {
                collectableItemNames[i] = collectables.items[i].name;
            }

            for (int i = 0; i < keys.items.Length; i++)
            {
                keyItemNames[i] = keys.items[i].name;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
