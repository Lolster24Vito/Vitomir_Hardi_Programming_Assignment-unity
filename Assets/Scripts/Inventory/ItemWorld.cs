﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWorld : MonoBehaviour
{ 
    // Start is called before the first frame update
    [SerializeField] private Item _item;

    [SerializeField] private int _amount;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        if(_item!=null)
        _spriteRenderer.sprite = _item.Icon;
    }
    public Item GetItem()
    {
        return _item;
    }
    public void SetItem(Item item)
    {
        _item = item;
        _spriteRenderer.sprite = _item.Icon;

    }
    public int GetAmount()
    {
        return _amount;
    }
    public void SetAmount(int amount)
    {
        _amount = amount;
    }
    
}
