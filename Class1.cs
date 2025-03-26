using System;
using System.Threading;
using MelonLoader;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SNHall
{
    public class Class1 : MelonMod
    {
        public override void OnGUI()
        {
            GUI.DragWindow(new Rect(400f, 400f, 400f, 400f));
            bool flag = GUILayout.Button("FullBright", Array.Empty<GUILayoutOption>());
            if (flag)
            {
                RenderSettings.ambientLight = Color.white;
            }
            bool flag4 = GUILayout.Button("Scene: PreLoader", Array.Empty<GUILayoutOption>());
            if (flag4)
            {
                SceneManager.LoadScene("Level_C");
            }
            bool flag7 = GUILayout.Button("Scene: Loading...", Array.Empty<GUILayoutOption>());
            if (flag7)
            {
                SceneManager.LoadScene("Loading");
            }
            bool flag10 = GUILayout.Button("Scene: BackRooms", Array.Empty<GUILayoutOption>());
            if (flag10)
            {
                SceneManager.LoadScene("Level_Backrooms");
            }
            bool flag13 = GUILayout.Button("Color YELLOW", Array.Empty<GUILayoutOption>());
            if (flag13)
            {
                RenderSettings.ambientLight = Color.yellow;
            }
            bool flag16 = GUILayout.Button("Color BLUE", Array.Empty<GUILayoutOption>());
            if (flag16)
            {
                RenderSettings.ambientLight = Color.blue;
            }
            bool flag19 = GUILayout.Button("Color GREEN", Array.Empty<GUILayoutOption>());
            if (flag19)
            {
                RenderSettings.ambientLight = Color.green;
            }
        }

        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Insert)) 
            {
                this.MainMenu = !this.MainMenu;
            }

        }
        
        private bool MainMenu;

    }
}
