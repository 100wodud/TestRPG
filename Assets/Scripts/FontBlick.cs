using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FontBlick : MonoBehaviour
{
    public TextMeshProUGUI text;
    public LoopType loopType;

    // Start is called before the first frame update
    void Start()
    {
        text.DOFade(0, 1f).SetLoops(-1, loopType);
    }

}
