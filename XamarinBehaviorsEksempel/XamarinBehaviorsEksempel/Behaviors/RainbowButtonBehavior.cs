using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinBehaviorsEksempel.Behaviors
{
    class RainbowButtonBehavior : Behavior<Button>
    {

        protected override void OnAttachedTo(Button button)
        {
            base.OnAttachedTo(button);

            button.Clicked += Button_Clicked;
        }

        protected override void OnDetachingFrom(Button button)
        {
            base.OnDetachingFrom(button);
            button.Clicked -= Button_Clicked;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Random rnd = new Random();

            byte[] bytes = new byte[3];
            rnd.NextBytes(bytes);
            btn.BackgroundColor = Color.FromRgb(bytes[0], bytes[1], bytes[2]);
        }

    }
}
