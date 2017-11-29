// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace ValueConversion.UI.Touch
{
    [Register ("ColorsView")]
    partial class ColorsView
    {
        [Outlet]
        UIKit.UILabel ColorLabel { get; set; }


        [Outlet]
        UIKit.UISlider RedSlider { get; set; }


        [Outlet]
        UIKit.UISlider GreenSlider { get; set; }


        [Outlet]
        UIKit.UISlider BlueSlider { get; set; }


        [Outlet]
        UIKit.UIView ColorView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BlueSlider != null) {
                BlueSlider.Dispose ();
                BlueSlider = null;
            }

            if (ColorLabel != null) {
                ColorLabel.Dispose ();
                ColorLabel = null;
            }

            if (ColorView != null) {
                ColorView.Dispose ();
                ColorView = null;
            }

            if (GreenSlider != null) {
                GreenSlider.Dispose ();
                GreenSlider = null;
            }

            if (RedSlider != null) {
                RedSlider.Dispose ();
                RedSlider = null;
            }
        }
    }
}