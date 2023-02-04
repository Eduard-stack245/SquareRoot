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

public class FinalManager : MonoBehaviour
{
    [SerializeField]
    private Text trueText, falseText, scoreText;
    [SerializeField]
    private GameObject finalImage, backButton, trueFalseImage, scoreImage, timeImage, QACircle;
    private void OnEnable()
    {
        backButton.SetActive(false);
        trueFalseImage.SetActive(false);
        scoreImage.SetActive(false);
        timeImage.SetActive(false);
        QACircle.SetActive(false);
        finalImage.transform.DOLocalMove(Vector3.zero, 0.5f).SetEase(Ease.OutBack);
        finalImage.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
    }
    void Start()
    {
        
    }
    public void playAgain()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void placeInfos(int trueCount, int falseCount, int score)
    {
        trueText.text = trueCount.ToString() + " TRUE";
        falseText.text = falseCount.ToString() + " FALSE";
        scoreText.text = score.ToString() + " SCORE";

    }

}
