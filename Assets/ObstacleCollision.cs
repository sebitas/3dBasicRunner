﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
      if (collision.transform.CompareTag("Player"))
      {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      }
    }
}
