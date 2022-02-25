using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    [SerializeField]
    private GameObject startBtn, exitBtn;

    
    void Start()
    {
       FadeOut(); 
    }

   
   private void FadeOut(){
       startBtn.GetComponent<CanvasGroup>().DOFade(1, 0.8f);
       exitBtn.GetComponent<CanvasGroup>().DOFade(1, 0.8f).SetDelay(0.5f);
   }

   public void ExitGame(){
       Application.Quit();
   }

   public void StartGameLevel(){
       SceneManager.LoadScene("GameLevel");
   }
}
