using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Collection : ScriptableObject
{

   public List<Object> CollectionList;
   
   public void Collect(Object obj)
   {
       CollectionList.Add(obj);
   }
   
   public void CollectionInfo() 
   {
       foreach (var obj in CollectionList)
       {
           Debug.Log(obj);
       }
   }

   public void AmmoInfo()
   {
       foreach (var obj in CollectionList)
       {
           if(obj.name == "Ammo")
           {
               Debug.Log("We have ammo");
               Debug.Log("We have " + obj.Value + " ammo.");
               //AFTER TESTING: Change "We have ammo" to "We Have " + obj.Value + " ammo."
           }
       }
   }

   public void FuelInfo()
   {
       for (int i = 0; i < 10; i++)
       //AFTER TESTING: change "i < 10" to "i < CollectionList.Count"
       {
           Debug.Log(i);
           if (CollectionList[i].name == "Fuel")
           {
               Debug.Log(CollectionList[i]);
           }
          
           //AFTER TESTING: Change the debug log to "Debug.Log(CollectionList[i]);"
           //Then put debug log inside "if(CollectionList[i].name == "Fuel") {}"
       }
   }
   
}