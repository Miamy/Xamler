using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp.Commands
{
    public static class CommonCommands
    {
        public static RoutedUICommand ExitApplication { get; } = new RoutedUICommand("Exit", "ExitApplication", typeof(CommonCommands));
        public static RoutedUICommand OpenFile { get; } = new RoutedUICommand("Open file...", "OpenFile", typeof(CommonCommands));

        public static RoutedUICommand ShowOptions { get; } = new RoutedUICommand("Options...", "ShowOptions", typeof(CommonCommands));

    }

}
