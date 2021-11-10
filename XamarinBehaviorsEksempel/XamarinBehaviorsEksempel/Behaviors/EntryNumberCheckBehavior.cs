using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinBehaviorsEksempel.Behaviors
{
    class EntryNumberCheckBehavior : Behavior<Entry>
    {

        protected override void OnAttachedTo(Entry entry)
        {
            base.OnAttachedTo(entry);
            entry.TextChanged += Entry_TextChanged;
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            base.OnDetachingFrom(entry);
            entry.TextChanged -= Entry_TextChanged;
        }
        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry ent = sender as Entry;

            if (!string.IsNullOrEmpty(ent.Text))
            {
                int number = Convert.ToInt32(ent.Text);

                if (number < 20)
                {
                    ent.BackgroundColor = Color.Green;
                }
                else if (number < 50)
                {
                    ent.BackgroundColor = Color.Orange;
                }
                else if (number < 90)
                {
                    ent.BackgroundColor = Color.OrangeRed;
                }
                else
                {
                    ent.BackgroundColor = Color.Red;
                }
            }
        }
    }
}
