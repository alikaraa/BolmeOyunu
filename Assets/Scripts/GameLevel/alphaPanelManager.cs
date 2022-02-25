using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class alphaPanelManager : MonoBehaviour
{

    public GameObject alphaPanel;

    
    void Start()
    {
        alphaPanel.GetComponent<CanvasGroup>().DOFade(0, 2f);
    }
}
