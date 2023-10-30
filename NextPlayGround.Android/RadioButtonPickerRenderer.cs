using System;
using System.ComponentModel;
using System.Linq;
using Android.Content;
using Android.Widget;
using AndroidX.AppCompat.App;
using NextPlayGround;
using NextPlayGround.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(RadioButtonPickerRenderer))]

namespace NextPlayGround.Droid
{
    public class RadioButtonPickerRenderer: PickerRenderer
    {
        private AlertDialog _dialog;
        IElementController ElementController => Element as IElementController;
        EventHandler<Android.Content.DialogClickEventArgs> _pickerHandler;
        private int _selectedIndex;
        public RadioButtonPickerRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            Control.Click += Control_Click;
            _pickerHandler += PerformPickerEvent;
        }

        private void PerformPickerEvent(object sender, DialogClickEventArgs e)
        {
            _selectedIndex = e.Which;
        }

        private void Control_Click(object sender, EventArgs e)
        {
            Picker model = Element;

            //var picker = new NumberPicker(Context);
            //if (model.Items != null && model.Items.Any())
            //{
            //    // set style here
            //    picker.MaxValue = model.Items.Count - 1;
            //    picker.MinValue = 0;
            //    picker.SetBackgroundColor(Android.Graphics.Color.Yellow);
            //    picker.SetDisplayedValues(model.Items.ToArray());
            //    picker.WrapSelectorWheel = false;
            //    picker.Value = model.SelectedIndex;
            //}

            //var layout = new LinearLayout(Context) { Orientation = Orientation.Vertical };
            //layout.AddView(picker);

            ElementController.SetValueFromRenderer(VisualElement.IsFocusedProperty, true);

            var builder = new AlertDialog.Builder(Context);
            //builder.SetView(layout);

            builder.SetTitle(model.Title ?? "");
            builder.SetNegativeButton("Cancel  ", (s, a) =>
            {
                ElementController.SetValueFromRenderer(VisualElement.IsFocusedProperty, false);
                // It is possible for the Content of the Page to be changed when Focus is changed.
                // In this case, we'll lose our Control.
                Control?.ClearFocus();
                _dialog = null;
            });
            builder.SetPositiveButton("Ok ", (s, a) =>
            {
                //ElementController.SetValueFromRenderer(Picker.SelectedIndexProperty, picker.Value);
                // It is possible for the Content of the Page to be changed on SelectedIndexChanged.
                // In this case, the Element & Control will no longer exist.
                if (Element != null)
                {
                    if (model.Items.Count > 0 && _selectedIndex >= 0)
                        //Control.Text = model.Items[Element.SelectedIndex];
                        Element.SelectedIndex = _selectedIndex;
                    ElementController.SetValueFromRenderer(VisualElement.IsFocusedProperty, false);
                    // It is also possible for the Content of the Page to be changed when Focus is changed.
                    // In this case, we'll lose our Control.
                    Control?.ClearFocus();
                }
                _dialog = null;
            });
            //builder.SetSingleChoiceItems(model.Items.ToArray(),0, (s,e)=> {

            

            //});

            builder.SetSingleChoiceItems(model.Items.ToArray(), _selectedIndex, _pickerHandler);
            _dialog = builder.Create();
            _dialog.DismissEvent += (ssender, args) =>
            {
                ElementController?.SetValueFromRenderer(VisualElement.IsFocusedProperty, false);
            };
            _dialog.Show();
        }
    
    }
}
