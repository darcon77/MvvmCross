// MvxConsoleSystemMessageHandler.cs

// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace MvvmCross.Console.Views
{
    public class MvxConsoleSystemMessageHandler
    {
        public bool ExitFlag { get; set; }

        private IMvxConsoleNavigation ConsoleNavigation => Mvx.Resolve<IMvxConsoleNavigation>();

        public virtual bool HandleInput(IMvxViewModel viewModel, string input)
        {
            input = input.ToUpper();
            switch (input)
            {
                case "BACK":
                case "B":
                    if (ConsoleNavigation.CanGoBack())
                        ConsoleNavigation.GoBack();
                    return true;

                case "QUIT":
                case "Q":
                    ExitFlag = true;
                    return true;
            }

            return false;
        }
    }
}