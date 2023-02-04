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

public class colorBoxManager : MonoBehaviour
{
    
    private Image colorBox;
    int random;
    Color color;
    void Start()
    {
        colorBox= GetComponent<Image>();
        changeColor();
    }

    void changeColor()
    {
        random = Random.Range(0, 50);
        if(random<=10)
        {
            color = Color.magenta;
        }
        else if (random <= 20)
        {
            color = Color.yellow;
        }
        else if(random <= 30)
        {
            color = Color.green;
        }
        else if(random <= 40)
        {
            color = Color.red;
        }
        else if(random <= 50)
        {
            color = Color.cyan;
        }
        colorBox.color = color;
    }
    
}
