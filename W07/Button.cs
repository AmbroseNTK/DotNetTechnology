using System;
using System.Collections.Generic;
using System.Text;

namespace W07
{
    public delegate void ClickHandle(Button parent);
    public class Button
    {
        public event ClickHandle OnClickButton;
        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public void Click()
        {
            OnClickButton(this);
        }
    }
}
