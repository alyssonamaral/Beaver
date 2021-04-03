using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Beaver.Controls;
using Beaver.Droid.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(RoundedEntry), typeof(RoundedEntryRendererAndroid))]
namespace Beaver.Droid.Controls
{
    public class RoundedEntryRendererAndroid : EntryRenderer
    {
        public RoundedEntryRendererAndroid(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(20f);
                gradientDrawable.SetColor(Android.Graphics.Color.Gainsboro);
                Control.SetBackground(gradientDrawable);
                Control.FocusChange += FocusChanged;
                Control.SetPadding(50, Control.PaddingTop, Control.PaddingRight, Control.PaddingBottom);
            }
        }

        private void FocusChanged(object sender, FocusChangeEventArgs e)
        {
            var color = Android.Graphics.Color.DodgerBlue;
            if (e.HasFocus)
                color = Android.Graphics.Color.DodgerBlue;
            else
                color = Android.Graphics.Color.Gainsboro;

            var gradientDrawable = new GradientDrawable();
            gradientDrawable.SetCornerRadius(20f);
            gradientDrawable.SetStroke(5, color);
            gradientDrawable.SetColor(Android.Graphics.Color.Gainsboro);
            Control.SetBackground(gradientDrawable);
        }
    }
}