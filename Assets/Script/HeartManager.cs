using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartManager : MonoBehaviour
{
    [SerializeField] public Image[] hearts;
    [SerializeField] public Sprite fullHeart;
    [SerializeField] public Sprite emptyHeart;
    [SerializeField] public Sprite halffullHeart;
    [SerializeField] public FloatValue HeartContainer;
    [SerializeField] public FloatValue playerCurrenthealth;
    public GameEvent onPlayerDeath;
    bool isAttack;


    void Start()
    {
        FillHeart();
    }

    public void FillHeart()
    {
        for (int i = 0; i < HeartContainer.initialValue; i++)
        {
            hearts[i].gameObject.SetActive(true);
            hearts[i].sprite = fullHeart;
        }
    }
    public void Updatehearts()
    {
        float tempHealth = playerCurrenthealth.RuntimeValue; // /2;

        // for (int i = 0;i < HeartContainer.initialValue; i++)
        // {
        //     if (i <= tempHealth - 1)
        //     {
        //         hearts[i].sprite = FullHeart;
        //     } else if (i > tempHealth)
        //     {
        //         hearts[i].sprite= emptyHeart;
        //     } else 
        //     {
        //         hearts[i].sprite = halffullHeart;
        //     }
        // }

        if(isAttack)
        {
            tempHealth = 7;
            isAttack = false;
        }

        if(tempHealth == 7)
        {
            hearts[3].sprite = halffullHeart;
        }
        if(tempHealth == 6)
        {
            hearts[3].sprite = halffullHeart;
            hearts[3].sprite = emptyHeart;
        }
        if(tempHealth == 5)
        {
            hearts[3].sprite = halffullHeart;
            hearts[3].sprite = emptyHeart;
            hearts[2].sprite = halffullHeart;
        }
        if(tempHealth == 4)
        {
            hearts[3].sprite = halffullHeart;
            hearts[3].sprite = emptyHeart;
            hearts[2].sprite = halffullHeart;
            hearts[2].sprite = emptyHeart;
        }
        if(tempHealth == 3)
        {
            hearts[3].sprite = halffullHeart;
            hearts[3].sprite = emptyHeart;
            hearts[2].sprite = halffullHeart;
            hearts[2].sprite = emptyHeart;
            hearts[1].sprite = halffullHeart;
        }
        if(tempHealth == 2)
        {
            hearts[3].sprite = halffullHeart;
            hearts[3].sprite = emptyHeart;
            hearts[2].sprite = halffullHeart;
            hearts[2].sprite = emptyHeart;
            hearts[1].sprite = halffullHeart;
            hearts[1].sprite = emptyHeart;
        }
        if(tempHealth == 1)
        {
            hearts[3].sprite = halffullHeart;
            hearts[3].sprite = emptyHeart;
            hearts[2].sprite = halffullHeart;
            hearts[2].sprite = emptyHeart;
            hearts[1].sprite = halffullHeart;
            hearts[1].sprite = emptyHeart;
            hearts[0].sprite = halffullHeart;
        }

        if(tempHealth < 1)
        {
            onPlayerDeath.Raise();
        }
    }

    public void InitialAttackOnPlayer()
    {
        isAttack = true;
        Updatehearts();
    }
}
