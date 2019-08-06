﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DataController : MonoBehaviour
{
    private int m_Move = 0;
    private int m_ClickMove = 0;
    private int m_slider = 0;


    private void Awake()
    {
        m_Move = PlayerPrefs.GetInt("Move");
        m_ClickMove = PlayerPrefs.GetInt("ClickMove", 1);
        m_slider = PlayerPrefs.GetInt("Slider");
    }

    public void SetMove(int newMove)
    {
        m_Move = newMove;
        PlayerPrefs.SetInt("Move", m_Move);

    }
    public void AddMove(int newMove)
    {
        m_Move += newMove;
        SetMove(m_Move);
    }
    public void SubMove(int newMove)
    {
        m_Move -= newMove;
        SetMove(m_Move);
    }
    public int GetMove()
    {
        return m_Move;
    }
    public int GetClickMove()
    {
        return m_ClickMove;
    }
    public void SetClickMove(int newClickMove)
    {
        m_ClickMove = newClickMove;
        PlayerPrefs.SetInt("ClickMove", m_ClickMove);
    }
     public void SetSlider(int newSlider)
    {
        m_slider = newSlider;
        PlayerPrefs.SetInt("Slider", m_slider);

    }
    public void AddSlider(int newSlider)
    {
        m_slider += newSlider;
        SetSlider(m_slider);
    }
    public int GetSlider()
    {
        return m_slider;
    } 

}
