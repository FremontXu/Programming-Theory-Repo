using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daughter : Father
{
    protected override void ShowInf()
    {
        gameManager.console.text = "Daughter Object";
    }
}
