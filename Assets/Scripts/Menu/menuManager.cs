//--------------------------Eduard--Babii------------------------------------\\
//   Copyright © 2022 Babii Eduard.All rights reserved.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
//--------------------------Eduard--Babii------------------------------------\\

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class menuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject aboutPanel;
    //private GameObject playButton, exitButton, aboutMeButton;
    bool isOpen;
    
    void Start()
    {
        Debug.Log("start menu");
        aboutPanel.GetComponent<CanvasGroup>().DOFade(0, 0.5f);
        isOpen = false;
    }
    public void aboutUsButton()
    {
        Debug.Log("about bttn");
        if (!isOpen)
        {
            aboutPanel.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
            isOpen = true;
        }
        else
        {
            aboutPanel.GetComponent<CanvasGroup>().DOFade(0, 0.5f);
            isOpen = false;
        }
        
    } 
    public void exitButton()
    {
        Debug.Log("exit bttn");
        Application.Quit();
    }
    public void playButton()
    {
        Debug.Log("play bttn");
        SceneManager.LoadScene("LearnScene");
    }
}
