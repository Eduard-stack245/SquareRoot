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
using UnityEngine.SceneManagement;
using DG.Tweening;  

public class LearnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject playButton, backButton, fadePanel;
    [SerializeField]
    private GameObject squareRootPrefab;
    [SerializeField]
    private Transform content;
    [SerializeField]
    private Sprite[] squareRootImages, squareRootOuts;
    [SerializeField]
    private Image answerImage;
    [SerializeField]
    private Text learnTxt;
    
    void Start()
    {
        learnTxt.text = "";
        fadePanel.SetActive(true);
        playButton.GetComponent<RectTransform>().localScale = Vector3.zero;
        backButton.GetComponent<RectTransform>().localScale = Vector3.zero;
        fadePanel.GetComponent<CanvasGroup>().DOFade(0, 1f).OnComplete(firstSettings);
        answerImage.sprite = squareRootOuts[0];
        
    }
    void firstSettings()
    {
        learnTxt.text = "Click square roots to see their result.";
        
        fadePanel.SetActive(false);
        scaleButtons();
        generateSquareRoots();
    }
    public void goBack()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void play()
    {
        SceneManager.LoadScene("GameScene");
    }
    void scaleButtons()
    {
        playButton.GetComponent<RectTransform>().DOScale(1, 1f).SetEase(Ease.OutBack);
        backButton.GetComponent<RectTransform>().DOScale(1, 1f).SetEase(Ease.OutBounce);
    }

    void generateSquareRoots()
    {
        for (int i = 0; i < squareRootImages.Length; i++)
        {
            GameObject item = Instantiate(squareRootPrefab, content);
            item.GetComponent<squareRootButtonManager>().buttonNo = i;
            item.transform.GetChild(3).GetComponent<Image>().sprite = squareRootImages[i];
        }
        
    }
    public void showAnswer(int buttonNo)
    {
        answerImage.sprite = squareRootOuts[buttonNo];
    }
}
