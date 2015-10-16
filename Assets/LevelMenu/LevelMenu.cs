﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelMenu : MonoBehaviour
{
  public List<string> LevelNames;
  public GameObject itemPrefab;

  // Use this for initialization
  void Start()
  {
    Vector3 position = new Vector3(0, 0, 0);

    foreach (string name in LevelNames)
    {
      GameObject item = Instantiate(itemPrefab, position, Quaternion.identity) as GameObject;
      item.transform.parent = gameObject.transform;

      position.y += .3f;
    }
  }

  // Update is called once per frame
  void Update()
  {

  }
}