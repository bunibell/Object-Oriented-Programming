using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class CardManager : MonoBehaviour
{
    //Variables 
    public SpriteRenderer cardPic;
    public CardOBJ currentcard;
    public TextMeshProUGUI cardName;
    public TextMeshProUGUI cardDesc;
    public TextMeshProUGUI Health;
    public List<CardOBJ> cards = new List<CardOBJ>();
    private UnityEngine.Object[] loadcards;

    // Start is called before the first frame update
    void Start()
    {
        loadcards = Resources.LoadAll<CardOBJ>("ScriptableObjects/Cards");
        foreach (CardOBJ c in loadcards)
        {
            c.Health = c.startHealth;
            cards.Add(c);
        }

    }

    // Update is called once per frame
    void Update()
    {
        cardPic.sprite = currentcard.CardImage;
        cardDesc.text = currentcard.CardDescription;
        cardName.text = currentcard.CardName;
        Health.text = " " + currentcard.Health;
        if (Input.GetKeyDown(KeyCode.E))
        {
            currentcard = currentcard.nextCard;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            currentcard.Health -= currentcard.nextCard.Attack;
        }
    }
}
