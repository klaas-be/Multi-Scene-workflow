﻿using UnityEngine;

[CreateAssetMenu(fileName = "NewLevel", menuName = "Scene Data/Level")]
public class Level : GameScene
{
    //Settings specific to level only
    [Header("Level")]
    public float timer;
}
