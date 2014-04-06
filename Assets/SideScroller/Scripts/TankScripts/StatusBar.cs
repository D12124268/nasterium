   
using UnityEngine;
public class StatusBar : MonoBehaviour
    {
		public Transform HPtarget;
     	private GameObject HPGUI;
        private GameObject HPfabbie;
     	private float healthGUIWidth;
     
        private Camera FindCamera()
        {
            return camera ? camera : Camera.main;
        }
     
     
        private void Start()
        {
            HPGUI = Instantiate(HPfabbie, new Vector3(0.5f, 0.5f, 0), Quaternion.identity) as GameObject;
     
     
            if (HPGUI != null) healthGUIWidth = HPGUI.guiTexture.pixelInset.width;
        }
     
     
        private void Update()
        {
            Camera mainCamera = FindCamera();
     
     
            Vector3 p = mainCamera.WorldToViewportPoint(HPtarget.position + Vector3.up*1.5f);
     
     
            const float healthFraction = 0.5f;
     
            Rect pixel = HPGUI.guiTexture.pixelInset;
            pixel.xMax = HPGUI.guiTexture.pixelInset.xMin + healthGUIWidth*healthFraction;
            HPGUI.guiTexture.pixelInset = pixel;
     
     
            HPGUI.transform.position = p;
        }
    }