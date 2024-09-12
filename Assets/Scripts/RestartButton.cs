using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{

    public void RestartGame()
    {

        ScoreManager.Instance.ResetScore();

        SceneManager.LoadScene("Game");


   

    }




}
