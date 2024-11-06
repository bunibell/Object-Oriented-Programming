using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "NewCard", menuName = "ScriptableObjects/Cards", order = 0)]

public class CardOBJ : ScriptableObject
{
    //Declare the Variables Used in our ScriptableObject
    public int startHealth;
    public string CardName;
    public Sprite CardImage;
    public string CardDescription;
    public int Attack;
    public int Health;
    public CardOBJ nextCard;
}
