using System;
using System.Threading;
using MelonLoader;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SNHall
{
    // Token: 0x02000002 RID: 2
    public class Class1 : MelonMod
    {
        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
        public override void OnGUI()
        {
            bool mainMenu = this.MainMenu;
            bool flag = mainMenu;
            bool flag2 = flag;
            if (flag2)
            {
                this.Menat = GUI.Window(1, this.Menat, new GUI.WindowFunction(this.MenuHack), "Cheat Neiro by BigBrain_Z");
            }
        }

        // Token: 0x06000002 RID: 2 RVA: 0x00002094 File Offset: 0x00000294
        public override void OnUpdate()
        {
            bool keyDown = UnityEngine.Input.GetKeyDown((KeyCode)277);
            if (keyDown) {
                this.MainMenu = !this.MainMenu;
            }

        }


        // Token: 0x06000003 RID: 3 RVA: 0x000020C8 File Offset: 0x000002C8
        private void MenuHack(int id)
        {
            bool flag = GUILayout.Button("FullBright", Array.Empty<GUILayoutOption>());
            bool flag2 = flag;
            bool flag3 = flag2;
            if (flag3)
            {
                RenderSettings.ambientLight = Color.white;
            }
            bool flag4 = GUILayout.Button("Scene: PreLoader", Array.Empty<GUILayoutOption>());
            bool flag5 = flag4;
            bool flag6 = flag5;
            if (flag6)
            {
                SceneManager.LoadScene("Level_C");
            }
            bool flag7 = GUILayout.Button("Scene: Loading...", Array.Empty<GUILayoutOption>());
            bool flag8 = flag7;
            bool flag9 = flag8;
            if (flag9)
            {
                SceneManager.LoadScene("Loading");
            }
            bool flag10 = GUILayout.Button("Scene: BackRooms", Array.Empty<GUILayoutOption>());
            bool flag11 = flag10;
            bool flag12 = flag11;
            if (flag12)
            {
                SceneManager.LoadScene("Level_Backrooms");
            }
            bool flag13 = GUILayout.Button("Color YELLOW", Array.Empty<GUILayoutOption>());
            bool flag14 = flag13;
            bool flag15 = flag14;
            if (flag15)
            {
                RenderSettings.ambientLight = Color.yellow;
            }
            bool flag16 = GUILayout.Button("Color BLUE", Array.Empty<GUILayoutOption>());
            bool flag17 = flag16;
            bool flag18 = flag17;
            if (flag18)
            {
                RenderSettings.ambientLight = Color.blue;
            }
            bool flag19 = GUILayout.Button("Color GREEN", Array.Empty<GUILayoutOption>());
            bool flag20 = flag19;
            bool flag21 = flag20;
            if (flag21)
            {
                RenderSettings.ambientLight = Color.green;
            }
            GUI.DragWindow();
        }

        // Token: 0x04000001 RID: 1
        public bool noclip;

        // Token: 0x04000002 RID: 2
        private bool MainMenu;

        // Token: 0x04000003 RID: 3
        public Rect Menat = new Rect(400f, 400f, 400f, 400f);

    }
}
