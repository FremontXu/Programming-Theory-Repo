using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Son : Father
{

    protected override void ShowInf()
    {
        gameManager.console.text = "Son Object";
    }

}
