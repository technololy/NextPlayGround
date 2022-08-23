using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NextPlayGround
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //MainControl.FlowDirection = FlowDirection.RightToLeft;
            
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Task.Delay(1000);
            Animation sideAddToBagCircleAnimation = new Animation();
            Animation sideAddToBagButtonFirstAnimation = new Animation();
            Animation sideAddToBagButtonReverseAnimation = new Animation();

            sideAddToBagCircleAnimation.WithConcurrent(
                (f) => SideAddToBagImage.WidthRequest =
                (int)f, 0, 30, Easing.Linear, 0, 1);

            sideAddToBagCircleAnimation.WithConcurrent(
                (f) => SideAddToBagImage.HeightRequest =
                (int)f, 0, 30, Easing.Linear, 0, 1);

            sideAddToBagCircleAnimation.WithConcurrent(
                (f) => CircleFrame.HeightRequest =
                (int)f, 0, 44, Easing.Linear, 0, 1);

            sideAddToBagCircleAnimation.WithConcurrent(
                (f) => CircleFrame.WidthRequest =
                (int)f, 0, 44, Easing.Linear, 0, 1);

            sideAddToBagCircleAnimation.WithConcurrent(
                (f) => CircleFrame.CornerRadius =
                (int)f, 0, 22, Easing.Linear, 0, 1);



            sideAddToBagCircleAnimation.Commit(this, nameof(sideAddToBagCircleAnimation), 16, 250, Easing.Linear);
            await Task.Delay(1000);

            var sideAddToBagNormalButtonTranslate = new Animation(v => AddToBagButton.TranslationX = v, 0, 0);
            var sideAddToBagNormalButtonChangeWidth = new Animation(v => AddToBagButton.WidthRequest = v, SideAddToBagImage.Width + 20, 200);

            sideAddToBagButtonFirstAnimation.Add(0, 1, sideAddToBagNormalButtonTranslate);
            sideAddToBagButtonFirstAnimation.Add(0, 1, sideAddToBagNormalButtonChangeWidth);

            sideAddToBagButtonFirstAnimation.Commit(this, nameof(sideAddToBagButtonFirstAnimation), 16, 250, Easing.Linear);
            await Task.Delay(1000);

            var sideAddToBagNormalButtonTranslateReverse = new Animation(v => AddToBagButton.TranslationX = v, 0, -10);
            var sideAddToBagNormalButtonChangeWidthReverse = new Animation(v => AddToBagButton.WidthRequest = v, 200, 0);

            sideAddToBagButtonReverseAnimation.Add(0, 1, sideAddToBagNormalButtonTranslateReverse);
            sideAddToBagButtonReverseAnimation.Add(0, 1, sideAddToBagNormalButtonChangeWidthReverse);
            sideAddToBagButtonReverseAnimation.Commit(this, nameof(sideAddToBagButtonReverseAnimation), 16, 250, Easing.Linear);

        }
    }
}
