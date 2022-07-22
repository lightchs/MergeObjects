using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    public  Dictionary<EntityType, GameObject> textureDict;
    public  Dictionary<EntityType, Vector2> textureCenters;
    public GameObject CoinObject;
    public GameObject CornObject;
    public GameObject BabyCornObject;
    public GameObject BadDoghouseObject;
    public GameObject DoghouseObject;

    public void Awake()
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
