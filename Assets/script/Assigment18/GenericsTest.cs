using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    void Start()
    {
        GameContainer<string> gameContainer = new GameContainer<string>();
        gameContainer.SetItem("Healing Postion");
        gameContainer.GetItem();
        
        Debug.Log(GameUtils.DescribeItem<string>(gameContainer.GetItem()));
    }


}
