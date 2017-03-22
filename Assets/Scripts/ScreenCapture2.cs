 using UnityEngine;
 using System.Collections;
 using System.IO;

 public class ScreenShot : MonoBehaviour

	 // 4k = 3840 x 2160   1080p = 1920 x 1080
	public int captureWidth = 1920;
	public int captureHeight = 1080;

	// optional game object to hide during screenshots (usually your scene canvas hud)
     	public GameObject hideGameObject; 

 	// configure with raw, jpg, png, or ppm (simple raw format)
   	public enum Format { RAW, JPG, PNG, PPM };
     	public Format format = Format.PPM;



	public void Save(){
		var path = EditorUtility.SaveFilePanel(
 				"Save texture as PNG",
 				Application.dataPath + "/screenshots",
 				"screen_1920x1080" + ".png",
 				"png");
		
	}

	
 {
