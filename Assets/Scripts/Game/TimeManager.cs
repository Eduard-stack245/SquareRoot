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
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    int timer = 90;
    [SerializeField]
    private Text timeText;
    [SerializeField]
    private GameObject finalPanel;
    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip finishClip;
    FinalManager finalManager;
    GameManager gameManager;
    private void Awake()
    {
        
        gameManager = Object.FindObjectOfType<GameManager>();
    }

    public IEnumerator startTime()
    {
        for(int i = timer; i>=0; i--)
        {
           
            if(i<10)
            {
                timeText.text = "0" + i.ToString();
                yield return new WaitForSeconds(1f);
            }
            else
            {
                 timeText.text = i.ToString();
                timeText.color = Color.red;
                 yield return new WaitForSeconds(1f);
            }
            if(i==1)
            {
                audioSource.PlayOneShot(finishClip);
            }
            if(i==0)
            {
                
                finalPanel.SetActive(true);
                
                if(finalPanel!=null)
                {
                    finalManager = Object.FindObjectOfType<FinalManager>();
                    
                    finalManager.placeInfos(gameManager.trueCounter, gameManager.falseCounter, gameManager.totalScore);
                }
                
            }
        }
    }
}
