using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
   private float health = 10f;
   
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
   }
}
