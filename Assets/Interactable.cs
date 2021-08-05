using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.Mathematics;
using UnityEngine;

public class Interactable : MonoBehaviour
{
   private float health = 10f;
   private GameObject woodPrefab;
   private Transform spawnTransform;

   private void Start()
   {
      var loadedPrefab = LoadPrefabFromFile();
      woodPrefab = loadedPrefab as GameObject;
      spawnTransform = GameObject.Find("SpawnTransform").GetComponent<Transform>();
   }
   private UnityEngine.Object LoadPrefabFromFile()
   {
      //Debug.Log("Trying to load Prefab from file ("+filename+ ")...");
      var loadedObject = Resources.Load("Prefabs/Wood");
      if (loadedObject == null)
      {
         throw new FileNotFoundException("...no file found - please check the configuration");
      }
      return loadedObject;
   }

   // I've been hit, now do something
   public void Interact(GameObject tool)
   {
      if (tool.gameObject.CompareTag("Axe"))
      {
         //take damage
         TakeDamage();
      }
   }

   void TakeDamage()
   {
      health -= 2f;
      Mathf.Clamp(health, 0f,10f);
      if (health <= 0)
      {
         //get destroyed and drop items
         DropItems();
         Die();
      }
   }

   void Die()
   {
      Destroy(gameObject);
   }

   void DropItems()
   {
      //instantiate wood prefabs
      Instantiate(woodPrefab, spawnTransform.position, quaternion.identity);
   }
}
