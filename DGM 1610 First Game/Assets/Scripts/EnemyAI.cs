using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
    
public class EnemyAI : MonoBehaviour
{
   public Transform Player;
   private NavMeshAgent agent;

   public UnityEvent IdleEvent, TrackingEvent, ConfusedEvent, DestroyedEvent;
    
   public enum States
   {
      Idle,
      Tracking,
      Confused,
      Destroyed
   }
    
   public States CurrentState;
   
   void Start()
   {
      agent = GetComponent<NavMeshAgent>();
   }
   
   void Update() //formerly Update, then OnTriggerStay
   {
      if(CurrentState == States.Tracking)
      {
         agent.destination = Player.position;
      }
      switch (CurrentState)
      {
         case States.Idle:
            IdleEvent.Invoke();
            break;
         case States.Tracking:
            TrackingEvent.Invoke();
            break;
         case States.Confused:
            ConfusedEvent.Invoke();
            break;
         case States.Destroyed:
            DestroyedEvent.Invoke();
            break;
         default:
            throw new ArgumentOutOfRangeException();

      }
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