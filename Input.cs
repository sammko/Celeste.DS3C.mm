using Monocle;
using Microsoft.Xna.Framework.Input;

namespace Celeste
{
    public static class patch_Input
    {
        public static string GuiInputPrefix() {
            if (!string.IsNullOrEmpty(Input.OverrideInputPrefix))
            {
                return Input.OverrideInputPrefix;
            }
            if (!MInput.GamePads[Input.Gamepad].Attached)
            {
                return "keyboard";
            }
            string guid = GamePad.GetGUIDEXT(MInput.GamePads[Input.Gamepad].PlayerIndex);
            if (guid.Equals("4c05c405") || guid.Equals("4c05cc09")
                || guid.Equals("4c056802"))
            {
                return "ps4";
            }
            if (guid.Equals("7e050920") || guid.Equals("7e053003"))
            {
                return "ns";
            }
            return "xb1";
        }
    }
}
