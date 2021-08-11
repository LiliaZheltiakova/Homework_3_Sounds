using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteIconSwap : MonoBehaviour
{
    [SerializeField] private Sprite muteIcon;
    [SerializeField] private Sprite unmuteIcon;
    private Sprite currentSprite;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchIcons(Image ImageToSwap)
    {
        currentSprite = ImageToSwap.GetComponent<Image>().sprite;
        if(currentSprite == muteIcon)
        {
            ImageToSwap.GetComponent<Image>().sprite = unmuteIcon;
            currentSprite = unmuteIcon;
            return;
        }

        ImageToSwap.GetComponent<Image>().sprite = muteIcon;
        currentSprite = muteIcon;
    }
}
