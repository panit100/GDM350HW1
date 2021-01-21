using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CalculateManager : MonoBehaviour
{
    public TMP_InputField Exp;
    public TMP_InputField Level;
    public GameObject Error;
    int inputLevel = 0;
    int OutputExp = 0;
    
    int inputExp = 0;
    int OutputLevel = 0;

    public void CalculateLeveltoExp(){
        if(Level.text != null && Level.text != ""){
            inputLevel = Convert.ToInt32(Level.text);
        }

        if(Level.text == "" || inputLevel > 20000 || inputLevel < 0){
            Error.SetActive(true);
            return;
        }

        if(Level.text != "" && inputLevel <= 20000 && inputLevel >= 0){
            if(inputLevel > 0 && inputLevel <= 16){
            OutputExp = (inputLevel * inputLevel) + (6 * inputLevel);
            }else
            if(inputLevel > 16 && inputLevel <= 31){
            OutputExp = (int)((2.5 * (inputLevel*inputLevel)) - (inputLevel * 40.5) + 360);
            }else
            if(inputLevel > 31){
            OutputExp = (int)((4.5 * (inputLevel*inputLevel)) - (inputLevel * 162.5) + 2220);
            }
            Error.SetActive(false);
        }
        Exp.text = OutputExp.ToString();
    }

    
    public void CalculateExptoLevel(){
        int currentLevel = 0;
        if(Exp.GetComponent<TMP_InputField>().text != null){
            inputExp = Convert.ToInt32(Exp.GetComponent<TMP_InputField>().text);
        }

        if(inputExp < 0){
            Error.SetActive(true);
            return;
        }
        
        for(int currentExp = inputExp; currentExp >= 0;currentLevel++){
            if(currentLevel <= 15){
                if(currentExp < ((2 * currentLevel) + 7)){
                    OutputLevel = currentLevel;
                    break;
                }
            }else if(currentLevel > 15 && currentLevel <= 30){
                    if(currentExp < ((5 * currentLevel) - 38)){
                    OutputLevel = currentLevel;
                    break;

            }
            }else if(currentLevel > 30){
                    if(currentExp < ((9 * currentLevel) - 158)){
                    OutputLevel = currentLevel;
                    break;
                }
            }

            if(currentLevel <= 15){
                currentExp -= (2 * currentLevel) + 7;
            }else if(currentLevel > 15 && currentLevel <= 30){
                currentExp -= (5 * currentLevel) -38;
            }else if(currentLevel > 30){
                currentExp -= (9 * currentLevel) -158;
            }
        }
        Error.SetActive(false);
        Level.text = OutputLevel.ToString();
    }
}