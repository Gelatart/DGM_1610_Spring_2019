using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
    
public class EnemyAI : MonoBehaviour
{
   public Transform Player;
   private NavMeshAgent agent;

   void Start()
   {
      agent = GetComponent<NavMeshAgent>();
   }
   
   void Update() //formerly Update, then OnTriggerStay
   {
      agent.destination = Player.position;
   }

   /*void OnTriggerEnter(Collider other) //formerly Update, then OnTriggerStay
   {
      agent.destination = Player.position;
   }

   private void OnTriggerExit(Collider other)
   {
      agent.destination = transform.position;
   }*/
   //If doesn't work the way you want it, change OnTriggerEnter back to Update, get rid of OnTriggerExit?
}