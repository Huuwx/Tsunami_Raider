using System.Collections;
using System.Collections.Generic;
using UnityEditor;
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
    [SerializeField] private string characterName;
    [SerializeField] private string shipName;
    //[SerializeField] private Sprite character;
    //[SerializeField] private Sprite ship;
    [SerializeField] private bool haveChar1 = false;
    [SerializeField] private bool haveChar2 = false;
    [SerializeField] private bool haveChar3 = false;
    [SerializeField] private bool haveChar4 = false;
    [SerializeField] private bool haveShip1 = false;
    [SerializeField] private bool haveShip2 = false;
    [SerializeField] private bool haveShip3 = false;
    [SerializeField] private bool haveShip4 = false;

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
    public Sprite getCharSprite() { return Resources.Load<Sprite>($"Characters/{characterName}"); }
    public Sprite getShipSprite() { return Resources.Load<Sprite>($"Ships/{shipName}"); }
    public bool getHaveChar1() { return haveChar1; }
    public bool getHaveChar2() {  return haveChar2; }
    public bool getHaveChar3() {  return haveChar3; }
    public bool getHaveChar4() {  return haveChar4; }
    public bool getHaveShip1() {  return haveShip1; }
    public bool getHaveShip2() {  return haveShip2; }
    public bool getHaveShip3() {  return haveShip3; }
    public bool getHaveShip4() {  return haveShip4; }

    public void setHighestDistance(float highestDistance) { this.highestDistance = highestDistance; }
    public void setCurrentCoin(int currentCoin) {  this.currentCoin = currentCoin; }
    public void setCurrentRocketItem(int currentRocketItem) { this.currentRocketItem = currentRocketItem; }
    public void setCurrentRespawnItem(int currentRespawnItem) { this.currentRespawnItem = currentRespawnItem; }
    public void setSFXVolume(float sfxVolume) {  this.sfxVolume = sfxVolume; }
    public void setMusicVolume(float musicVolume) {  this.musicVolume = musicVolume; }
    public void setMasterVolume(float masterVolume) {  this.masterVolume = masterVolume; }
    public void setCharSprite(string characterName) { this.characterName = characterName; }
    public void setShipSprite(string shipName) {  this.shipName = shipName; }
    public void setHaveChar1(bool haveChar1) {  this.haveChar1 = haveChar1; }
    public void setHaveChar2(bool haveChar2) {  this.haveChar2 = haveChar2; }
    public void setHaveChar3(bool haveChar3) {  this.haveChar3 = haveChar3; }
    public void setHaveChar4(bool haveChar4) {  this.haveChar4 = haveChar4; }
    public void setHaveShip1(bool haveShip1) {  this.haveShip1 = haveShip1; }
    public void setHaveShip2(bool haveShip2) {  this.haveShip2 = haveShip2; }
    public void setHaveShip3(bool haveShip3) {  this.haveShip3 = haveShip3; }
    public void setHaveShip4(bool haveShip4) {  this.haveShip4 = haveShip4; }
}
