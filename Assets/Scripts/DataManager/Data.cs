using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Data
{
    [SerializeField] private float highestDistance;
    [SerializeField] private int currentCoin = 100;
    [SerializeField] private int currentRocketItem = 1;
    [SerializeField] private int currentRespawnItem = 1;
    [SerializeField] private int rocketItemPrice = 10;
    [SerializeField] private int respawnItemPrice = 5;
    [SerializeField] private int char_1_ItemPrice = 1000;
    [SerializeField] private int char_2_ItemPrice = 1000;
    [SerializeField] private int char_3_ItemPrice = 1000;
    [SerializeField] private int char_4_ItemPrice = 1000;
    [SerializeField] private int ship_1_ItemPrice = 1000;
    [SerializeField] private int ship_2_ItemPrice = 1000;
    [SerializeField] private int ship_3_ItemPrice = 1000;
    [SerializeField] private int ship_4_ItemPrice = 1000;
    [SerializeField] private float sfxVolume = 1.0f;
    [SerializeField] private float musicVolume = 1.0f;
    [SerializeField] private float masterVolume = 1.0f;
    [SerializeField] private GameObject character;
    [SerializeField] private GameObject ship;

    public float getHighestDistance() { return highestDistance;}
    public int getCurrentCoin() { return currentCoin;}
    public int getCurrentRocketItem() {  return currentRocketItem;}
    public int getCurrentRespawnItem() {  return currentRespawnItem;}
    public int getRocketItemPrice() {  return rocketItemPrice;}
    public int getRespawnItemPrice() { return respawnItemPrice;}
    public int getChar1Price() {  return char_1_ItemPrice;}
    public int getChar2Price() {  return char_2_ItemPrice;}
    public int getChar3Price() { return char_3_ItemPrice; }
    public int getChar4Price() {  return char_4_ItemPrice;}
    public int getShip1Price() { return ship_1_ItemPrice;}
    public int getShip2Price() { return ship_2_ItemPrice;}
    public int getShip3Price() { return ship_3_ItemPrice;}
    public int getShip4Price() { return ship_4_ItemPrice;}
    public float getsfxVolume() {  return sfxVolume;}
    public float getmusicVolume() {  return musicVolume;}
    public float getmasterVolume() {  return masterVolume;}

    public void setHighestDistance(float highestDistance) { this.highestDistance = highestDistance; }
    public void setCurrentCoin(int currentCoin) {  this.currentCoin = currentCoin; }
    public void setCurrentRocketItem(int currentRocketItem) { this.currentRocketItem = currentRocketItem; }
    public void setCurrentRespawnItem(int currentRespawnItem) { this.currentRespawnItem = currentRespawnItem; }
    public void setSFXVolume(float sfxVolume) {  this.sfxVolume = sfxVolume; }
    public void setMusicVolume(float musicVolume) {  this.musicVolume = musicVolume; }
    public void setMasterVolume(float masterVolume) {  this.masterVolume = masterVolume; }
}
