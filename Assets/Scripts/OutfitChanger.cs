using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitChanger : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer bodyPart;

    [SerializeField]
    private List<Sprite> options = new List<Sprite>();

    private int optionSelected = 0;

    public void NextOption()
    {
        optionSelected++;

        if (this.optionSelected >= this.options.Count)
        {
            this.optionSelected = 0;
        }

        bodyPart.sprite = options[this.optionSelected];
    }

    public void PreviousOption()
    {
        optionSelected--;

        if (this.optionSelected <= this.options.Count)
        {
            this.optionSelected = this.options.Count - 1;
        }

        bodyPart.sprite = options[this.optionSelected];
    }
}
