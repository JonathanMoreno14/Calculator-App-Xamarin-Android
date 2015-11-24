using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.PM;

namespace Calculator
{
    [Activity(Label = "Calculator", MainLauncher = true, Icon = "@drawable/icon", ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : Activity
    {
     

        EditText firstValue;
        EditText secondValue;
        EditText result;


        Button clrButton;
        Button addButton;
        Button subButton;
        Button multButton;
        Button divButton;
        Button modButton;

      

        double a, b, c;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            SetTheme(Android.Resource.Style.ThemeBlackNoTitleBar);
            // Get our button from the layout resource,
            // and attach an event to it
            firstValue = FindViewById<EditText>(Resource.Id.editText2);
            secondValue = FindViewById<EditText>(Resource.Id.editText3);
            result = FindViewById<EditText>(Resource.Id.editText1);


            clrButton = FindViewById<Button>(Resource.Id.clrbtn);
            addButton = FindViewById<Button>(Resource.Id.addbtn);
            subButton = FindViewById<Button>(Resource.Id.subbtn);
            multButton = FindViewById<Button>(Resource.Id.mulbtn);
            divButton = FindViewById<Button>(Resource.Id.divbtn);
            modButton = FindViewById<Button>(Resource.Id.modbtn);

            computationButtons();

            this.Window.SetFlags(WindowManagerFlags.KeepScreenOn, WindowManagerFlags.KeepScreenOn);
        }



        protected  void computationButtons()
        {    

            addButton.Click += delegate
            {
                try
                {
                  
                        a = double.Parse(firstValue.Text);
                        b = double.Parse(secondValue.Text);
                        c = a + b;
                        result.Text = c.ToString();
                   
                  
                }
                catch (Exception ex)
                {
                    

                    firstValue.Text = "Input Number(s)";
                    secondValue.Text = "Input Number(s)";
                    result.Text = "Invalid Operation";
                }
            };

            subButton.Click += delegate
            {
                try
                {
                    a = double.Parse(firstValue.Text);
                    b = double.Parse(secondValue.Text);
                    c = a - b;
                    result.Text = c.ToString();
                }
                catch (Exception ex)
                {
                   

                    firstValue.Text = "Input Number(s)";
                    secondValue.Text = "Input Number(s)";
                    result.Text = "Invalid Operation";
                }
            };

            multButton.Click += delegate
            {
                try
                {
                    a = double.Parse(firstValue.Text);
                    b = double.Parse(secondValue.Text);
                    c = a * b;
                    result.Text = c.ToString();
                }
                catch (Exception ex)
                {
                    

                    firstValue.Text = "Input Number(s)";
                    secondValue.Text = "Input Number(s)";
                    result.Text = "Invalid Operation";
                }
            };

            divButton.Click += delegate
            {
                try
                {
                    a = double.Parse(firstValue.Text);
                    b = double.Parse(secondValue.Text);
                    c = a / b;
                    result.Text = c.ToString();
                  
                }
                catch (Exception ex)
                {


                    result.Text = ex.Message;
                    firstValue.Text = "Input Number(s)";
                    secondValue.Text = "Input Number(s)";
                    result.Text = "Invalid Operation";
                   
                }
            };
            modButton.Click += delegate
            {
                try
                {
                    a = double.Parse(firstValue.Text);
                    b = double.Parse(secondValue.Text);
                    c = a % b;
                    result.Text = c.ToString();
                }
                catch (Exception ex)
                {
                   

                    firstValue.Text = "Input Number(s)";
                    secondValue.Text = "Input Number(s)";
                    result.Text = "Invalid Operation";
                     result.Text = ex.Message;

                }
            };

            clrButton.Click += delegate
            {
                    secondValue.Text = "";
                    firstValue.Text = "";
                    result.Text = "";
            };

        }
      
    }



}





