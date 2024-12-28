using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playknopka : MonoBehaviour
{
   public void PlayButtonLoadScene()
    {
        SceneManager.LoadScene("gaym");
    }
}
