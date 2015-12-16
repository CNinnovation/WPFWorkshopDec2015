using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MySimpleEditor
{
    public class MyCustomCommands
    {
        public static RoutedUICommand Action1 { get; } = new RoutedUICommand("Action1", "Action1", typeof(MyCustomCommands), new InputGestureCollection() { new KeyGesture(Key.B, ModifierKeys.Alt) });
    }
}
