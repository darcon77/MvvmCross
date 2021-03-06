// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;
using MvvmCross.Mac.Views;

namespace Playground.Mac
{
    [MvxFromStoryboard("Main")]
    public partial class ToolbarWindow : MvxWindowController
    {
        private static int _count;

        public ToolbarWindow(IntPtr handle) : base(handle)
        {
            _count++;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public NSTextField TextTitle
        {
            get { return textTitle; }
        }

        public NSMenuItem MenuItem1
        {
            get { return menuItem1; }
        }

        public NSMenuItem MenuItem2
        {
            get { return menuItem2; }
        }

        public NSMenuItem MenuItem3
        {
            get { return menuItem3; }
        }

        public NSMenuItem MenuItemSetting
        {
            get { return menuItemSetting; }
        }
    }
}
