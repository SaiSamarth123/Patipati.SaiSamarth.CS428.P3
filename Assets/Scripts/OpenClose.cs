using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenClose : MonoBehaviour
{
    private Slider mSlider;

    public GameObject Box;

    // Start is called before the first frame update
    void Start()
    {
        mSlider = GetComponent<Slider>();
    }

    public void ApplyAnimation()
    {

        if (Box != null)
        {
            Animator nAnimator = Box.GetComponent<Animator>();
            if(nAnimator)
            {
                nAnimator.SetFloat("OpenCloseValue", mSlider.value);
            }
        }
    }
}
