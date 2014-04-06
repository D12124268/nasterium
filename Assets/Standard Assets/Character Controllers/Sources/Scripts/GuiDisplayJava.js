#pragma strict
 
// JavaScript
 
var backgroundTexture : Texture;
var foregroundTexture : Texture;
var frameTexture : Texture;
var TextTexture : Texture;
 
var healthWidth: int = 199;
var healthHeight: int = 30;
var damage: int = 252 / 100;
 
var healthMarginLeft: int = 41;
var healthMarginTop: int = 38;
 
var frameWidth : int = 266;
var frameHeight: int = 65;
 
var frameMarginLeft : int = 10;
var frameMarginTop: int = 10;
 
function OnGUI () {
 
    GUI.DrawTexture( Rect(frameMarginLeft,frameMarginTop, frameMarginLeft + frameWidth, frameMarginTop + frameHeight), backgroundTexture, ScaleMode.ScaleToFit, true, 0 );
 
    GUI.DrawTexture( Rect(healthMarginLeft,healthMarginTop,healthWidth + healthMarginLeft, healthHeight), foregroundTexture, ScaleMode.ScaleAndCrop, true, 0 );
    
    //GUI.DrawTexture( Rect(healthMarginLeft,healthMarginTop,healthWidth + healthMarginLeft, healthHeight), TextTexture, ScaleMode.ScaleAndCrop, true, 0 );
 
    GUI.DrawTexture( Rect(frameMarginLeft,frameMarginTop, frameMarginLeft + frameWidth,frameMarginTop + frameHeight), frameTexture, ScaleMode.ScaleToFit, true, 0 );
 
}