//using System;
//using System.Collections;

using System;
using System.Collections.Generic;
using DefaultNamespace;
using Unity.Mathematics;
using UnityEngine;
//using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using UnityEngine.Audio;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Collections.ObjectModel;

public class DrugObj: MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
   public ObjectCreatorScriptableObject Creator;
   public MatchEntity SelfEntity;
   private Vector2 mousePosition;
   private float offsetX, offsetY;
   public static bool ButtonReleased;

   private void OnTriggerStay2D(Collider2D collision)
   {
      if (ButtonReleased && SelfEntity.EntityType == collision.gameObject.GetComponent<MatchEntity>().EntityType)
      {
         
         var obGameObject = Creator.GetObGameObject(SelfEntity.Upgrade());
         Instantiate((obGameObject), transform.position, Quaternion.identity);
         ButtonReleased = false;
         Destroy(collision.gameObject);
         Destroy(gameObject);
      }
   }

   public void OnDrag(PointerEventData eventData)
   {
      mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
      transform.position = new Vector2(mousePosition.x - offsetX, mousePosition.y - offsetY);
   }

   public void OnPointerDown(PointerEventData eventData)
   {
      ButtonReleased = false;
      offsetX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
      offsetY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
   }

   public void OnPointerUp(PointerEventData eventData)
   {
      ButtonReleased = true;
   }

   public void OnPointerClick(PointerEventData eventData)
   {
      if (SelfEntity.EntityType == EntityType.Coin)
      {
         Creator.scoreController.AddScore(1); 
         Destroy(gameObject);
      }
   }
   
}

   