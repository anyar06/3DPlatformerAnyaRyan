using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour
{
     public void PlayGame()
     {
         UnityEngine.SceneManagement.SceneManager.LoadScene(1);
     }
     public void QuitGame()
     {
         Application.Quit();
     }

     public void HelpMenu()
     {
         UnityEngine.SceneManagement.SceneManager.LoadScene(2);
     }

     public void BackToMenu()
     {
         UnityEngine.SceneManagement.SceneManager.LoadScene(0);
     }
}


