using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App2.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomMaterialEntryRenderer), new[] { typeof(VisualMarker.MaterialVisual) })]

namespace App2.Droid
{
    public class CustomMaterialEntryRenderer : MaterialEntryRenderer
    {
        public CustomMaterialEntryRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.EditText.Background = null;
                Control.EditText.SetBackgroundColor(Android.Graphics.Color.Transparent);
            }
        }
    }
}