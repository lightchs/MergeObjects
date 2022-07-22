using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "ObjectCreator", menuName = "Test/ObjectCreator", order = 0)]
    public class ObjectCreatorScriptableObject : ScriptableObject
    {
        public ScoreController scoreController;
        public  Dictionary<EntityType, GameObject> textureDict;
        public  Dictionary<EntityType, Vector2> textureCenters;
        public GameObject CoinObject;
        public GameObject CornObject;
        public GameObject BabyCornObject;
        public GameObject BadDoghouseObject;
        public GameObject DoghouseObject;

        public void OnEnable()
        {
            textureDict = new Dictionary<EntityType, GameObject>(){
                { EntityType.Corn, CornObject},
                { EntityType.BabyСorn, BabyCornObject},
                { EntityType.Coin, CoinObject},
                { EntityType.ВadDoghouse, BadDoghouseObject},
                { EntityType.Doghouse, DoghouseObject},
            };
        }

        public GameObject GetObGameObject(EntityType eType)
        {
            return  textureDict[eType];
        }
        
    }
}