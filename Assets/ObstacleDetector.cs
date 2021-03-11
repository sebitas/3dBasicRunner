using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collisionInfo)
    {
      if (collisionInfo.gameObject.name == "Player");
      {
        SceneManager.LoadScene(0);
      }
    }
}
